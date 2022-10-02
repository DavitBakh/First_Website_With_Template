namespace FirstWebsite.WebUi.Models
{
    public class HomePageViewModel
    {
        public HomePageViewModel()
        {
            PopularPlaces = new List<PopularPlaceViewModel>();
        }

        public List<PopularPlaceViewModel> PopularPlaces { get; set; }
    }
}
