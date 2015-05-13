using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zelo.Management.AppUtils
{
    public class ObjectUtils
    {
        /// <summary>
        /// 是否为NULL或者空
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static Boolean IsNullOrEmpty<T>(List<T> list)
        {
            if (list == null)
            {
                return true;
            }
            if (list.Count <= 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        ///如果非NULL则返回默认值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static String GetValueOrEmpty(String obj)
        {
            if (obj != null)
            {
                return obj;
            }
            return "";
        }

        public static T GetValueOrDefault<T>(Object item)
        {
            if (item != null)
            {
                return (T)item;
            }
            return default(T);
        }

     



    }
}