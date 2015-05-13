using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zelo.Common.Common;
using Zelo.DBModel;

namespace Zelo.DBService
{
    /// <summary>
    /// 系统服务
    /// </summary>
    public class SystemService : BaseService
    {

        /// <summary>
        /// 获取更新升级
        /// </summary>
        /// <param name="type"></param>
        /// <param name="versionCode"></param>
        /// <returns></returns>
        public TAppUpgradeInfo GetUpgradeInfo(AppOSType type, float versionCode)
        {

            String strSql = "select * from t_appupgradeinfo where ostype=@ostype  and ispublish=@ispublish and status=@status and versioncode>@versioncode order by versioncode  desc";
            ParamMap param = ParamMap.newMap();
            param.setParameter("ostype", (int)type);
            param.setParameter("ispublish", (int)Status.Enable);
            param.setParameter("status", (int)Status.Enable);
            param.setParameter("versioncode", versionCode);
            return DataBaseHelper.FindOne<TAppUpgradeInfo>(strSql, param);
        }






    }
}
