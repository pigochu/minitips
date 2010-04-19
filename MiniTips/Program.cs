using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Threading;


namespace MiniTips
{

    static class Program
    {

        /// <summary>
        /// Main Program
        /// </summary>
        [STAThread]
        static void Main()
        {

            // 用具名 Mutex 去判斷是否有相同程式執行 , 若有則離開
            // 這樣的做法是為了怕同時開多個本程式視窗出來
            bool flag = false;
            Mutex m = new Mutex(true, "MiniTips Mutex" , out flag);
            if (!flag)
            {
                Environment.Exit(1);
            }

            ApplicationConfig.LoadConfig();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormList());

            ApplicationConfig.SaveConfig();

        }
    }


}
