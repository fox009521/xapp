
using System;
using System.Collections.Generic; 
using System.Linq;  
using System.Text;
using Zelo.Common.CustomAttributes;  
namespace Zelo.DBModel
{

	 [Table(Name = "T_AppUpgradeInfo")] 
	 public class TAppUpgradeInfo
	 { 
		[Id(Name = "ID", Strategy = GenerationType.INDENTITY)]
		public int ID{ get; set; } 

		[Column(Name = "VersionCode")]
		public float VersionCode{ get; set; } 

		[Column(Name = "VersionName")]
		public string VersionName{ get; set; } 

		[Column(Name = "VersionContent")]
		public string VersionContent{ get; set; } 

		[Column(Name = "CreateTime")]
		public DateTime? CreateTime{ get; set; } 

		[Column(Name = "UpdateTime")]
		public DateTime? UpdateTime{ get; set; } 

		[Column(Name = "IsDel")]
		public int IsDel{ get; set; } 

		[Column(Name = "OSType")]
		public int OSType{ get; set; } 

		[Column(Name = "VersionPublishDate")]
		public DateTime? VersionPublishDate{ get; set; } 

		[Column(Name = "IsPublish")]
		public int IsPublish{ get; set; } 

		[Column(Name = "Status")]
		public int Status{ get; set; } 

		[Column(Name = "BuildCode")]
		public string BuildCode{ get; set; }

        [Column(Name = "DownloadUrl")]
        public string DownloadUrl { get; set; } 

	 } 
}    
