using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace MiniTips
{
    static class TipsTimeChecker
    {
        /// <summary>
        /// 如果時間到了會傳回 true
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public static bool check(MiniTipsDataSet.TipsTimeRow row)
        {
            switch ((int)row.TipType)
            {
                case 0:
                    return TipsTimeChecker.checkOnce(row);
                case 1:
                    return TipsTimeChecker.checkYear(row);
                case 2:
                    return TipsTimeChecker.checkMonth(row);
                case 3:
                    return TipsTimeChecker.checkWeek(row);
                case 4:
                    return TipsTimeChecker.checkDay(row);
                case 5:
                    return TipsTimeChecker.checkHour(row);
                default:
                    return false;
            }
        }

        private static bool checkOnce(MiniTipsDataSet.TipsTimeRow row)
        {
            DateTime nowDateTime = DateTime.Now;
            if (nowDateTime > row.TipDateTime && row.TipsRow.LastNotifiedDate < row.TipDateTime)
            {
                if (nowDateTime.Ticks < row.TipDateTime.Ticks + 100000000)
                {
                    // 應提醒時間小於現在時間 10 秒內就通知
                    return true;
                }
                else if (true == row.EnableExpireNotify)
                {
                    // 如果有設定過期通知 , 判斷是否有在延長期限內
                    Int32 ExpireTime = 10000000*((row.ExpireDay * 86400) + (row.ExpireHour * 3600) + (row.ExpireMinute * 60));

                    if (nowDateTime.Ticks < (row.TipDateTime.Ticks + ExpireTime))
                    {
                        return true;
                    }
                }
             }

            return false;
        }


        private static bool checkYear(MiniTipsDataSet.TipsTimeRow row)
        {
            DateTime nowDateTime = DateTime.Now;
            DateTime newTipsTime;

            try
            {
                newTipsTime = new DateTime(
                       nowDateTime.Year,
                       row.TipDateTime.Month,
                       row.TipDateTime.Day,
                       row.TipDateTime.Hour,
                       row.TipDateTime.Minute,
                       row.TipDateTime.Second);
            }
            catch (ArgumentOutOfRangeException e)
            {
                // 有時候小月沒有 31 日也可能會錯 , 所以傳回 false
                return false;
            }

            if (row.TipsRow.LastNotifiedDate < newTipsTime && nowDateTime > newTipsTime)
            {

                if (nowDateTime.Ticks < newTipsTime.Ticks + 100000000)
                {
                    // 應提醒時間小於現在時間 10 秒內就通知
                    return true;
                }
                else if (true == row.EnableExpireNotify)
                {
                    // 如果有設定過期通知 , 判斷是否有在延長期限內
                    Int32 ExpireTime = 10000000 * ((row.ExpireDay * 86400) + (row.ExpireHour * 3600) + (row.ExpireMinute * 60));

                    if (nowDateTime.Ticks < (newTipsTime.Ticks + ExpireTime))
                    {
                        return true;
                    }
                }

            }
            return false;
        }

        private static bool checkMonth(MiniTipsDataSet.TipsTimeRow row)
        {
            DateTime nowDateTime = DateTime.Now;
            DateTime newTipsTime;
            try
            {
                newTipsTime = new DateTime(
                           nowDateTime.Year,
                           nowDateTime.Month,
                           row.TipDateTime.Day,
                           row.TipDateTime.Hour,
                           row.TipDateTime.Minute,
                           row.TipDateTime.Second);
            }
            catch (ArgumentOutOfRangeException e)
            {
                // 有時候小月沒有 31 日也可能會錯 , 所以傳回 false
                return false;
            }
            if (row.TipsRow.LastNotifiedDate < newTipsTime && nowDateTime > newTipsTime)
            {

                if (nowDateTime.Ticks < newTipsTime.Ticks + 100000000)
                {
                    // 應提醒時間小於現在時間 10 秒內就通知
                    return true;
                }
                else if (true == row.EnableExpireNotify)
                {
                    // 如果有設定過期通知 , 判斷是否有在延長期限內
                    Int32 ExpireTime = 10000000 * ((row.ExpireDay * 86400) + (row.ExpireHour * 3600) + (row.ExpireMinute * 60));

                    if (nowDateTime.Ticks < (newTipsTime.Ticks + ExpireTime))
                    {
                        return true;
                    }
                }

            }
            return false;
        }
        private static bool checkWeek(MiniTipsDataSet.TipsTimeRow row)
        {
            DateTime nowDateTime = DateTime.Now;
            byte NowWeek = (byte)(1 << ((int)DateTime.Now.DayOfWeek));
            if ((NowWeek & row.Week) > 0)
            {
                DateTime newTipsTime = new DateTime(
                       nowDateTime.Year,
                       nowDateTime.Month,
                       nowDateTime.Day,
                       row.TipDateTime.Hour,
                       row.TipDateTime.Minute,
                       row.TipDateTime.Second);
                if (row.TipsRow.LastNotifiedDate < newTipsTime && nowDateTime > newTipsTime)
                {

                    if (nowDateTime.Ticks < newTipsTime.Ticks + 100000000)
                    {
                        // 應提醒時間小於現在時間 10 秒內就通知
                        return true;
                    }
                    else if (true == row.EnableExpireNotify)
                    {
                        // 如果有設定過期通知 , 判斷是否有在延長期限內
                        Int32 ExpireTime = 10000000 * ((row.ExpireDay * 86400) + (row.ExpireHour * 3600) + (row.ExpireMinute * 60));

                        if (nowDateTime.Ticks < (newTipsTime.Ticks + ExpireTime))
                        {
                            return true;
                        }
                    }

                }

            }
            return false;
        }
        private static bool checkDay(MiniTipsDataSet.TipsTimeRow row)
        {
            DateTime nowDateTime = DateTime.Now;
            DateTime newTipsTime;
            try
            {
                newTipsTime = new DateTime(
                           nowDateTime.Year,
                           nowDateTime.Month,
                           nowDateTime.Hour,
                           row.TipDateTime.Day,
                           row.TipDateTime.Minute,
                           row.TipDateTime.Second);
            }
            catch (ArgumentOutOfRangeException e)
            {
                // 有時候小月沒有 31 日也可能會錯 , 所以傳回 false
                return false;
            }
            if (row.TipsRow.LastNotifiedDate < newTipsTime && nowDateTime > newTipsTime)
            {

                if (nowDateTime.Ticks < newTipsTime.Ticks + 100000000)
                {
                    // 應提醒時間小於現在時間 10 秒內就通知
                    return true;
                }
                else if (true == row.EnableExpireNotify)
                {
                    // 如果有設定過期通知 , 判斷是否有在延長期限內
                    Int32 ExpireTime = 10000000 * ((row.ExpireDay * 86400) + (row.ExpireHour * 3600) + (row.ExpireMinute * 60));

                    if (nowDateTime.Ticks < (newTipsTime.Ticks + ExpireTime))
                    {
                        return true;
                    }
                }

            }
            return false;
        }

        private static bool checkHour(MiniTipsDataSet.TipsTimeRow row)
        {
            DateTime nowDateTime = DateTime.Now;
            DateTime newTipsTime;
            try
            {
                newTipsTime = new DateTime(
                           nowDateTime.Year,
                           nowDateTime.Month,
                           nowDateTime.Day,
                           nowDateTime.Hour,
                           row.TipDateTime.Minute,
                           row.TipDateTime.Second);
            }
            catch (ArgumentOutOfRangeException e)
            {
                // 有時候小月沒有 31 日也可能會錯 , 所以傳回 false
                return false;
            }
            if (row.TipsRow.LastNotifiedDate < newTipsTime && nowDateTime > newTipsTime)
            {

                if (nowDateTime.Ticks < newTipsTime.Ticks + 100000000)
                {
                    // 應提醒時間小於現在時間 10 秒內就通知
                    return true;
                }
                else if (true == row.EnableExpireNotify)
                {
                    // 如果有設定過期通知 , 判斷是否有在延長期限內
                    Int32 ExpireTime = 10000000 * ((row.ExpireDay * 86400) + (row.ExpireHour * 3600) + (row.ExpireMinute * 60));

                    if (nowDateTime.Ticks < (newTipsTime.Ticks + ExpireTime))
                    {
                        return true;
                    }
                }

            }
            return false;
        }
    }
}
