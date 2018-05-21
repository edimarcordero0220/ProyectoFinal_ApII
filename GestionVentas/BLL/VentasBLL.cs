using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionVentas.DAL;
using GestionVentas.Entidades;

namespace GestionVentas.BLL
{
    public class VentasBLL
    {
        public static void Guardar(Ventas ve)
        {
            try
            {
                GestionVentaDb db = new GestionVentaDb();
                db.ventas.Add(ve);
                //db.SaveChanges();
                db.Dispose();
            }
            catch (FormatException)
            {
                Console.WriteLine("No se puede convertir a '{0}' a un solo. ", ve);
            }

        }



        public static void Eliminar(int eliminar)
        {
            GestionVentaDb db = new GestionVentaDb();
            Ventas ve = db.ventas.Find(eliminar);

            db.ventas.Remove(ve);
            db.SaveChanges();
        }

        public static Ventas Buscar(int Id)
        {
            GestionVentaDb db = new GestionVentaDb();
            return db.ventas.Find(Id);
        }
        public static List<Ventas> GetListaVentaId(int tmp)
        {
            List<Ventas> lista = new List<Ventas>();
            GestionVentaDb db = new GestionVentaDb();
            lista = db.ventas.Where(a => a.VentaId == tmp).ToList();
            return lista;
        }
        public static List<Ventas> GetContrasena(string tmp)
        {
            List<Ventas> lista = new List<Ventas>();
            GestionVentaDb db = new GestionVentaDb();
            //lista = db.ventas.Where(e => e.Comision == tmp).ToList();
            return lista;
        }
        public static List<Ventas> ListarTodo()
        {
            List<Ventas> lista = null;
            using (var conn = new Repositorio<Ventas>())
            {
                lista = conn.GetListTodo().ToList();
            }

            return lista;
        }
    }
}
