using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWebsite.Data.Entities
{
    public class Address : EntityBase
    {
        public Address()
        {
            this.Street = string.Empty;
            this.Number = string.Empty;
        }

        public string Street { get; set; }

        public string? Number { get; set; }

    }
}
