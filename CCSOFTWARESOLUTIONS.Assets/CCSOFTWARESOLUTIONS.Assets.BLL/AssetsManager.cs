using CCSOFTWARESOLUTIONS.Assets.Data;
using CCSOFTWARESOLUTIONS.Assets.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CCSOFTWARESOLUTIONS.Assets.BLL
{
    public class AssetsManager
    {
        public static List<Asset> GetAll()
        {
            var context = new AssetsContext();
            var asset = context.Assets.Include(at => at.AssetType).OrderBy(a => a.AssetType).ToList();
            return asset;
        }

        public static List<Asset> GetAllByAssetType(int id)
        {
            var context = new AssetsContext();
            var asset = context.Assets.Where(at => at.AssetTypeId == id).Include(a => a.AssetType).ToList();
            return asset;
        }

        public static void Add(Asset asset)
        {
            var context = new AssetsContext();
            context.Assets.Add(asset);
            context.SaveChanges();
        }

        public static Asset Find(int id)
        {
            var context = new AssetsContext();
            var asset = context.Assets.Find(id);
            return asset;
        }

        public static IList GetAsKeyValuePairs()
        {
            var context = new AssetsContext();
            var type = context.AssetTypes.Select(a => new
            {
               Value = a.Id,
                Text = a.Name,
            }).ToList();
            return type;
        }
       
    }
}
