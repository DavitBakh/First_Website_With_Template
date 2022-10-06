namespace FirstWebsite.WebUi.Models
{
    public class HomePageViewModel
    {
        public HomePageViewModel()
        {
            PopularPlaces = new List<PopularPlaceViewModel>();
            Estates = new List<EstateViewModel>();
        }

        public List<PopularPlaceViewModel> PopularPlaces { get; set; }

        public List<EstateViewModel> Estates { get; set; }
    }
}
