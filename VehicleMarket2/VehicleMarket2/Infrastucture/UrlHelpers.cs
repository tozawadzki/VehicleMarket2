using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace VehicleMarket2.Infrastucture
{
    public static class UrlHelpers
    {
        public static string CategoriesIconsPath(this UrlHelper helper, string categoryIconName)
        {
            var CategoriesIconFolder = AppConfig.CategoryIconRelationFolder;
            var tmpPath = Path.Combine(CategoriesIconFolder, categoryIconName);
            var absPath = helper.Content(tmpPath);

            return absPath;
        }

        public static string ImagesIconsPath(this UrlHelper helper, string imagesIconName)
        {
            var ImagesIconFolder = AppConfig.CategoryIconRelationFolder;
            var tmpPath = Path.Combine(ImagesIconFolder, imagesIconName);
            var absPath = helper.Content(tmpPath);

            return absPath;
        }

        public static string VehiclesIconsPath(this UrlHelper helper, string vehicleIconName)
        {
            var VehiclesIconFolder = AppConfig.CategoryIconRelationFolder;
            var tmpPath = Path.Combine(VehiclesIconFolder, vehicleIconName);
            var absPath = helper.Content(tmpPath);

            return absPath;
        }
    }
}