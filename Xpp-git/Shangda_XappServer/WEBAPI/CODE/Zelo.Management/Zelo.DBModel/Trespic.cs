using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zelo.Common.CustomAttributes;

namespace Zelo.DBModel 
{  
	 [Table(Name = "trespic")] 
	 public class Trespic
	 { 
		[Id(Name = "rp_id", Strategy = GenerationType.INDENTITY)]
		public int RpId{ get; set; } 

		[Column(Name = "rp_Gid")]
		public string RpGid{ get; set; } 

		[Column(Name = "rp_url")]
		public string RpUrl{ get; set; } 

		[Column(Name = "rp_uploaderid")]
		public int? RpUploaderid{ get; set; } 

		[Column(Name = "rp_date")]
		public DateTime? RpDate{ get; set; } 

		[Column(Name = "rp_ip")]
		public string RpIp{ get; set; } 

		[Column(Name = "rp_quoteGID")]
		public string RpQuoteGID{ get; set; } 

		[Column(Name = "rp_width")]
		public int? RpWidth{ get; set; } 

		[Column(Name = "rp_height")]
		public int? RpHeight{ get; set; } 

		[Column(Name = "rp_Angle")]
		public Decimal? RpAngle{ get; set; } 

		[Column(Name = "rp_rz1")]
		public string RpRz1{ get; set; } 

		[Column(Name = "rp_rz2")]
		public string RpRz2{ get; set; } 

		[Column(Name = "rp_rz3")]
		public string RpRz3{ get; set; } 

		[Column(Name = "rp_updatetime")]
		public DateTime? RpUpdatetime{ get; set; } 

		[Column(Name = "rp_isdel")]
		public int? RpIsdel{ get; set; } 

	 } 
}    

