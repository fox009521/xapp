using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zelo.Common.CustomAttributes;

namespace Zelo.DBModel 
{  
	 [Table(Name = "tfav")] 
	 public class Tfav
	 { 
		[Id(Name = "fav_id", Strategy = GenerationType.INDENTITY)]
		public int FavId{ get; set; } 

		[Column(Name = "fav_GID")]
		public string FavGID{ get; set; } 

		[Column(Name = "fav_type")]
		public int? FavType{ get; set; } 

		[Column(Name = "fav_userGID")]
		public string FavUserGID{ get; set; } 

		[Column(Name = "fav_CreateTime")]
		public DateTime? FavCreateTime{ get; set; } 

		[Column(Name = "fav_updatetime")]
		public string FavUpdatetime{ get; set; } 

		[Column(Name = "fav_isdel")]
		public int? FavIsdel{ get; set; } 

	 } 
}    

