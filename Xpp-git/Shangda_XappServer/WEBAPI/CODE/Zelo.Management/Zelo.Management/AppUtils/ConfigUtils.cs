using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Zelo.Management.AppUtils
{
    public class ConfigUtils
    {
        private static readonly String HHT_TYPE_STRING = ConfigurationManager.AppSettings["HHT_Type"];

        public static Boolean IsWebApiDebug()
        {
            String str=ConfigurationManager.AppSettings["IsWebApiDebug"];
            if ("true".ToUpper().Equals(str.ToUpper()))
            {
                return true;
            }
            return false;
        }
    }
}