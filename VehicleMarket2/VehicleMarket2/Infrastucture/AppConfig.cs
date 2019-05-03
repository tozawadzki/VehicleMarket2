using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace VehicleMarket2.Infrastucture
{
    public class AppConfig
    {
        private static string _categoryIconRelationFolder = ConfigurationManager.AppSettings["CategoryIconFolder"];

        public static string CategoryIconRelationFolder
        {
            get { return _categoryIconRelationFolder; }
        }

        private static string _imagesIconRelationFolder = ConfigurationManager.AppSettings["ImagesIconFolder"];

        public static string ImagesIconRelationFolder
        {
            get { return _imagesIconRelationFolder; }
        }

        private static string _vehiclesIconRelationFolder = ConfigurationManager.AppSettings["VehiclesIconFolder"];

        public static string VehiclesIconRelationFolder
        {
            get { return _vehiclesIconRelationFolder; }
        }
    }
}