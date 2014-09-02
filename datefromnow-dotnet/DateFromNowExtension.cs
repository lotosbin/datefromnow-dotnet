using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datefromnow_dotnet
{
    public static class DateFromNowExtension
    {/// <summary>
        /// 格式化显示时间为几个月,几天前,几小时前,几分钟前,或几秒前
        /// </summary>
        /// <param name="dt">要格式化显示的时间</param>
        /// <returns>几个月,几天前,几小时前,几分钟前,或几秒前</returns>
        public static string ToDateStringFromNow(DateTime dt)
        {
            TimeSpan span = DateTime.Now - dt;
            return span.ToDateStringFromNow();
        }

        public static string ToDateStringFromNow(this TimeSpan span)
        {
            if (span.TotalDays > 60)
            {
                return "几个月前";
            }
            else if (span.TotalDays > 30)
            {
                return "1个月前";
            }
            else if (span.TotalDays > 14)
            {
                return "2周前";
            }
            else if (span.TotalDays > 7)
            {
                return "1周前";
            }
            else if (span.TotalDays > 1)
            {
                return string.Format("{0}天前", (int)Math.Floor(span.TotalDays));
            }
            else if (span.TotalHours > 1)
            {
                return string.Format("{0}小时前", (int)Math.Floor(span.TotalHours));
            }
            else if (span.TotalMinutes > 1)
            {
                return string.Format("{0}分钟前", (int)Math.Floor(span.TotalMinutes));
            }
            else if (span.TotalSeconds >= 1)
            {
                return string.Format("{0}秒前", (int)Math.Floor(span.TotalSeconds));
            }
            else
            {
                return "1秒前";
            }
        }
    }
}
