namespace UrbanAreasProject.Models
{
    public class CityGeoLocation
    {
        public CountryCode Country { get; set; }
        public Location Location { get; set; }
        public string Postcode { get; set; }
        public CityGeo City { get; set; }
        public Continent Continent { get; set; }
    }

    public class CountryCode
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
    public class Location
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }

    public class CityGeo
    {
        public string Name { get; set; }
        public string Population { get; set; }
    }

    public class Continent
    {
        public string Name { get; set; }
    }
}







