using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CCSOFTWARESOLUTIONS.Assets.BLL;
using CCSOFTWARESOLUTIONS.Assets.Domain;
using CCSOFTWARESOLUTIONS.Assets.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CCSOFTWARESOLUTIONS.Assets.Presentation.Controllers
{
    public class AssetsController : Controller
    {
        public IActionResult Index()
        {
            // load content to viewbag

            return View();
        }


        public IActionResult Create()
        {
            // we will need to call the AssetType manager here to get the collection of key value objects
            var assets = AssetsManager.GetAsKeyValuePairs();
            // to create the collection of SelectListItems
            var types = new SelectList(assets, "Value", "Text");
            var list = types.ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "Select Asset Type",
                Value = ""
            });

            ViewBag.AssetType = list;
            
            return View();
        }        


        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Create(Asset asset)
        {
            try
            {
                AssetsManager.Add(asset);
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }

        }


    }
}