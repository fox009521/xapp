using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zelo.Common.CustomAttributes;

namespace Zelo.DBModel 
{  
	 [Table(Name = "tconf")] 
	 public class Tconf
	 { 
		[Id(Name = "cf_id", Strategy = GenerationType.INDENTITY)]
		public int id{ get; set; } 

		[Column(Name = "cf_Gid")]
		public string gid{ get; set; } 

		[Column(Name = "cf_name")]
		public string title{ get; set; } 

		[Column(Name = "cf_avatars")]
		public string avatars{ get; set; } 

		[Column(Name = "cf_date")]
		public DateTime? cfdate{ get; set; } 

		[Column(Name = "cf_date_end")]
		public DateTime? dateend{ get; set; } 

		[Column(Name = "cf_Schedule")]
		public string schedule{ get; set; } 

		[Column(Name = "cf_local")]
		public string local{ get; set; } 

		[Column(Name = "cf_localgps")]
		public string localgps{ get; set; } 

		[Column(Name = "cf_localDetail")]
		public string localdetail{ get; set; } 

		[Column(Name = "cf_slogan")]
		public string slogan{ get; set; } 

		[Column(Name = "cf_slogan_e")]
		public string sloganE{ get; set; } 

		[Column(Name = "cf_detail")]
		public string detail{ get; set; } 

		[Column(Name = "cf_Sponsor")]
		public string sponsor{ get; set; } 

		[Column(Name = "cf_contact")]
		public string contact{ get; set; } 

		[Column(Name = "cf_CreateTime")]
		public DateTime? CfCreateTime{ get; set; } 

		[Column(Name = "cf_UpdateTime")]
		public DateTime? updatetime{ get; set; } 

		[Column(Name = "cf_isdel")]
		public int? isdel{ get; set; }

        [Column(Name = "isfav")]
        public int? isfav { get; set; } 

	 } 
}    

