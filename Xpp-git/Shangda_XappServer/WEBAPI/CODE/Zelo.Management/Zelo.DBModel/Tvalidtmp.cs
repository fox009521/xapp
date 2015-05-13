using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zelo.Common.CustomAttributes;

namespace Zelo.DBModel 
{  
	 [Table(Name = "tvalidtmp")] 
	 public class Tvalidtmp
	 { 
		[Id(Name = "vt_id", Strategy = GenerationType.INDENTITY)]
		public int VtId{ get; set; } 

		[Column(Name = "vt_gid")]
		public int VtGid{ get; set; } 

		[Column(Name = "vt_validtext")]
		public string VtValidtext{ get; set; } 

		[Column(Name = "vt_phonenumber")]
		public string VtPhonenumber{ get; set; } 

		[Column(Name = "vt_ipaddress")]
		public string VtIpaddress{ get; set; } 

		[Column(Name = "vt_createtime")]
		public string VtCreatetime{ get; set; } 

		[Column(Name = "vt_validtime")]
		public DateTime VtValidtime{ get; set; } 

		[Column(Name = "vt_status")]
		public int VtStatus{ get; set; } 

	 } 
}    

