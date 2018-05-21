using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestionVentas.BLL;
using GestionVentas.Entidades;

namespace GestionVentas.Registros
{
    public partial class rDetalleVendedor : System.Web.UI.Page
    {
        VendedoresDetalles vendedor = new VendedoresDetalles();
        System.Data.DataTable table;
        System.Data.DataRow row;
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                LlenarComboCategoria();
                LLenarComboVendedor();

            }

            if (IsPostBack == false)
            {

                dt.Columns.AddRange(new DataColumn[3] { new DataColumn("Vendedor Id"), new DataColumn("Categoria Id"), new DataColumn("Maximo Venta") });
                ViewState["Vendedor"] = dt;


            }
        }

        protected void Limpiar()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[3] { new DataColumn("Vendedor Id"), new DataColumn("Categoria Id"), new DataColumn("Maximo Venta") });
            MaximoventaTextBox.Text = "";
          
            ViewState["Vendedor"] = dt;
            this.BindGrid();
        }

        public void LLenarComboVendedor()
        {
            VendedorDropDownList1.DataSource = BLL.VendedoresBLL.GetListTodo();
            VendedorDropDownList1.DataTextField = "Nombres";
            VendedorDropDownList1.DataValueField = "VendedorId";
            VendedorDropDownList1.DataBind();

        }
        public void LlenarComboCategoria()
        {
            CategoriaDropDownList1.DataSource = BLL.CategoriasBLL.GetListTodo();
            CategoriaDropDownList1.DataTextField = "Nombre";
            CategoriaDropDownList1.DataValueField = "CategoriaId";
            CategoriaDropDownList1.DataBind();

        }
       
        protected void BindGrid()
        {
            GridView.DataSource = (DataTable)ViewState["Vendedor"];
            GridView.DataBind();

        }

        protected void AgregalButton_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)ViewState["Vendedor"];
            dt.Rows.Add(VendedorDropDownList1.Text, CategoriaDropDownList1.Text, MaximoventaTextBox.Text);
            ViewState["Vendedor"] = dt;

            this.BindGrid();
        }

        public void LlenarRegistro(VendedoresDetalles d)
        {

            foreach (GridViewRow dr in GridView.Rows)
            {
                d.VendedorId = Convert.ToInt32(dr.Cells[0].Text);
                d.CategoriaId = Convert.ToInt32(dr.Cells[1].Text);
                d.MaximoVenta = Convert.ToInt32(dr.Cells[2].Text);

            }

        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if (MaximoventaTextBox.Text == "")
            {
                Utilidades.Mensage(this.Page, "Bien", "<script>alert('Debes Llenar el Campo Maximo Venta');</script>");
            }
            else
            {

                VendedoresDetalles v = new VendedoresDetalles();
                LlenarRegistro(v);
                VendedorDetalleBLL.Insertar(v);
            }


            

            Utilidades.Mensage(this.Page, "Bien", "<script>alert('Guardado');</script>");
            
        }

        protected void LimpiarButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
     
       
        
       
        protected void BuscarButton_Click(object sender, EventArgs e)
        {


            

        }
      
        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            if (IdTextBox.Text == "")
            {
                Utilidades.Mensage(this.Page, "scripts", "<script>alert('Debes Llenar el Campo Id');</script>");
            }
            else
            {
                if (VendedorDetalleBLL.Buscar(Utilidades.TOINT(IdTextBox.Text)) == null)
                {
                    Utilidades.Mensage(this.Page, "scripts", "<script>alert('No existe ');</script>");

                }
                else
                {
                    VendedorDetalleBLL.Eliminar(Utilidades.TOINT(IdTextBox.Text));
                    Utilidades.Mensage(this.Page, "scripts", "<script>alert('Proceso Completado');</script>");
                }

            }
        }
    }
}