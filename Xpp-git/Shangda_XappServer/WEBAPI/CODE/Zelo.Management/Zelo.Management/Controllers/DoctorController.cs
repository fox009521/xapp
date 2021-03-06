﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Zelo.DBModel;
using Zelo.DBService;
using Zelo.Management.AppFliter;
using Zelo.Management.Models;

namespace Zelo.Management.Controllers
{

    public class DoctorController : AbstractUserController, IUserController
    {

        public DoctorController()
        {
            this.ControllerTokenType = TokenType.Doctor;
        }

        #region 登录
        /// <summary>
        /// 通过手机号登录
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpPost]
        public Result<LoginDoctorInfo> LoginByPhone(UserPhoneLogin loginInfo)
        {
            TDoctor doctor = GetService<DoctorService>().GetDoctorByPhone(loginInfo.phone, loginInfo.password);
            Result<LoginDoctorInfo> returnResult = Result<LoginDoctorInfo>.CreateInstance(ResultCode.Fail);
            if (doctor == null)
            {
                returnResult.message = "账号名或密码错误";
                return returnResult;
            }

            //获取token
            ServiceResult result = GetService<TokenService>().InsertOrUpdateToken(TokenType.Doctor, doctor.DoctorGID);
            if (result.IsSuccess)
            {
                LoginDoctorInfo info = new LoginDoctorInfo();

                info.age = doctor.Age.GetValueOrDefault();
                info.token = result.message;
                info.avatar = doctor.Avatar;
                info.name = doctor.DoctorName;
                info.user_id = doctor.DoctorGID;
                info.doctor_id = doctor.DocotorMID;
                //TDoctorTeam sr = ServiceFactory.GetService<DoctorTeamService>().IsJoinTeamByGid(doctor.DoctorGID);
                //if (sr != null) { info.teamId = sr.TeamMID; }

                returnResult.SetSuccess();

                returnResult.result_data = info;

                return returnResult;
            }
            else
            {
                returnResult.message = result.message;
                return returnResult;
            }
        }

        #endregion



        #region  医生信息编辑
        /// <summary>
        /// 更新医生信息
        /// </summary>
        /// <param name="docotorInfo"></param>
        /// <returns></returns>
        [DoctorTokenAuthActionFilter]
        public Result<String> UpdateDoctorInfo(UpdateDocotorParams doctorInfo)
        {
            //if (IsAuthrized)
            //{
            //    Result<String> result = Result<String>.CreateInstance(ResultCode.Fail);
            //    TDoctor doctor = GetService<DoctorService>().GetDoctorByGID(doctorInfo.user_id);
            //    if (doctor != null)
            //    {
            //        // 姓名
            //        doctor.DoctorName = doctorInfo.name != null ? doctorInfo.name : doctor.DoctorName;
            //        // 地区-市
            //        doctor.CityName = doctorInfo.city != null ? doctorInfo.city : doctor.CityName;
            //        // 医院名称
            //        doctor.HospitalName = doctorInfo.hospital != null ? doctorInfo.hospital : doctor.HospitalName;
            //        // 地区-省
            //        doctor.ProvinceName = doctorInfo.province != null ? doctorInfo.province : doctor.ProvinceName;
            //        // 职称
            //        doctor.DoctorTitle = doctorInfo.title != null ? doctorInfo.title : doctor.DoctorTitle;
            //        // 个性签名
            //        doctor.Introduce = doctorInfo.introduce != null ? doctorInfo.introduce : doctor.Introduce;

            //        if (doctorInfo.sex != null)
            //        {
            //            if (doctorInfo.sex >= 0)
            //            {
            //                doctor.Sex = doctorInfo.sex;

            //            }
            //        }
            //        else
            //        {
            //            doctor.Sex = doctorInfo.sex;
            //        }

            //        if (((DoctorService)UserService).UpdateDoctorInfo(doctor))
            //        {
            //            result.SetSuccess();
            //            result.message = "更新成功";
            //        }
            //        else
            //        {

            //            result.message = "服务器错误：更新失败";
            //        }
            //    }
            //    else
            //    {
            //        result.message = "没有查询到对应用户";
            //    }
            //    return result;


            //}
            return GetAuthFilterResult<String>();
        }

        /// <summary>
        /// 更新医生头像
        /// </summary>
        /// <param name="docotorInfo"></param>
        /// <returns></returns>
        [DoctorTokenAuthActionFilter]
        [HttpPost]
        public Result<string> UploadUserAvatar(UpdateAvatarParams param)
        {
            return base.UploadAvatar(param);
        }
        /// <summary>
        /// 获取医生信息
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        [DoctorTokenAuthActionFilter]
        public Result<DoctorInfo> DoctorInfo(BaseParams search)
        {
            if (IsAuthrized)
            {
                Result<DoctorInfo> result = Result<DoctorInfo>.CreateInstance(ResultCode.Fail);
                String searchUserID = search.to_user_id == null ? search.user_id : search.to_user_id;
                TDoctor doctor = GetService<DoctorService>().GetDoctorByGID(searchUserID);
                if (doctor != null)
                {
                    DoctorInfo info = ConvertDoctorInfo(doctor);
                    result.SetSuccess();
                    result.result_data = info;
                }
                else
                {
                    result.message = "没有查询到该医生信息";
                }

                return result;

            }
            return GetAuthFilterResult<DoctorInfo>();
        }




        #endregion



        #region 接口实现类

        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="password"></param>
        /// <param name="validCode"></param>
        /// <returns></returns>
        [HttpPost]
        public Result<BaseLoginUserInfo> SignUp(UserPhoneSignUp signUpInfo)
        {
            return base.SignUpByPhone(signUpInfo);
        }

        /// <summary>
        /// 更新密码
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        [DoctorTokenAuthActionFilter]
        public Result<String> UpdatePassword(UserUpdatePassword param)
        {
            return base.UpdateUserPassword(param);
        }

        /// <summary>
        /// 发送验证信息
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        [HttpGet]
        public Result<String> GetValidMessage(String phone)
        {
            return base.SendValidMessage(phone);

        }


        #endregion

        [DoctorTokenAuthActionFilter]
        public Result<DoctorInfo> QueryDoctorInfoByID(QueryDoctorInfoByMIDParams param)
        {
            return base.QueryDoctorByMID(param);
        }
    }
}
