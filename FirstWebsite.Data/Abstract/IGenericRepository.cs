using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWebsite.Data.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        void Add(T entity);

        void Delete(T entity);
        void Update(T entity);
        
        T? FindById(int id);
        Task<T?> FindByIdAsync(int id);

        void Save();
        Task SaveAsync();

        IQueryable<T> GetAll();
    }
}
