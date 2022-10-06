using FirstWebsite.Data.Abstract;
using FirstWebsite.Data.Data;
using FirstWebsite.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWebsite.Data.Concreate
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        private  GenericRepositiry<Estate> estateRepo;
        private  GenericRepositiry<City> cityRepo;
        private  GenericRepositiry<Country> countryRepo;


        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<Estate> EstateRepo
        {
            get
            {
                if (estateRepo == null)
                    estateRepo = new GenericRepositiry<Estate>(_context);
                return estateRepo;
            }
        }

        public IGenericRepository<City> CityRepo
        {
            get
            {
                if (cityRepo == null)
                    cityRepo = new GenericRepositiry<City>(_context);
                return cityRepo;
            }
        }

        public IGenericRepository<Country> CountryRepo
        {
            get
            {
                if (countryRepo == null)
                    countryRepo = new GenericRepositiry<Country>(_context);
                return countryRepo;
            }
        }

        public void Dispose()
        {
           _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task SaveAsync()
        {
           await _context.SaveChangesAsync();
        }
    }
}
