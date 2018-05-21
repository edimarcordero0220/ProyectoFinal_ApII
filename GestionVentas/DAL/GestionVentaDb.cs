using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using GestionVentas.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace GestionVentas.DAL
{
    public class GestionVentaDb : DbContext
    {
        private SqlConnection con;
        private SqlCommand Cmd;
        public GestionVentaDb() : base("name = ConStr")
        {
                
        }
        public virtual DbSet<Gastos> gasto { get; set; }
        public virtual DbSet<Pagos> pago { get; set; }
        public virtual DbSet<CuadresVendedores> Cuadre { get; set; }
        public virtual DbSet<CuadresVendedorDetalles> detalle { get; set; }
        public virtual DbSet<Vendedores> vendedores { get; set; }
        public virtual DbSet<Ventas> ventas { get; set; }
        public virtual DbSet<Subsidios> subsidios { get; set; }
        public virtual DbSet<Categorias> Categoria { get; set; }
        public virtual DbSet<VendedoresDetalles>VendedorDetalle { get; set; }


        public DataTable ObtenerDatos(String ComandoSql)
        {

            SqlDataAdapter adapter;
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                Cmd.Connection = con;
                Cmd.CommandText = ComandoSql;

                adapter = new SqlDataAdapter(Cmd);
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return dt;
        }

    }
}