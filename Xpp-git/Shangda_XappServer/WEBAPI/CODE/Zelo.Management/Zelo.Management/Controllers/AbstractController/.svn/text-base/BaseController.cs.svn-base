using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Zelo.Management.AppUtils;
using Zelo.Management.Models;
using Zelo.DBModel;
using Zelo.DBService;


namespace Zelo.Management.Controllers
{
    public abstract class BaseController : ApiController
    {

        public BaseController()
        {



        }

        public User CurrentUser
        {
            get;
            set;
        }

        private Boolean _isAuthrized = false;
        public Boolean IsAuthrized
        {
            get
            {
                return _isAuthrized;
            }
            set
            {
                _isAuthrized = value;
            }

        }


        /// <summary>
        /// token是否过期
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public Boolean IsTokenOutDate(String userID, String token)
        {
            return false;
            //return userTokenDAL.IsTokenOutDate(userID,token);
        }
        /// <summary>
        /// 检查modelstat,参数是否验证成功，且token是否正确，如果正确返回null;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param"></param>
        /// <returns></returns>
        public Result<T> CheckModelState<T>(BaseParams param)
        {
            Result<T> result = ControllerUtils.getErrorResult<T>(ModelState, param);
            if (result == null)
            {

                if (IsTokenOutDate(param.user_id, param.token))
                {
                    User user = new User();
                    user.UserGID = param.user_id;
                    user.UserToken = param.token;
                    CurrentUser = user;
                    return Result<T>.CreateInstance(ResultCode.TokenOutDate, "token过期");
                }
                else
                {
                    return null;
                }
            }
            return result;
        }

        public Result<object> AuthFilterResult { get; set; }

        /// <summary>
        /// 获取最后结果
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public Result<T> GetAuthFilterResult<T>()
        {
            Result<T> temp = new Result<T>();
            temp.code = AuthFilterResult.code;
            temp.message = AuthFilterResult.message;
            return temp;

        }

        public T GetService<T>() where T : BaseService
        {
            return ServiceFactory.GetService<T>(CurrentUser);
        }

        #region 一些特殊方法

        /// <summary>
        /// 一身模型转化
        /// </summary>
        /// <param name="doctor"></param>
        /// <returns></returns>
        protected DoctorInfo ConvertDoctorInfo(TDoctor doctor)
        {
            DoctorInfo info = new DoctorInfo();

            info.avatar = ObjectUtils.GetValueOrEmpty(doctor.Avatar);
            info.name = ObjectUtils.GetValueOrEmpty(doctor.DoctorName);
            info.province = ObjectUtils.GetValueOrEmpty(doctor.ProvinceName);
            info.sex = ObjectUtils.GetValueOrDefault<int>(doctor.Sex);
            info.title = ObjectUtils.GetValueOrEmpty(doctor.DoctorTitle);
            info.doctor_id = doctor.DocotorMID;
            info.city = ObjectUtils.GetValueOrEmpty(doctor.CityName);
            info.hospital = ObjectUtils.GetValueOrEmpty(doctor.HospitalName);
            info.introduce = ObjectUtils.GetValueOrEmpty(doctor.Introduce);
            info.user_id = ObjectUtils.GetValueOrEmpty(doctor.DoctorGID);

            return (DoctorInfo)info;
        }


        #endregion
    }
}
