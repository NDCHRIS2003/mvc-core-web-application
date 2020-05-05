using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CCSOFTWARESOLUTIONS.Assets.Presentation.Models
{
    // this is to create the HomeViewModel ( that is the asset we want to display on the
    // home page once it is loaded)
    public class HomeViewModel
    {
        [Display(Name = "Tag Number")]
        public string TagNumber { get; set; }

        public string AssetTypeId { get; set; } 

        [Display(Name = "Asset Type Name")]
        public string AssetTypeName { get; set; }

        public string Description { get; set; }

        [Display(Name = "Serial Number")]
        public string SerialNumber { get; set; }
    }
}
