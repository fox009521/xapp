using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatLibrary
{
    public interface IChatClient
    {
        String GetBaseUrl();

        Boolean CreateUser(String userName, String password, String nickName);

    }
}
