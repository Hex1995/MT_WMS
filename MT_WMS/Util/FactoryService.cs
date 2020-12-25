using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_WMS
{
    public class FactoryService
    {
        /// <summary>
        /// 构造指定的类
        /// </summary>
        /// <typeparam name="T">返回类型</typeparam>
        /// <param name="assemblyName">类的完全限定名</param>
        /// <returns></returns>
        public static T Build<T>(string assemblyName)
        {
            var type = GlobalSwitch.Instance.AllTypes.Where(x => x.FullName == assemblyName).FirstOrDefault();
            var a = type.Assembly.CreateInstance(assemblyName);
            return (T)a;
        }
        /// <summary>
        /// 根据config的配置构造指定的类
        /// </summary>
        /// <typeparam name="T">返回类型</typeparam>
        /// <param name="configKey">目标键</param>
        /// <returns></returns>
        public static T BulidByConfigKey<T>(string configKey)
        {
            string value = ConfigHelper.GetKeyValue(configKey);
            return Build<T>(value);
        }
    }
}
