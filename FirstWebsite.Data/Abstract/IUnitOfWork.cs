using FirstWebsite.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWebsite.Data.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Estate> EstateRepo { get; }
        IGenericRepository<City> CityRepo { get; }
        IGenericRepository<Country> CountryRepo { get; }

        void Save();
        Task SaveAsync();     
    }
}
