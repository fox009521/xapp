using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zelo.Common.CustomAttributes;

namespace Zelo.DBModel 
{  
	 [Table(Name = "ttopic")] 
	 public class Ttopic
	 { 
		[Id(Name = "tpc_id", Strategy = GenerationType.INDENTITY)]
		public int TpcId{ get; set; } 

		[Column(Name = "tpc_Gid")]
		public string TpcGid{ get; set; } 

		[Column(Name = "tpc_cfGid")]
		public string TpcCfGid{ get; set; } 

		[Column(Name = "tpc_ParentGid")]
		public string TpcParentGid{ get; set; } 

		[Column(Name = "tpc_moderator")]
		public string TpcModerator{ get; set; } 

		[Column(Name = "tpc_reviewer")]
		public string TpcReviewer{ get; set; } 

		[Column(Name = "tpc_speaker")]
		public string TpcSpeaker{ get; set; } 

		[Column(Name = "tpc_sponsor")]
		public string TpcSponsor{ get; set; } 

		[Column(Name = "tpc_sponsorDesc")]
		public string TpcSponsorDesc{ get; set; } 

		[Column(Name = "tpc_title")]
		public string TpcTitle{ get; set; } 

		[Column(Name = "tpc_title_e")]
		public string TpcTitleE{ get; set; } 

		[Column(Name = "tpc_detail")]
		public string TpcDetail{ get; set; } 

		[Column(Name = "tpc_detail_e")]
		public string TpcDetailE{ get; set; } 

		[Column(Name = "tpc_type")]
		public string TpcType{ get; set; } 

		[Column(Name = "tpc_level")]
		public string TpcLevel{ get; set; } 

		[Column(Name = "tpc_datetime_begin")]
		public DateTime? TpcDatetimeBegin{ get; set; } 

		[Column(Name = "tpc_datetime_end")]
		public DateTime? TpcDatetimeEnd{ get; set; } 

		[Column(Name = "tpc_createtime")]
		public DateTime? TpcCreatetime{ get; set; } 

		[Column(Name = "tpc_updatetime")]
		public DateTime? TpcUpdatetime{ get; set; } 

		[Column(Name = "tpc_isdel")]
		public int? TpcIsdel{ get; set; } 

	 } 
}    

