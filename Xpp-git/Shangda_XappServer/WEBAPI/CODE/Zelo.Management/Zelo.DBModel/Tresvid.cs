using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zelo.Common.CustomAttributes;

namespace Zelo.DBModel 
{  
	 [Table(Name = "tresvid")] 
	 public class Tresvid
	 { 
		[Id(Name = "rv_id", Strategy = GenerationType.INDENTITY)]
		public int RvId{ get; set; } 

		[Column(Name = "rv_Gid")]
		public string RvGid{ get; set; } 

		[Column(Name = "rv_url")]
		public string RvUrl{ get; set; } 

		[Column(Name = "rv_uid")]
		public int? RvUid{ get; set; } 

		[Column(Name = "rv_date")]
		public DateTime? RvDate{ get; set; } 

		[Column(Name = "rv_ip")]
		public string RvIp{ get; set; } 

		[Column(Name = "rv_protocal")]
		public string RvProtocal{ get; set; } 

		[Column(Name = "rv_width")]
		public int? RvWidth{ get; set; } 

		[Column(Name = "rv_height")]
		public int? RvHeight{ get; set; } 

		[Column(Name = "rv_Angle")]
		public Decimal? RvAngle{ get; set; } 

		[Column(Name = "rv_fps")]
		public Decimal? RvFps{ get; set; } 

		[Column(Name = "rv_size")]
		public int? RvSize{ get; set; } 

		[Column(Name = "rv_newurl")]
		public string RvNewurl{ get; set; } 

		[Column(Name = "rv_updatetime")]
		public DateTime? RvUpdatetime{ get; set; } 

		[Column(Name = "rv_isdel")]
		public int? RvIsdel{ get; set; } 

	 } 
}    

