using System;
using System.IO;
using System.Windows.Forms;
using System.Threading;
namespace MiniTips {
    
    
    public partial class ConfigDataSet {


        private Mutex _mutex = new Mutex();
        private string _dbfile = Environment.GetEnvironmentVariable("LOCALAPPDATA") + "/MiniTips/config.xml";

        /// <summary>
        /// 為了怕程式中有其它執行緒更新資料 , 所以可以呼叫 Mutex 來鎖定資料
        /// </summary>
        public Mutex mutext
        {
            get
            {
                return _mutex;
            }
        }

        public void LoadUserDb()
        {
            if (File.Exists(_dbfile))
            {
                this.ReadXml(_dbfile);
            }
            else
            {
                Directory.CreateDirectory(Environment.GetEnvironmentVariable("LOCALAPPDATA") + "/MiniTips");
            }


            this.AcceptChanges();
        }

        public void SaveUserDb()
        {
            this.AcceptChanges();
            this.WriteXml(_dbfile);
        }
    }

}
