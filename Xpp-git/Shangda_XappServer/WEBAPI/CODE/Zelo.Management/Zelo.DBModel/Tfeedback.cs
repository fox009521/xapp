using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zelo.Common.CustomAttributes;
 
namespace Zelo.DBModel 
{  
	 [Table(Name = "tfeedback")] 
	 public class Tfeedback
	 { 
		[Id(Name = "fb_id", Strategy = GenerationType.INDENTITY)]
		public int FbId{ get; set; } 

		[Column(Name = "fb_Gid")]
		public string FbGid{ get; set; } 

		[Column(Name = "fb_userGid")]
		public string FbUserGid{ get; set; } 

		[Column(Name = "fb_detail")]
		public string FbDetail{ get; set; } 

		[Column(Name = "fb_datetime")]
		public DateTime? FbDatetime{ get; set; } 

		[Column(Name = "fb_pic")]
		public string FbPic{ get; set; } 

		[Column(Name = "fb_reply")]
		public string FbReply{ get; set; } 

		[Column(Name = "fb_reply_time")]
		public DateTime? FbReplyTime{ get; set; } 

		[Column(Name = "fb_status")]
		public int? FbStatus{ get; set; } 

		[Column(Name = "fb_CreateTime")]
		public DateTime? FbCreateTime{ get; set; } 

		[Column(Name = "fb_UpdateTime")]
		public DateTime? FbUpdateTime{ get; set; } 

		[Column(Name = "fb_isdel")]
		public int? FbIsdel{ get; set; } 

	 } 
}    

