using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zelo.Management.AppUtils
{
    /// <summary>
    /// 短信发送工具类
    /// </summary>
    public class SmsUtils
    {

        //<add key="SMSPassWord" value="159283"/>
		//<add key="SMSCharset" value="GBK"/>
        private static SmsService.SDKClientClient sdk = new SmsService.SDKClientClient();
        private static readonly String userkey = "6SDK-EMY-6688-KDWTN";
        private static readonly String password = "159283";
        private static readonly String charset = "GBK";
        //验证码业务
        private static readonly String validTemplate = "【X-APP】您申请注册X-APP账号的短信验证码为{0}，请在30分钟内完成验证。退订回复TD";
        //提醒锻炼业务
        private static readonly String exerciseRemindTemplate = "【X-APP】亲爱的患者！您的主治医生已经连续三天未收到您的锻炼信息了，请您及时登录手机应用补充锻炼信息，方便医生指导您的康复。退订回复TD";
        //提醒复查业务
        private static readonly String recheckRemindTemplate="【X-APP】亲爱的患者！今天距离您的手术时间快一个月了，为了您更快更好地恢复，建议您前往手术医院进行复查。退订回复TD";
        /// <summary>
        /// 发送验证码
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="validCode"></param>
        /// <returns></returns>
        public static Boolean SendValidCode(String phone,String validCode)
        {
            return SendSms(phone,String.Format(validTemplate,validCode));
        }
        /// <summary>
        /// 发送锻炼提醒
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public static Boolean SendExerciseRemind(String phone)
        {
            return SendSms(phone, exerciseRemindTemplate);
        }

        public static Boolean SendRecheckRemind(String phone)
        {
            return SendSms(phone, recheckRemindTemplate);
        }



        /// <summary>
        /// 发送单条短信
        /// </summary>
        /// <param name="mobile"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        private static Boolean SendSms(String mobile, String content)
        {
            return SendSms(mobile.Split(','),content);
        }
        /// <summary>
        /// 群发短信
        /// </summary>
        /// <param name="mobileArray"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        private static Boolean SendSms(String[] mobileArray, String content)
        {
            int res = sdk.sendSMS(userkey, password, null, mobileArray, content, null, charset, 3, 9988);
            
            return res == 0 ? true : false;
          
        }



    }
}