using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionVentas.Entidades;
using GestionVentas.DAL;
using System.Linq.Expressions;
using System.Data;

namespace GestionVentas.BLL
{
    public class DetalleCuadreBLL
    {
        public static void Insertar(CuadresVendedorDetalles cd)
        {
            try
            {
                GestionVentaDb db = new GestionVentaDb();
                db.detalle.Add(cd);
                db.SaveChanges();
                db.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static CuadresVendedorDetalles Buscar(int Id)
        {
            GestionVentaDb db = new GestionVentaDb();
            return db.detalle.Find(Id);
        }
        public static List<CuadresVendedorDetalles> GetLista()
        {
            List<CuadresVendedorDetalles> lista = new List<CuadresVendedorDetalles>();
            GestionVentaDb db = new GestionVentaDb();
            lista = db.detalle.ToList();
            return lista;

        }

     


        public static void Eliminar(int v)
        {
            GestionVentaDb db = new GestionVentaDb();
            CuadresVendedorDetalles cl = db.detalle.Find(v);

            db.detalle.Remove(cl);
            db.SaveChanges();
        }
      
        public static List<CuadresVendedorDetalles> GetListaCuadre(int tmp)
        {
            List<CuadresVendedorDetalles> lista = new List<CuadresVendedorDetalles>();
            GestionVentaDb db = new GestionVentaDb();
            lista = db.detalle.Where(p => p.CuadreId == tmp).ToList();
            return lista;
        }
        public static List<Entidades.CuadresVendedorDetalles> GetList(Expression<Func<Entidades.CuadresVendedorDetalles, bool>> criterioBusqueda)
        {
            using (var repositorio = new Repositorio<CuadresVendedorDetalles>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }
        public static List<CuadresVendedorDetalles> GetListTodo()
        {
            List<CuadresVendedorDetalles> lista = null;
            using (var conn = new Repositorio<CuadresVendedorDetalles>())
            {
                lista = conn.GetListTodo().ToList();
            }

            return lista;
        }

     
    }
}