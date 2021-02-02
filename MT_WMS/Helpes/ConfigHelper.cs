using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_WMS
{
    /// <summary>
    /// 配置方法类
    /// </summary>
    public class ConfigHelper
    {
        /// <summary>
        /// 根据配置名称获取配置的值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetKeyValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
        /// <summary>
        /// 根据配置名称获取配置的解密后的值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetKeyValueDecrypt(string key)
        {
            var val = GetKeyValue(key);
            var valDecrypt = EncryptionHelper.DESDecrypt(val);
            return valDecrypt;
        }
        /// <summary>
        /// 设置配置文件中key的值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool SetConfigValue(string key, string value)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                if (config.AppSettings.Settings[key] != null)
                    config.AppSettings.Settings[key].Value = value;
                else
                    config.AppSettings.Settings.Add(key, value);
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
