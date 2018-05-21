using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestionVentas.Entidades;
using GestionVentas.BLL;


namespace GestionVentas.Registros
{
    public partial class rCuadreDetalleVend : System.Web.UI.Page
    {
        
        System.Data.DataTable table;
        System.Data.DataRow row;
        DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)
            {

               
                LLenarComboGastos();
                LLenarComboPagos();
                LlenarComboSubsidios();

            }

            if (IsPostBack == false)
            {

                dt.Columns.AddRange(new DataColumn[7] { new DataColumn("Vendido"), new DataColumn("Gastos"), new DataColumn("Pagos"), new DataColumn("Comision"), new DataColumn("Ganancia"), new DataColumn("Pendiente"), new DataColumn("Monto") });
                ViewState["Detalle"] = dt;


            }
        }
        protected void Limpiar()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[7] { new DataColumn("Vendido"), new DataColumn("Gastos"), new DataColumn("Pagos"), new DataColumn("Comision"), new DataColumn("Ganancia"), new DataColumn("Pendiente"), new DataColumn("Monto") });

            VendidoTextBox.Text = "";
            ComisionTextBox.Text = "";
            PendienteTextBox.Text = "";
            GananciaTextBox.Text = "";
            TextBox2.Text = "";
            ViewState["Detalle"] = dt;
            this.BindGrid();
        }
        public void LLenarComboGastos()
        {
            GastosDropDownList.DataSource = BLL.GastosBLL.GetListTodo();
            GastosDropDownList.DataTextField = "Concepto";
            GastosDropDownList.DataValueField = "GastoId";
            GastosDropDownList.DataBind();

        }
        public void LLenarComboPagos()
        {
            PagosDropDownList2.DataSource = BLL.PagosBLL.GetListTodo();
            PagosDropDownList2.DataTextField = "Concepto";
            PagosDropDownList2.DataValueField = "PagoId";
            PagosDropDownList2.DataBind();

        }
        public void LlenarComboSubsidios()
        {
            SubcidioDropDownList1.DataSource = BLL.SubsidiosBLL.GetListTodo();
            SubcidioDropDownList1.DataTextField = "Concepto";
            SubcidioDropDownList1.DataValueField = "SubcidioId";
            SubcidioDropDownList1.DataBind();

        }
        public void LlenarClase(Entidades.CuadresVendedorDetalles d)
        {
            Entidades.CuadresVendedores c = new CuadresVendedores();
            
            d.Vendido = Utilidades.TOINT(VendidoTextBox.Text);
            d.Subsidios = Utilidades.ValidarIdEntero(SubcidioDropDownList1.SelectedValue);
            d.Pagos = Utilidades.ValidarIdEntero(PagosDropDownList2.SelectedValue);
            d.Gastos = Utilidades.ValidarIdEntero(GastosDropDownList.SelectedValue);
            d.Monto = Utilidades.TOINT(TextBox2.Text);
            d.Comision = Utilidades.TOINT(ComisionTextBox.Text);
            d.Pendiente = Utilidades.TOINT(PendienteTextBox.Text);
            d.Ganancia = Utilidades.TOINT(GananciaTextBox.Text);

            foreach (GridViewRow dr in GridView.Rows)
            {
                c.AgregarDetalle(Convert.ToInt16(dr.Cells[0].Text), Convert.ToInt32(dr.Cells[1].Text), Convert.ToInt32(dr.Cells[2].Text), Convert.ToInt32(dr.Cells[3].Text), Convert.ToInt32(dr.Cells[4].Text), Convert.ToInt32(dr.Cells[5].Text), Convert.ToInt32(dr.Cells[6].Text));
            }
        }
        protected void BindGrid()
        {
            GridView.DataSource = (DataTable)ViewState["Detalle"];
            GridView.DataBind();

        }
        protected void Search()
        {

           
        }
        protected void AgregarButton_Click(object sender, EventArgs e)
        {

            if (VendidoTextBox.Text == "" || ComisionTextBox.Text == "" || GananciaTextBox.Text == "" || PendienteTextBox.Text == "" || TextBox2.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debes Llenar los Campos identificados con (*)');</script>");
            }
            else
            {
                DataTable dt = (DataTable)ViewState["Detalle"];
                dt.Rows.Add(PendienteTextBox.Text, TextBox2.Text, VendidoTextBox.Text, GastosDropDownList.Text, PagosDropDownList2.Text, ComisionTextBox.Text, GananciaTextBox.Text);
                ViewState["Detalle"] = dt;

                this.BindGrid();

            }
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
                CuadresVendedorDetalles p = new CuadresVendedorDetalles();
                LlenarClase(p);
                DetalleCuadreBLL.Insertar(p);
                Utilidades.ShowToastr(this, "Nitido, Ya Lo Guardaste.", "Exito", "success");
                Limpiar();
            
        }
        public void LlenarRegistro(CuadresVendedorDetalles p)
        {
            CuadresVendedores df = new CuadresVendedores();

            PendienteTextBox.Text = Convert.ToString(p.Pendiente);
            TextBox2.Text = Convert.ToString(p.Monto);
            VendidoTextBox.Text = Convert.ToString(p.Vendido);
            GastosDropDownList.SelectedValue = Convert.ToString(p.Gastos);
            PagosDropDownList2.SelectedValue = Convert.ToString(p.Pagos);
            ComisionTextBox.Text = Convert.ToString(p.Comision);
            GananciaTextBox.Text = Convert.ToString(p.Ganancia);

            foreach (var li in df.Lista)
            {
                DataTable dt = (DataTable)ViewState["Detalle"];
                dt.Rows.Add(li.Pendiente, li.Monto, li.Vendido, li.Gastos, li.Pagos, li.Comision, li.Ganancia);
                ViewState["Detalle"] = dt;
                this.BindGrid();
            }

        }
      
        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            CuadresVendedorDetalles cd = new CuadresVendedorDetalles();


            if (IdTextBox.Text=="") 
            {
                
            }
            else
            {
                DetalleCuadreBLL.Buscar(Convert.ToInt16(IdTextBox.Text));
                LlenarRegistro(cd);
            }
            
        }
    }
}