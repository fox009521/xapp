using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zelo.Common.CustomAttributes;
 
namespace Zelo.DBModel 
{  
	 [Table(Name = "tuserinfo")] 
	 public class Tuserinfo
	 { 
		[Id(Name = "Uinfo_id", Strategy = GenerationType.INDENTITY)]
		public int UinfoId{ get; set; } 

		[Column(Name = "Uinfo_userGID")]
		public string UinfoUserGID{ get; set; } 

		[Column(Name = "Uinfo_sex")]
		public int? UinfoSex{ get; set; } 

		[Column(Name = "Uinfo_birthday")]
		public DateTime? UinfoBirthday{ get; set; } 

		[Column(Name = "Uinfo_local")]
		public string UinfoLocal{ get; set; } 

		[Column(Name = "Uinfo_Descript")]
		public string UinfoDescript{ get; set; } 

		[Column(Name = "Uinfo_Title")]
		public string UinfoTitle{ get; set; } 

		[Column(Name = "Uinfo_avatars")]
		public string UinfoAvatars{ get; set; } 

		[Column(Name = "Uinfo_hospital")]
		public string UinfoHospital{ get; set; } 

		[Column(Name = "Uinfo_jobtitle")]
		public string UinfoJobtitle{ get; set; } 

		[Column(Name = "Uinfo_wx")]
		public string UinfoWx{ get; set; } 

		[Column(Name = "Uinfo_wb")]
		public string UinfoWb{ get; set; } 

		[Column(Name = "Uinfo_qq")]
		public string UinfoQq{ get; set; } 

		[Column(Name = "Uinfo_CreateTime")]
		public DateTime? UinfoCreateTime{ get; set; } 

		[Column(Name = "Uinfo_UpdateTime")]
		public DateTime? UinfoUpdateTime{ get; set; } 

		[Column(Name = "Uinfo_isdel")]
		public int? UinfoIsdel{ get; set; } 

	 } 
}    

