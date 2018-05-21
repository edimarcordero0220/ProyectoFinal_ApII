using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionVentas.DAL;
using GestionVentas.Entidades;
using System.Linq.Expressions;

namespace GestionVentas.BLL
{
    public class CategoriasBLL
    {
        public static void Insertar(Categorias c)
        {
            try
            {
                GestionVentaDb db = new GestionVentaDb();
                db.Categoria.Add(c);
                db.SaveChanges();
                db.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public static List<Categorias> GetLista()
        {
            List<Categorias> lista = new List<Categorias>();
            GestionVentaDb db = new GestionVentaDb();
            lista = db.Categoria.ToList();
            return lista;

        }

        public static void Eliminar(int v)
        {
            GestionVentaDb db = new GestionVentaDb();
            Categorias cl = db.Categoria.Find(v);

            db.Categoria.Remove(cl);
            db.SaveChanges();
        }

        public static Categorias Buscar(int Id)
        {
            GestionVentaDb db = new GestionVentaDb();
            return db.Categoria.Find(Id);
        }
        public static List<Categorias> GetListaCategoria(int tmp)
        {
            List<Categorias> lista = new List<Categorias>();
            GestionVentaDb db = new GestionVentaDb();
            lista = db.Categoria.Where(p => p.CategoriaId == tmp).ToList();
            return lista;
        }

        public static List<Categorias> GetNombres(string nombres)
        {
            List<Categorias> lista = new List<Categorias>();
            GestionVentaDb db = new GestionVentaDb();
            lista = db.Categoria.Where(p => p.Nombre == nombres).ToList();
            return lista;
        }
        public static List<Entidades.Categorias> GetList(Expression<Func<Entidades.Categorias, bool>> criterioBusqueda)
        {
            using (var repositorio = new Repositorio<Categorias>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }
        public static List<Categorias> GetListTodo()
        {
            List<Categorias> lista = null;
            using (var conn = new Repositorio<Categorias>())
            {
                lista = conn.GetListTodo().ToList();
            }

            return lista;
        }
    }
}