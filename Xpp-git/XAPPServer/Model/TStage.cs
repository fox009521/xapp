using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Easy4net.CustomAttributes;
namespace HealthCloud.DBModel
{
    [Table(Name = "T_Stage")]
    public class TStage
    {
        [Id(Name = "StageID", Strategy = GenerationType.INDENTITY)]
        public int StageID { get; set; }

        [Column(Name = "StageGID")]
        public string StageGID { get; set; }

        [Column(Name = "FromDay")]
        public int FromDay { get; set; }

        [Column(Name = "StageIndex")]
        public int StageIndex { get; set; } 

        [Column(Name = "ToDay")]
        public int ToDay { get; set; }

        [Column(Name = "Value")]
        public string Value { get; set; }

        [Column(Name = "TargetGID")]
        public string TargetGID { get; set; }

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

