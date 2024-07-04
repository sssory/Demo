using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.WebAPI
{
    public class WashingLine
    {

    }
    public class DataProcessingRequest
    {
        /// <summary>
        /// 二维码
        /// </summary>
        public string QRCode { get; set; }
        /// <summary>
        /// 设备
        /// </summary>
        public string EquipmentCode { get; set; }
        /// <summary>
        /// yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string Time { get; set; }
    }
    public class DataProcessingResponse
    {
        /// <summary>
        /// 状态
        /// </summary>
        public int Code { get; set; }
        /// <summary>
        /// 错误msg
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// open close
        /// </summary>
        public string Result { get; set; }
    }
}
