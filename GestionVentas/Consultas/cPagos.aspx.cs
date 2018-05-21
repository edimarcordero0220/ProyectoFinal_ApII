using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestionVentas.BLL;
using GestionVentas.Entidades;

namespace GestionVentas.Consultas
{
    public partial class cPagos : System.Web.UI.Page
    {
        public static List<Pagos> Listas { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                Listas = BLL.PagosBLL.GetListTodo();

                ConsultaClienteGridView.DataSource = Listas;
                ConsultaClienteGridView.DataBind();
            }

        }
        private void BuscarSelecCombo()
        {
            Listas = null;

            if (FiltrarDropDownList.SelectedIndex == 0)
            {
                Listas = BLL.PagosBLL.GetListTodo();

            }
            else if (FiltrarDropDownList.SelectedIndex == 1)
            {
                if (BuscarTextBox.Text == "")
                {
                    base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe de Insertar la descripcion');</script>");
                }
                else
                {
                    int Busqueda = Utilidades.TOINT(BuscarTextBox.Text);
                    Listas = PagosBLL.GetList(p => p.PagoId == Busqueda);
                    ConsultaClienteGridView.DataSource = Listas;
                    ConsultaClienteGridView.DataBind();
                }
            }
            else if (FiltrarDropDownList.SelectedIndex == 2)
            {
                if (BuscarTextBox.Text == "")
                {
                    base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe de Insertar la descripcion');</script>");
                }
                else
                {
                    int Busqueda = Utilidades.TOINT(BuscarTextBox.Text);
                    Listas = PagosBLL.GetList(p => p.VendedorId == Busqueda);
                    ConsultaClienteGridView.DataSource = Listas;
                    ConsultaClienteGridView.DataBind();
                }
            }
            else if (FiltrarDropDownList.SelectedIndex == 3)
            {


                if (DesdeTextBox.Text != "" && HastaTextBox.Text != "")
                {
                    DateTime desde = Convert.ToDateTime(DesdeTextBox.Text);
                    DateTime hasta = Convert.ToDateTime(HastaTextBox.Text);
                    if (desde <= hasta)
                    {
                        Listas = BLL.PagosBLL.GetList(p => p.Fecha >= desde && p.Fecha <= hasta);

                    }
                    else
                    {
                        base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Orden Cronologico mal seleccionado, la primera fecha debe ser menor que la segunda.');</script>");
                        Listas = null;
                    }
                }
                else
                {
                    base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debes insertar la fecha');</script>");
                    Listas = null;
                }



            }
            ConsultaClienteGridView.DataSource = Listas;
            ConsultaClienteGridView.DataBind();
        }
        private bool ValidarBuscar()
        {
            if (PagosBLL.Buscar(String(BuscarTextBox.Text)) == null)
            {
                base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No Existe');</script>");
                return false;

            }

            return true;


        }

        public int String(string texto)
        {
            int numero = 0;
            int.TryParse(texto, out numero);
            return numero;
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {

            if (BuscarTextBox.Text == "")
            {
                base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe de Insertar la descripcion');</script>");
            }
            else
            {
                BuscarSelecCombo();
                ValidarBuscar();
            }
        }
    }
}