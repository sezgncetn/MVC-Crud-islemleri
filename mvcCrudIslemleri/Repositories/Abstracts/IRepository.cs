using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace mvcCrudIslemleri.Repositories.Abstracts
{
    public interface IRepository<T> where T:class,new()
    {
        void Add(T entity);
        void Delete(int id);
        void Update(T entity);
        IEnumerable<T> GetAll();
        IEnumerable<T> Where(Expression<Func<T, bool>> lamda);

        T GetObject(Expression<Func<T, bool>> lamda);
    }
}
