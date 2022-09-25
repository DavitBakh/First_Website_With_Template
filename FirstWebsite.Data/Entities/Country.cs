using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWebsite.Data.Entities
{
    public class Country : EntityBase
    {
        public Country()
        {
            this.Name = string.Empty;
            this.Cities = new List<City>();
        }

        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}
