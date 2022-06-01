using System.Collections.Generic;

namespace UrbanAreasProject.Models
{
    public class Country
    {
        public List<DataCountry> Data { get; set; }
    }
    public class DataCountry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string WikiDataId { get; set; }
        public string Code { get; set; }
    }
}
