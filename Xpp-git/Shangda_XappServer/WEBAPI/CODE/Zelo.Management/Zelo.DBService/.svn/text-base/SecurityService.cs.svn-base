using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zelo.Common.DBUtility;

namespace Zelo.DBService
{
    /// <summary>
    /// 系统安全服务累
    /// </summary>
    public class SecurityService
    {

        private static readonly String USER_PASSWORD_PREFIX = "a49b0cASDFASDFASDF3a279a7e8ASDFASDFSDFA72a49b0cASDFB";
        /// <summary>
        /// 用户密码加密
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static String PasswordEncrypt(String password)
        {
            return SecurityUtils.AESEncrypt(password,USER_PASSWORD_PREFIX);
        }
        /// <summary>
        /// 用户密码解密
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static String PasswordDecrypt(String password)
        {
            return SecurityUtils.AESDecrypt(password,USER_PASSWORD_PREFIX);
        }
        /// <summary>
        /// 获取GUID
        /// </summary>
        /// <returns></returns>
        public static String RandomGUID()
        {
            return Guid.NewGuid().ToString();

        }
    }
}
