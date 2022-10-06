using FirstWebsite.Data.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

        public virtual Estate_Status Status { get; set; }

        public virtual Estate_Type Type { get; set; }

        public int Rooms { get; set; }

        public decimal Prise { get; set; }

        public int Area { get; set; }

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
