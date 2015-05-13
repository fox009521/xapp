using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zelo.Management.AppUtils;
using Zelo.Management.Models;
using Zelo.DBModel;
using Zelo.DBService;

namespace Zelo.Management.Controllers
{
    /// <summary>
    /// 用户控制器公共抽象类
    /// </summary>
    public abstract class AbstractUserController : BaseController
    {

        private SmsValidService smsValidService = new SmsValidService();
        private TokenService tokenService = new TokenService();
        private static Random random = new Random();

        public TokenType ControllerTokenType
        {
            get;
            set;

        }

        protected SmsValidType GetSmsValidType()
        {
            switch (ControllerTokenType)
            {
                case TokenType.Doctor:
                    {
                        return SmsValidType.DoctorRegisteValid;
                    };
                case TokenType.Patient:
                    {
                        return SmsValidType.PatientRegisteValid;
                    };
            }
            return SmsValidType.DoctorRegisteValid;

        }

        public IUserService UserService
        {
            get
            {
                return ServiceFactory.GetUserService(ControllerTokenType);
            }
        }


        /// <summary>
        /// 上传头像
        /// </summary>
        /// <param name="param"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        protected Result<String> UploadAvatar(UpdateAvatarParams param)
        {
            if (IsAuthrized)
            {
                MemoryStream mStream = new MemoryStream(Convert.FromBase64String(param.image_data));
                String fileName = Guid.NewGuid().ToString() + ".png";
                String fileUrl = "/UploadFiles/Avatars/" + fileName;
                Bitmap bitmap = new Bitmap(mStream);
                var filePath = HttpContext.Current.Server.MapPath(fileUrl);
                bitmap.Save(filePath);
                Result<String> result = new Result<string>();
                if (UserService.UpdateUserAvatar(param.user_id, fileUrl))
                {
                    result.SetSuccess(fileUrl);
                }
                else
                {
                    result.SetFail("更新失败");
                }
                return result;
            }
            return GetAuthFilterResult<String>();
        }


        /// <summary>
        /// 发送短信
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        protected Result<String> SendValidMessage(String phone)
        {
            Result<String> result = Result<String>.CreateInstance(ResultCode.Fail);
            //电话是否正确
            if (!RegUtils.ValidPhoneNumber(phone))
            {
                result.message = "请输入正确的手机号";
                return result;
            }
            //手机号是否已经被医生注册
            if (UserService.IsPhoneExist(phone))
            {
                result.message = "该手机号已经被注册";
                return result;
            }
            //短信是否在1分钟内已经发送过了。
            if (smsValidService.IsSended(SmsValidType.DoctorRegisteValid, phone))
            {
                result.message = "请在1分钟之后再请求短信发送";
                return result;
            }

            //发送短信验证
            String validCode = random.Next(1000, 9999).ToString();
            if (!SmsUtils.SendValidCode(phone, validCode))
            {
                result.message = "服务器连接错误：短信发送失败";
                return result;
            }
            if (!smsValidService.SendSmsValid(GetSmsValidType(), phone, validCode))
            {
                result.message = "服务器错误:获取短信验证失败";
                return result;
            }
            result.SetSuccess();
            result.message = validCode;
            return result;
        }


        /// <summary>
        /// 更新用户密码
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        protected Result<String> UpdateUserPassword(UserUpdatePassword param)
        {
            if (IsAuthrized)
            {
                if (UserService.UpdatePassword(param.user_id, param.password))
                {
                    return Result<String>.CreateInstance(ResultCode.Success, "修改密码成功");
                }
                else
                {
                    return Result<String>.CreateInstance(ResultCode.Fail, "修改密码失败");
                }
            }
            return GetAuthFilterResult<String>();
        }
        /// <summary>
        /// 通过手机号注册
        /// </summary>
        /// <param name="signUpInfo"></param>
        /// <returns></returns>
        protected Result<BaseLoginUserInfo> SignUpByPhone(UserPhoneSignUp signUpInfo)
        {
            Result<BaseLoginUserInfo> result = Result<BaseLoginUserInfo>.CreateInstance(ResultCode.Fail);
            //验证验证码
            if (!smsValidService.IsSmsValid(GetSmsValidType(), signUpInfo.phone
                , signUpInfo.validcode))
            {
                result.message = "验证码错误";
                return result;
            }
            if (UserService.IsPhoneExist(signUpInfo.phone))
            {
                result.message = "该用户已注册";
                return result;
            }
            //添加患者信息
            if (UserService.AddUserByPhone(signUpInfo.phone, signUpInfo.password))
            {

                //后期重构 这么多冗余USER类
                Result<User> user = UserLoginByPhone(signUpInfo.phone, signUpInfo.password);
                if (user.code == (int)ResultCode.Success)
                {
                    BaseLoginUserInfo info = new BaseLoginUserInfo();
                    info.token = user.result_data.UserToken;
                    info.user_id = user.result_data.UserGID;
                    result.result_data = info;
                    result.SetSuccess();
                    result.message = "注册成功";
                }
                else
                {
                    result.SetFail("注册成功，但服务器自动登陆失败");

                }

            }
            else
            {
                result.message = "服务器错误：无法添加该用户";
            }
            return result;
        }

        /// <summary>
        /// 用户登陆
        /// </summary>
        /// <param name="loginInfo"></param>
        /// <returns></returns>
        protected Result<User> UserLoginByPhone(String phone, String password)
        {
            User doctor = UserService.GetUserByPhone(phone, password);
            Result<User> returnResult = Result<User>.CreateInstance(ResultCode.Fail);
            if (doctor == null)
            {
                returnResult.message = "账号名或密码错误";
                return returnResult;
            }
            //获取token
            ServiceResult result = tokenService.InsertOrUpdateToken(ControllerTokenType, doctor.UserGID);
            if (result.IsSuccess)
            {
                doctor.UserToken = result.message;
                returnResult.SetSuccess();
                returnResult.result_data = doctor;
                return returnResult;
            }
            else
            {
                returnResult.message = result.message;
                return returnResult;
            }
        }

        /// <summary>
        /// 查询医生信息通过MID
        /// </summary>
        /// <param name="doctorMID"></param>
        /// <returns></returns>
        protected Result<DoctorInfo> QueryDoctorByMID(QueryDoctorInfoByMIDParams doctorMID)
        {
            if (IsAuthrized)
            {
                Result<DoctorInfo> result = Result<DoctorInfo>.CreateInstance(ResultCode.Fail);
                DoctorService service = (DoctorService)ServiceFactory.GetUserService(TokenType.Doctor);
                TDoctor doctor = service.GetDoctorByMID(doctorMID.doctor_id);
                if (doctor != null)
                {
                    result.SetSuccess();
                    result.message = "查询成功";
                    result.result_data = ConvertDoctorInfo(doctor);
                }
                else
                {
                    result.message = "没有对应医生信息";
                }
                return result;
            }
            return GetAuthFilterResult<DoctorInfo>();
        }


    }
}