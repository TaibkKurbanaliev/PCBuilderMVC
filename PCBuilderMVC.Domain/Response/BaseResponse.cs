using PCBuilderMVC.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilderMVC.Domain.Response
{
    public class BaseResponse<T>
    {
        public StatusCode StatusCode { get; set; }
        public string Description {  get; set; }
        public T Data { get; set; }
    }
}
