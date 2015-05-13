using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Easy4net.CustomAttributes;

namespace HealthCloud.DBModel
{
    [Table(Name = "T_DoctorTeam")]
    public class TDoctorTeam
    {
        [Id(Name = "TeamID", Strategy = GenerationType.INDENTITY)]
        public int TeamID { get; set; }

        [Column(Name = "TeamMID")]
        public string TeamMID { get; set; } 


        [Column(Name = "CreateTime")]
        public DateTime CreateTime { get; set; }

        [Column(Name = "UpdateTime")]
        public DateTime? UpdateTime { get; set; }

        [Column(Name = "TeamGID")]
        public string TeamGID { get; set; }

        [Column(Name = "TeamName")]
        public string TeamName { get; set; }

        [Column(Name = "TeamLogo")]
        public string TeamLogo { get; set; }

        [Column(Name = "ProvinceName")]
        public string ProvinceName { get; set; }

        [Column(Name = "CityName")]
        public string CityName { get; set; }

        [Column(Name = "HospitalName")]
        public string HospitalName { get; set; }



        [Column(Name = "IsDel")]
        public int IsDel { get; set; }

        [Column(Name = "Status")]
        public int Status { get; set; }

        [Column(Name = "TeamOwnerGID")]
        public string TeamOwnerGID { get; set; }

    }
}
