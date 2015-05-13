using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Easy4net.CustomAttributes;
namespace HealthCloud.DBModel
{
    public class VExercisesData
    {

    }
    
    /// <summary>
    /// 返回昨日动作总个数
    /// </summary>
    [Table(Name = "T_ExercisesData")]
    public class ExerciseCount
    {
        public String ActionGID { set; get; }
        public String ActionName { set; get; }
        public String DataValue { set; get; }
    }
    /// <summary>
    /// 既往康复数据
    /// </summary>
    [Table(Name = "T_ExercisesData")]
    public class HistoryExerciseData
    {
        public String ActionGID { set; get; }
        public String ActionName { set; get; }
        public String DataValue { set; get; }
        public DateTime UploadTime { set; get; }
        
    }
    [Table(Name = "T_ExercisesData")]
    public class PatientHistoryData
    {
        public String ActionGID { set; get; }
        public String ActionName { set; get; }
        public String ActionType { set; get; }
        public String DataValue { set; get; }
        public DateTime UploadTime { set; get; }

    }

    public class ExerciseCountData
    {
        public String ActionGID { set; get; }
        public String ActionName { set; get; }
        public String TargetValue { set; get; }
        public String DataValue { set; get; }
    }


    /// <summary>
    /// 活动度统计信息
    /// 昨日最大 昨日次数  今日次数
    /// </summary>
    [Table(Name = "T_ExercisesData")]
    public class ActivityStatistics
    {
        public String MaxDataValue { set; get; }
        public String YesterdayCount { set; get; }
        public String TodayCount { set; get; }
    }

}
