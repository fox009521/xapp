using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zelo.Management.AppFliter;
using Zelo.Management.AppUtils;
using Zelo.Management.Models;
using Zelo.DBModel;
using Zelo.DBService;

namespace Zelo.Management.Controllers
{

    public class PatientController : AbstractUserController, IUserController
    {
        public PatientController()
        {
            this.ControllerTokenType = TokenType.Patient;
        }
        /// <summary>
        /// 通过手机号登录
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpPost]
        public Result<LoginPatientInfo> LoginByPhone(UserPhoneLogin loginInfo)
        {
            TPatient patient = GetService<PatientService>().GetPatientByPhone(loginInfo.phone, loginInfo.password);
            Result<LoginPatientInfo> returnResult = Result<LoginPatientInfo>.CreateInstance(ResultCode.Fail);
            if (patient == null)
            {
                returnResult.message = "账号名或密码错误";
                return returnResult;
            }
            //获取token
            ServiceResult result = GetService<TokenService>().InsertOrUpdateToken(TokenType.Patient, patient.PatientGID);
            if (result.IsSuccess)
            {
                LoginPatientInfo info = new LoginPatientInfo();

                info.age = patient.Age;
                info.token = result.message;
                info.avatar = patient.Avatar;
                info.name = patient.PatientName;
                info.patient_id = patient.PatientMID;
                info.user_id = patient.PatientGID;

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
        /// 更新患者信息
        /// </summary>
        /// <param name="docotorInfo"></param>
        /// <returns></returns>
        [PatientTokenAuthActionFilter]
        public Result<String> UpdatePatientInfo(UpdatePatientParam patientParams)
        {
            if (IsAuthrized)
            {

                Result<String> result = Result<String>.CreateInstance(ResultCode.Fail);
                TPatient patient = GetService<PatientService>().GetPatientByGID(patientParams.user_id);
                if (patient != null)
                {
                    patient.PatientName = patientParams.name != null ? patientParams.name : patient.PatientName;
                    patient.ReservationPhone = patientParams.contact_phone != null ? patientParams.contact_phone : patient.ReservationPhone;
                    patient.FamilyName = patientParams.family_name != null ? patientParams.family_name : patient.FamilyName;
                    patient.FamilyTelephone = patientParams.family_phone != null ? patientParams.family_phone : patient.FamilyTelephone;
                    patient.Address = patientParams.address != null ? patientParams.address : patient.Address;
                    if (patientParams.sex >= 0)
                    {
                        patient.Sex = patientParams.sex;
                    }
                    if (patientParams.age >= 0)
                    {
                        patient.Age = patientParams.age;
                    }
                    if (((PatientService)UserService).UpdatePatientInfo(patient))
                    {
                        result.SetSuccess();
                        result.message = "更新成功";
                    }
                    else
                    {

                        result.message = "服务器错误：更新失败";
                    }
                }
                else
                {
                    result.message = "没有查询到对应用户";
                }


                return result;

            }
            return GetAuthFilterResult<String>();
        }
        /// <summary>
        /// 获取患者信息信息
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        [HttpPost]
        [PatientTokenAuthActionFilter]
        public Result<PatientInfo> PatientInfo(BaseParams search)
        {

            if (IsAuthrized)
            {
                String searchUserID = search.to_user_id == null ? search.user_id : search.to_user_id;
                TPatient patient = ((PatientService)UserService).GetPatientByGID(searchUserID);
                if (patient != null)
                {
                    PatientInfo info = new PatientInfo();
                    info.age = patient.Age;
                    info.sex = patient.Sex;
                    info.avatar = ObjectUtils.GetValueOrEmpty(patient.Avatar);
                    info.contact_phone = ObjectUtils.GetValueOrEmpty(patient.ReservationPhone);
                    info.family_name = ObjectUtils.GetValueOrEmpty(patient.FamilyName);
                    info.family_phone = ObjectUtils.GetValueOrEmpty(patient.FamilyTelephone);
                    info.name = ObjectUtils.GetValueOrEmpty(patient.PatientName);
                    info.address = ObjectUtils.GetValueOrEmpty(patient.Address);
                    Result<PatientInfo> result = Result<PatientInfo>.CreateInstance(ResultCode.Success, "获取信息成功");
                    result.result_data = info;
                    return result;
                }

                return Result<PatientInfo>.CreateInstance(ResultCode.Fail, "没有对应患者信息");
            }
            return GetAuthFilterResult<PatientInfo>();
        }




        [PatientTokenAuthActionFilter]
        public Result<String> UpdatePassword(UserUpdatePassword param)
        {
            return base.UpdateUserPassword(param);
        }






        [PatientTokenAuthActionFilter]
        public Result<string> UploadUserAvatar(UpdateAvatarParams param)
        {
            return base.UploadAvatar(param);
        }

        [HttpPost]
        [PatientTokenAuthActionFilter]
        public Result<DoctorInfo> QueryDoctorInfoByID(QueryDoctorInfoByMIDParams param)
        {
            return base.QueryDoctorByMID(param);
        }
    }
}
