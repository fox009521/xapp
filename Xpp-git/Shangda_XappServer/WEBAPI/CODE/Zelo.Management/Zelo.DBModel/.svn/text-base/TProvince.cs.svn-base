using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zelo.Common.CustomAttributes;
namespace Zelo.DBModel
{
    [Table(Name = "T_Province")]
    public class TProvince
    {
        [Id(Name = "ProvinceID", Strategy = GenerationType.INDENTITY)]
        public int ProvinceID { get; set; }

        [Column(Name = "CreateTime")]
        public DateTime? CreateTime { get; set; }

        [Column(Name = "UpdateTime")]
        public DateTime? UpdateTime { get; set; }

        [Column(Name = "ProvinceName")]
        public string ProvinceName { get; set; }

        [Column(Name = "IsDel")]
        public int? IsDel { get; set; }

    }
}

