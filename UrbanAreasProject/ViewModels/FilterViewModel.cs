namespace UrbanAreasProject.ViewModels
{
    public class FilterViewModel
    {
        public FilterViewModel( string name, string country, string region)
        {          
            SelectedCountryName = country;
            SelectedCityName = name;
            SelectedRegionName = region;
        }
        public string SelectedCityName { get; private set; }
        public string SelectedRegionName { get; private set; }       
        public string SelectedCountryName { get; private set; } 
        
    }
}
