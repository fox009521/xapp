using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Easy4net.CustomAttributes;
namespace HealthCloud.DBModel
{
    [Table(Name = "T_Template")]
    public class TTemplate
    {
        [Id(Name = "TemplateID", Strategy = GenerationType.INDENTITY)]
        public int TemplateID { get; set; }

        [Column(Name = "TemplateGID")]
        public string TemplateGID { get; set; }

        [Column(Name = "TemplateName")]
        public string TemplateName { get; set; }

        [Column(Name = "TemplateMemo")]
        public string TemplateMemo { get; set; }

        [Column(Name = "DocotorMID")]
        public string DocotorMID { get; set; }

        [Column(Name = "TeamMID")]
        public string TeamMID { get; set; }

        [Column(Name = "TemplateType")]
        public int TemplateType { get; set; }

        [Column(Name = "ApplicationType")]
        public int ApplicationType { get; set; }

        [Column(Name = "BAK1")]
        public string BAK1 { get; set; }

        [Column(Name = "BAK2")]
        public string BAK2 { get; set; }

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

