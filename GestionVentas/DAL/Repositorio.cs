using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;
using System.Data.Entity;
using GestionVentas.DAL;



    public class Repositorio<TEntity> : IRepository <TEntity> where TEntity : class
    {
        GestionVentaDb Contex = null;

        public Repositorio()
        {
            Contex = new GestionVentaDb();
        }
        public List<TEntity> GetList(Expression<Func<TEntity, bool>> criterioBusqueda)
        {
            try
            {
                return EntitySet.Where(criterioBusqueda).ToList();
            }
            catch (Exception)
            {
               throw;
                //return new List<TEntity>();
            }
        }
    public TEntity Buscar(Expression<Func<TEntity, bool>> Id)
    {
        TEntity result = null;
        try
        {

            result = EntitySet.FirstOrDefault(Id);
        }
        catch (Exception)
        {

            throw;
        }
        return result;
    }
    public List<TEntity> GetListTodo()
        {
            try
            {
                return EntitySet.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private DbSet<TEntity> EntitySet
        {
            get
            {

                return Contex.Set<TEntity>();
            }
        }

        public List<TEntity> Lista(Expression<Func<TEntity, bool>> criterioBusqueda)
        {
            List<TEntity> Result = null;
            try
            {
                Result = EntitySet.Where(criterioBusqueda).ToList();
            }
            catch { }

            return Result;
        }

        public List<TEntity> ListaTodo()
        {
            using (var Conec = new GestionVentaDb())
            {
                try
                {
                    return EntitySet.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }

          //  return null;
        }

        public void Dispose()
        {
            if (Contex != null)
                Contex.Dispose();
        }

    }

namespace GestionVentas.DAL
{

    public class Repositorio<TEntity> : IRepository<TEntity> where TEntity : class
    {
        GestionVentaDb Contex = null;

        public Repositorio()
        {
            Contex = new GestionVentaDb();
        }
        public List<TEntity> GetList(Expression<Func<TEntity, bool>> criterioBusqueda)
        {
            try
            {
                return EntitySet.Where(criterioBusqueda).ToList();
            }
            catch (Exception)
            {
                throw;
            //    return new List<TEntity>();
            }
        }
        public List<TEntity> GetListTodo()
        {
            try
            {
                return EntitySet.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private DbSet<TEntity> EntitySet
        {
            get
            {

                return Contex.Set<TEntity>();
            }
        }

        public List<TEntity> Lista(Expression<Func<TEntity, bool>> criterioBusqueda)
        {
            List<TEntity> Result = null;
            try
            {
                Result = EntitySet.Where(criterioBusqueda).ToList();
            }
            catch { }

            return Result;
        }
        public TEntity Buscar(Expression<Func<TEntity, bool>> Id)
        {
            TEntity result = null;
            try
            {

                result = EntitySet.FirstOrDefault(Id);
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
        public List<TEntity> ListaTodo()
        {
            using (var Conec = new DAL.GestionVentaDb())
            {
                try
                {
                    return EntitySet.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }

            //return null;
        }

        public void Dispose()
        {
            if (Contex != null)
                Contex.Dispose();
        }

    }
}