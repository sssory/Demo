using Model;
using System.Web.Http;

namespace Controllers
{
    public class DefaultController:ApiController
    { 
        [HttpPost] 
        public IHttpActionResult POST()
        {
            ApiResponse<string> response = new ApiResponse<string>();
            response.Message = response.Code.ToString();
            response.Data = "POST请求";
            return Json(response);
        }
        [HttpGet]
        public IHttpActionResult GET()
        {
            ApiResponse<string> response = new ApiResponse<string>();
            response.Message = response.Code.ToString();
            response.Data = "GET请求";
            return Json(response);
        }
    }
}
