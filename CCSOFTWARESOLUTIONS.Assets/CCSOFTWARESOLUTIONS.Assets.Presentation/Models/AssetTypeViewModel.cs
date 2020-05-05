using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CCSOFTWARESOLUTIONS.Assets.Presentation.Models
{
    // this is to create the AssetType view model as we want only the asset name display on the
    // page
    public class AssetTypeViewModel
    {
        [Display(Name = "Asset Type")]
        public string Name { get; set; }
    }
}
