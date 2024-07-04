using Microsoft.Owin.Hosting;
using System;

namespace App
{
    public class WebApiSercives
    {
        private static IDisposable _disposable;
        private WebApiSercives()
        { 
        
        }
        
        public static readonly WebApiSercives sercives = new WebApiSercives();

        /// <summary>
        /// 启动
        /// </summary>
        public bool Start()
        {
            if (_disposable != null)
            {
                return true;
            }

            string EAPIP = "";
            int EAPPort = 0;
            try
            {
                EAPIP = AppConfig.WebAPIIP;
                EAPPort = Convert.ToInt32(AppConfig.WebAPIPort);
                string baseAddress = $"http://{EAPIP}:{EAPPort}/";
                _disposable = WebApp.Start<Startup>(url: baseAddress);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// 停止
        /// </summary>
        public void Stop()
        {
            if (_disposable != null)
            {
                _disposable.Dispose();
                _disposable = null;
            }
        }
        
        #region 状态
        public APIOC State { get { return _disposable == null ? APIOC.CLOSE : APIOC.OPEN; } }

        public enum APIOC
        {
            OPEN,
            CLOSE
        }

        #endregion


    }


}
