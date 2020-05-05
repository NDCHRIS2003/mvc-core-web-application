using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CCSOFTWARESOLUTIONS.Assets.Domain
{
    [Table("AssetType")]
    public class AssetType
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "AssetType")]
        public string Name { get; set; }
        //navigation property
        public ICollection<Asset> Asset { get; set; }
    }
}
