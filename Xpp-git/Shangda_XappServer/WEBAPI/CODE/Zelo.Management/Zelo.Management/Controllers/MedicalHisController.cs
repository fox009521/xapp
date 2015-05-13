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
    public class MedicalHisController : AbstractUserController
    {
        /// <summary>
        /// 获取病历夹信息
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>

        [MedicalHisTokenAuthActionFilter]
        [HttpPost]
        public Result<List<TMedicalHisExtend>> MedicalHisInfo(BaseParams search)
        {
            if (IsAuthrized)
            {
                Result<List<TMedicalHisExtend>> result = Result<List<TMedicalHisExtend>>.CreateInstance(ResultCode.Fail);
                List<TMedicalHisExtend> lstMedicalHis = GetService<MedicalHisService>().GetMedicalHis(search.user_id);
                if (lstMedicalHis != null && lstMedicalHis.Count > 0)
                {
                    result.SetSuccess();
                    result.result_data = lstMedicalHis;
                }
                result.message = "您尚未创建病历夹";
                return result;
            }
            return GetAuthFilterResult<List<TMedicalHisExtend>>();
        }

        /// <summary>
        /// 创建病历夹
        /// </summary>
        /// <param name="templateInfo"></param>
        /// <returns></returns>
        [MedicalHisTokenAuthActionFilter]
        [HttpPost]
        public Result<string> AddMedicalHis(MedicalHisParams medicalHisParam)
        {
            if (IsAuthrized)
            {
                Result<String> result = Result<String>.CreateInstance(ResultCode.Fail);
                bool bResult = GetService<MedicalHisService>().AddMedicalHis(medicalHisParam.user_id, medicalHisParam.patient_id, medicalHisParam.SickNess);
                if (bResult)
                {
                    result.SetSuccess();
                    result.message = "创建病历夹成功";
                    return result;
                }
                else
                {
                    result.message = "服务器错误:创建病历夹失败";
                    return result;
                }
            }
            return GetAuthFilterResult<string>();
        }

        /// <summary>
        /// 更新病历夹信息
        /// </summary>
        /// <param name="docotorInfo"></param>
        /// <returns></returns>
        [MedicalHisTokenAuthActionFilter]
        public Result<String> UpdateMedicalInfo(UpdateMedicalHisParams medicalHis)
        {
            if (IsAuthrized)
            {
                Result<String> result = Result<String>.CreateInstance(ResultCode.Fail);
                TMedicalHis medicalHisInfo = GetService<MedicalHisService>().GetMedicalHisInfo(medicalHis.HisGid);
                if (medicalHisInfo != null)
                {
                    medicalHisInfo.DoctorID = medicalHis.user_id != null ? medicalHis.user_id : medicalHisInfo.DoctorID;
                    medicalHisInfo.PatientID = medicalHis.patient_id != null ? medicalHis.patient_id : medicalHisInfo.PatientID;
                    medicalHisInfo.Sickness = medicalHis.SickNess != null ? medicalHis.SickNess : medicalHisInfo.Sickness;
                    medicalHisInfo.UpdateTime = DateTime.Now;

                    if ((new MedicalHisService()).UpdateMedicalHis(medicalHisInfo))
                    {
                        result.SetSuccess();
                        result.message = "更新成功";
                    }
                    else
                    {
                        result.message = "服务器错误：更新失败";
                    }
                }
                else
                {
                    result.message = "没有查询到对应病历夹";
                }
                return result;


            }
            return GetAuthFilterResult<String>();
        }

        /// <summary>
        /// 根据病历夹ID删除病历夹信息
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        [HttpPost]
        [MedicalHisTokenAuthActionFilter]
        public Result<String> RemoveMedicalHis(UpdateMedicalHisParams param)
        {
            if (IsAuthrized)
            {
                Result<String> result = Result<String>.CreateInstance(ResultCode.Fail);

                if (GetService<MedicalHisService>().DeleteHisByGid(param.HisGid))
                {
                    result.SetSuccess("病历夹删除成功");
                    return result;
                }
                else
                {
                    result.message = "服务器错误:病历夹删除失败";
                    return result;
                }


            }
            return GetAuthFilterResult<string>();
        }

        /// <summary>
        /// 根据病历夹获取病历信息
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        [MedicalHisTokenAuthActionFilter]
        [HttpPost]
        public Result<List<TMedicHisDetailInfo>> MedicalHisDetailInfo(MedicalHisDetailParams param)
        {
            if (IsAuthrized)
            {
                Result<List<TMedicHisDetailInfo>> result = Result<List<TMedicHisDetailInfo>>.CreateInstance(ResultCode.Fail);
                List<TMedicHisDetailInfo> lstMedicalHis = GetService<MedicalHisDetailService>().GetMedicalHisDetailByHisgid(param.hisgid);
                if (lstMedicalHis != null && lstMedicalHis.Count > 0)
                {
                    result.SetSuccess();
                    result.result_data = lstMedicalHis;
                }
                result.message = "该病历夹尚未记录病历信息";
                return result;
            }
            return GetAuthFilterResult<List<TMedicHisDetailInfo>>();
        }

        /// <summary>
        /// 创建病历信息
        /// </summary>
        /// <param name="templateInfo"></param>
        /// <returns></returns>
        [MedicalHisTokenAuthActionFilter]
        [HttpPost]
        public Result<string> AddMedicalHisDetail(MedicalHisDetailOperParams detailParams)
        {
            if (IsAuthrized)
            {
                Result<String> result = Result<String>.CreateInstance(ResultCode.Fail);

                List<String> lstImgUrl = Zelo.Common.Common.ImageSave.ImgSave(detailParams.lstPic, "MedicalHisPic");

                bool bResult = GetService<MedicalHisDetailService>().AddHisDetail(detailParams.hisgid,
                                        detailParams.title, detailParams.descript, detailParams.user_id, lstImgUrl);
                if (bResult)
                {
                    result.SetSuccess();
                    result.message = "创建病历成功";
                    return result;
                }
                else
                {
                    result.message = "服务器错误:创建病历失败";
                    return result;
                }
            }
            return GetAuthFilterResult<string>();
        }

        [MedicalHisTokenAuthActionFilter]
        [HttpPost]
        public Result<string> MethodTest(methodParam lst)
        {
            Result<String> result = Result<String>.CreateInstance(ResultCode.Fail);
            return result;
        }

        /// <summary>
        /// 更新病历信息
        /// </summary>
        /// <param name="templateInfo"></param>
        /// <returns></returns>
        [HttpPost]
        [MedicalHisTokenAuthActionFilter]
        public Result<string> UpdateMedicalHisDetail(MedicalHisDetailOperParams detailParams)
        {
            if (IsAuthrized)
            {
                Result<String> result = Result<String>.CreateInstance(ResultCode.Fail);

                List<String> lstImgUrl = Zelo.Common.Common.ImageSave.ImgSave(detailParams.lstPic, "MedicalHisPic");
                bool bResult = GetService<MedicalHisDetailService>().UpdateHisDetail(detailParams.detailgid,
                                        detailParams.title, detailParams.descript, detailParams.user_id, lstImgUrl);
                if (bResult)
                {
                    result.SetSuccess();
                    result.message = "更新病历成功";
                    return result;
                }
                else
                {
                    result.message = "服务器错误:更新病历失败";
                    return result;
                }
            }
            return GetAuthFilterResult<string>();
        }

        /// <summary>
        /// 删除病历信息
        /// </summary>
        /// <param name="templateInfo"></param>
        /// <returns></returns>
        [HttpPost]
        [MedicalHisTokenAuthActionFilter]
        public Result<string> DeleteMedicalHisDetail(MedicalHisDetailOperParams detailParams)
        {
            if (IsAuthrized)
            {
                Result<String> result = Result<String>.CreateInstance(ResultCode.Fail);
                bool bResult = GetService<MedicalHisDetailService>().DeleteDetailByGId(detailParams.detailgid);
                if (bResult)
                {
                    result.SetSuccess();
                    result.message = "删除病历成功";
                    return result;
                }
                else
                {
                    result.message = "服务器错误:删除病历失败";
                    return result;
                }
            }
            return GetAuthFilterResult<string>();
        }
    }
}
