using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CCSOFTWARESOLUTIONS.Assets.Presentation.Models
{
    public class AssetViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Asset Type")]
        public string AssetType { get; set; }
        public string AssetTypeId { get; set; }

        [Display(Name = "Tag Number")]
        public string TagNumber { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        [Display(Name = "Serail Number")]
        public string SerialNumber { get; set; }
    }
}
