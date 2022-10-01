using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWebsite.Data.Abstract
{
    public interface IGenericRepository<T>
    {
        void Add(T entity);

        void Delete(T entity);
        void Update(T entity);
        
        T? FindById(int id);
        Task<T?> FindByIdAsync();

        void Save();
        Task SaveAsync();

        IEnumerable<T> GetAll();
    }
}
