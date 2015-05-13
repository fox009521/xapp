using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Easy4net.CustomAttributes;
namespace HealthCloud.DBModel  
{
    [Table(Name = "T_SmsValid")]
    public class TSmsValid
    {
        [Id(Name = "SmsID", Strategy = GenerationType.INDENTITY)]
        public int SmsID { get; set; }

        [Column(Name = "smsGID")]
        public string SmsGID { get; set; }

        [Column(Name = "Phone")]
        public string Phone { get; set; }

        [Column(Name = "StartTime")]
        public DateTime? StartTime { get; set; }

        [Column(Name = "EndTime")]
        public DateTime? EndTime { get; set; }

        [Column(Name = "ValidStatus")]
        public int? ValidStatus { get; set; }

        [Column(Name = "ValidCode")]
        public string ValidCode { get; set; }

        [Column(Name = "ValidType")]
        public int? ValidType { get; set; }

        [Column(Name = "CreateTime")]
        public DateTime? CreateTime { get; set; }

        [Column(Name = "UpdateTime")]
        public DateTime? UpdateTime { get; set; }

        [Column(Name = "Status")]
        public int? Status { get; set; }

    }
}
