using Microsoft.EntityFrameworkCore;
using StoreWepApp.Model.DBContext;
using StoreWepApp.repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StoreWepApp.repository.repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        StoreDBConext _dbContext;
        public DbSet<T> dbset;
        public GenericRepository(StoreDBConext context)
        {
            _dbContext = context;
            dbset = _dbContext.Set<T>();
        }
        public void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

      

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            return dbset;
        }
    }
}
