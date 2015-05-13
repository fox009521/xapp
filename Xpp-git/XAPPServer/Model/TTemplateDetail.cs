using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Easy4net.CustomAttributes;
namespace HealthCloud.DBModel
{
    [Table(Name = "T_TemplateDetail")]
    public class TTemplateDetail
    {
        [Id(Name = "TemplateDetailID", Strategy = GenerationType.INDENTITY)]
        public int TemplateDetailID { get; set; }

        [Column(Name = "TemplateDetailGID")]
        public string TemplateDetailGID { get; set; }

        [Column(Name = "TemplateGID")]
        public string TemplateGID { get; set; }

        [Column(Name = "ActionType")]
        public int ActionType { get; set; }

        [Column(Name = "ActionGID")]
        public string ActionGID { get; set; }

        [Column(Name = "ActionName")]
        public string ActionName { get; set; }
        [Column(Name = "StatisticalType")]
        public int StatisticalType { get; set; }

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


