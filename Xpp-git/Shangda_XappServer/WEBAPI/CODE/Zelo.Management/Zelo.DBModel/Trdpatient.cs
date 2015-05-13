using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zelo.Common.CustomAttributes;

namespace Zelo.DBModel 
{  
	 [Table(Name = "trdpatient")] 
	 public class Trdpatient
	 { 
		[Id(Name = "repa_id", Strategy = GenerationType.INDENTITY)]
		public int RepaId{ get; set; } 

		[Column(Name = "repa_Gid")]
		public string RepaGid{ get; set; } 

		[Column(Name = "repa_name")]
		public string RepaName{ get; set; } 

		[Column(Name = "repa_age")]
		public int? RepaAge{ get; set; } 

		[Column(Name = "repa_gender")]
		public int? RepaGender{ get; set; } 

		[Column(Name = "repa_sick")]
		public string RepaSick{ get; set; } 

		[Column(Name = "repa_sick2")]
		public string RepaSick2{ get; set; } 

		[Column(Name = "repa_sick3")]
		public string RepaSick3{ get; set; } 

		[Column(Name = "repa_VisitDate")]
		public DateTime? RepaVisitDate{ get; set; } 

		[Column(Name = "repa_UserGID")]
		public string RepaUserGID{ get; set; } 

		[Column(Name = "repa_createtime")]
		public DateTime? RepaCreatetime{ get; set; } 

		[Column(Name = "repa_updatetime")]
		public DateTime? RepaUpdatetime{ get; set; } 

		[Column(Name = "repa_isdel")]
		public int? RepaIsdel{ get; set; } 

	 } 
}    

