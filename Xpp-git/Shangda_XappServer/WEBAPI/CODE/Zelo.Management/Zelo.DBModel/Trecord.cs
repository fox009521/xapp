using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zelo.Common.CustomAttributes;

namespace Zelo.DBModel 
{  
	 [Table(Name = "trecord")] 
	 public class Trecord
	 { 
		[Id(Name = "tr_id", Strategy = GenerationType.INDENTITY)]
		public int TrId{ get; set; } 

		[Column(Name = "tr_Gid")]
		public string TrGid{ get; set; } 

		[Column(Name = "th_PGid")]
		public int? ThPGid{ get; set; } 

		[Column(Name = "tr_title")]
		public string TrTitle{ get; set; } 

		[Column(Name = "tr_detail")]
		public string TrDetail{ get; set; } 

		[Column(Name = "tr_date")]
		public DateTime? TrDate{ get; set; } 

		[Column(Name = "tr_pic")]
		public string TrPic{ get; set; } 

		[Column(Name = "tr_vid")]
		public string TrVid{ get; set; } 

		[Column(Name = "tr_createtime")]
		public DateTime? TrCreatetime{ get; set; } 

		[Column(Name = "tr_udpatetime")]
		public DateTime? TrUdpatetime{ get; set; } 

		[Column(Name = "tr_isdel")]
		public int? TrIsdel{ get; set; } 

	 } 
}    

