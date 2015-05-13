using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zelo.Management.Models
{
    /// <summary>
    /// 登录患者信息
    /// </summary>
    public class LoginPatientInfo : AbstractUserInfo
    {

        public int age
        {
            get;
            set;
        }

        /// <summary>
        /// 医生ID
        /// </summary>
        public String patient_id
        {
            get;
            set;
        }


    }


    public class PatientInfo
    {
        public int sex
        {
            get;
            set;
        }

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
        public int age
        {
            get;
            set;
        }
        public String contact_phone
        {
            get;
            set;
        }
        public String family_name
        {

            get;
            set;
        }
        public String family_phone
        {
            get;
            set;
        }
        public String address
        {
            get;
            set;
        }
       // 姓名、性别，年龄，联系电话、患者家属名字，患者家属电话
    }

    /// <summary>
    /// 向医生报道
    /// </summary>
    public class ReportToDoctorParam:BaseParams
    {
        /// <summary>
        /// 医生ID
        /// </summary>
        public String doctor_id
        {
            get;
            set;
        }

        ///// <summary>
        ///// 患者姓名
        ///// </summary>
        //public String patient_name
        //{
        //    get;
        //    set;
        //}

        ///// <summary>
        ///// 患者电话
        ///// </summary>
        //public String patient_phone
        //{
        //    get;
        //    set;
        //}
    }

    
    /// <summary>
    /// 更新患者信息
    /// </summary>
    public class UpdatePatientParam : BaseParams
    {
        public int sex
        {
            get;
            set;
        }

        public String name
        {
            get;
            set;
        }
    
        public int age
        {
            get;
            set;
        }
        public String contact_phone
        {
            get;
            set;
        }
        public String family_name
        {

            get;
            set;
        }
        public String family_phone
        {
            get;
            set;
        }
        public String address
        {
            get;
            set;
        }
    }


}