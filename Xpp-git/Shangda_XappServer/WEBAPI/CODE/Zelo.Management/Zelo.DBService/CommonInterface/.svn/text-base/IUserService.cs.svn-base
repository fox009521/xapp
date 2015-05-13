using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zelo.DBModel;

namespace Zelo.DBService
{
    /// <summary>
    /// 用户服务抽象类
    /// </summary>
    public interface IUserService
    {

        User GetUserByPhone(String phone, String password);
      

          /// <summary>
          /// 更新用户头像
          /// </summary>
          /// <param name="userGID"></param>
          /// <param name="avatarAddr"></param>
          /// <returns></returns>
         Boolean UpdateUserAvatar(String userGID,String avatarAddr);

        /// <summary>
        /// 电话是否存在
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
         Boolean IsPhoneExist(String phoneNumber);

        /// <summary>
        /// 更新密码
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
         Boolean UpdatePassword(String gid, String newPassword);

        /// <summary>
        /// 通过手机号添加用户
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="password"></param>
        /// <returns></returns>
         Boolean AddUserByPhone(String phone, String password);
    }
}
