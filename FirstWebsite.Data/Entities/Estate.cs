using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWebsite.Data.Entities
{
    public class Estate : EntityBase
    {
        public Estate()
        {
            this.Name = string.Empty;
            this.Description = string.Empty;
            this.Address = new Address();
            this.City = new City();
        }

        public string Name { get; set; }

        public string? Description { get; set; }

        public decimal Prise { get; set; }

        public virtual Address Address { get; set; }

        public virtual City City { get; set; }

        [NotMapped]
        public string Image
        {
            get
            {
                return Path.Combine("property-images", this.Id + ".jpg");
            }
        }
    }
}
