using UrbanAreasProject.Models;

namespace UrbanAreasProject.ViewModels
{
    public class SortViewModel
    {
        public SortState PopulationSort { get; private set; } 
        public SortState LatitudeSort { get; private set; }    
        public SortState LongitudeSort { get; private set; }   
        public SortState NameSort { get; private set; }
        public SortState Current { get; private set; } 

        public SortViewModel(SortState sortOrder)
        {
            NameSort = sortOrder == SortState.NameAsc ? SortState.NameDesc : SortState.NameAsc;
            PopulationSort = sortOrder == SortState.PopulationAsc ? SortState.PopulationDesc : SortState.PopulationAsc;
            LatitudeSort = sortOrder == SortState.LatitudeAsc ? SortState.LatitudeDesc : SortState.LatitudeAsc;
            LongitudeSort = sortOrder == SortState.LongitudeAsc ? SortState.LongitudeDesc : SortState.LongitudeAsc;
            Current = sortOrder;
        }
    }
}
