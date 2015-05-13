using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zelo.Common.Common;
using Zelo.DBModel;

namespace Zelo.DBService
{
    public class PatientService : BaseService, IUserService
    {

        public Boolean UpdatePatientInfo(TPatient patient)
        {
            return DataBaseHelper.Update<TPatient>(patient) > 0 ? true : false;
        }


        /// <summary>
        /// 通过手机号和密码查找病人
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public TPatient GetPatientByPhone(String phoneNumber, String password)
        {
            String passwordEncrypt = SecurityService.PasswordEncrypt(password);
            String strSql = "select * from T_Patient where phone=@myPhone and password=@password ";
            ParamMap param = ParamMap.newMap();
            param.setParameter("myPhone", phoneNumber);
            param.setParameter("password", passwordEncrypt);
            return DataBaseHelper.FindOne<TPatient>(strSql, param);
        }

        /// <summary>
        /// 通过GID来获取患者信息
        /// </summary>
        /// <param name="gid"></param>
        /// <returns></returns>
        public TPatient GetPatientByGID(String gid)
        {
            String passwordEncrypt = SecurityService.PasswordEncrypt(gid);
            String strSql = "select * from T_Patient where patientgid=@patientgid";
            ParamMap param = ParamMap.newMap();
            param.setParameter("patientgid", gid);
            return DataBaseHelper.FindOne<TPatient>(strSql, param);
        }

        /// <summary>
        /// 手机号是否已经被医生注册
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public Boolean IsPhoneExist(String phoneNumber)
        {
            String strSql = "select count(*) from T_Patient where phone=@myPhone  ";
            ParamMap param = ParamMap.newMap();
            param.setParameter("myPhone", phoneNumber);
            return DataBaseHelper.IsExist(strSql, param);
        }

        /// <summary>
        /// 添加患者
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Boolean AddUserByPhone(String phone, String password)
        {
            TPatient patient = new TPatient();
            patient.Phone = phone;
            patient.Password = SecurityService.PasswordEncrypt(password);
            patient.CreateTime = DateTime.Now;
            patient.Status = (int)Status.Enable;
            patient.PatientName = "";
            return DataBaseHelper.Save<TPatient>(patient) > 0 ? true : false;
        }

        public Boolean UpdatePassword(String gid, String newPassword)
        {
            String strSql = @"update T_Patient set password=@Password  where PatientGID=@PatientGID";
            ParamMap param = ParamMap.newMap();
            param.setParameter("Password", SecurityService.PasswordEncrypt(newPassword));
            param.setParameter("PatientGID", gid);
            return DataBaseHelper.ExcuteSQL(strSql, param) > 0 ? true : false;
        }


        public bool UpdateUserAvatar(string userGID, string avatarAddr)
        {
            String strSql = @"update T_Patient set avatar=@avatar  where patientGID=@patientGID";
            ParamMap param = ParamMap.newMap();
            param.setParameter("avatar", avatarAddr);
            param.setParameter("PatientGID", userGID);
            return DataBaseHelper.ExcuteSQL(strSql, param) > 0 ? true : false;
        }




        /// <summary>
        /// 
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public User GetUserByPhone(string phone, string password)
        {
            TPatient patient = GetPatientByPhone(phone, password);
            if (patient != null)
            {
                User user = new User();
                user.UserGID = patient.PatientGID;
                return user;
            }
            return null;

        }
    }
}
