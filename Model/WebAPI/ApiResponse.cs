using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ApiResponse<T>
    {
        public ResponseCode Code { get; set; } = ResponseCode.Success;
        public string Message { get; set; } = "";
        public T Data { get; set; }
    }

    public enum ResponseCode
    {
        /// <summary>
        /// 成功
        /// </summary>
        Success=1000,
        /// <summary>
        /// 失败
        /// </summary>
        Fail=1001,
        /// <summary>
        /// 服务内部错误
        /// </summary>
        Error=-1,
    }

}
