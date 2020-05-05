using CCSOFTWARESOLUTIONS.Assets.BLL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CCSOFTWARESOLUTIONS.Assets.Domain;
using CCSOFTWARESOLUTIONS.Assets.Presentation.Models;

namespace CCSOFTWARESOLUTIONS.Assets.Presentation.ViewComponents
{
    public class AssetsByTypeViewComponent : ViewComponent
    {
        //use InvokeAsync to have assets display asynchronously

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            List<Asset> types = null;           

            if(id == 0)
            {
                types = AssetsManager.GetAll();   

            }
            else
            {
                types = AssetsManager.GetAllByAssetType(id);
            }
            // get the assets from the AssetViewModel
            var assets = types.Select(a => new AssetViewModel 
            { 
                Description = a.Description,
                TagNumber = a.TagNumber,
                SerialNumber = a.SerialNumber,
                Id = a.Id,
                AssetType = a.AssetType.Name,               
            
            }).ToList();

            return View(assets);
        }
    }
}
