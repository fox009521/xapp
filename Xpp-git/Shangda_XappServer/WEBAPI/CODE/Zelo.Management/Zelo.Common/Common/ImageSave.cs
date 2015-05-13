using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Web;

namespace Zelo.Common.Common
{
    public class ImageSave
    {
        /// <summary>
        /// 保存图片并返回路径
        /// </summary>
        /// <param name="lstPic">图片数据</param>
        /// <param name="strSaveUrl">实际路径</param>
        /// <param name="strDataUrl">相对路径</param>
        /// <returns></returns>
        public static List<String> ImgSave(List<String> lstPic, String strType)
        {
            List<String> lstResult = new List<string>();
            if (lstPic != null && lstPic.Count > 0)
            {
                try
                {
                    DateTime date = DateTime.Now;
                    //yyy-MM-dd-hh-mm-ss-ff [ 年-月-日-时-分-秒-毫秒(ff保留两位数字 最多8位表示为ffffffff) ]
                    string DateStr = date.ToString("yyy-MM-dd", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                    String filePath = System.Web.HttpContext.Current.Server.MapPath("/UploadFiles/" + strType + "/" + DateStr + "/") ;
                    if (!Directory.Exists(filePath))
                    {
                        Directory.CreateDirectory(filePath);
                    }

                    foreach (String strImgData in lstPic)
                    {
                        try
                        {
                            MemoryStream mStream = new MemoryStream(Convert.FromBase64String(strImgData));
                            String fileName = Guid.NewGuid().ToString() + ".png";
                            String fileUrl = filePath + fileName;
                            Bitmap bitmap = new Bitmap(mStream);

                            bitmap.Save(fileUrl);

                            lstResult.Add("/UploadFiles/" + strType + "/" + DateStr + "/" + fileName);
                        }
                        catch
                        {
                            continue;
                        }
                    }
                    return lstResult;
                }
                catch
                {
                    return lstResult;
                }
                
            }
            else
            {
                return lstResult;
            }
        }

        /// <summary>
        /// 删除图片
        /// </summary>
        /// <param name="lstPic">图片数据</param>
        /// <param name="strSaveUrl">实际路径</param>
        /// <param name="strDataUrl">相对路径</param>
        /// <returns></returns>
        public static void DeletePic(List<String> lstPic)
        {
            if (lstPic != null && lstPic.Count > 0)
            {
                foreach (String strFilePath in lstPic)
                {
                    try
                    {
                        string strFileDir = strFilePath.Substring(0, strFilePath.LastIndexOf('/'));
                        string strFileName = strFilePath.Substring(strFilePath.LastIndexOf('/') + 1);
                        string strPath = System.Web.HttpContext.Current.Server.MapPath(strFileDir) + "/" + strFileName;
                        if (File.Exists(strPath))
                        {
                            File.Delete(strPath);
                        }
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
        }
    }
}
