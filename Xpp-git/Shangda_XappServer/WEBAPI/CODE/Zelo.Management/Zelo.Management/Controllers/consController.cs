using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Zelo.DBModel;
using Zelo.DBService;
using Zelo.Management.AppFliter;
using Zelo.Management.Models;

namespace Zelo.Management.Controllers
{
    public class consController : AbstractUserController
    {
        /// <summary>
        /// 通过手机号登录
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpPost]
        [MedicalHisTokenAuthActionFilter]
        public Result<List<Tconf>> consummary(consModels cons)
        {
            Result<List<Tconf>> result = Result<List<Tconf>>.CreateInstance(ResultCode.Fail);
            List<Tconf> lst = new List<Tconf>();

            for (int iIndex = 0; iIndex < 10; iIndex++)
            {
                Tconf t = new Tconf();
                t.gid = "会议GID" + (iIndex + 1).ToString();
                t.local = "会议地点" + (iIndex + 1).ToString();
                t.cfdate = DateTime.Now;
                t.title = "会议名称" + (iIndex + 1).ToString();
                t.sponsor = "发起人" + (iIndex + 1).ToString();
                if ((iIndex + 1) % 2 == 0)
                {
                    t.isfav = 0;
                }
                else
                {
                    t.isfav = 1;
                }

                lst.Add(t);
            }

            result.SetSuccess();
            result.result_data = lst;

            return result;
        }
        [HttpPost]
        public Result<Tconf> condetail(conModel cons)
        {
            Result<Tconf> result = Result<Tconf>.CreateInstance(ResultCode.Fail);
            
            Tconf t = new Tconf();
            t.gid = "会议GID";
            t.local = "会议地点" ;
            t.dateend = DateTime.Now.AddHours(10);
            t.cfdate = DateTime.Now;
            t.title = "会议名称";
            t.sponsor = "发起人";

            result.SetSuccess();
            result.result_data = t;

            return result;
        }
    }
}
