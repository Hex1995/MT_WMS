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

    }
}
