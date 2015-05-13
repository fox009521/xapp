using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zelo.Common.CustomAttributes;

namespace Zelo.DBModel 
{  
	 [Table(Name = "tnotice")] 
	 public class Tnotice
	 { 
		[Id(Name = "tn_id", Strategy = GenerationType.INDENTITY)]
		public int TnId{ get; set; } 

		[Column(Name = "tn_userGid")]
		public string TnUserGid{ get; set; } 

		[Column(Name = "tn_pstGid")]
		public string TnPstGid{ get; set; } 

		[Column(Name = "tn_type")]
		public int? TnType{ get; set; } 

		[Column(Name = "tn_Count")]
		public int? TnCount{ get; set; } 

		[Column(Name = "tn_CreateTime")]
		public DateTime? TnCreateTime{ get; set; } 

		[Column(Name = "tn_updatetime")]
		public DateTime? TnUpdatetime{ get; set; } 

		[Column(Name = "tn_isdel")]
		public int? TnIsdel{ get; set; } 

	 } 
}    

