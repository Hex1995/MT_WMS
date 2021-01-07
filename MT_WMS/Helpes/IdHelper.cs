using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MT_WMS
{
    public sealed class IdHelper
    {


        /// <summary>
        /// 获取相关Id
        /// base N 和 雪花ID
        /// </summary>
        /// <param name="type">Id类型</param>
        /// <param name="team">班组</param>
        /// <param name="code">相关编码</param>
        public static string GetId(IdType type, string team = "", string code = "")
        {
            long datacenterId = GlobalSwitch.Instance.datacenterId;
            long workerId = GlobalSwitch.Instance.workerId;
            StringBuilder builder = new StringBuilder("");
            switch (type)
            {
                case IdType.Base8:
                    builder.Append(GetBase(8));
                    break;
                case IdType.Base16:
                    builder.Append(GetBase(16));
                    break;
                case IdType.Base32:
                    builder.Append(GetBase(32));
                    break;
                case IdType.Guid:
                    builder.Append(GetBase(0));
                    break;
                case IdType.Snowflake:
                    builder.Append(GetSnowflakeId(datacenterId, workerId));
                    break;
                case IdType.Batch:
                    builder.Append(GetNumber(team,code));
                    break;
                default:
                    builder.Append("");
                    break;
            }
            return builder.ToString();
        }
        private static string GetBase(int Length)
        {
            if (Length==0)
            {
                return Guid.NewGuid().ToString();
            }
            long i = 1;
            foreach (byte b in Guid.NewGuid().ToByteArray())
            {
                i *= ((int)b + 1);
            }
            return string.Format("{0:x}", i - DateTime.Now.Ticks);
        }

        /// <summary>
        ///  获取雪花ID
        /// </summary>
        /// <returns></returns>
        private static long GetSnowflakeId(long datacenterId, long workerId)
        {
            long id  = new SnowflakeId(datacenterId, workerId).NextId();
            return id;
        }
        /// <summary>
        /// 生成规则如下
        /// yyyymmdd+team+code
        /// </summary>
        /// <param name="team">班组</param>
        /// <param name="code">后缀自定义字符</param>
        /// <returns></returns>
        private static string GetNumber(string team="", string code="")
        {
            string str =$@"{ DateTime.Now.ToString("yyyyMMdd")}{team}{code}";
            return str;
        }

        
    }
    public enum IdType
    {
        /// <summary>
        /// 基础Id，8位
        /// </summary>
        Base8,
        /// <summary>
        /// 基础Id，16位
        /// </summary>
        Base16,
        /// <summary>
        /// 基础Id，32位
        /// </summary>
        Base32,
        /// <summary>
        /// Guid
        /// </summary>
        Guid,
        /// <summary>
        /// 雪花ID
        /// </summary>
        Snowflake,
        /// <summary>
        /// 批次
        /// </summary>
        Batch,
    }
    /// <summary>
    /// 雪花ID
    /// </summary>
     internal sealed class SnowflakeId
    {
        private const long twepoch = 1577836800000L;
        private const int workerIdBits = 5;
        private const int datacenterIdBits = 5;
        private const long maxWorkerId = -1L ^ (-1L << workerIdBits);
        private const long maxDatacenterId = -1L ^ (-1L << datacenterIdBits);
        private const int sequenceBits = 12;
        private const int datacenterIdShift = sequenceBits + workerIdBits;
        private const int workerIdShift = sequenceBits;
        private const int timestampLeftShift = sequenceBits + workerIdBits + datacenterIdBits;
        private const long sequenceMask = -1L ^ (-1L << sequenceBits);
        public long datacenterId { get; private set; }
        public long workerId { get; private set; }
        public long sequence { get; private set; }
        public long lastTimestamp { get; private set; }
        /// <summary>
        /// 雪花ID
        /// </summary>
        /// <param name="datacenterId">数据中心ID</param>
        /// <param name="workerId">机器ID</param>
        public SnowflakeId(long datacenterId, long workerId)
        {
            if (datacenterId > maxDatacenterId || datacenterId < 0)
            {
                throw new Exception(string.Format("datacenter Id can't be greater than {0} or less than 0", maxDatacenterId));
            }
            if (workerId > maxWorkerId || workerId < 0)
            {
                throw new Exception(string.Format("worker Id can't be greater than {0} or less than 0", maxWorkerId));
            }
            this.workerId = workerId;
            this.datacenterId = datacenterId;
            this.sequence = 0L;
            this.lastTimestamp = -1L;
        }

        /// <summary>
        /// 获取下一个ID
        /// </summary>
        /// <returns></returns>
        public long NextId()
        {
            lock (this)
            {
                long timestamp = GetCurrentTimestamp();
                if (timestamp > lastTimestamp) //时间戳改变，毫秒内序列重置
                {
                    sequence = 0L;
                }
                else if (timestamp == lastTimestamp)
                {
                    sequence = (sequence + 1) & sequenceMask;
                    if (sequence == 0)
                    {
                        timestamp = GetNextTimestamp(lastTimestamp); //阻塞到下一个毫秒,获得新的时间戳
                    }
                }
                else
                {
                    sequence = (sequence + 1) & sequenceMask;
                    if (sequence > 0)
                    {
                        timestamp = lastTimestamp;     //停留在最后一次时间戳上，等待系统时间追上后即完全度过了时钟回拨问题。

                    }
                    else
                    {
                        timestamp = lastTimestamp + 1;
                    }
                }
                lastTimestamp = timestamp;       //上次生成ID的时间截
                var id = ((timestamp - twepoch) << timestampLeftShift)
                    | (datacenterId << datacenterIdShift)
                    | (workerId << workerIdShift)
                    | sequence;
                return id;
            }
        }
        public static string AnalyzeId(long Id)
        {
            StringBuilder sb = new StringBuilder();
            var timestamp = (Id >> timestampLeftShift);
            var time = Jan1st1970.AddMilliseconds(timestamp + twepoch);
            sb.Append(time.ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss:fff"));
            var datacenterId = (Id ^ (timestamp << timestampLeftShift)) >> datacenterIdShift;
            sb.Append("_" + datacenterId);
            var workerId = (Id ^ ((timestamp << timestampLeftShift) | (datacenterId << datacenterIdShift))) >> workerIdShift;
            sb.Append("_" + workerId);
            var sequence = Id & sequenceMask;
            sb.Append("_" + sequence);
            return sb.ToString();
        }
        /// <summary>
        /// 阻塞到下一个毫秒，直到获得新的时间戳
        /// </summary>
        /// <param name="lastTimestamp">上次生成ID的时间截</param>
        /// <returns></returns>
        private long GetNextTimestamp(long lastTimestamp)
        {
            long timestamp = GetCurrentTimestamp();
            while (timestamp <= lastTimestamp)
            {
                timestamp = GetCurrentTimestamp();
            }
            return timestamp;

        }
        private static long GetCurrentTimestamp()
        {
            return (long)(DateTime.UtcNow - Jan1st1970).TotalMilliseconds;
        }
        private static readonly DateTime Jan1st1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
    }
}
