using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;
using Zelo.Management.AppUtils;
using Newtonsoft.Json;
using Zelo.Management.Models;

namespace Zelo.Management.AppFliter
{
    /// <summary>
    /// API调用异常处理
    /// </summary>
    public class APIExceptionFilterAttribute : ExceptionFilterAttribute
    {

        public override void OnException(HttpActionExecutedContext context)
        {
            
        
            Result<String> result=Result<String>.CreateInstance(ResultCode.ServerException);
            context.Response = new HttpResponseMessage { StatusCode = System.Net.HttpStatusCode.ExpectationFailed };
            if (ConfigUtils.IsWebApiDebug())
            {

                result.message = context.Exception.ToString();
            }
            else
            {
                result.message = "服务器异常";
            }
            context.Response.Content = new StringContent(JsonConvert.SerializeObject(result));
            
        }
    }
}