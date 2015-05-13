using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zelo.Common.CustomAttributes;
namespace Zelo.DBModel
{
    [Table(Name = "T_Medical_His")]
    public class TMedicalHis
    {
        [Id(Name = "Id", Strategy = GenerationType.INDENTITY)]
        public int Id { get; set; }

        [Column(Name = "His_Gid")]
        public string HisGid { get; set; }

        [Column(Name = "Doctor_ID")]
        public string DoctorID { get; set; }

        [Column(Name = "Patient_ID")]
        public string PatientID { get; set; }

        [Column(Name = "Sickness")]
        public string Sickness { get; set; }

        [Column(Name = "CreateTime")]
        public DateTime? CreateTime { get; set; }

        [Column(Name = "UpdateTime")]
        public DateTime? UpdateTime { get; set; }

        [Column(Name = "status")]
        public int? Status { get; set; }

    } 

}