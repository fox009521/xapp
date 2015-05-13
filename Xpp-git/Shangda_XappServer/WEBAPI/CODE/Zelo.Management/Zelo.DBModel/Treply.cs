using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zelo.Common.CustomAttributes;

namespace Zelo.DBModel 
{  
	 [Table(Name = "treply")] 
	 public class Treply
	 { 
		[Id(Name = "rpy_id", Strategy = GenerationType.INDENTITY)]
		public int RpyId{ get; set; } 

		[Column(Name = "rpy_gid")]
		public string RpyGid{ get; set; } 

		[Column(Name = "rpy_userGid")]
		public string RpyUserGid{ get; set; } 

		[Column(Name = "rpy_pstGid")]
		public string RpyPstGid{ get; set; } 

		[Column(Name = "rpy_detail")]
		public string RpyDetail{ get; set; } 

		[Column(Name = "rpy_toUserGid")]
		public string RpyToUserGid{ get; set; } 

		[Column(Name = "rpy_CreateTime")]
		public DateTime? RpyCreateTime{ get; set; } 

		[Column(Name = "rpy_fav")]
		public int? RpyFav{ get; set; } 

		[Column(Name = "rpy_updatetime")]
		public DateTime? RpyUpdatetime{ get; set; } 

		[Column(Name = "rpy_isdel")]
		public int? RpyIsdel{ get; set; } 

	 } 
}    

