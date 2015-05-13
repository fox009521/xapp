using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zelo.Common.CustomAttributes;

namespace Zelo.DBModel 
{  
	 [Table(Name = "ttextbook")] 
	 public class Ttextbook
	 { 
		[Id(Name = "tb_id", Strategy = GenerationType.INDENTITY)]
		public int TbId{ get; set; } 

		[Column(Name = "tb_Gid")]
		public string TbGid{ get; set; } 

		[Column(Name = "tb_category")]
		public string TbCategory{ get; set; } 

		[Column(Name = "tb_avatars")]
		public string TbAvatars{ get; set; } 

		[Column(Name = "tb_title")]
		public string TbTitle{ get; set; } 

		[Column(Name = "tb_publish")]
		public DateTime? TbPublish{ get; set; } 

		[Column(Name = "tb_count")]
		public int? TbCount{ get; set; } 

		[Column(Name = "tb_author")]
		public string TbAuthor{ get; set; } 

		[Column(Name = "tb_detail")]
		public string TbDetail{ get; set; } 

		[Column(Name = "tb_selected")]
		public int? TbSelected{ get; set; } 

		[Column(Name = "tb_createtime")]
		public DateTime? TbCreatetime{ get; set; } 

		[Column(Name = "tb_updatetime")]
		public DateTime? TbUpdatetime{ get; set; } 

		[Column(Name = "tb_isdel")]
		public int? TbIsdel{ get; set; } 

	 } 
}    

