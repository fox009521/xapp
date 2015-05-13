using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatLibrary;
using ChatLibrary.EaseMob;
using RestSharp;

namespace ConsoleUnitTest
{
    class Program
    {
        public static void Main(string[] args)
        {

            //var client = new RestClient();
            //client.BaseUrl = new Uri("https://a1.easemob.com");

            //client.AddDefaultHeader("Authorization", " Bearer ${token}");
            //var request = new RestRequest();
            //request.AddParameter("grant_type", "client_credentials");
            ////client_id
            //request.AddParameter("client_id", "YXA6nwBKUMOUEeSjt3k5hh_rSA");

            //request.AddParameter("client_secret", "YXA6o7jnQGmwhJ8tIGNyzMHrciYDsMM");


            ////xapp
            //request.Resource = "/jimmyleeking/xapp/token";

            //IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);
         //   EaseMobChatClient client = new EaseMobChatClient();
           // var info=client.QueryTokenInfo("YXA6nwBKUMOUEeSjt3k5hh_rSA", "YXA6o7jnQGmwhJ8tIGNyzMHrciYDsMM");
            //if (info != null)
            //{
            //    Console.WriteLine(info.access_token+":"+info.expires_in);
            //}
            IChatClient client = ChatClientFactory.getDefaultChatClient();
            Boolean item=client.CreateUser("jimmy", "1234561234123123", "wa");
            Console.ReadKey();
        }
    }
}
