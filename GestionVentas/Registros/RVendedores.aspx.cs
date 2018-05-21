using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestionVentas.BLL;
using GestionVentas.Entidades;
using System.Data;

namespace GestionVentas.Registros
{
    public partial class RVendedores : System.Web.UI.Page
    {
        public DataRow vendedores { get; private set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Vendedores vendedores = new Vendedores();
            Categorias categorias = new Categorias();
            DataTable dt = new DataTable();
            if (IsPostBack == false)
            {


                dt.Columns.AddRange(new DataColumn[3] { new DataColumn("Id"), new DataColumn("CategoriaId"), new DataColumn("MaximoVenta") });
                ViewState["Detalle"] = dt;
            }
        }
     
        public void Llenar(Vendedores vendedores)
        {

            float LimiteVentas = 0;


            float.TryParse(LimiteVentasTextBox1.Text, out LimiteVentas);
            PorcientoComisionTextBox.Text = (LimiteVentas * 0.1 / 100).ToString() + "%";
            Porcientocomision2TextBox1.Text = (LimiteVentas * 0.2 / 100).ToString() + "%";
            Porcientocomision3TextBox1.Text = (LimiteVentas * 0.3 / 100).ToString() + "%";
            Porcientocomision4TextBox.Text = (LimiteVentas * 0.4/ 100).ToString() + "%";
            Porcientocomision5TextBox1.Text = (LimiteVentas * 0.5 / 100).ToString() + "%";



            vendedores.Nombres = NombreTextBox1.Text;
            DescripcionTextBox.Text = DescripcionTextBox.Text + "Productos Vendidos";
            MensajeInicialTextBox.Text = MensajeInicialTextBox.Text + " Mayor Venta  ";
            MensajefinalTextBox.Text = MensajefinalTextBox.Text + " Satisfecho ";

        }
        protected void BindGrid()
        {
            DetalleGridView.DataSource = (DataTable)ViewState["Detalle"];
            DetalleGridView.DataBind();
        }

        protected void LimpiarCampos_Click(object sender, EventArgs e)
        {
            Limpiar();
           
        }
        protected void Limpiar()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[3] { new DataColumn("Id"), new DataColumn("CategoriaId"), new DataColumn("MaximoVenta") });

            IdTextBox.Text = "";
            IdTextBox.Enabled = true;
            NombreTextBox1.Text = "";
            DescripcionTextBox.Text = "";
            ViewState["Detalle"] = dt;
            this.BindGrid();
        }
        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            
            Vendedores vendedores = new Vendedores();
            Llenar(vendedores);
            VendedoresBLL.Guardar(vendedores);
            Utilidades.ShowToastr(this, "Proceso Completado", "Exito", "success");

        }
        public void BuscarVendedores(Vendedores ve)
        {
            if (VendedoresBLL.Buscar(Utilidades.TOINT(IdTextBox.Text)) == null)
            {
                Utilidades.ShowToastr(this, "No Existe", "Danger", "warning");


            }
            else
            {
                VendedoresBLL.Buscar(Utilidades.TOINT(IdTextBox.Text));
               


            }
        }
        protected void BuscarButton1_Click(object sender, EventArgs e)
        {
            Vendedores vendedores = new Vendedores();
            if (IdTextBox.Text == "")
            {
                Llenar(vendedores);
                Utilidades.ShowToastr(this, "Busqueda exitosa", "Exito");
                IdTextBox.Enabled = false;
            }
            else
            {
                Limpiar();
                Utilidades.ShowToastr(this, "No se pudo encontrar el presupuesto especificado", "Error", "error");
            }
        }
    }
}