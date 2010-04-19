using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;
namespace MiniTips
{
    public partial class FormList : Form
    {

        private MiniTipsDataSet _ds;
        private bool _exit = false;
        private DateTime _lastCheckNotifyTime = DateTime.Now;


        public FormList()
        {


            InitializeComponent();
        }

        private void HideMe()
        {
            this.NotifyIcon_Tip.Visible = true;
            this.NotifyIcon_Tip.BalloonTipTitle = "Mini Tips 已經隱藏";
            this.NotifyIcon_Tip.BalloonTipText = "若您要打開 Mini Tips , 請於右下角Mini Tips圖示點兩下";
            this.NotifyIcon_Tip.ShowBalloonTip(1000);
            this.Visible = false;
        }

        private void FormList_Load(object sender, EventArgs e)
        {
            _ds = new MiniTipsDataSet();
            _ds.LoadUserDb();
            this.BindingSource_Tips.DataSource = this._ds.Tips;
            this.BindingSource_TipsNotified.DataSource = this._ds.TipsNotified;
            // 計時器開始
            Timer_Tip.Start();

        }
        private void FormList_Shown(object sender, EventArgs e)
        {
            if (true == ApplicationConfig.StartupHide)
            {
                this.HideMe();
            }
            else
            {
                this.Opacity = 100;
            }
        }

        private void FormList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (true == ApplicationConfig.CloseHide && false == this._exit)
            {
                this.HideMe();
                e.Cancel = true;
            }
        }


        /// <summary>
        /// 通知提醒項目
        /// </summary>
        private void TipNotifyCheck()
        {
            DateTime nowDateTime = DateTime.Now;
            UInt64 tipsCount = 0;
            string lastSubject = "";

            _ds.mutext.WaitOne();

            foreach (MiniTipsDataSet.TipsRow tipsRow in _ds.Tips)
            {
                // 判斷該提醒項目是否已經啟動
                if (true == tipsRow.Active)
                {
                    // 判斷所有提醒時間是否到了
                    foreach (MiniTipsDataSet.TipsTimeRow tipsTimeRow in tipsRow.GetTipsTimeRows())
                    {

                        if (true == TipsTimeChecker.check(tipsTimeRow))
                        {
                            // 為了怕多次提醒 , 所以只要有一時間設定到期了就退出
                            tipsRow.LastNotifiedDate = nowDateTime;
                            MiniTipsDataSet.TipsNotifiedRow tipsNotifiedRow = _ds.TipsNotified.NewTipsNotifiedRow();
                            tipsNotifiedRow.TipId = tipsRow.TipId;
                            tipsNotifiedRow.NotifiedDate = nowDateTime;
                            tipsNotifiedRow.Viewed = false;
                            _ds.TipsNotified.AddTipsNotifiedRow(tipsNotifiedRow);
                            lastSubject = tipsRow.Subject;
                            tipsCount++;
                            break;
                        }

                    }

                }

            }

            if (tipsCount > 0)
            {
                if (tipsCount > 1)
                {
                    NotifyIcon_Tip.BalloonTipTitle = "Mini Tips 提醒";
                    NotifyIcon_Tip.BalloonTipText = "您有" + tipsCount + "則的提醒項目喔\n請點我打開MiniTips觀看所有提醒項目";
                }
                else
                {
                    NotifyIcon_Tip.BalloonTipText = lastSubject;
                }

                if (true == ApplicationConfig.EnableSound)
                {
                    SystemSounds.Exclamation.Play();
                }

                // NotifyIcon_Tip.Visible = true;
                NotifyIcon_Tip.ShowBalloonTip(3000);
                _ds.SaveUserDb();
            }
            else if(ApplicationConfig.CheckNotify == true)
            {
                if (DateTime.Now.Ticks - _lastCheckNotifyTime.Ticks > (ApplicationConfig.CheckNotifyMinutes * 60 * 10000000))
                {
                    Int32 NotViewedCount = _ds.TipsNotified.Select("Viewed=False").Length;

                    // 檢查是否尚有未檢視的通知
                    if (NotViewedCount > 0)
                    {
                        NotifyIcon_Tip.BalloonTipTitle = "Mini Tips 提醒";
                        NotifyIcon_Tip.BalloonTipText = "您還有" + NotViewedCount + "則的提醒項目尚未檢視喔";
                        NotifyIcon_Tip.ShowBalloonTip(3000);
                    }
                    _lastCheckNotifyTime = DateTime.Now;
                }
            }
            _ds.mutext.ReleaseMutex();
        }

