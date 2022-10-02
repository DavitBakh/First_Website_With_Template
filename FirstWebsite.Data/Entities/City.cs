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
            Estates = new List<Estate>();
        }

        public string Name { get; set; }

        public bool isPopular { get; set; }

        public virtual Country Country { get; set; }

        public virtual ICollection<Estate> Estates { get; set; }
    }
}
