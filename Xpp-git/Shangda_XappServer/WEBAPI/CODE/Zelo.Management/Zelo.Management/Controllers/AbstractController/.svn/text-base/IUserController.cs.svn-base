using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zelo.DBModel;
using Zelo.Management.Models;

namespace Zelo.Management.Controllers
{
    public interface IUserController
    {


        /// <summary>
        /// 更新用户头像
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        Result<String> UploadUserAvatar(UpdateAvatarParams param);

        /// <summary>
        /// 获取短信验证
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        Result<String> GetValidMessage(String phone);
        /// <summary>
        /// 注册，通过手机号
        /// </summary>
        /// <param name="signUpInfo"></param>
        /// <returns></returns>
        Result<BaseLoginUserInfo> SignUp(UserPhoneSignUp signUpInfo);

        /// <summary>
        /// 通过医生的MID来查询医生
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        Result<DoctorInfo> QueryDoctorInfoByID(QueryDoctorInfoByMIDParams param);
        
        
    }
}