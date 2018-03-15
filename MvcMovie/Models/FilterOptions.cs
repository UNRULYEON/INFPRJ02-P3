using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Models
{
    public class FilterOptions
    {
        public string Age { get; set; }
        public List<SelectListItem> SelectedAge { get; set; }
        public string Gender{ get; set; }
        public List<SelectListItem> SelectedGender { get; set; }
        public string MigratieAchtergrond{ get; set; }
        public List<SelectListItem> SelectedMigratieAchtergrond { get; set; }
        public string Period{ get; set; }
        public List<SelectListItem> SelectedPeriod { get; set; }
    }
}