using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zelo.Common.CustomAttributes;

namespace Zelo.DBModel 
{  
	 [Table(Name = "tuser")] 
	 public class Tuser
	 { 
		[Id(Name = "User_ID", Strategy = GenerationType.INDENTITY)]
		public int UserID{ get; set; } 

		[Column(Name = "User_GID")]
		public string UserGID{ get; set; } 

		[Column(Name = "User_Name")]
		public string UserName{ get; set; } 

		[Column(Name = "User_Pwd")]
		public string UserPwd{ get; set; } 

		[Column(Name = "User_Email")]
		public string UserEmail{ get; set; } 

		[Column(Name = "User_Phone")]
		public string UserPhone{ get; set; } 

		[Column(Name = "User_SMSverf")]
		public int? UserSMSverf{ get; set; } 

		[Column(Name = "User_Adddate")]
		public DateTime? UserAdddate{ get; set; } 

		[Column(Name = "User_ChAu")]
		public int? UserChAu{ get; set; } 

		[Column(Name = "User_ChGId")]
		public string UserChGId{ get; set; } 

		[Column(Name = "User_CfAu")]
		public int? UserCfAu{ get; set; } 

		[Column(Name = "User_TmAu")]
		public int? UserTmAu{ get; set; } 

		[Column(Name = "User_Online")]
		public int? UserOnline{ get; set; } 

		[Column(Name = "User_ipv4")]
		public string UserIpv4{ get; set; } 

		[Column(Name = "User_ipv6")]
		public string UserIpv6{ get; set; } 

		[Column(Name = "User_LoginDate")]
		public DateTime? UserLoginDate{ get; set; } 

		[Column(Name = "User_LoginTime")]
		public int? UserLoginTime{ get; set; } 

		[Column(Name = "User_OSType")]
		public string UserOSType{ get; set; } 

		[Column(Name = "User_OSSN")]
		public string UserOSSN{ get; set; } 

		[Column(Name = "User_UpdateTime")]
		public DateTime? UserUpdateTime{ get; set; } 

		[Id(Name = "User_isdel", Strategy = GenerationType.FILL)]
		public int UserIsdel{ get; set; } 

	 } 
}    

