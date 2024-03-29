﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDateTimeDealWith
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = "20220527";

            DateTime result;
            var check = DateTime.TryParseExact(date,"yyyyMMdd", new CultureInfo("zh-TW"), DateTimeStyles.None , out result);
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

        /// <summary>
        /// 取得yyyyMMddHHmmss
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public string GetDateTimeString_yyyyMMddHHmmss(DateTime datetime)
        {
            return datetime.ToString("yyyyMMddHHmmss");
        }

        /// <summary>
        /// 取得yyyyMMdd
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public string GetDateTimeString_yyyyMMdd(DateTime datetime)
        {
            return datetime.ToString("yyyyMMdd");
        }

        /// <summary>
        /// 透過字串 轉型成日期格式
        /// </summary>
        /// <param name="dateStr"></param>
        /// <returns></returns>
        public DateTime StringConvertToDateTime(string dateStr)
        {
            return StringConvertToDateTimeByFormat(dateStr, "yyyyMMdd");
        }

        /// <summary>
        /// 透過字串 格式 轉型成日期格式
        /// </summary>
        /// <param name="dateStr"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public DateTime StringConvertToDateTimeByFormat(string dateStr,string format)
        {
            return DateTime.ParseExact(dateStr, format, null, System.Globalization.DateTimeStyles.AllowWhiteSpaces);
        }
    }
}
