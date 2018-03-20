using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Models
{
    public class SelectedListModel
    {
        [DisplayName("Select a category")]
        public string SelectedId { get; set; }

        public IEnumerable<SelectListItem> CategoryList { get; set; }
    }
}