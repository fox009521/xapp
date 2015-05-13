using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zelo.Common.Common;
using Zelo.DBModel;

namespace Zelo.DBService
{
    /// <summary>
    /// 医生服务类
    /// </summary>
    public class DoctorService : BaseService, IUserService
    {

        /// <summary>
        /// 添加医生
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Boolean AddUserByPhone(String phone, String password)
        {
            //用户是否存在

            TDoctor doctor = new TDoctor();
            doctor.Phone = phone;
            doctor.Password = SecurityService.PasswordEncrypt(password);
            doctor.CreateTime = DateTime.Now;
            doctor.Status = (int)Status.Enable;
            //赋值ID

            return DataBaseHelper.Save<TDoctor>(doctor) > 0 ? true : false;
        }

        /// <summary>
        /// 通过手机号登录
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <param name="password"></param>
        public TDoctor GetDoctorByPhone(String phoneNumber, String password)
        {
            String passwordEncrypt = SecurityService.PasswordEncrypt(password);
            String strSql = "select * from T_Doctor where phone=@myPhone and password=@password ";
            ParamMap param = ParamMap.newMap();
            param.setParameter("myPhone", phoneNumber);
            param.setParameter("password", passwordEncrypt);
            return DataBaseHelper.FindOne<TDoctor>(strSql, param);
        }

        /// <summary>
        /// 通过GID获取医生的信息
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public TDoctor GetDoctorByGID(String doctocID)
        {
            String strSql = "select * from T_Doctor where DoctorGID=@DoctorGID";
            ParamMap param = ParamMap.newMap();
            param.setParameter("DoctorGID", doctocID);
            return DataBaseHelper.FindOne<TDoctor>(strSql, param);
        }
        /// <summary>
        /// 通过医生的MID来查询医生信息
        /// </summary>
        /// <param name="doctorMID"></param>
        /// <returns></returns>
        public TDoctor GetDoctorByMID(String doctorMID)
        {
            String strSql = "select * from T_Doctor where DocotorMID=@DoctorMID";
            ParamMap param = ParamMap.newMap();
            param.setParameter("DoctorMID", doctorMID);
            return DataBaseHelper.FindOne<TDoctor>(strSql, param);
        }

        /// <summary>
        /// 手机号是否已经被医生注册
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public Boolean IsPhoneExist(String phoneNumber)
        {
            String strSql = "select count(*) from T_Doctor where phone=@myPhone  ";
            ParamMap param = ParamMap.newMap();
            param.setParameter("myPhone", phoneNumber);
            return DataBaseHelper.IsExist(strSql, param);
        }

        public Boolean UpdatePassword(String gid, String newPassword)
        {
            String strSql = @"update T_Doctor set password=@Password  where DoctorGID=@DoctorGID";
            ParamMap param = ParamMap.newMap();
            param.setParameter("Password", SecurityService.PasswordEncrypt(newPassword));
            param.setParameter("DoctorGID", gid);
            return DataBaseHelper.ExcuteSQL(strSql, param) > 0 ? true : false;
        }


        public Boolean UpdateDoctorInfo(TDoctor doctor)
        {
            return DataBaseHelper.Update<TDoctor>(doctor) > 0 ? true : false;
        }



        public bool UpdateUserAvatar(string userGID, string avatarAddr)
        {
            String strSql = @"update T_Doctor  SET Avatar=@Avatar where DoctorGID=@DoctorGID";
            ParamMap param = ParamMap.newMap();
            param.setParameter("Avatar", avatarAddr);
            param.setParameter("DoctorGID", userGID);
            return DataBaseHelper.ExcuteSQL(strSql, param) > 0 ? true : false;

        }



        public User GetUserByPhone(string phone, string password)
        {
            TDoctor doctor = GetDoctorByPhone(phone, password);
            if (doctor != null)
            {
                User user = new User();
                user.UserGID = doctor.DoctorGID;

                return user;
            }
            return null;
        }

    }
}
