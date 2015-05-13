using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Zelo.Management.AppUtils
{
    /// <summary>
    /// 正则表达式工具
    /// </summary>
    public static class RegUtils
    {
        /// <summary>
        /// 是否为邮箱
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static Boolean ValidEmail(string source)
        {
            return Regex.IsMatch(source, EmailRegString, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// 是否为标准手机
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public static Boolean ValidPhoneNumber(String phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, PhoneRegString);
        }

        public static readonly String PhoneRegString=@"^(13|14|15|16|17|18|19)\d{9}$";
        public static readonly String EmailRegString=@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
         

    }
}