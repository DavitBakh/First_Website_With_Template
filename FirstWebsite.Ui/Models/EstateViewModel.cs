using FirstWebsite.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace FirstWebsite.WebUi.Models
{
    public class EstateViewModel
    {
        public EstateViewModel()
        {
            Title = String.Empty;
            Description = String.Empty;
            Address = String.Empty;
            City = String.Empty;
            Country = String.Empty;
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public string Type { get; set; }

        public int Rooms { get; set; }

        public decimal Price { get; set; }

        public int Area { get; set; }

        private string address;

        public string Address { get { return $"{Country} - {City} - {address}"; } set { address = value; } }


        public string City { get; set; }

        public string Country { get; set; }


    }
}
