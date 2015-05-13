using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Easy4net.CustomAttributes;

namespace HealthCloud.DBModel
{
    [Table(Name = "T_Template")]
    public class VTemplate : TTemplate
    {
        #region  拓展属性
        public String DoctorName { get; set; }
        #endregion
    }
}
