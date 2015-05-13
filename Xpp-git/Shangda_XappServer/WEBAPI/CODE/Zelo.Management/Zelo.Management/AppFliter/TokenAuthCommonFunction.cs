using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zelo.DBModel;
using Zelo.DBService;
using Zelo.Management.AppUtils;
using Zelo.Management.Models;
using System.Web.Http.ModelBinding;



namespace Zelo.Management.AppFliter
{
    public class TokenAuthCommonFunction
    {

        private TokenService tokenService = new TokenService();

        /// <summary>
        /// 检查医生modelstat,参数是否验证成功，且token是否正确，如果正确返回null;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param"></param>
        /// <returns></returns>
        public  Result<T> CheckDoctorModelState<T>(BaseParams param, ModelStateDictionary modelState)
        {

            return CheckModelState<T>(TokenType.Doctor, param, modelState);
        }

        /// <summary>
        /// 检查患者modelstat,参数是否验证成功，且token是否正确，如果正确返回null;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param"></param>
        /// <returns></returns>
        public Result<T> CheckPatientModelState<T>(BaseParams param, ModelStateDictionary modelState)
        {

            return CheckModelState<T>(TokenType.Patient, param, modelState);
        } 
        /// <summary>
        /// 检查modelstat,参数是否验证成功，且token是否正确，如果正确返回null;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param"></param>
        /// <returns></returns>
        private Result<T> CheckModelState<T>(TokenType tokenType, BaseParams param, ModelStateDictionary modelState)
        {
            Result<T> result = ControllerUtils.getErrorResult<T>(modelState, param);
            if (result == null)
            {
                Boolean isOutDate = true;
                switch (tokenType)
                {
                    case TokenType.Doctor:
                        {
                            isOutDate=tokenService.IsDoctorTokenOutDate(param.user_id, param.token);
                        };break;
                    case TokenType.Patient:
                        {
                            isOutDate = tokenService.IsPatientTokenOutDate(param.user_id, param.token);
                        };break;
                }

                if(isOutDate)
                {
                    return Result<T>.CreateInstance(ResultCode.TokenOutDate, "登录已过期,请重新登录。");
                }
                else
                {
                    return null;
                }
            }
            return result;
        }

        
    }
}