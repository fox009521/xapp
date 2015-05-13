using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zelo.Management.Models
{
    public class MedicalHisModels
    {
       

    }

    public class MedicalHisParams : BaseParams
    {
        public String patient_id { get; set; }
        public String SickNess { get; set; }
    }

    public class UpdateMedicalHisParams : BaseParams
    {
        public String patient_id { get; set; }
        public String SickNess { get; set; }
        public String HisGid { get; set; }
    }

    public class MedicalHisDetailParams : BaseParams
    {
        public String hisgid { get; set; }
    }

    public class MedicalHisDetailOperParams : BaseParams
    {
        public String detailgid { get; set; }
        public String hisgid { get; set; }
        public String title { get; set; }
        public String descript { get; set; }
        public List<String> lstPic { get; set; }
        //public String[] lstPic { get; set; }
    }

    public class imagePic {
        public String imageData { get; set; }
    }

    public class methodParam:BaseParams {
        public String hisgid { get; set; }
        public List<String> lstPic { get; set; }
    }
}
