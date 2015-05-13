using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Easy4net.CustomAttributes;

namespace HealthCloud.DBModel
{
     [Table(Name = "T_Doctor")]
    public class VDoctorTeamApply:TDoctor
    {
       [Column(Name = "TeamApplyID")]
        public int TeamApplyID { get; set; } 
    }
}
