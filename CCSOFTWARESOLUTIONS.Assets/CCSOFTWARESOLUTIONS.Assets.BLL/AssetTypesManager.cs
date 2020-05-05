using CCSOFTWARESOLUTIONS.Assets.Data;
using CCSOFTWARESOLUTIONS.Assets.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCSOFTWARESOLUTIONS.Assets.BLL
{
    public class AssetTypesManager
    {
        public static IList GetAsKeyValuePairs()
        {
            var context = new AssetsContext();
            var types = context.AssetTypes.Select(type => new
            {
                Value = type.Id,
                Text = type.Name,
            }).ToList();
            return types;
        }

        public static void Add(AssetType assetType)
        {
            var context = new AssetsContext();
            context.AssetTypes.Add(assetType);
            context.SaveChanges();
        }

        public static IList<AssetType> GetAll()
        {
            var context = new AssetsContext();
            var assetType = context.AssetTypes.OrderBy(a => a.Name).ToList();
            return assetType;
        }

        public static void update(AssetType assetType)
        {
            var context = new AssetsContext();
            var originalAssetType = context.AssetTypes.Find(assetType.Id);
            originalAssetType.Name = assetType.Name;           
            context.SaveChanges();
        }

        public static AssetType Find(int id)
        {
            var context = new AssetsContext();
            var assetType = context.AssetTypes.Find(id);
            return assetType;
        }



    }
}
