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
    public partial class CVentas : System.Web.UI.Page
    {
        public static List<Ventas> Listas { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
           if (!Page.IsPostBack)
            {
                Listas = VentasBLL.ListarTodo();

                GridViewConsultaVenta.DataSource = Listas;
                GridViewConsultaVenta.DataBind();
            }
            
        }
        private void BuscarSelecCombo()
        {
            Listas = null;

            if (DropDownListFiltro.SelectedIndex == 0)
            {
                Listas = VentasBLL.ListarTodo();

            }
            else if (DropDownListFiltro.SelectedIndex == 1)
            {
                if (TextBox1.Text == "")
                {
                    base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe de Insertar la descripcion');</script>");
                }
                else
                {
                    int Busqueda = Utilidades.TOINT(TextBox1.Text);
                    Listas = VentasBLL.GetListaVentaId( Busqueda);
                    
                }
                GridViewConsultaVenta.DataSource = Listas;
                GridViewConsultaVenta.DataBind();
            }
            else if (DropDownListFiltro.SelectedIndex == 2)
            {
                if (TextBox1.Text == "")
                {
                    base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe de Insertar la descripcion');</script>");
                }
                else
                {
                    int Busqueda = Utilidades.TOINT(TextBox1.Text);
                    Listas = VentasBLL.GetListaVentaId( Busqueda);
                    GridViewConsultaVenta.DataSource = Listas;
                    GridViewConsultaVenta.DataBind();
                }
            }
           
       

        }

        public int String(string texto)
        {
            int numero = 0;
            int.TryParse(texto, out numero);
            return numero;
        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe de Insertar la descripcion');</script>");
            }
            else
            {
                BuscarSelecCombo();
                
            }
        }

    }
    }



    
    
