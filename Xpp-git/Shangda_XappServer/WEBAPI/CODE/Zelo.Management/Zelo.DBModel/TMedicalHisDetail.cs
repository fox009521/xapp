using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zelo.Common.CustomAttributes;
namespace Zelo.DBModel
{
    [Table(Name = "T_Medical_HisDetail")]
    public class TMedicalHisDetail
    {
        [Id(Name = "Id", Strategy = GenerationType.INDENTITY)]
        public int Id { get; set; }

        [Column(Name = "Detail_Gid")]
        public string DetailGid { get; set; }

        [Column(Name = "His_ID")]
        public string HisID { get; set; }

        [Column(Name = "Detail_Title")]
        public string DetailTitle { get; set; }

        [Column(Name = "Detail_Describe")]
        public string DetailDescribe { get; set; }

        [Column(Name = "CreateUser")]
        public string CreateUser { get; set; }

        [Column(Name = "CreateTime")]
        public DateTime? CreateTime { get; set; }

        [Column(Name = "UpdateTime")]
        public DateTime? UpdateTime { get; set; }

        [Column(Name = "status")]
        public int? Status { get; set; }

    } 

}