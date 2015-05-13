using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthCloud.DBModel
{
    /// <summary>
    /// 模版参数
    /// </summary>
    public class TemplateInfo
    {
        public string templateId { get; set; }
        public string templateName { get; set; }
        public string docotorMID { get; set; }
        public string teamMID { get; set; }
        public string templateMemo { get; set; }
        //public int templateType { get; set; }
        public int applicationType { get; set; }
        public String createName { get; set; }
        public DateTime? createTime { get; set; }
        public DateTime? updateTime { get; set; }
        public List<TemplateDetail> templateDetailList { get; set; }



    }

    /// <summary>
    /// 患者模版信息
    /// </summary>
    public class PatientTemplateInfo
    {
        public string templateId { get; set; }
        public string templateName { get; set; }
        public string docotorName { get; set; }
        public string templateMemo { get; set; }
        /// <summary>
        /// 模版类型
        /// </summary>
        public int applicationType { get; set; }
        public List<TemplateDetail> templateDetailList { get; set; }
    }

    //返回的模版信息
    public class TemplateRetuInfo
    {
        public string templateId { get; set; }
        public string templateName { get; set; }
        public string docotorMID { get; set; }
        public string teamMID { get; set; }
        public string templateMemo { get; set; }
        public int applicationType { get; set; }
        public String createName { get; set; }
        public DateTime? createTime { get; set; }
        public DateTime? updateTime { get; set; }
    }
    //返回的模版信息
    public class AdminTemplateRetuInfo
    {
        public string templateId { get; set; }
        public string templateName { get; set; }
        public string templateMemo { get; set; }
        public int applicationType { get; set; }
        public String createName { get; set; }
        public DateTime? createTime { get; set; }
        public DateTime? updateTime { get; set; }
    }

    /// <summary>
    /// Stage对象
    /// </summary>
    public class StageInfo
    {
        //public string stageID { get; set; }
        //public string targetGID { get; set; }
        public int stageIndex { get; set; }
        public int fromData { get; set; }
        public int toData { get; set; }
        public string valueData { get; set; }

    }

    /// <summary>
    /// 模版详情
    /// </summary>
    public class TemplateDetail
    {
        public string templateDetailId { get; set; }
        //public string templateId { get; set; }
        public string actionId { get; set; }
        public string actionName { get; set; }
        public int actionType { get; set; }
        public int statisticalType { get; set; }
        public string actionImages { get; set; }
        public List<StageInfo> targetList { get; set; }
    }

    /// <summary>
    /// 动作表
    /// </summary>
    public class ActionInfo
    {
        public string actionGID { get; set; }
        public string actionName { get; set; }
        public string actionImages { get; set; }
        public string actionVideos { get; set; }
        public string actionMemo { get; set; }
        public int actionType { get; set; }
        public int StatisticalType { get; set; }
    }
    public class ActionInfoParam
    {
        public string ActionGID { get; set; }
        public string ActionName { get; set; }
        public string ActionImages { get; set; }
        public string ActionVideos { get; set; }
        public string ActionMemo { get; set; }
        public int ActionType { get; set; }
        public int StatisticalType { get; set; }
    }
   
}
