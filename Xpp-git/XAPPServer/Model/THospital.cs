using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Easy4net.CustomAttributes;
namespace HealthCloud.DBModel
{
    [Table(Name = "T_Hospital")]
    public class THospital
    {
        [Id(Name = "HospitalID", Strategy = GenerationType.FILL)]
        public int HospitalID { get; set; }

        [Column(Name = "HospitalGID")]
        public string HospitalGID { get; set; }

        [Column(Name = "CreateTime")]
        public DateTime? CreateTime { get; set; }

        [Column(Name = "UpdateTime")]
        public DateTime? UpdateTime { get; set; }

        [Column(Name = "HospitalName")]
        public string HospitalName { get; set; }

        [Column(Name = "CityName")]
        public string CityName { get; set; }

        [Column(Name = "IsDel")]
        public int? IsDel { get; set; }

        [Column(Name = "HospitalLevel")]
        public string HospitalLevel { get; set; }

    }
}
