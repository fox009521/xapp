using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zelo.Common.CustomAttributes;

namespace Zelo.DBModel 
{  
	 [Table(Name = "tconfinfo")] 
	 public class Tconfinfo
	 { 
		[Id(Name = "cinfo_id", Strategy = GenerationType.INDENTITY)]
		public int CinfoId{ get; set; } 

		[Column(Name = "cinfo_CGID")]
		public string CinfoCGID{ get; set; } 

		[Column(Name = "cinfo_userGid")]
		public string CinfoUserGid{ get; set; } 

		[Column(Name = "cinfo_CreateTime")]
		public DateTime? CinfoCreateTime{ get; set; } 

		[Column(Name = "cinfo_UpdateTime")]
		public DateTime? CinfoUpdateTime{ get; set; } 

		[Column(Name = "cinfo_isdel")]
		public int? CinfoIsdel{ get; set; } 

	 } 
}    

