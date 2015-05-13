using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;
using Newtonsoft.Json;

namespace Zelo.Management.AppFliter
{
    /// <summary>
    /// 动作执行日志
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple=true)]
    public class ServiceLogActionFilter : BaseActionFilter
    {
        //Service_LogDAL logDAL = new Service_LogDAL();
        public override void OnActionExecuting(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            //Boolean enableLog = Convert.ToBoolean(ConfigurationManager.AppSettings["EnableWebApiLog"]);
            //if (!enableLog)
            //{
            //    return;
            //}
            //HttpContextBase httpContextBase = (HttpContextBase)actionContext.Request.Properties["MS_HttpContext"];
            //if (httpContextBase != null)
            //{
            //    String ipAddress = httpContextBase.Request.UserHostAddress;
            //    Service_Log log = new Service_Log();
            //    log.F_IP = ipAddress;
            //    BaseParams param = GetBaseParams(actionContext);
            //    if (param != null)
            //    {
            //        log.F_USERID = param.user_id;
            //        log.F_TOKEN = param.token;
            //        log.F_OPERCONTENT = String.Format("url:{0},params:{1}", actionContext.Request.RequestUri.ToString(), JsonConvert.SerializeObject(param));
            //    }
            //    else{
                
            //        log.F_OPERCONTENT = String.Format("url:{0},params :", actionContext.Request.RequestUri.ToString());
            //    }
            //    log.F_OPERTIME = DateTime.Now;
            //    log.f_gid = Guid.NewGuid().ToString();
            //    logDAL.Add(log);
            //}
       
        }
     

      
    }
}