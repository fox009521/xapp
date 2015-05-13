using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Easy4net.CustomAttributes;
namespace HealthCloud.DBModel  
{
    [Table(Name = "T_DoctorTeamApply")]
    public class TDoctorTeamApply
    {
        [Id(Name = "TeamApplyID", Strategy = GenerationType.INDENTITY)]
        public int TeamApplyID { get; set; }

        [Column(Name = "ApplyContent")]
        public string ApplyContent { get; set; }


        [Column(Name = "DoctorGID")]
        public string DoctorGID { get; set; } 

        [Column(Name = "TeamGID")]
        public string TeamGID { get; set; }

        [Column(Name = "ApplyResult")]
        public int ApplyResult { get; set; }

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
