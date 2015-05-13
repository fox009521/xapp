using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Zelo.ChatLibrary.EaseMob.Models;

namespace Zelo.ChatLibrary.EaseMob
{
    /// <summary>
    ///   环信的聊天客户端
    /// </summary>
    internal class EaseMobChatClient : BaseRestChatClient, IChatClient
    {
        public EaseMobChatClient()
        {
        }



        public String GetBaseUrl()
        {
            return "https://a1.easemob.com";
            //  throw new NotImplementedException();
        }
        protected String GetAppUrl()
        {

            return String.Format("/{0}/{1}", "jimmyleeking", "xapp");
        }
        protected String GetApiUrl(String method)
        {
            return String.Format("{0}/{1}", GetAppUrl(), method);
        }

        protected RestRequest NewRequest(String method)
        {
            RestRequest request = new RestRequest();
            request.AddHeader("Authorization", String.Format("Bearer {0}", CurrentTokenInfo.access_token));
            request.Resource = GetApiUrl(method);
            return request;
        }

        /// <summary>
        /// 获取当前token信息
        /// </summary>
        private TokenInfo CurrentTokenInfo
        {
            get;
            set;
        }

        /// <summary>
        ///  appkey "YXA6nwBKUMOUEeSjt3k5hh_rSA"
        ///  clientkey "YXA6o7jnQGmwhJ8tIGNyzMHrciYDsMM"
        /// </summary>
        /// <param name="appKey"></param>
        /// <param name="clientSercet"></param>
        /// <returns></returns>
        public TokenInfo QueryTokenInfo(String appKey, String clientSercet)
        {

            var request = new RestRequest();
            request.AddParameter("grant_type", "client_credentials");
            request.AddParameter("client_id", appKey);
            request.AddParameter("client_secret", clientSercet);
            GetRestClient().BaseUrl = new Uri(GetBaseUrl());
            request.Resource = GetApiUrl("token");
            var response = GetRestClient().Execute<TokenInfo>(request);//  .Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                this.CurrentTokenInfo = response.Data;
                this.CurrentTokenInfo.StartTime = DateTime.Now;
                this.CurrentTokenInfo.ExpireTime = this.CurrentTokenInfo.StartTime.AddDays(7);

                return response.Data;
            }
            return null;
        }

        /// <summary>
        /// token过期并自动请求
        /// </summary>
        public void AutoQueryToken()
        {

            if (CurrentTokenInfo == null || (CurrentTokenInfo.ExpireTime <= DateTime.Now))
            {
                QueryTokenInfo("YXA6nwBKUMOUEeSjt3k5hh_rSA", "YXA6o7jnQGmwhJ8tIGNyzMHrciYDsMM");
            }
        }


        /// <summary>
        /// 创建用户
        /// </summary>
        public Boolean CreateUser(String userName, String password, String nickName)
        {

            var request = NewRequest("users");
            request.Method = Method.POST;
            UserCreateQuery query = new UserCreateQuery();
            query.password = password;
            query.nickname = nickName;
            query.username = userName;
            request.AddJsonBody(query);
            var item = GetRestClient().Execute(request);//  .Execute(request);
            if (item.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            return false;
        }



    }
}

