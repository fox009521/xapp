using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zelo.Management.Models
{

    #region 返回参数
    /// <summary>
    /// 登录医生信息
    /// </summary>
    public class LoginDoctorInfo : AbstractUserInfo
    {

        public int age
        {
            get;
            set;
        }


        /// <summary>
        /// 医生ID
        /// </summary>
        public String doctor_id
        {
            get;
            set;
        }
        /// <summary>
        /// 医生团队信息
        /// </summary>
        public String teamId
        {
            get;
            set;
        }


    }


    public class DoctorInfo
    {

        public String user_id
        {
            get;
            set;
        }
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

        public String doctor_id
        {
            get;
            set;
        }
        public int sex
        {
            get;
            set;
        }
        public String province
        {
            get;
            set;
        }
        public String city
        {
            get;
            set;
        }
        public String hospital
        {
            get;
            set;
        }

        public String title
        {
            get;
            set;
        }
        public String introduce
        {
            get;
            set;
        }
    }


    /// <summary>
    /// 返回请求患者信息
    /// </summary>
    public class ReportPatientInfo
    {
        public String patientMId
        {
            get;
            set;
        }
        public string patientId
        {
            get;
            set;
        }
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
        public String address { get; set; }
        // 姓名、性别，年龄，联系电话、患者家属名字，患者家属电话 患者地址
    }

    /// <summary>
    /// 我的患者信息
    /// </summary>
    public class MyPatientInfo
    {
        public String patientMId
        {
            get;
            set;
        }
        public string patientId
        {
            get;
            set;
        }
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
        //用户状态
        public int patientType
        {
            get;
            set;
        }
        //诊断  
        public string diagnosisResult
        {
            get;
            set;
        }
        //床号
        public String bedNum { get; set; }
        //入院时间
        public DateTime admissionTime { get; set; }
        //康复方案Id
        public String recoveryPlan { get; set; }
        //康复方案名称
        public String templateName { get; set; }
        //地址
        public String address { get; set; }
        public String contact_phone
        {
            get;
            set;
        }
        //聊天群组ID
        public string chatGroupID { get; set; } 

    }


    #endregion

    #region 查询
    /// <summary>
    /// 更新医生信息
    /// </summary>
    public class UpdateDocotorParams : BaseParams
    {

        /// <summary>
        /// 姓名
        /// </summary>
        public String name
        {
            get;
            set;
        }

        private int mSex = -1;
        public int sex
        {
            get
            {
                return mSex;
            }
            set
            {
                mSex = value;
            }
        }
        public String province
        {
            get;
            set;
        }
        public String hospital
        {
            get;
            set;
        }

        public String title
        {
            get;
            set;
        }
        public String city
        {
            get;
            set;
        }

        public String introduce
        {
            get;
            set;
        }

    }


    /// <summary>
    /// 请求我的患者请求信息
    /// </summary>
    public class MyPatientParams : BaseParams
    {
        /// <summary>
        /// 患者状态  0123 分别为全部  门诊 住院  出院
        /// </summary>
        public int patientStatus
        {
            get;
            set;
        }

    }
    /// <summary>
    /// 修改我的患者状态
    /// </summary>
    public class EditMyPatientParams : BaseParams
    {
        /// <summary>
        /// 患者状态  0123 分别为全部  门诊 住院  出院
        /// </summary>
        public String patientId
        {

            get;
            set;
        }
        public int patientStatus
        {
            get;
            set;
        }

    }

    //我的患者其他信息
    /// <summary>
    /// 床号等
    /// </summary>
    public class MyPatientInfoParams : BaseParams
    {
        /// <summary>
        /// 患者状态  0123 分别为全部  门诊 住院  出院
        /// </summary>
        public String patientId { get; set; }
        //床号
        public string bedNum { get; set; }

        //入院时间
        public DateTime admissionTime { get; set; }

        //诊断结果
        public string diagnosisResult { get; set; }
        //康复方案Id
        public string recoveryPlan { get; set; }
        //用户状态
        public int patientStatus { get; set; }

    }



    #endregion


}