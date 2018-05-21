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
    public partial class cGastos : System.Web.UI.Page
    {
        public static List<Gastos> Listas { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Listas = BLL.GastosBLL.GetListTodo();

                ConsultaClienteGridView.DataSource = Listas;
                ConsultaClienteGridView.DataBind();
            }
        }
        private void BuscarSelecCombo()
        {
            Listas = null;

            if (FiltrarDropDownList.SelectedIndex == 0)
            {
                Listas = BLL.GastosBLL.GetListTodo();

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
                    Listas = GastosBLL.GetList(p => p.GastoId == Busqueda);
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
                    Listas = GastosBLL.GetList(p => p.VendedorId == Busqueda);
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
                        Listas = BLL.GastosBLL.GetList(p => p.Fecha >= desde && p.Fecha <= hasta);

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
        //private bool ValidarBuscar()
        //{
        //    //if (GastosBLL.Buscar(String(BuscarTextBox.Text)) == null)
        //    //{
        //    //    base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No Existe');</script>");
        //    //    return false;

        //    //}

        //    //return true;


        //}

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
                //ValidarBuscar();
            }
        }

        protected void imprimirButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Reportes/GastosReportes.aspx");
        }
    }
}