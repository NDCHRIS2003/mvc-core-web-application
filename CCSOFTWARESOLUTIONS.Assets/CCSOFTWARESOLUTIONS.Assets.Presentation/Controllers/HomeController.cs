using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CCSOFTWARESOLUTIONS.Assets.Presentation.Models;
using System.Collections;
using CCSOFTWARESOLUTIONS.Assets.BLL;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CCSOFTWARESOLUTIONS.Assets.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // get list of asset types and add a 0 element to the list
            ViewBag.AssetTypes = GetAssetTypes();
            return View();
        }

        protected IEnumerable GetAssetTypes()
        {
            var types = AssetTypesManager.GetAsKeyValuePairs();
            var names = new SelectList(types, "Value", "Text");

            var list = names.ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "All Asset Types",
                Value = "0",
            });
            return list;
        }

        public IActionResult GetAssetByType(int id)
        {
            return ViewComponent("AssetsByType", id);
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}
