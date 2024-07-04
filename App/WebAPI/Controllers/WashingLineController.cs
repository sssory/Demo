using Model.WebAPI;

using System.Web.Http;

namespace App.WebAPI.Controllers
{
    public class WashingLineController:ApiController
    {
        [HttpPost]
        public IHttpActionResult DataProcessing([FromBody] DataProcessingRequest request)
        {
            DataProcessingResponse data = new DataProcessingResponse() 
            { 
                Code=200,
                Message="",
                Result="open"
            };

            if (request.QRCode=="1")
            {
                data.Code = 500;
                data.Message = "发生错误";

            }

            
            return Json(data);
        }
    }
}
