using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;
using System.Data.Entity;


namespace GestionVentas.DAL
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        List<TEntity> Lista(Expression<Func<TEntity, bool>> criterioBusqueda);
        TEntity Buscar(Expression<Func<TEntity, bool>> Id);
        

       
    }
}