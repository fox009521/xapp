using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zelo.Common.Common;
using Zelo.DBModel;

namespace Zelo.DBService
{
    public class SmsValidService:BaseService
    {

        /// <summary>
        /// 发送短信验证
        /// </summary>
        /// <param name="smsValidType"></param>
        /// <param name="phone"></param>
        /// <param name="validCode"></param>
        /// <returns></returns>
        public Boolean SendSmsValid(SmsValidType smsValidType, String phone, String validCode)
        {
               
            try
            {
                TSmsValid smsItem = GetSmsValidInfo(smsValidType, phone);
                //短信是否存在
                if (smsItem != null)
                {
                    //更新
                    smsItem.ValidCode = validCode;
                    smsItem.UpdateTime = DateTime.Now;
                    smsItem.StartTime = DateTime.Now;
                    smsItem.EndTime = DateTime.Now.AddMinutes(30);
                    DataBaseHelper.Update<TSmsValid>(smsItem);

                }
                else
                {
                    //插入
                    AddSmsValid(smsValidType, phone, validCode);
                }
                return true;
            }
            catch { }
            return false;
          
            
        }
        /// <summary>
        /// 短信验证
        /// </summary>
        /// <param name="smsValidType"></param>
        /// <param name="phone"></param>
        /// <param name="validCode"></param>
        /// <returns></returns>
        public Boolean IsSmsValid(SmsValidType smsValidType, String phone, String validCode)
        {

            String strSql = "select * from t_smsvalid where validtype=@validType and phone=@phone and GETDATE() between starttime and endtime ";
            ParamMap param = ParamMap.newMap();
            param.setParameter("validType", (int)smsValidType);
            param.setParameter("phone", phone);
            TSmsValid item=DataBaseHelper.FindOne<TSmsValid>(strSql, param);
            if(item!=null&& item.ValidCode!=null&&validCode!=null)
            {
                if (validCode.ToUpper().Equals(item.ValidCode.ToUpper()))
                {
                    return true;
                }
            }
           
            return false;
        }


        /// <summary>
        /// 短信三分钟之内已经被发送过
        /// </summary>
        /// <param name="smsValidType"></param>
        /// <param name="phone"></param>
        /// <returns></returns>
        public Boolean IsSended(SmsValidType smsValidType, String phone)
        {
            TSmsValid smsItem = GetSmsValidInfo(smsValidType, phone);
            if (smsItem != null)
            {
                try
                {
                    TimeSpan span = DateTime.Now - (DateTime)smsItem.StartTime;
                    if (span.Minutes <=1)
                    {
                        return true;
                    }
                }catch
                {
                }
                
                
            }
            return false;
            

        }
        #region 私有函数

        /// <summary>
        /// 短信注册验证信息是否存在
        /// </summary>
        /// <param name="smsValidType"></param>
        /// <param name="phone"></param>
        /// <returns></returns>
        private TSmsValid GetSmsValidInfo(SmsValidType smsValidType, String phone)
        {
            String strSql = @"  select * from t_smsvalid where validtype=@validType  and phone=@phone ";
            ParamMap param = ParamMap.newMap();
            param.setParameter("validType", (int)smsValidType);
            param.setParameter("phone", phone);
            return DataBaseHelper.FindOne<TSmsValid>(strSql, param);
        }
       

        /// <summary>
        ///  短信注册验证信息是否存在
        /// </summary>
        /// <param name="smsValidType"></param>
        /// <param name="validStatus"></param>
        /// <param name="phone"></param>
        /// <returns></returns>
        private Boolean IsSmsValidExist(SmsValidType smsValidType,ValidStatus validStatus, String phone)
        {
            String strSql = @"  select * from t_smsvalid where validtype=@validType and ValidStatus=@ValidStatus and phone=@phone ";
            ParamMap param = ParamMap.newMap();
            param.setParameter("validType", (int)smsValidType);
            param.setParameter("ValidStatus", (int)validStatus);
            param.setParameter("phone", phone);
            return DataBaseHelper.IsExist(strSql, param);
        }

      

        /// <summary>
        /// 添加验证信息
        /// </summary>
        /// <param name="smsInfo"></param>
        /// <returns></returns>
        private Boolean AddSmsValid(SmsValidType smsValidType, String phone,String validCode)
        {
            TSmsValid smsItem = new TSmsValid();
            smsItem.Phone = phone;
            smsItem.CreateTime = DateTime.Now;
            smsItem.StartTime = DateTime.Now;
            smsItem.EndTime = DateTime.Now.AddMinutes(30);
            smsItem.Status =(int) Status.Enable;
            smsItem.ValidStatus =(int) ValidStatus.Unvalid;
            smsItem.ValidType = (int)smsValidType;
            smsItem.UpdateTime = DateTime.Now;
            smsItem.ValidCode = validCode;
            return DataBaseHelper.Save<TSmsValid>(smsItem)>0?true:false;
        }
        #endregion








    }
}
