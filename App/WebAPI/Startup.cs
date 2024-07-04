using Owin;
using System.Web.Http;

namespace App
{
    /// <summary>
    /// 路由
    /// </summary>
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            HttpConfiguration config = new HttpConfiguration();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{action}", // 可根据需要自定义模板
                defaults: new { id = RouteParameter.Optional } // 可选参数默认为可选
            );

            config.Routes.MapHttpRoute(
                name: "WashingLineApi",
                routeTemplate: "api/{controller}/{action}", // 可根据需要自定义模板
                defaults: new { id = RouteParameter.Optional } // 可选参数默认为可选
            );
             

            appBuilder.UseWebApi(config);
        }
    }
}
