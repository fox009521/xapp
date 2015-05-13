using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zelo.Management.Models
{
    public  class BaseLoginUserInfo
    {
        /// <summary>
        /// token
        /// </summary>
        public String token
        {
            get;
            set;
        }
        /// <summary>
        /// 用户ID
        /// </summary>
        public String user_id
        {
            get;
            set;
        }
    }

    public abstract class AbstractUserInfo:BaseLoginUserInfo
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public String name
        {
            get;
            set;
        }

        public String avatar
        {
            get;
            set;
        }
    }


    /// <summary>
    /// 用户手机注册模板
    /// </summary>
    public class UserPhoneSignUp
    {
        public String phone
        {
            get;
            set;

        }
        public String password
        {
            get;
            set;
        }
        [Required(ErrorMessage="请填写验证码")]
        public String validcode
        {
            get;
            set;
        }

    }

    /// <summary>
    /// 用户手机登录模板
    /// </summary>
    public class UserPhoneLogin
    {

        public String phone
        {
            get;
            set;

        }
        public String password
        {
            get;
            set;
        }
    }

    
    public class UserUpdatePassword:BaseParams{
        [Required(AllowEmptyStrings = false, ErrorMessage = "password为空")]
        [StringLength(60,MinimumLength=6)]
        public String password
        {
            get;
            set;
        }
    }



    public class UpdateAvatarParams : BaseParams
    {
        [Required(ErrorMessage = "缺少image_data参数")]
        public String image_data
        {
            get;
            set;
        }
    }

    public class QueryDoctorInfoByMIDParams : BaseParams
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "doctor_id为空")]
        public String doctor_id
        {
            get;
            set;
        }
    }
}