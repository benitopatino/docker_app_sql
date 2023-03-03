using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace docker_app_sql
{
    public class Config
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["SqlConfig"] != null ? ConfigurationManager.ConnectionStrings["SqlConfig"].ToString() : string.Empty;
    }
}