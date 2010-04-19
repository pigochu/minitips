using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
namespace MiniTips
{
    /// <summary>
    /// 應用程式設定
    /// </summary>
    class ApplicationConfig
    {

        private static ConfigDataSet _ds;
        private static bool _enableSound = false;
        private static bool _closeHide = true;
        private static bool _startupHide = false;
        private static bool _checkNotify = false;
        private static Int32 _checkNotifyMinutes = 5;



        /// <summary>
        /// 取得或設定是否要啟用提醒音效
        /// </summary>
        public static bool EnableSound
        {
            get
            {
                return _enableSound;
            }
            set
            {
                _enableSound = value;
            }
        }


        /// <summary>
        /// 取得或設定是否當使用者按下關閉按鈕時 , 隱藏 form 並縮到右下角圖示
        /// </summary>
        public static bool CloseHide
        {
            get
            {
                return _closeHide;
            }
            set
            {
                _closeHide = value;
            }
        }

        /// <summary>
        /// 取得或設定當啟動程式時馬上隱藏視窗 , 並且縮到右下角
        /// </summary>
        public static bool StartupHide
        {
            get
            {
                return _startupHide;
            }
            set
            {
                _startupHide = value;
            }
        }


        /// <summary>
        /// 設定每隔一段時間是否檢查有尚未檢視的通知
        /// </summary>
        public static bool CheckNotify
        {
            get
            {
                return _checkNotify;
            }
            set
            {
                _checkNotify = value;
            }
        }

        public static Int32 CheckNotifyMinutes
        {
            get
            {
                return _checkNotifyMinutes;
            }
            set
            {
                _checkNotifyMinutes = value;
            }

        }

        public static void LoadConfig() {
            _ds = new ConfigDataSet();
            _ds.LoadUserDb();

            ConfigDataSet.OptionsRow row;
            
            row = (ConfigDataSet.OptionsRow)_ds.Options.Rows.Find("ENABLE_SOUND");
            if (row != null)
            {
                _enableSound = bool.Parse(row.Value);
            }
            row = (ConfigDataSet.OptionsRow)_ds.Options.Rows.Find("CLOSE_HIDE");
            if (row != null)
            {
                _closeHide = bool.Parse(row.Value);
            }

            row = (ConfigDataSet.OptionsRow)_ds.Options.Rows.Find("STARTUP_HIDE");
            if (row != null)
            {
                _startupHide = bool.Parse(row.Value);
            }

            row = (ConfigDataSet.OptionsRow)_ds.Options.Rows.Find("CHECK_NOTIFY");
            if (row != null)
            {
                _checkNotify = bool.Parse(row.Value);
            }
            row = (ConfigDataSet.OptionsRow)_ds.Options.Rows.Find("CHECK_NOTIFY_MINUTES");
            if (row != null)
            {
                _checkNotifyMinutes = Int32.Parse(row.Value);
            }

        }

        public static void SaveConfig()
        {
            ConfigDataSet.OptionsRow row;
            row = (ConfigDataSet.OptionsRow)_ds.Options.Rows.Find("ENABLE_SOUND");
            if (row == null)
            {
                ConfigDataSet.OptionsRow newRow = _ds.Options.NewOptionsRow();
                newRow.Key = "ENABLE_SOUND";
                newRow.Value = _enableSound.ToString();
                _ds.Options.AddOptionsRow(newRow);
                
            }
            else
            {
                row.Key = "ENABLE_SOUND";
                row.Value = _enableSound.ToString();  
            }

            row = (ConfigDataSet.OptionsRow)_ds.Options.Rows.Find("CLOSE_HIDE");
            if (row == null)
            {
                ConfigDataSet.OptionsRow newRow = _ds.Options.NewOptionsRow();
                newRow.Key = "CLOSE_HIDE";
                newRow.Value = _closeHide.ToString();
                _ds.Options.AddOptionsRow(newRow);

            }
            else
            {
                row.Key = "CLOSE_HIDE";
                row.Value = _closeHide.ToString();
            }

            row = (ConfigDataSet.OptionsRow)_ds.Options.Rows.Find("STARTUP_HIDE");
            if (row == null)
            {
                ConfigDataSet.OptionsRow newRow = _ds.Options.NewOptionsRow();
                newRow.Key = "STARTUP_HIDE";
                newRow.Value = _startupHide.ToString();
                _ds.Options.AddOptionsRow(newRow);
            }
            else
            {
                row.Key = "STARTUP_HIDE";
                row.Value = _startupHide.ToString();
            }

            row = (ConfigDataSet.OptionsRow)_ds.Options.Rows.Find("CHECK_NOTIFY");
            if (row == null)
            {
                ConfigDataSet.OptionsRow newRow = _ds.Options.NewOptionsRow();
                newRow.Key = "CHECK_NOTIFY";
                newRow.Value = _checkNotify.ToString();
                _ds.Options.AddOptionsRow(newRow);
            }
            else
            {
                row.Key = "CHECK_NOTIFY";
                row.Value = _checkNotify.ToString();
            }


            row = (ConfigDataSet.OptionsRow)_ds.Options.Rows.Find("CHECK_NOTIFY_MINUTES");
            if (row == null)
            {
                ConfigDataSet.OptionsRow newRow = _ds.Options.NewOptionsRow();
                newRow.Key = "CHECK_NOTIFY_MINUTES";
                newRow.Value = _checkNotifyMinutes.ToString();
                _ds.Options.AddOptionsRow(newRow);
            }
            else
            {
                row.Key = "CHECK_NOTIFY_MINUTES";
                row.Value = _checkNotifyMinutes.ToString();
            }

            _ds.SaveUserDb();
        }

        


    }
}
