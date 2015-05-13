using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zelo.Common.Common;
using Zelo.DBModel;
using Zelo.Common.DBUtility;
using System.IO;

namespace Zelo.DBService
{
    public class MedicalHisDetailService : BaseService
    {
        /// <summary>
        /// 添加一个病历
        /// </summary>
        /// <param name="templateInfo"></param>
        /// <returns></returns>
        /// <summary>
        public bool AddHisDetail(string strHisGid, string strTitle, string strDesc, string strDoctorGid, List<String> lstPic)
        {
            DataBaseHelper.BeginTransaction();
            try
            {
                TMedicalHisDetail detail = new TMedicalHisDetail();
                detail.DetailGid = Guid.NewGuid().ToString();
                detail.HisID = strHisGid;
                detail.DetailTitle = strTitle;
                detail.DetailDescribe = strDesc;
                detail.CreateUser = strDoctorGid;

                List<TMedicalHisDetailPic> lstDetailPic = new List<TMedicalHisDetailPic>();
                foreach(string strImgUrl in lstPic)
                {
                    TMedicalHisDetailPic detailPic = new TMedicalHisDetailPic();
                    detailPic.DetailGid = detail.DetailGid;
                    detailPic.PicUrl = strImgUrl;
                    lstDetailPic.Add(detailPic);
                }
                Save(lstDetailPic);
                Save<TMedicalHisDetail>(detail);
                DataBaseHelper.CommitTransaction();
                return true;
            }
            catch
            {

                //事务回滚
                DataBaseHelper.RollbackTransaction();
                return false;
            }
        }

