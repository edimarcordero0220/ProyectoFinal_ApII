using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionVentas.DAL;
using GestionVentas.Entidades;
using System.Linq.Expressions;
using System.Data;

namespace GestionVentas.BLL
{
    public class GastosBLL
    {
        GestionVentaDb gestion = new GestionVentaDb();

        public static void Insertar(Gastos g)
        {
            try
            {
                GestionVentaDb db = new GestionVentaDb();
                db.gasto.Add(g);
                db.SaveChanges();
                db.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public static List<Gastos> GetLista()
        {
            List<Gastos> lista = new List<Gastos>();
            GestionVentaDb db = new GestionVentaDb();
            lista = db.gasto.ToList();
            return lista;

        }

        public static void Eliminar(int v)
        {
            GestionVentaDb db = new GestionVentaDb();
            Gastos cl = db.gasto.Find(v);

            db.gasto.Remove(cl);
            db.SaveChanges();
        }
        public bool Buscar(int id)
        {
            bool retorno = false;
            try
            {
                using (var db = new GestionVentaDb())
                {


                    Gastos cl = db.gasto.Find(id);

                }
                retorno = true;
            }
            catch (Exception)
            {
                throw;
            }
            return retorno;
        }
        //internal static bool Buscar(int gastoId)
        //{
        //    bool retorno = false;


        //    using (var conn = new Repositorio<Gastos>())
        //    {
        //        Gastos criterio = new Gastos();
        //        retorno = conn.Buscar(retor);
        //    }
        //    return retorno;
        //}

        //public static Gastos Buscar()
        //{


        //}
        //public bool Buscar(int Id)
        //{
        //    GestionVentaDb db = new GestionVentaDb();
        //    return db.gasto.Find(Id);
        //}


        public static Pagos Buscarbtn(int Id)
        {
            GestionVentaDb db = new GestionVentaDb();
            return db.pago.Find(Id);
        }
        public static List<Gastos> GetListaVendedor(int tmp)
        {
            List<Gastos> lista = new List<Gastos>();
            GestionVentaDb db = new GestionVentaDb();
            lista = db.gasto.Where(p => p.VendedorId == tmp).ToList();
            return lista;
        }

        public static List<Gastos> GetId(int gastoid)
        {
            List<Gastos> lista = new List<Gastos>();
            GestionVentaDb db = new GestionVentaDb();
            lista = db.gasto.Where(p => p.GastoId == gastoid).ToList();
            return lista;
        }

        public static List<Entidades.Gastos> GetList(Expression<Func<Entidades.Gastos, bool>> criterioBusqueda)
        {
            using (var repositorio = new Repositorio<Gastos>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }
        public static List<Gastos> GetListTodo()
        {
            List<Gastos> lista = null;
            using (var conn = new Repositorio<Gastos>())
            {
                lista = conn.GetListTodo().ToList();
            }

            return lista;
        }
    }
}