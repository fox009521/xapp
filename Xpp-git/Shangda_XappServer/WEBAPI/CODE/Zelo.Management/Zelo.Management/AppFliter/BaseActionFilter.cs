using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using Zelo.Management.Models;

namespace Zelo.Management.AppFliter
{
    /// <summary>
    /// filter的基类
    /// </summary>
    public class BaseActionFilter : ActionFilterAttribute
    {

        /// <summary>
        /// 获取BaseParams，如果不存在，则返回NULL
        /// </summary>
        /// <param name="actionContext"></param>
        /// <returns></returns>
        public BaseParams GetBaseParams(HttpActionContext actionContext)
        {
            foreach (String key in actionContext.ActionArguments.Keys)
            {
                Object obj = actionContext.ActionArguments[key];
                if (obj is BaseParams)
                {
                    BaseParams baseParams = obj as BaseParams;
                    return baseParams;
                }
            }
            return null;
        }

        public MedicalHisParams TestGetBaseParams(HttpActionContext actionContext)
        {
            foreach (String key in actionContext.ActionArguments.Keys)
            {
                Object obj = actionContext.ActionArguments[key];
                if (obj is MedicalHisParams)
                {
                    MedicalHisParams baseParams = obj as MedicalHisParams;
                    return baseParams;
                }
            }
            return null;
        }

     
    }
}