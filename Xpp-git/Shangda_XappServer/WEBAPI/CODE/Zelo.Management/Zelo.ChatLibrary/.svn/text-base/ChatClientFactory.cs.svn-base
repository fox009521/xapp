using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zelo.ChatLibrary.EaseMob;

namespace Zelo.ChatLibrary
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatLibraryType
    {
        //环信
        EaseMob
    }

    public static class ChatClientFactory
    {
        private static Dictionary<ChatLibraryType, IChatClient> dictChatClient = new Dictionary<ChatLibraryType, IChatClient>();

        private static IChatClient defaultClient = null;

        /// <summary>
        /// 获取默认的聊天接口
        /// </summary>
        /// <returns></returns>
        public static IChatClient getDefaultChatClient()
        {
            IChatClient client = getChatClient(ChatLibraryType.EaseMob);
            //自动请求token
            ((EaseMobChatClient)client).AutoQueryToken();
            return client;
        }

        public static IChatClient getChatClient(ChatLibraryType type)
        {
            if (!dictChatClient.ContainsKey(type))
            {
                switch (type)
                {
                    case ChatLibraryType.EaseMob:
                        {
                            dictChatClient.Add(type, new EaseMobChatClient());
                        }; break;
                }
            }
            return dictChatClient[ChatLibraryType.EaseMob];
        }

    }
}
