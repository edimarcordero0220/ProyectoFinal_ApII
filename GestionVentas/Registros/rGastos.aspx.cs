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
    public partial class rGastos : System.Web.UI.Page
    {
        Vendedores Vendedor = new Vendedores();
        Gastos gasto = new Gastos();
        GastosBLL g= new GastosBLL();
        int GastoId = 1;

        protected void Page_Load(object sender, EventArgs e)
        {
          

            if (!IsPostBack)
            {
                int.TryParse(Request.QueryString["GastoId"], out GastoId);
                if (GastoId > 0)
                {
                    g.Buscar(GastoId);
                    ConceptoTextBox.Text = gasto.Concepto;
                    //g.Fecha = Convert.ToDateTime(FechaTextBox.Text);
                    MontoTextBox.Text = Convert.ToString(gasto.Monto);
                    Buscar(GastoId);

                }
            }


            FechaTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy");
            if (!Page.IsPostBack)
            {
                //todo: query string que permita buscar un id
                LLenarComboVendedor();

            }
        }
        void Buscar(int id)
        {
            Gastos g = new Gastos();
            ConceptoTextBox.Text = g.Concepto;
            MontoTextBox.Text = Convert.ToString(g.Monto);
        }
        public void LLenarComboVendedor()
        {
           VendedorDropDownList1.DataSource = BLL.VendedoresBLL.GetListTodo();
            VendedorDropDownList1.DataTextField = "Nombres";
            VendedorDropDownList1.DataValueField = "VendedorId";
            VendedorDropDownList1.DataBind();

        }
       

        public void LlenarClase(Gastos g)
        {

            g.Fecha = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
            g.VendedorId = Utilidades.ValidarIdEntero(VendedorDropDownList1.SelectedValue);
            g.Concepto = ConceptoTextBox.Text;
            g.Monto = Utilidades.TOINT(MontoTextBox.Text);


        }
        public void Limpiar()
        {
            IdTextBox.Text = "";
            FechaTextBox.Text = DateTime.Now.ToString();
            VendedorDropDownList1.ClearSelection();
            ConceptoTextBox.Text = "";
            MontoTextBox.Text = "";
            
        }
        protected void LimpiarCampos_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if ( ConceptoTextBox.Text == "" || MontoTextBox.Text == "")
            {
                Utilidades.ShowToastr(this, "Completar Campos (*)  ", "Advertencia", "Warning");
            }
            else
            {
                Entidades.Gastos gasto = new Entidades.Gastos();
                LlenarClase(gasto);
                GastosBLL.Insertar(gasto);

                Utilidades.ShowToastr(this, "Guardado con Exitos", "Exito", "success");
                Limpiar();
            }
        }
        
        public void BuscarGasto()
        {
            Gastos g = new Gastos();
            if (GastosBLL.Buscarbtn(Utilidades.TOINT(IdTextBox.Text)) == null)
            {
                Utilidades.ShowToastr(this, "No Existe", "Que Mal", "Error");


            }
            else
            {
              
                ConceptoTextBox.Text = g.Concepto;
                MontoTextBox.Text = Convert.ToString(g.Monto);


            }
        }
        protected void BuscarButton_Click(object sender, EventArgs e)
        {

            //if (IdTextBox.Text == "")
            //{
            //    Utilidades.ShowToastr(this, "Debes Llenar el Campo Id  ", "Advertencia", "Warning");
            //}
            //else
            //{

            //}

            Response.Redirect("/Consultas/cGastos.aspx");
        }

        protected void AnularButton_Click(object sender, EventArgs e)
        {
            if (IdTextBox.Text == "")
            {
                Utilidades.ShowToastr(this, "Debes Llenar el Campo Id  ", "Advertencia", "Warning");
            }
            else
            {
                if (GastosBLL.Buscarbtn(Utilidades.TOINT(IdTextBox.Text)) == null)
                {
                    Utilidades.ShowToastr(this, "No Existe", "Que Mal", "Error");

                }
                else
                {
                    GastosBLL.Eliminar(Utilidades.TOINT(IdTextBox.Text));
                    Utilidades.ShowToastr(this, "Proceso Completado", "Exito", "success");
                }

            }

        }
    }
}