namespace FirstWebsite.WebUi.Models
{
    public class PopularPlaceViewModel
    {
        public PopularPlaceViewModel()
        {
            Name = String.Empty;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int EstatesCount { get; set; }
    }
}
