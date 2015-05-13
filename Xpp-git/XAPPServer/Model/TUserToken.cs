using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Easy4net.CustomAttributes;
namespace HealthCloud.DBModel 
{
    [Table(Name = "T_UserToken")]
    public class TUserToken
    {
        [Id(Name = "TokenID", Strategy = GenerationType.INDENTITY)]
        public int TokenID { get; set; }

        [Column(Name = "TokenGID")]
        public string TokenGID { get; set; }

        [Column(Name = "StartTime")]
        public DateTime? StartTime { get; set; }

        [Column(Name = "EndTime")]
        public DateTime? EndTime { get; set; }

        [Column(Name = "UpdateTime")]
        public DateTime? UpdateTime { get; set; }

        [Column(Name = "CreateTime")]
        public DateTime? CreateTime { get; set; }

        [Column(Name = "Status")]
        public int? Status { get; set; }

        [Column(Name = "TokenContent")]
        public string TokenContent { get; set; }

        [Column(Name = "TokenType")]
        public int? TokenType { get; set; }

        [Column(Name = "TokenOwnerGID")]
        public string TokenOwnerGID { get; set; }

    }
}
