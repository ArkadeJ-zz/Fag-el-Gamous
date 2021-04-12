using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Configuration;

namespace Fag_el_Gamous.Models
{
    public class Helpers
    {
        public static string GetRDSConnectionString()
        {
            var appConfig = ConfigurationManager.AppSettings;

            string dbname = appConfig["waterbuffalo"];

            if (string.IsNullOrEmpty(dbname)) return null;

            string username = appConfig["postgres"];
            string password = appConfig["profgreg"];
            string hostname = appConfig["aa1vamryrftaifd.cehgg64lqejx.us-east-1.rds.amazonaws.com"];
            string port = appConfig["5432"];

            return "Data Source=" + hostname + ";Initial Catalog=" + dbname + ";User ID=" + username + ";Password=" + password + ";";
        }
    }
}
