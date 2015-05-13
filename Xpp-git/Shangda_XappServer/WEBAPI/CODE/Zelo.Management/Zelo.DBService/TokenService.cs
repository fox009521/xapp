using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zelo.Common.Common;
using Zelo.DBModel;

namespace Zelo.DBService
{
    /// <summary>
    /// token服务类
    /// </summary>
    public class TokenService:BaseService
    {

       /// <summary>
        ///  插入或者更新token信息
       /// </summary>
       /// <param name="tokenType"></param>
       /// <param name="ownerGID"></param>
       /// <param name="tokenContent"></param>
       /// <returns>成功，则返回token信息</returns>
        public ServiceResult InsertOrUpdateToken(TokenType tokenType, String ownerGID)
        {
            //是否存在token
            //不存在，插入
            //存在，更新
            String strSql = @"select * from dbo.T_usertoken where  tokenType=@tokenType   and tokenownergid=@ownerGID ";
            ParamMap param = ParamMap.newMap();
            param.setParameter("tokenType", (int)tokenType);
            param.setParameter("ownerGID", ownerGID);
           TUserToken token= DataBaseHelper.FindOne<TUserToken>(strSql, param);

           if (token == null)
           {
               String guid = Guid.NewGuid().ToString();
               //插入token
               if (InsertToken(tokenType, ownerGID, guid))
               {
                   return ServiceResult.CreateInstance(true, guid);
               }
               else
               {
                   return ServiceResult.CreateInstance(false, "服务器错误：插入登录令牌错误");
               }
           }
           else
           {
               if (token.Status != (int)Status.Enable)
               {
                   return ServiceResult.CreateInstance(false, "登录令牌已禁用");
               }
               //更新
               token.StartTime = DateTime.Now;
               token.EndTime = DateTime.Now.AddDays(7);
               token.TokenContent= Guid.NewGuid().ToString(); 
               
               if (DataBaseHelper.Update<TUserToken>(token) > 0)
               {
                   return ServiceResult.CreateInstance(true, token.TokenContent);
               }
               else
               {
                   return ServiceResult.CreateInstance(false, "服务器错误：更新令牌信息");
               }

           }

        }

        /// <summary>
        ///  添加token
        /// </summary>
        /// <param name="tokenType"></param>
        /// <param name="ownerGID"></param>
        /// <returns></returns>
        public Boolean InsertToken(TokenType tokenType, String ownerGID,String guid)
        {
            TUserToken token = new TUserToken();
            token.TokenContent = guid;
            token.TokenOwnerGID = ownerGID;
            token.StartTime = DateTime.Now;
            token.EndTime = DateTime.Now.AddDays(7);
            token.TokenType = (int)tokenType;
            token.Status =(int) Status.Enable;
            return Save<TUserToken>(token) > 0 ? true : false;
            //return  DataBaseHelper.Save<TUserToken>(token) > 0 ? true : false;
        }


        /// <summary>
        /// 医生是否TOKEN过期
        /// </summary>
        /// <returns></returns>
        public Boolean IsDoctorTokenOutDate(String ownerGID, String tokenContent)
        {
            return IsTokenOutDate(TokenType.Doctor, ownerGID, tokenContent);
        }
        /// <summary>
        /// 患者是否TOKEN过期
        /// </summary>
        /// <param name="ownerGID"></param>
        /// <param name="tokenContent"></param>
        /// <returns></returns>
        public Boolean IsPatientTokenOutDate(String ownerGID, String tokenContent)
        {
            return IsTokenOutDate(TokenType.Patient,ownerGID,tokenContent);
        }
        /// <summary>
        /// TOKEN是否过期
        /// </summary>
        /// <param name="tokenType"></param>
        /// <param name="ownerGID"></param>
        /// <param name="tokenContent"></param>
        /// <returns></returns>
        private Boolean IsTokenOutDate(TokenType tokenType, String ownerGID, String tokenContent)
        {
            String strSql = @"select count(*) from dbo.T_usertoken where status=@Status and tokenType=@tokenType   and tokenownergid=@ownerGID and  tokenContent=@tokenContent and ( GETDATE() between starttime and endtime) ";
            ParamMap param = ParamMap.newMap();
            param.setParameter("Status",(int)Status.Enable);
            param.setParameter("tokenType", (int)tokenType);
            param.setParameter("tokenContent", tokenContent);
            param.setParameter("ownerGID", ownerGID);
            if (DataBaseHelper.IsExist(strSql, param))
            {
                return false;
            }
            else
            {
                return true;
            }
          
        }

    }
}
