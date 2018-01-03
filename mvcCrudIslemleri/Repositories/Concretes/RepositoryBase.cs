using mvcCrudIslemleri.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvcCrudIslemleri.Repositories.Concretes
{
    public class RepositoryBase<T> : IRepository<T> where T : class, new()
    {
        protected DbContext _context;
        protected IDbSet<T> _dbset;

        public RepositoryBase(DbContext context)
        {
            _context = context;
            _dbset = _context.Set<T>();

        }
        public void Add(T entity)
        {
            _dbset.Add(entity);
        }

        public void Delete(int id)
        {
            var entity = _dbset.Find(id);
            _dbset.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbset.AsEnumerable<T>();
        }

        public T GetObject(System.Linq.Expressions.Expression<Func<T, bool>> lamda)
        {
            return _dbset.FirstOrDefault(lamda);
        }

        public void Update(T entity)
        {
            var model = _dbset.Find(entity);
            _context.Entry(model).CurrentValues.SetValues(entity);
        }

        public IEnumerable<T> Where(System.Linq.Expressions.Expression<Func<T, bool>> lamda)
        {
            return _dbset.Where(lamda).AsEnumerable<T>();
        }
    }
}