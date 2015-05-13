using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http.Filters;
using System.Web.Http.ModelBinding;
using Zelo.Management.AppUtils;
using Zelo.Management.Controllers;
using Zelo.DBModel;
using Zelo.Management.Models;
namespace Zelo.Management.AppFliter
{
    /// <summary>
    /// token验证的过滤器,基于传递参数为BaseParam
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class DoctorTokenAuthActionFilter : BaseActionFilter
    {
        TokenAuthCommonFunction tokenDAL = new TokenAuthCommonFunction();

        //执行action之前
        public override void OnActionExecuting(System.Web.Http.Controllers.HttpActionContext actionContext)
        {

            Result<Object> result = new Result<Object>();
            BaseController controller = (BaseController)actionContext.ControllerContext.Controller;
            BaseParams baseParams = GetBaseParams(actionContext);
            result = tokenDAL.CheckDoctorModelState<Object>(baseParams, actionContext.ModelState);
            if (result == null)
            {
                controller.IsAuthrized = true;
                User user = new User();
                user.UserGID = baseParams.user_id;
                user.UserToken = baseParams.token;
                controller.CurrentUser = user;
            }
            else
            {
                controller.IsAuthrized = false;
                controller.AuthFilterResult = result;

            }

        }


    }
}