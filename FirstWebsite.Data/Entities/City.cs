using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWebsite.Data.Entities
{
    public class City : EntityBase
    {
        public City()
        {
            this.Name = string.Empty;
            this.Country = new Country();
        }

        public string Name { get; set; }

        public virtual Country Country { get; set; }
    }
}
