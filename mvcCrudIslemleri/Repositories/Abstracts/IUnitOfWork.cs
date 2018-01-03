using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcCrudIslemleri.Repositories.Abstracts
{
    public interface IUnitOfWork:IDisposable
    {
        bool Commit();
        IRepository<T> GetRepo<T>() where T : class, new();

        void Dispose(bool disposing);

        //1. Respository Bağlantısı
        //2. Data base bağlantısı tek bir yerden yürütülsün
        //3. Transaction yönetimi

    }
}
