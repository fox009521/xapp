using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Easy4net.CustomAttributes;
namespace HealthCloud.DBModel
{
    [Table(Name = "T_TemplateDetail")]
    public class VTemplateDetail : TTemplateDetail
    {
        [Column(Name = "ActionImages")]
        public string ActionImages { get; set; }
    }
}


