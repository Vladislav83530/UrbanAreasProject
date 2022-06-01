using System.Collections.Generic;
using UrbanAreasProject.Models;

namespace UrbanAreasProject.ViewModels
{
    public class IndexViewModel
    {
        public DataCity Data { get; set; }
        public IEnumerable<DataCity> Cities { get; set; }
        public FilterViewModel FilterViewModel { get; set; }
        public SortViewModel SortViewModel { get; set; }
    }
}
