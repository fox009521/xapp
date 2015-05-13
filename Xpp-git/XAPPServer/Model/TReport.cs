using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Easy4net.CustomAttributes;

namespace HealthCloud.DBModel
{

    [Table(Name = "T_Report")]
    public class TReport
    {
        [Id(Name = "ReportID", Strategy = GenerationType.INDENTITY)]
        public int ReportID { get; set; }

        [Column(Name = "ReportGID")]
        public string ReportGID { get; set; }

        [Column(Name = "PatientID")]
        public string PatientID { get; set; }

        [Column(Name = "DoctorID")]
        public string DoctorID { get; set; }

        [Column(Name = "TeamID")]
        public string TeamID { get; set; } 

        [Column(Name = "ReportResult")]
        public int ReportResult { get; set; }

        [Column(Name = "CreateTime")]
        public DateTime CreateTime { get; set; }

        [Column(Name = "UpdateTime")]
        public DateTime? UpdateTime { get; set; }

        [Column(Name = "IsDel")]
        public int? IsDel { get; set; }

        [Column(Name = "Status")]
        public int? Status { get; set; }

    }
}
