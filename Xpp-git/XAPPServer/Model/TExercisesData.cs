using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Easy4net.CustomAttributes;
namespace HealthCloud.DBModel
{
    [Table(Name = "T_ExercisesData")]
    public class TExercisesData
    {
        [Id(Name = "ExercisesDataID", Strategy = GenerationType.INDENTITY)]
        public int ExercisesDataID { get; set; }

        [Column(Name = "ExercisesDataGID")]
        public string ExercisesDataGID { get; set; }

        [Column(Name = "PatientGID")]
        public string PatientGID { get; set; }

        [Column(Name = "ActionGID")]
        public string ActionGID { get; set; }

        [Column(Name = "UploadTime")]
        public DateTime UploadTime { get; set; }

        [Column(Name = "DataValue")]
        public string DataValue { get; set; }

        [Column(Name = "Bak1")]
        public string Bak1 { get; set; }

        [Column(Name = "Bak2")]
        public string Bak2 { get; set; }

        [Column(Name = "Bak3")]
        public string Bak3 { get; set; }

        [Column(Name = "CreateName")]
        public string CreateName { get; set; }

        [Column(Name = "CreateTime")]
        public DateTime? CreateTime { get; set; }

        [Column(Name = "UpdateName")]
        public string UpdateName { get; set; }

        [Column(Name = "UpdateTime")]
        public DateTime? UpdateTime { get; set; }

        [Column(Name = "IsDel")]
        public int? IsDel { get; set; }

        [Column(Name = "Status")]
        public int? Status { get; set; }

    }
}

