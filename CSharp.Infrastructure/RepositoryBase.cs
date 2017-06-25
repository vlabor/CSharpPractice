using CSharp.Data;
using System;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Linq;
using System.Collections.Generic;

namespace CSharp.Infrastructure
{
    public abstract class RepositoryBase <T> where T : class
    {
        private CSharpEntities dbContext;

        private readonly DbSet<T> dbSet;

        protected IDbFactory DbFactory
        {
            get;
            private set;
        }
        protected CSharpEntities DbContext
        {
            get { return dbContext ?? (dbContext = DbFactory.Init()); }
        }

        protected RepositoryBase(IDbFactory dbFactory)
        {
            this.DbFactory = dbFactory;

            dbSet = DbContext.Set<T>();
        }

        public virtual void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public virtual void Update(T entity)
        {
            dbSet.Attach(entity);
            DbContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> listToDelete = dbSet.Where<T>(where).AsEnumerable(); 
            foreach(T entity in listToDelete)
            {
                dbSet.Remove(entity);
            }
        }

        public virtual T GetById(int id)
        {
            return dbSet.Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).ToList<T>();
        }

        public virtual T Get(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).FirstOrDefault<T>();
        }
    }
}
