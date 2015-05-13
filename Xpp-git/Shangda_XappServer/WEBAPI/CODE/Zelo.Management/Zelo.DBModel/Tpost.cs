using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zelo.Common.CustomAttributes;

namespace Zelo.DBModel 
{  
	 [Table(Name = "tpost")] 
	 public class Tpost
	 { 
		[Id(Name = "pst_id", Strategy = GenerationType.INDENTITY)]
		public int PstId{ get; set; } 

		[Column(Name = "pst_Gid")]
		public string PstGid{ get; set; } 

		[Column(Name = "pst_chGid")]
		public string PstChGid{ get; set; } 

		[Column(Name = "pst_userGid")]
		public string PstUserGid{ get; set; } 

		[Column(Name = "pst_detail")]
		public string PstDetail{ get; set; } 

		[Column(Name = "pst_CreateTime")]
		public DateTime? PstCreateTime{ get; set; } 

		[Column(Name = "pst_pic")]
		public string PstPic{ get; set; } 

		[Column(Name = "pst_vid")]
		public string PstVid{ get; set; } 

		[Column(Name = "pst_updatetime")]
		public DateTime? PstUpdatetime{ get; set; } 

		[Column(Name = "pst_isdel")]
		public int? PstIsdel{ get; set; } 

	 } 
}    

