using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Easy4net.CustomAttributes;
namespace HealthCloud.DBModel
{
    [Table(Name = "T_MedicalMember")]
    public class TMedicalMember
    {
        [Id(Name = "MedicalMemberID", Strategy = GenerationType.INDENTITY)]
        public int MedicalMemberID { get; set; }

        [Column(Name = "MedicalMemberGID")]
        public string MedicalMemberGID { get; set; }

        [Column(Name = "PatientGID")]
        public string PatientGID { get; set; }

        [Column(Name = "PatientMID")]
        public string PatientMID { get; set; }

        [Column(Name = "Status")]
        public int? Status { get; set; }

        [Column(Name = "DoctorGID")]
        public string DoctorGID { get; set; }

        [Column(Name = "DoctorMID")]
        public string DoctorMID { get; set; }

        //[Column(Name = "ChatGroupID")]
        //public string ChatGroupID { get; set; }

        [Column(Name = "TeamID")]
        public string TeamID { get; set; }

        [Column(Name = "BedNum")]
        public string BedNum { get; set; }

        [Column(Name = "AdmissionTime")]
        public DateTime? AdmissionTime { get; set; }

        [Column(Name = "DiagnosisResult")]
        public string DiagnosisResult { get; set; }

        [Column(Name = "RecoveryPlan")]
        public string RecoveryPlan { get; set; }

        [Column(Name = "RecoveryPlanTime")]
        public DateTime? RecoveryPlanTime { get; set; }

        [Column(Name = "CreateTime")]
        public DateTime? CreateTime { get; set; }

        [Column(Name = "UpdateTime")]
        public DateTime? UpdateTime { get; set; }

        [Column(Name = "IsDel")]
        public int? IsDel { get; set; }

    }
}
