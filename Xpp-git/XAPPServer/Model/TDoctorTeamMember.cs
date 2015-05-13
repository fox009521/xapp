using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Easy4net.CustomAttributes;
namespace HealthCloud.DBModel
{
    [Table(Name = "T_DoctorTeamMember")]
    public class TDoctorTeamMember
    {
        [Id(Name = "TeamMemberID", Strategy = GenerationType.INDENTITY)]
        public int TeamMemberID { get; set; }

        [Column(Name = "DoctorGID")]
        public string DoctorGID { get; set; }

        [Column(Name = "DoctorMID")]
        public string DoctorMID { get; set; }

        [Column(Name = "Status")]
        public int Status { get; set; }

        [Column(Name = "TeamGID")]
        public string TeamGID { get; set; }

        [Column(Name = "TeamMID")]
        public string TeamMID { get; set; }

        [Column(Name = "CreateTime")]
        public DateTime CreateTime { get; set; }

        [Column(Name = "UpdateTime")]
        public DateTime? UpdateTime { get; set; }

        [Column(Name = "IsDel")]
        public int? IsDel { get; set; }

    }
}    