        /// <summary>
        /// 添加一个病历
        /// </summary>
        /// <param name="templateInfo"></param>
        /// <returns></returns>
        /// <summary>
        public bool UpdateHisDetail(string strDetailGid, string strTitle, string strDesc, string strDoctorGid, List<String> lstPic)
        {
            //开启事务
            DataBaseHelper.BeginTransaction();
            try
            {
                String strSql = "select * from T_Medical_HisDetail where DETAIL_GID=@DETAIL_GID AND Status =1";
                ParamMap param = ParamMap.newMap();
                param.setParameter("DETAIL_GID", strDetailGid);
                TMedicalHisDetail detail = DataBaseHelper.FindOne<TMedicalHisDetail>(strSql, param);
                if (detail != null)
                {
                    detail.DetailTitle = strTitle != null ? strTitle : detail.DetailTitle;
                    detail.DetailDescribe = strDesc != null ? strDesc : detail.DetailDescribe;
                    detail.CreateUser = strDoctorGid != null?strDoctorGid:detail.CreateUser;

                    String strSql1 = "select * from T_Medical_HisDetailPic where Detail_Gid=@Detail_Gid and status =1";
                    ParamMap paramDetail = ParamMap.newMap();
                    paramDetail.setParameter("Detail_Gid", strDetailGid);
                    List<TMedicalHisDetailPic> lstDetailPic = DataBaseHelper.FindBySql<TMedicalHisDetailPic>(strSql1, paramDetail);

                    if (lstDetailPic != null && lstDetailPic.Count > 0)
                    {
                        List<String> lstDeletePic = new List<string>();
                        String strPicUrl = "";
                        foreach (TMedicalHisDetailPic mhp in lstDetailPic)
                        {
                            strPicUrl = "";
                            strPicUrl = mhp.PicUrl;
                            if (strPicUrl.Trim() != "")
                            {
                                lstDeletePic.Add(strPicUrl.Trim());
                            }
                        }

                        Zelo.Common.Common.ImageSave.DeletePic(lstDeletePic);
                    }
                    //Update(ttem);
                    DataBaseHelper.Remove(lstDetailPic);

                    lstDetailPic = new List<TMedicalHisDetailPic>();
                    ///提交模版下的每个动作
                    foreach (string strImgUrl in lstPic)
                    {
                        TMedicalHisDetailPic detailPic = new TMedicalHisDetailPic();
                        detailPic.DetailGid = detail.DetailGid;
                        detailPic.PicUrl = strImgUrl;
                        lstDetailPic.Add(detailPic);
                    }
                    Update<TMedicalHisDetail>(detail);
                    Save(lstDetailPic);
                    //提交事务
                    DataBaseHelper.CommitTransaction();
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch
            {
                //事务回滚
                DataBaseHelper.RollbackTransaction();
                return false;
            }
        }

        /// <summary>
        /// 删除病历
        /// </summary>
        /// <param name="templateId"></param>
        /// <returns></returns>
        public Boolean DeleteDetailByGId(String strDetailGid)
        {
            //开启事务
            DataBaseHelper.BeginTransaction();
            try
            {
                //查询模版动作信息
                String strSql1 = "select * from T_Medical_HisDetail where Detail_Gid=@Detail_Gid and status = 1";
                ParamMap param = ParamMap.newMap();
                param.setParameter("Detail_Gid", strDetailGid);
                List<TMedicalHisDetail> ttem = DataBaseHelper.FindBySql<TMedicalHisDetail>(strSql1, param);

                strSql1 = "select * from T_Medical_HisDetailPic where Detail_Gid=@Detail_Gid and status =1";
                ParamMap paramDetail = ParamMap.newMap();
                paramDetail.setParameter("Detail_Gid", strDetailGid);
                List<TMedicalHisDetailPic> lstDetailPic = DataBaseHelper.FindBySql<TMedicalHisDetailPic>(strSql1, paramDetail);

                if (lstDetailPic != null && lstDetailPic.Count > 0)
                {
                    List<String> lstDeletePic = new List<string>();
                    String strPicUrl = "";
                    foreach (TMedicalHisDetailPic mhp in lstDetailPic)
                    {
                        strPicUrl = "";
                        strPicUrl = mhp.PicUrl;
                        if (strPicUrl.Trim() != "")
                        {
                            lstDeletePic.Add(strPicUrl.Trim());
                        }
                    }

                    Zelo.Common.Common.ImageSave.DeletePic(lstDeletePic);
                }

                //Update(ttem);
                DataBaseHelper.Remove(lstDetailPic);
                //Update(ttem);
                DataBaseHelper.Remove(ttem);
                //提交事务
                DataBaseHelper.CommitTransaction();
                return true;
            }
            catch
            {
                //事务回滚
                DataBaseHelper.RollbackTransaction();
                return false;
            }
        }

        /// <summary>
        /// 根据病历ID获取病历信息
        /// </summary>
        /// <param name="strDoctorGid"></param>
        /// <param name="strPatientGid"></param>
        /// <param name="strSickness"></param>
        /// <returns></returns>
        public TMedicHisDetailInfo GetMedicalHisDetail(String strDetailGid)
        {
            TMedicHisDetailInfo info = new TMedicHisDetailInfo();
            String strSql = "SELECT * FROM T_Medical_HisDetail WHERE DETAIL_GID = @DETAIL_GID AND STATUS =1  ";
            ParamMap param = ParamMap.newMap();
            param.setParameter("DETAIL_GID", strDetailGid);
            TMedicalHisDetail detail = DataBaseHelper.FindOne<TMedicalHisDetail>(strSql, param);
            if (detail != null)
            {
                info.DetailGid = detail.DetailGid;
                info.HisID = detail.HisID;
                info.DetailTitle = detail.DetailTitle;
                info.DetailDescribe = detail.DetailDescribe;
                info.CreateUser = detail.CreateUser;
                info.CreateTime = detail.CreateTime;
                info.UpdateTime = detail.UpdateTime;
                info.Status = detail.Status;

                strSql = "select * from T_Medical_HisDetailPic where Detail_Gid=@Detail_Gid and status =1";
                ParamMap paramDetail = ParamMap.newMap();
                param.setParameter("Detail_Gid", strDetailGid);
                info.PicList = DataBaseHelper.FindBySql<TMedicalHisDetailPic>(strSql, paramDetail);
                return info;
            }
            else
            {
                return null;
            }
           
        }

        /// <summary>
        /// 根据病历ID获取病历信息
        /// </summary>
        /// <param name="strDoctorGid"></param>
        /// <param name="strPatientGid"></param>
        /// <param name="strSickness"></param>
        /// <returns></returns>
        public List<TMedicHisDetailInfo> GetMedicalHisDetailByHisgid(String strHisGid)
        {
            List<TMedicHisDetailInfo> lstDetailInfo = new List<TMedicHisDetailInfo>();
            String strSql = "SELECT * FROM T_Medical_HisDetail WHERE HIS_ID = @HIS_ID AND STATUS =1  ";
            ParamMap param = ParamMap.newMap();
            param.setParameter("HIS_ID", strHisGid);
            List<TMedicalHisDetail> lstdetail = DataBaseHelper.FindBySql<TMedicalHisDetail>(strSql, param);
            if (lstdetail != null && lstdetail.Count > 0)
            {
                foreach (TMedicalHisDetail detail in lstdetail)
                {
                    TMedicHisDetailInfo info = new TMedicHisDetailInfo();
                    info.DetailGid = detail.DetailGid;
                    info.HisID = detail.HisID;
                    info.DetailTitle = detail.DetailTitle;
                    info.DetailDescribe = detail.DetailDescribe;
                    info.CreateUser = detail.CreateUser;
                    info.CreateTime = detail.CreateTime;
                    info.UpdateTime = detail.UpdateTime;
                    info.Status = detail.Status;

                    strSql = "select * from T_Medical_HisDetailPic where Detail_Gid=@Detail_Gid and status =1";
                    ParamMap paramDetail = ParamMap.newMap();
                    param.setParameter("Detail_Gid", detail.DetailGid);
                    info.PicList = DataBaseHelper.FindBySql<TMedicalHisDetailPic>(strSql, paramDetail);
                    lstDetailInfo.Add(info);
                }
                return lstDetailInfo;
            }
            else
            {
                return null;
            }

        }
    }
}
