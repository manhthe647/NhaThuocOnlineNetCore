using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.ViewModel.Common
{
    public class ApiSuccessResult<T>: ApiResult<T>
    {
        public ApiSuccessResult() { 
            IsSuccessed = true;
        }

        public ApiSuccessResult(T result)
        {
            IsSuccessed = true;
            ResultObject = result;
        }
    }
}
