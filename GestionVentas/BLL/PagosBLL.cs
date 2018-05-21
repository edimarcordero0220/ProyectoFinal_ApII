using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionVentas.Entidades;
using GestionVentas.DAL;
using System.Linq.Expressions;

namespace GestionVentas.BLL
{
    public class PagosBLL
    {
        public static void Insertar(Pagos p)
        {
            try
            {
                GestionVentaDb db = new GestionVentaDb();
                db.pago.Add(p);
                db.SaveChanges();
                db.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public static List<Pagos> GetLista()
        {
            List<Pagos> lista = new List<Pagos>();
            GestionVentaDb db = new GestionVentaDb();
            lista = db.pago.ToList();
            return lista;

        }

        public static void Eliminar(int v)
        {
            GestionVentaDb db = new GestionVentaDb();
            Pagos cl = db.pago.Find(v);

            db.pago.Remove(cl);
            db.SaveChanges();
        }
        public static Pagos Buscar(int Id)
        {
            GestionVentaDb db = new GestionVentaDb();
            return db.pago.Find(Id);
        }
        public static List<Pagos> GetListaVendedor(int tmp)
        {
            List<Pagos> lista = new List<Pagos>();
            GestionVentaDb db = new GestionVentaDb();
            lista = db.pago.Where(p => p.VendedorId == tmp).ToList();
            return lista;
        }

        public static List<Pagos> GetId(int pagoid)
        {
            List<Pagos> lista = new List<Pagos>();
            GestionVentaDb db = new GestionVentaDb();
            lista = db.pago.Where(p => p.PagoId== pagoid).ToList();
            return lista;
        }
        public static List<Entidades.Pagos> GetList(Expression<Func<Entidades.Pagos, bool>> criterioBusqueda)
        {
            using (var repositorio = new Repositorio<Pagos>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }
        public static List<Pagos> GetListTodo()
        {
            List<Pagos> lista = null;
            using (var conn = new Repositorio<Pagos>())
            {
                lista = conn.GetListTodo().ToList();
            }

            return lista;
        }
    }
}