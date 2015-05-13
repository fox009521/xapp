using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zelo.Common.CustomAttributes;

namespace Zelo.DBModel 
{  
	 [Table(Name = "tchannel")] 
	 public class Tchannel
	 { 
		[Id(Name = "ch_id", Strategy = GenerationType.INDENTITY)]
		public int ChId{ get; set; } 

		[Column(Name = "ch_Gid")]
		public string ChGid{ get; set; } 

		[Column(Name = "ch_name")]
		public string ChName{ get; set; } 

		[Column(Name = "ch_slogan")]
		public string ChSlogan{ get; set; } 

		[Column(Name = "ch_avatars")]
		public string ChAvatars{ get; set; } 

		[Column(Name = "ch_createtime")]
		public DateTime? ChCreatetime{ get; set; } 

		[Column(Name = "ch_UpdateTime")]
		public DateTime? ChUpdateTime{ get; set; } 

		[Column(Name = "ch_isdel")]
		public int? ChIsdel{ get; set; } 

	 } 
}    

