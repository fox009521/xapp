using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zelo.Common.CustomAttributes;
namespace Zelo.DBModel
{
    [Table(Name = "T_Medical_His")]
    public class TMedicalHisExtend:TMedicalHis
    {
        public string PatientName
        {
            set;
            get;
        }

        public string PatientSex
        {
            set;
            get;
        }

        public string PatientAge
        {
            set;
            get;
        }
    }
}