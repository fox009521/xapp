using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zelo.Management.Models
{
    public class consModels:BaseParams
    {
        public DateTime datebegin
        {
            get;
            set;
        }

        public string selecttype
        {
            get;
            set;
        }

        public int count
        {
            get;
            set;
        }

        public int isfav { get; set; }
    }

    public class conModel : BaseParams
    {
        public string gid { get; set; }
    }


}