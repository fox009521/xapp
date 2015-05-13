using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatLibrary.EaseMob.Models
{
    public class UserCreateQuery
    {
        public String username
        {
            get;
            set;
        }
        public String password
        {
            get;
            set;
        }
        public String nickname
        {
            get;
            set;
        }
        public class UserCreatedInfo
        {
            public String uuid
            {
                get;
                set;
            }
            public String type
            {
                get;
                set;
            }
            public String modified
            {
                get;
                set;
            }
            public String username
            {
                get;
                set;
            }
            public Boolean activated
            {
                get;
                set;
            }

        }
    }
}
