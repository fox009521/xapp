using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Easy4net.CustomAttributes;

namespace HealthCloud.DBModel
{
    [Table(Name = "T_Patient")]
   public class VTPatient:TPatient
    {
        #region  拓展属性
        //患者类型  住院状态
        public int patientType { get; set; }
        //诊断结果
        public String diagnosisResult { get; set; }
        //床号
        public String bedNum { get; set; }
        //入院时间
        public DateTime admissionTime { get; set; }
        //康复方案Id
        public String recoveryPlan { get; set; }
        //康复方案名称
        public String templateName { get; set; }
        ////聊天群组号 
        //public String chatGroupID { get; set; }
        
        #endregion
    }
}
