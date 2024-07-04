using System;
using System.Configuration;

namespace App
{
    public static class AppConfig
    {
        public static string Get(string key)
        {
            try
            {
                string value = ConfigurationManager.AppSettings[key];
                return value;
            }
            catch (Exception)
            {
                return "";
            } 
        }
        public static bool Set(string key,string value)
        {
            try
            {
                ConfigurationManager.AppSettings.Set(key,value);
                return true;
            }
            catch (Exception)
            {
                return false;
            } 
        }
        public static bool Add(string key,string value) 
        {
            try
            {
                ConfigurationManager.AppSettings.Add(key, value);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool Remove(string key) 
        {
            try
            {
                ConfigurationManager.AppSettings.Remove(key);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string WebAPIIP { get { return Get("WebAPIIP"); } }
        public static string WebAPIPort { get { return Get("WebAPIPort"); } }
    }
}
