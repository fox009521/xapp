using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatLibrary.EaseMob.Models
{
    public class TokenInfo
    {
        public String access_token
        {
            get;
            set;
        }
        public long expires_in
        {
            get;
            set;
        }
        public String application
        {
            get;
            set;
        }

        public DateTime StartTime
        {
            get;
            set;
        }
        public DateTime ExpireTime
        {
            get;
            set;
        }
    }
}
