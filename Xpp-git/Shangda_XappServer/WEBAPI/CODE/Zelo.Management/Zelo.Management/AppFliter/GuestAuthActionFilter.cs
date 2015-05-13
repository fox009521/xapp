using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Zelo.Management.AppUtils;
using Zelo.Management.Controllers;
using Zelo.Management.Models;


namespace Zelo.Management.AppFliter
{
     [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class GuestAuthActionFilter : BaseActionFilter
    {
         private static String guestUserID;// = SecurityUtils.AESDecrypt(ConfigurationManager.AppSettings["GUEST_USER_ID"]);
         private static String guestUserToken;// = SecurityUtils.AESDecrypt(ConfigurationManager.AppSettings["GUEST_USER_TOKEN"]);
         TokenAuthCommonFunction tokenDAL = new TokenAuthCommonFunction();
         public override void OnActionExecuting(System.Web.Http.Controllers.HttpActionContext actionContext)
         {
             Result<Object> result = new Result<Object>();
             BaseController controller = (BaseController)actionContext.ControllerContext.Controller;
             BaseParams baseParams = GetBaseParams(actionContext);
              //设置游客账号为例外。
             if (guestUserID.Equals(baseParams.user_id) && guestUserToken.Equals(baseParams.token))
             {
                 if (ControllerUtils.getErrorResult<Object>(actionContext.ModelState,baseParams) == null)
                 {
                     controller.IsAuthrized = true;
                     return;
                 }
             }
             result = tokenDAL.CheckDoctorModelState<Object>(baseParams, actionContext.ModelState);
             if (result == null)
             {

                 controller.IsAuthrized = true;
             }
             else
             {
                 
                 controller.IsAuthrized = false;
                     controller.AuthFilterResult = result;
                 
                

             }
         }
    }
}