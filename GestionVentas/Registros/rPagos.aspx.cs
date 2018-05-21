using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestionVentas.Entidades;
using GestionVentas.BLL;

namespace GestionVentas.Registros
{
    public partial class rPagos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FechaTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy");
            if (!Page.IsPostBack)
            {

                LLenarComboVendedor();

            }
        }
        public void LLenarComboVendedor()
        {
            VendedorDropDownList1.DataSource = BLL.VendedoresBLL.GetListTodo();
            VendedorDropDownList1.DataTextField = "Nombres";
            VendedorDropDownList1.DataValueField = "VendedorId";
            VendedorDropDownList1.DataBind();

        }
        public void LlenarClase(Pagos p)
        {

            p.Fecha = Convert.ToDateTime(FechaTextBox.Text);
            
            p.Concepto = ConceptoTextBox.Text;
            p.Monto = Utilidades.TOINT(MontoTextBox.Text);


        }

        public void Limpiar()
        {
            IdTextBox.Text = "";
           
            ConceptoTextBox.Text = "";
            MontoTextBox.Text = "";

        }
        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if ( ConceptoTextBox.Text == "" || MontoTextBox.Text == "")
            {
                Utilidades.ShowToastr(this, "Completar Campos (*)  ", "Advertencia", "Warning");
            }
            else
            {
                Entidades.Pagos p = new Entidades.Pagos();
                LlenarClase(p);
                PagosBLL.Insertar(p);
                Utilidades.ShowToastr(this, "Guardado con Exitos", "Exito", "success");
                Limpiar();
            }
            

        }
       
        public void BuscarPagos(Entidades.Pagos p)
        {
            if (PagosBLL.Buscar(Utilidades.TOINT(IdTextBox.Text)) == null)
            {
                Utilidades.ShowToastr(this, "No Existe", "Que Mal", "Error");


            }
            else
            {

                
                ConceptoTextBox.Text = p.Concepto;
                p.Fecha = Convert.ToDateTime(FechaTextBox.Text);
                MontoTextBox.Text = Convert.ToString(p.Monto);


            }
        }
        protected void LimpiarCampos_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            if (IdTextBox.Text == "")
            {
                Utilidades.ShowToastr(this, "Debes Llenar el Campo Id  ", "Advertencia", "Warning");
            }
            else
            {
                BuscarPagos(PagosBLL.Buscar(Utilidades.TOINT(IdTextBox.Text)));
            }
        }

        protected void AnularButton_Click(object sender, EventArgs e)
        {
            if (IdTextBox.Text == "")
            {
                Utilidades.ShowToastr(this, "Debes Llenar el Campo Id  ", "Advertencia", "Warning");
            }
            else
            {
                if (PagosBLL.Buscar(Utilidades.TOINT(IdTextBox.Text)) == null)
                {
                    Utilidades.ShowToastr(this, "No Existe", "Que Mal", "Error");
                }
                else
                {
                    PagosBLL.Eliminar(Utilidades.TOINT(IdTextBox.Text));
                    Utilidades.ShowToastr(this, "Proceso Completado", "Exito", "success");
                }

            }
        }
    }
}