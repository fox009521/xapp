using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zelo.DBService
{
    public class ServiceResult
    {
        public static ServiceResult CreateInstance(Boolean IsSuccess, String message)
        {
            ServiceResult result= new ServiceResult();
            result.IsSuccess = IsSuccess;
            result.message = message;
            return result;
        }
        public Boolean IsSuccess
        {
            get;
            set;
        }
        public String message
        {
            get;
            set;
        }
    }
}
