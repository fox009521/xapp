using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zelo.Management.Models
{
    /// <summary>
    /// 基础请求参数
    /// </summary>
    public class BaseParams
    {
        [Required(AllowEmptyStrings=false,ErrorMessage="user_id为空")]
        public string user_id
        {
            get;set;
        }
         [Required(AllowEmptyStrings=false,ErrorMessage="token为空")]
        public string token
        {
             get;set;
        }
         
         public String to_user_id
         {
             get;
             set;
         }

     
    }

   /// <summary>
   /// 
   /// </summary>
    public class BaseListParams:BaseParams
    {
        public static readonly int DEFAULT_COUNT = 50;

        private int _count = DEFAULT_COUNT;
        /// <summary>
        /// 返回条数
        /// </summary>
        public int count
        {
            get
            {
                return _count;
            }
            set
            {
                if (value > 0)
                {
                    _count = value;
                }
            }
        }
        private int _page = 1;

        /// <summary>
        /// 页码
        /// </summary>
        public int page
        {
            get
            {
                return _page;
            }
            set
            {
                if (value > 0)
                {
                    _page = value;
                }
            }
        }
        


    }

    /// <summary>
    /// 包含时间参数的基础列表查询函数
    /// </summary>
    public class BaseDateListParams:BaseListParams{
        
        [DataType(DataType.DateTime)]
        public DateTime date_from
        {
            get;
            set;
        }

        [DataType(DataType.DateTime)]
        public DateTime date_to
        {
            get;
            set;
        }
    }
    

}