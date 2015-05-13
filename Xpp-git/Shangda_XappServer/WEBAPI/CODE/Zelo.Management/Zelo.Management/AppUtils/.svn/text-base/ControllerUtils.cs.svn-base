using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.ModelBinding;
using Zelo.Management.Models;



namespace Zelo.Management.AppUtils
{
    public static class ControllerUtils
    {
        /// <summary>
        /// 获取第一个错误消息
        /// </summary>
        /// <param name="modelState"></param>
        /// <returns></returns>
        public static String GetFirstErrorMessage(ModelStateDictionary modelState)
        {

            String errorMessage=null;
            foreach (var key in modelState.Keys)
            {
                var errors = modelState[key].Errors;
                foreach(var error in errors)
                {
                    errorMessage = error.ErrorMessage;
                    break;
                }
                break;

            }
            return errorMessage;
        }
        /// <summary>
        /// 如果验证成功，且object为null，则返回null
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="modelState"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Result<T> getErrorResult<T>(ModelStateDictionary modelState,Object obj)
        {
            if (modelState.IsValid)
            {
                if (obj == null)
                {
                    return Result<T>.CreateInstance(ResultCode.Fail, "没有提交任何参数");
                }
                return null;
            }
            String errorMessage=GetFirstErrorMessage(modelState);
            if(String.IsNullOrEmpty(errorMessage))
            {
                errorMessage="参数请求不完整";
            }
            return Result<T>.CreateInstance(ResultCode.Fail, errorMessage);
        }
    }
}