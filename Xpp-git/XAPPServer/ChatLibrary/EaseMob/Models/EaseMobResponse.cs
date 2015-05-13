﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatLibrary.EaseMob.Models
{
    public class EaseMobResponse<T>
    {
        public String action
        {
            get;
            set;
        }
        public String application
        {
            get;
            set;
        }
        public List<T> entities
        {
            get;
            set;
        }



    }
}
