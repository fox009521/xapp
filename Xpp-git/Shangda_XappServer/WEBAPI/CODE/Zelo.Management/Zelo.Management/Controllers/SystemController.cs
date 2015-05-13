using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zelo.DBModel;
using Zelo.DBService;
using Zelo.Management.Models;


namespace Zelo.Management.Controllers
{
    /// <summary>
    /// 系统接口
    /// </summary>
    public class SystemController : BaseController
    {
        

        /// <summary>
        /// 版本升级
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public Result<UpgradeInfo> CheckUpdateInfo(QueryUpdateParams info)
        {
           //获取版本信息

            Result<UpgradeInfo> result = Result<UpgradeInfo>.CreateInstance(ResultCode.Fail);
            if (info == null)
            {
                result.SetFail("请求参数不全");
                return result;
            }
            AppOSType type = (AppOSType)Enum.ToObject(typeof(AppOSType), info.os);
            TAppUpgradeInfo item=ServiceFactory.GetService<SystemService>().GetUpgradeInfo(type,info.version);
            if (item != null)
            {
                UpgradeInfo upgradeInfo = new UpgradeInfo();
                upgradeInfo.upgrade_info = item.VersionContent;
                upgradeInfo.version = item.VersionCode;
                upgradeInfo.download_url =item.DownloadUrl;
                upgradeInfo.version_name = item.VersionName;
                result.result_data = upgradeInfo;
                result.SetSuccess("您有新的版本升级");
                return result;
            }
            else
            {
                result.SetFail("您当前为最新版本");

            }
            return result;
        }

    }
}