        /// <summary>
        /// Timer 事件發生 , 檢查所有的 Rows 是否有項目提醒時間到了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerTip_Tick(object sender, EventArgs e)
        {
            this.TipNotifyCheck();
        }







        /// <summary>
        /// 當使用者按下提示圖示時 , 將視窗顯示並且恢復為正常大小
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIconTip_DoubleClick(object sender, EventArgs e)
        {
            // this.NotifyIcon_Tip.Visible = false; // 關閉右下角圖案
            this.Opacity = 100;
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        /// <summary>
        /// 當使用者按下 BalloonTip , 開啟檢視通知
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotifyIcon_Tip_BalloonTipClicked(object sender, EventArgs e)
        {
            MiniTipsDataSet.TipsNotifiedRow[] row = (MiniTipsDataSet.TipsNotifiedRow[])_ds.TipsNotified.Select("Viewed=False", "NotifiedDate DESC");
            if (row.Length > 0)
            {
                NotifiedBox form = new NotifiedBox(row[0]);
                form.ShowDialog();
                this.DataGridView_Notified.Refresh();
            }
        }

        /// <summary>
        /// 新增提醒項目
        /// </summary>
        private void AddTip()
        {
            MiniTipsDataSet newDs = new MiniTipsDataSet();
            FormEditTip tipForm = new FormEditTip(newDs);

            if (DialogResult.OK == tipForm.ShowDialog())
            {
                _ds.Merge(newDs);
                this._ds.SaveUserDb();
            }
            else
            {
                this._ds.RejectChanges();
            }
            // release all resorce
            newDs.Dispose();
            tipForm.Dispose();
        }

        private void QuickButton_AddTip_Click(object sender, EventArgs e)
        {
            this.AddTip();
        }

        /// <summary>
        /// 打開編輯提醒項目 Dialog
        /// </summary>
        private void EditTip()
        {
            if (this.DataGridView_Tips.SelectedRows.Count == 0)
            {
                return;
            }

            DataRowView view = (DataRowView)this.DataGridView_Tips.SelectedRows[0].DataBoundItem;
            FormEditTip tipForm = new FormEditTip((MiniTipsDataSet.TipsRow)view.Row);
            if (DialogResult.OK == tipForm.ShowDialog())
            {
                this._ds.SaveUserDb();
            }
            // release all resorce
            tipForm.Dispose();
        }
        private void ContextMenuTip_Edit_Click(object sender, EventArgs e)
        {
            this.EditTip();
        }
        private void QuickButton_EditTip_Click(object sender, EventArgs e)
        {
            this.EditTip();
        }


        /// <summary>
        /// 刪除提醒設定
        /// </summary>
        private void DeleteTip()
        {
            if (this.DataGridView_Tips.SelectedRows.Count == 0)
            {
                return;
            }

            _ds.mutext.WaitOne();
            DataRowView rowView = (DataRowView)this.DataGridView_Tips.SelectedRows[0].DataBoundItem;
            ((MiniTipsDataSet.TipsRow)rowView.Row).Delete();
            _ds.SaveUserDb();
            _ds.mutext.ReleaseMutex();
        }
        private void ContextMenuTip_Delete_Click(object sender, EventArgs e)
        {
            this.DeleteTip();

        }
        private void QuickButton_DeleteTip_Click(object sender, EventArgs e)
        {
            this.DeleteTip();
        }

        /// <summary>
        /// 當有按下儲存格時的事件 , 這裡是做檢查 checkbox 是否有被按下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView_Tips_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataRowView rowView= (DataRowView)this.DataGridView_Tips.SelectedRows[0].DataBoundItem;
                ((MiniTipsDataSet.TipsRow)rowView.Row).Active = !(bool)this.DataGridView_Tips.CurrentCell.Value;
                _ds.AcceptChanges();
            }
        }





        /// <summary>
        /// 打開選項對話盒
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainMenu_Option_Click(object sender, EventArgs e)
        {
            OptionsBox form = new OptionsBox();
            DialogResult ret = form.ShowDialog();
        }

        /// <summary>
        /// 匯出提醒檔案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainMenu_Export_Click(object sender, EventArgs e)
        {
            // 設定初始目錄為使用者的文件夾
            this.saveFileDialog_Export.InitialDirectory = Environment.GetEnvironmentVariable("HomePath");
            DialogResult ret = this.saveFileDialog_Export.ShowDialog();
            if (ret == DialogResult.OK)
            {
                // MessageBox.Show(this.saveFileDialog_Export.FileName);
                try
                {
                    _ds.WriteXml(this.saveFileDialog_Export.FileName);
                }
                catch (System.Security.SecurityException ex)
                {
                    string errorMessage = "無法存檔 , 可能是因為權限不足+ \r\n\r\n詳細錯誤訊息如下\r\n";
                    errorMessage += ex.ToString();
                    MessageBox.Show(errorMessage, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        /// <summary>
        /// 匯入提醒檔案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainMenu_Import_Click(object sender, EventArgs e)
        {
            DialogResult ret = this.openFileDialog_Import.ShowDialog();
            if (ret == DialogResult.OK)
            {
                MiniTipsDataSet newDs = new MiniTipsDataSet();
                _ds.mutext.WaitOne();
                try
                {
                    newDs.ReadXml(this.openFileDialog_Import.FileName);
                    _ds.Merge(newDs.Tips);
                    _ds.Merge(newDs.TipsTime);
                    _ds.SaveUserDb();
                }
                catch (System.Security.SecurityException ex)
                {
                    string errorMessage = "無法讀取檔案 , 可能是因為權限不足+ \r\n\r\n詳細錯誤訊息如下\r\n";
                    errorMessage += ex.ToString();
                    MessageBox.Show(errorMessage, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                _ds.mutext.ReleaseMutex();
                newDs.Dispose();
                newDs = null;
            }
        }

        /// <summary>
        /// 離開本程式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainMenu_Exit_Click(object sender, EventArgs e)
        {
            this._exit = true;
            this.NotifyIcon_Tip.Dispose();
            this._ds.SaveUserDb();
            Application.Exit();
        }



        /// <summary>
        /// 打開 About Dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainMenu_About_Click(object sender, EventArgs e)
        {
            AboutBox box = new AboutBox();
            box.ShowDialog();
            // release all resorce
            box.Dispose();
        }






        /// <summary>
        /// 檢視通知
        /// </summary>
        private void ViewNotified()
        {
            if (this.DataGridView_Notified.SelectedRows.Count == 0)
            {
                return;
            }

            DataRowView rowView = (DataRowView)this.DataGridView_Notified.SelectedRows[0].DataBoundItem;
            NotifiedBox form = new NotifiedBox((MiniTipsDataSet.TipsNotifiedRow)rowView.Row);
            form.ShowDialog();
            this.DataGridView_Notified.Refresh();

        }

        private void ContextMenuNotified_View_Click(object sender, EventArgs e)
        {
            this.ViewNotified();
        }
        private void QuickButton_ViewNotified_Click(object sender, EventArgs e)
        {
            this.ViewNotified();
        }
        private void DataGridView_Notified_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.ViewNotified();
        }

        /// <summary>
        /// 刪除通知
        /// </summary>
        private void DeleteNotified() {

            if (this.DataGridView_Notified.SelectedRows.Count == 0)
            {
                return;
            }

            _ds.mutext.WaitOne();
            DataRowView rowView = (DataRowView)this.DataGridView_Notified.SelectedRows[0].DataBoundItem;
            ((MiniTipsDataSet.TipsNotifiedRow)rowView.Row).Delete();
            _ds.SaveUserDb();
            _ds.mutext.ReleaseMutex();
        }
        private void ContextMenuNotified_Delete_Click(object sender, EventArgs e)
        {
            this.DeleteNotified();
        }

        private void QuickButton_DeleteNotified_Click(object sender, EventArgs e)
        {
            this.DeleteNotified();
        }



        private void DataGridView_Notified_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView gridView = (DataGridView)sender;
            _ds.mutext.WaitOne();

            DataRowView rowView = (DataRowView)gridView.Rows[e.RowIndex].DataBoundItem;
            MiniTipsDataSet.TipsNotifiedRow tipsNotifiedRow = (MiniTipsDataSet.TipsNotifiedRow)rowView.Row;

            if (gridView.Columns[e.ColumnIndex].Name == "ViewedIcon" && true == tipsNotifiedRow.Viewed)
            {
                // 如果這個提示被看過了 , 那就將圖示換成空的啦
                e.Value = MiniTips.Properties.Resources.empty;

            }
            // 改變文字內容
            if (gridView.Columns[e.ColumnIndex].Name == "NotifiedDate")
            {
                e.Value = "" + tipsNotifiedRow.NotifiedDate.ToString() + " 提醒\r\n";
                e.Value += tipsNotifiedRow.TipsRow.Subject;
            }
            _ds.mutext.ReleaseMutex();
        }

        private void ContextMenuNotifyIcon_Open_Click(object sender, EventArgs e)
        {
            this.Opacity = 100;
            this.Visible = true;
        }

        private void ContextMenuNotifyIcon_Exit_Click(object sender, EventArgs e)
        {
            this._exit = true;
            Application.Exit();
        }





    }
}
