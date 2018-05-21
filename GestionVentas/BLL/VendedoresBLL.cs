using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionVentas.DAL;
using GestionVentas.Entidades;
using System.Data;
using System.Linq.Expressions;

namespace GestionVentas.BLL
{
    public class VendedoresBLL
    {
        public static void Guardar(Vendedores ven)
        {
            try
            {


                GestionVentaDb db = new GestionVentaDb();
                db.vendedores.Add(ven);
                db.SaveChanges();
                db.Dispose();
            }
            catch (FormatException)
            {
                Console.WriteLine("No se puede convertir a '{0}' a un solo. ", ven);
            }

        }
        public static void Eliminar(int eliminar)
        {
            GestionVentaDb db = new GestionVentaDb();
            Vendedores ven = db.vendedores.Find(eliminar);

            db.vendedores.Remove(ven);
            // db.SaveChanges();
        }

        public static Vendedores Buscar(int Id)
        {
            GestionVentaDb db = new GestionVentaDb();
            return db.vendedores.Find(Id);
        }
        public static List<Vendedores> GetListaVendedorId(int tmp)
        {
            List<Vendedores> lista = new List<Vendedores>();
            GestionVentaDb db = new GestionVentaDb();
            lista = db.vendedores.Where(a => a.VendedorId == tmp).ToList();
            return lista;
        }
        public static List<Vendedores> GetContrasena(string tmp)
        {
            List<Vendedores> lista = new List<Vendedores>();
            GestionVentaDb db = new GestionVentaDb();
            lista = db.vendedores.Where(a => a.Nombres == tmp).ToList();
            return lista;
        }
        public static List<Entidades.Vendedores> GetList(Expression<Func<Entidades.Vendedores, bool>> criterioBusqueda)
        {
            using (var repositorio = new Repositorio<Vendedores>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }
        public static List<Vendedores> GetListTodo()
        {
            List<Vendedores> lista = null;
            using (var conn = new Repositorio<Vendedores>())
            {
                lista = conn.GetListTodo().ToList();
            }

            return lista;
        }

    }
}
