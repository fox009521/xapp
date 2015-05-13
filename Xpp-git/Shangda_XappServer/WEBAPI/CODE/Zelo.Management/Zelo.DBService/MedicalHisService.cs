using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zelo.Common.Common;
using Zelo.DBModel;

namespace Zelo.DBService
{
    public class MedicalHisService : BaseService
    {
        /// <summary>
        /// 添加病例夹
        /// </summary>
        /// <param name="strDoctorGid"></param>
        /// <param name="strPatientGid"></param>
        /// <param name="strSickness"></param>
        /// <returns></returns>
        public Boolean AddMedicalHis(String strDoctorGid, String strPatientGid, String strSickness)
        {
            TMedicalHis medicalHis = new TMedicalHis();

            medicalHis.DoctorID = strDoctorGid;
            medicalHis.PatientID = strPatientGid;
            medicalHis.Sickness = strSickness;
            return DataBaseHelper.Save<TMedicalHis>(medicalHis) > 0 ? true : false;
        }

        /// <summary>
        /// 修改病例夹
        /// </summary>
        /// <param name="strDoctorGid"></param>
        /// <param name="strPatientGid"></param>
        /// <param name="strSickness"></param>
        /// <returns></returns>
        public Boolean UpdateMedicalHis(TMedicalHis medicalHis)
        {
            return DataBaseHelper.Update<TMedicalHis>(medicalHis) > 0 ? true : false;
        }

        /// <summary>
        /// 病历夹是否存在
        /// </summary>
        /// <param name="strDoctorGid"></param>
        /// <param name="strPatientGid"></param>
        /// <param name="strSickness"></param>
        /// <returns></returns>
        public Boolean IsHisExist(String strDoctorGid, String strPatientGid, String strSickness)
        {
            String strSql = "select count(*) from T_MEDICAL_HIS  where  where Doctor_ID = @Doctor_ID AND Patient_ID = @Patient_ID AND Sickness =@Sickness  ";
            ParamMap param = ParamMap.newMap();
            param.setParameter("Doctor_ID", strDoctorGid);
            param.setParameter("Patient_ID", strPatientGid);
            param.setParameter("Sickness", strSickness);
            return DataBaseHelper.IsExist(strSql, param);
        }

        /// <summary>
        /// 根据医生ID（和病人ID）获取病历夹记录
        /// </summary>
        /// <param name="strDoctorGid"></param>
        /// <param name="strPatientGid"></param>
        /// <param name="strSickness"></param>
        /// <returns></returns>
        public List<TMedicalHisExtend> GetMedicalHis(String strDoctorGid)
        {
            String strSql = "SELECT A.*, B.PatientName, b.sex AS PatientSex, B.Age AS PatientAge " +
                            "FROM T_MEDICAL_HIS A LEFT JOIN T_PATIENT B ON A.PATIENT_ID = B.PatientGID " +
                            " where A.STATUS = 1 AND A.Doctor_ID = @Doctor_ID  ";
            ParamMap param = ParamMap.newMap();
            param.setParameter("Doctor_ID", strDoctorGid);
            return DataBaseHelper.FindBySql<TMedicalHisExtend>(strSql, param);
        }

        /// <summary>
        /// 根据医生ID（和病人ID）获取病历夹记录
        /// </summary>
        /// <param name="strDoctorGid"></param>
        /// <param name="strPatientGid"></param>
        /// <param name="strSickness"></param>
        /// <returns></returns>
        public TMedicalHis GetMedicalHisInfo(String strMedicalHisGid)
        {
            String strSql = "SELECT * " +
                            "FROM T_MEDICAL_HIS " +
                            " where STATUS = 1 AND His_Gid = @His_Gid  ";
            ParamMap param = ParamMap.newMap();
            param.setParameter("His_Gid", strMedicalHisGid);
            return DataBaseHelper.FindOne<TMedicalHis>(strSql, param);
        }

        /// <summary>
        /// 删除病历夹
        /// </summary>
        /// <param name="strDoctorGid"></param>
        /// <param name="strPatientGid"></param>
        /// <param name="strSickness"></param>
        /// <returns></returns>
        public Boolean DeleteHisByGid(String strMedicalHisGid)
        {
            String strSql = "select * from T_Medical_His where HIS_GID=@HIS_GID and status = 1";
            ParamMap param = ParamMap.newMap();
            param.setParameter("HIS_GID", strMedicalHisGid);
            TMedicalHis mh = DataBaseHelper.FindOne<TMedicalHis>(strSql, param);
            if (mh != null)
            {
                //开启事务
                DataBaseHelper.BeginTransaction();
                try
                {
                    String strSql1 = "select * from T_Medical_HisDetail where His_ID=@His_ID and status = 1";
                    param = ParamMap.newMap();
                    param.setParameter("His_ID", mh.HisGid);
                    List<TMedicalHisDetail> mht = DataBaseHelper.FindBySql<TMedicalHisDetail>(strSql1, param);

                    strSql1 = "select * from T_Medical_HisDetailPic where Detail_Gid IN (SELECT DETAIL_GID FROM T_Medical_HisDetail where His_ID=@His_ID and status = 1) and status =1";
                    ParamMap paramDetail = ParamMap.newMap();
                    paramDetail.setParameter("His_ID", mh.HisGid);
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

                    //new MedicalHisDetailService().DeleteDetailByGId(tem.HisGid)
                    if (lstDetailPic != null && lstDetailPic.Count > 0)
                    {
                        DataBaseHelper.Remove(lstDetailPic);
                    }
                    if (mht != null && mht.Count > 0)
                    {
                        DataBaseHelper.Remove(mht);
                    }
                    DataBaseHelper.Remove(mh);
                    //Update(ttem);
                    //Update<TTemplate>(tem);
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
            return false;
        }
    }
}