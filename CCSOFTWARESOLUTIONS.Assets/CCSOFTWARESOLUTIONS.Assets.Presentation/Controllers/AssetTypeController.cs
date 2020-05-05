using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CCSOFTWARESOLUTIONS.Assets.BLL;
using CCSOFTWARESOLUTIONS.Assets.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CCSOFTWARESOLUTIONS.Assets.Presentation.Controllers
{
    public class AssetTypeController : Controller
    {
        //// GET: AssetType
        public ActionResult Index()
        {
            return View();
        }

        //// GET: AssetType/Create
        public ActionResult Create()
        {
            return View();
        }

        //// POST: AssetType/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AssetType assetType)
        {
            try
            {
                // Call the AssetTypeManager to add
                AssetTypesManager.Add(assetType);
                return RedirectToAction("Create", "Assets");
            }
            catch
            {
                return View();
            }
        }

        //// GET: AssetType/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    var assetType = AssetTypesManager.Find(id);
        //    return View(assetType);
        //}

        //// POST: AssetType/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(AssetType assetType)
        //{
        //    try
        //    {
        //        // Call the AssetTypeManager to edit
        //        AssetTypesManager.update(assetType);

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}


    }
}