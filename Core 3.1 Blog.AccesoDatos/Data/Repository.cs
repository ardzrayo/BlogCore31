using Core_3._1_Blog.AccesoDatos.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core_3._1_Blog.AccesoDatos.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        //Variable protegida de solo lectura
        protected readonly DbContext Context;
        internal DbSet<T> dbSet;

        //ctor+tabx2: generar constructor
        public Repository(DbContext context)
        {
            Context = context;
            this.dbSet = context.Set<T>();
        }


        public void Add(T entity)
        {
            //throw new NotImplementedException();
            dbSet.Add(entity);
        }

        public T Get(int id)
        {
            //throw new NotImplementedException();
            return dbSet.Find(id);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null)
        {
            //throw new NotImplementedException();
            IQueryable<T> query = dbSet;

            if(filter != null)
            {
                query = query.Where(filter);
            }

            //include properties separadas por comas
            if(includeProperties != null)
            {
                foreach(var includeProperty in includeProperties.Split(new char[] { ','}, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            //validar el ordenamiento
            if(orderBy != null)
            {
                return orderBy(query).ToList();
            }

            return query.ToList();

        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null)
        {
            //throw new NotImplementedException();
            IQueryable<T> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            //include properties separadas por comas
            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            return query.FirstOrDefault();
        }

        public void Remove(int id)
        {
            //throw new NotImplementedException();
            T entityToRemove = dbSet.Find(id);

            Remove(entityToRemove);
        }

        public void Remove(T entity)
        {
            //throw new NotImplementedException();
            dbSet.Remove(entity);
        }
    }
}
