using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDateTimeDealWith
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        /// <summary>
        /// 取得兩日期相差幾天
        /// </summary>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <returns></returns>
        public int GetDays(DateTime dateFrom , DateTime dateTo)
        {
            return new TimeSpan(dateTo.Ticks - dateFrom.Ticks).Days;
        }

        /// <summary>
        /// 取得兩日期差的精確天數
        /// </summary>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <returns></returns>
        public double GetTotalDays(DateTime dateFrom, DateTime dateTo)
        {
            return new TimeSpan(dateTo.Ticks - dateFrom.Ticks).TotalDays;
        }

        /// <summary>
        /// 取得兩日期差的小時數
        /// </summary>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <returns></returns>
        public double GetTotalHours(DateTime dateFrom, DateTime dateTo)
        {
            return new TimeSpan(dateTo.Ticks - dateFrom.Ticks).TotalHours;
        }

        /// <summary>
        /// 取得兩日期差的分鐘數
        /// </summary>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <returns></returns>
        public double GetTotalMinutes(DateTime dateFrom, DateTime dateTo)
        {
            return new TimeSpan(dateTo.Ticks - dateFrom.Ticks).TotalMinutes;
        }

        /// <summary>
        /// 取得兩日期差的秒數
        /// </summary>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <returns></returns>
        public double GetTotalSeconds(DateTime dateFrom, DateTime dateTo)
        {
            return new TimeSpan(dateTo.Ticks - dateFrom.Ticks).TotalSeconds;
        }

        /// <summary>
        /// 取得兩日期差的豪秒數
        /// </summary>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <returns></returns>
        public double GetTotalMilliseconds(DateTime dateFrom, DateTime dateTo)
        {
            return new TimeSpan(dateTo.Ticks - dateFrom.Ticks).TotalMilliseconds;
        }
    }
}
