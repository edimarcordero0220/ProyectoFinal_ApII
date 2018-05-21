using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestionVentas.BLL;
using GestionVentas.Entidades;

namespace GestionVentas.Registros
{
    public partial class RVentas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int Id;
            this.FechaTextBox.Text = string.Format("{0:G}", DateTime.Now);
            if (!Page.IsPostBack)
            {

                LLenarComboVendedor();


                if (Request.QueryString["Id"] != null)
                {
                    Id = Utilidades.TOINT(Request.QueryString["Id"].ToString());

                    if (Id > 0)
                    {
                        Ventas ventas = new Ventas();
                        VentasBLL.Buscar(Id);

                        Utilidades.ShowToastr(this, "Registro no encontrado", "Error", "Danger");

                    }
                    else
                    {
                        VentasIdTextBox.Text = Id.ToString();

                    }

                }

            }
         
            

                    
              
            
        
    }
        public void LLenarComboVendedor()
        {
            VendedorDropDownList1.DataSource = BLL.VendedoresBLL.GetListTodo();
            VendedorDropDownList1.DataTextField = "Nombres";
            VendedorDropDownList1.DataValueField = "VendedorId";
            VendedorDropDownList1.DataBind();

        }
        public void Limpiar()
        {
            VentasIdTextBox.Text = "";
            FechaTextBox.Text = "";
            TotalTextBox.Text = "";
            ComisionTextBox.Text = "";


        }


        protected void LimpiarCampos_Click(object sender, EventArgs e)
        {
            Limpiar(); 
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if (VendedorDropDownList1.Text == "" || ComisionTextBox.Text == "")
            {
                Utilidades.ShowToastr(this, "No puede dejar Comision Vacio", "Error", "Danger");
            }
            else
            {


                float total = 0;


                float.TryParse(TotalTextBox.Text, out total);
                ComisionTextBox.Text = (total * 1.6 / 100).ToString() + "%";

            }
            Ventas ventas = new Ventas();
            VentasBLL.Guardar(ventas);
            Utilidades.ShowToastr(this, "Guardado con Exito", "Exitoso", "success");
        }

        protected void ImprimirButton_Click(object sender, EventArgs e)
        {
            ImprimirButton.Attributes.Add("onclick", "return printing()");
            ClientScript.RegisterStartupScript(this.GetType(), "printOperation", "printing()", true);
        }

        protected void AnularButton_Click(object sender, EventArgs e)
        {
            if (VentasIdTextBox.Text == "")
            {
             Utilidades.ShowToastr(this, "Debes Llenar el campo Id", "Error", "Danger");
            }
            else
            {
                if (VentasBLL.Buscar(Utilidades.TOINT(VentasIdTextBox.Text)) == null)
                {
                    Utilidades.ShowToastr(this, "Registro no encontrado", "Error", "Danger");


                }
                else
                {
                    VentasBLL.Eliminar(Utilidades.TOINT(VentasIdTextBox.Text));
                    Utilidades.ShowToastr(this, "Poceso Exitoso", "Exitoso", "success");
                }

            }
        }
    }
}