using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zelo.ChatLibrary
{
    public abstract class BaseRestChatClient
    {

        private RestClient mRestClient = null;
        public BaseRestChatClient()
        {
            mRestClient = new RestClient();
        }

        public RestClient GetRestClient()
        {
            return mRestClient;
        }


    }
}
