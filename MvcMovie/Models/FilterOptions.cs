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
        public string Period{ get; set; }
        public List<SelectListItem> SelectedPeriod { get; set; }
        public string Criteria{ get; set; }
        public List<SelectListItem> SelectedCriteria { get; set; }
        public string MigratieAchtergrond{ get; set; }
        public string MigratieAchtergrond2{ get; set; }
        public List<SelectListItem> SelectedMigratieAchtergrond { get; set; }
    }

    public class Deelvraag1FilterOptions
    {
        public string Bedrijfstak { get; set; }
        public List<SelectListItem> SelectedBedrijfstak { get; set; }
        public string Regio{ get; set; }
        public List<SelectListItem> SelectedRegio { get; set; }
        public string Period{ get; set; }
        public List<SelectListItem> SelectedPeriod { get; set; }
    }

    public class Deelvraag2FilterOptions
    {
        //public string WOZWaardeklassen { get; set; }
        //public List<SelectListItem> selectedWOZWaardeklassen { get; set; }
        //public string BrutoInkomen { get; set; }
        //public List<SelectListItem> selectedBrutoInkomen { get; set; }
        //public string Huishoudens { get; set; }
        //public List<SelectListItem> selectedHuishoudens { get; set; }
        //public string Herkomst { get; set; }
        //public List<SelectListItem> selectedHerkomst { get; set; }
        //public string RegioS { get; set; }
        //public List<SelectListItem> selectedRegioS { get; set; }
        //public string Perioden { get; set; }
        //public List<SelectListItem> selectedPerioden { get; set; }

        public string Perioden { get; set; }
        public List<SelectListItem> selectedPerioden { get; set; }
        public string KenmerkenBaanBedrijfsgrootte { get; set; }
        public List<SelectListItem> selectedKenmerkenBaanBedrijfsgrootte { get; set; }
        public string BedrijfstakkenBranchesSBI2008 { get; set; }
        public List<SelectListItem> selectedBedrijfstakkenBranchesSBI2008 { get; set; }
        public string BedrijfstakkenBranchesSBI20082 { get; set; }
        public List<SelectListItem> selectedBedrijfstakkenBranchesSBI20082 { get; set; }
        public string critters { get; set; }
        public List<SelectListItem> selectedCritters { get; set; }
    }
}