using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace MiniTips
{

    public partial class FormEditTip : Form
    {

        private MiniTipsDataSet _ds;
        private MiniTipsDataSet.TipsRow _tipsRow;

        /// <summary>
        /// 如果傳入 DataSet 型別 , 代表新增
        /// </summary>
        /// <param name="ds"></param>
        public FormEditTip(MiniTipsDataSet ds)
        {
            _ds = ds;
            _tipsRow = _ds.Tips.NewTipsRow();
            _tipsRow.TipId = (UInt64)DateTime.Now.Ticks;
            _tipsRow.Subject = "";
            _tipsRow.Description = "";
            _tipsRow.Url = "http://";
            _tipsRow.CreateDate = DateTime.Now;
            _tipsRow.LastNotifiedDate = _tipsRow.CreateDate;
            _ds.Tips.Rows.Add(_tipsRow);
            InitializeComponent();
        }

        /// <summary>
        /// 如果傳入 DataRow , 代表編輯
        /// </summary>
        /// <param name="row"></param>
        public FormEditTip(MiniTipsDataSet.TipsRow row)
        {
            _tipsRow = row;
            this._ds = (MiniTipsDataSet)row.Table.DataSet;
            InitializeComponent();
        }

        private void FormEditTip_Load(object sender, EventArgs e)
        {
            // 設定欄位的值
            this.bs_TipsTime.DataSource = _ds.TipsTime;
            this.bs_TipsTime.Filter = "TipId ='" + _tipsRow.TipId +"'";

            this.cbActive.Checked = _tipsRow.Active;
            this.tbSubject.Text = _tipsRow.Subject;
            this.tbDescription.Text = _tipsRow.Description;
            this.tbUrl.Text = _tipsRow.Url;

        }


        /// <summary>
        /// 檢查欄位的資料是否輸入正確
        /// </summary>
        private bool vaildData()
        {
            string caption = "錯誤提示";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Error;

            // 檢查是否有輸入標題
            if ("" == this.tbSubject.Text)
            {
                MessageBox.Show("必須輸入標題", caption, buttons, icon);
                this.tbSubject.Focus();
                return false;
            }

            // 檢查是否有輸入提醒內容
            if ("" == this.tbDescription.Text)
            {
                MessageBox.Show("必須輸入提醒內容", caption, buttons, icon);
                this.tbDescription.Focus();
                return false;
            }

            // TODO : check URL


            return true;

        }


        private void Save()
        {
            _tipsRow.Subject = this.tbSubject.Text;
            _tipsRow.Description = this.tbDescription.Text;
            _tipsRow.Url = this.tbUrl.Text;
            _tipsRow.Active = this.cbActive.Checked;
            _tipsRow.CreateDate = DateTime.Now;
            _tipsRow.LastNotifiedDate = _tipsRow.CreateDate;
        }

        /// <summary>
        /// 儲存提示資料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSave_Click(object sender, EventArgs e)
        {

            if (true == this.vaildData())
            {
                this.Save();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            _ds.mutext.WaitOne();
            _tipsRow.Delete();
            _ds.mutext.ReleaseMutex();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonNewTime_Click(object sender, EventArgs e)
        {

            MiniTipsDataSet.TipsTimeRow tipsTimeRow = ((MiniTipsDataSet)this._tipsRow.Table.DataSet).TipsTime.NewTipsTimeRow();
            tipsTimeRow.TipId = _tipsRow.TipId;
            tipsTimeRow.Week = (byte)0;
            tipsTimeRow.TipDateTime = DateTime.Now;
            tipsTimeRow.TipType = 0;
            tipsTimeRow.EnableExpireNotify = false;
            tipsTimeRow.ExpireDay = 0;
            tipsTimeRow.ExpireHour = 0;
            tipsTimeRow.ExpireMinute = 0;


            FormWizardTipTime form = new FormWizardTipTime(tipsTimeRow);
            DialogResult ret = form.ShowDialog();
            _ds.mutext.WaitOne();
            if (ret == DialogResult.OK)
            {
                tipsTimeRow.SetParentRow(_tipsRow);
                tipsTimeRow.TipTimeId = (UInt64)DateTime.Now.Ticks;
                ((MiniTipsDataSet.TipsTimeDataTable)tipsTimeRow.Table).AddTipsTimeRow(tipsTimeRow);
            }
            else
            {
                tipsTimeRow.Delete();
            }
            _ds.mutext.WaitOne();
            form.Dispose();
        }


        private void onEditTipsTime(object sender, EventArgs e) {

            if (this.dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            MiniTipsDataSet.TipsTimeRow row = (MiniTipsDataSet.TipsTimeRow)((DataRowView)this.dataGridView1.SelectedRows[0].DataBoundItem).Row;
            FormWizardTipTime form = new FormWizardTipTime(row);
            DialogResult ret = form.ShowDialog();
            if (ret == DialogResult.OK)
            {
                this.dataGridView1.Refresh();
            }
        }


        private void onDeleteTipsTime(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            _ds.mutext.WaitOne();
            DataRowView rowView = (DataRowView)this.dataGridView1.SelectedRows[0].DataBoundItem;
            rowView.Delete();
            _ds.mutext.ReleaseMutex();
        }



        private void contextMenuTipsTime_Opening(object sender, CancelEventArgs e)
        {
            // datagridview 中若沒有任何一列被選取 , 就取消動作
            if (this.dataGridView1.SelectedRows.Count == 0)
            {
                e.Cancel = true;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView gridView = (DataGridView)sender;

            _ds.mutext.WaitOne();
            if (gridView.Columns[e.ColumnIndex].Name == "TipType")
            {
                Int32 tipType = (Int32)e.Value;
                if (tipType == 0)
                {
                    e.Value = "一次";
                }
                else if (tipType == 1)
                {
                    e.Value = "每年";
                }
                else if (tipType == 2)
                {
                    e.Value = "每月";
                }
                else if (tipType == 3)
                {
                    e.Value = "每周";
                }
                else if (tipType == 4)
                {
                    e.Value = "每日";
                }
                else if (tipType == 5)
                {
                    e.Value = "每小時";
                }

            }
            if (gridView.Columns[e.ColumnIndex].Name == "TipsTimeDescription" )
            {
                MiniTipsDataSet.TipsTimeRow tipsTimeRow;
                try
                {
                    DataRowView rowView = (DataRowView)gridView.Rows[e.RowIndex].DataBoundItem;
                    tipsTimeRow = (MiniTipsDataSet.TipsTimeRow)rowView.Row;
                }
                catch(Exception ex)
                {
                    return;
                }


                if (tipsTimeRow.TipType == 0)
                {
                    e.Value = "" + tipsTimeRow.TipDateTime.Year + "年"
                        + tipsTimeRow.TipDateTime.Month + "月"
                        + tipsTimeRow.TipDateTime.Day + "日"
                        + tipsTimeRow.TipDateTime.Hour + "時"
                        + tipsTimeRow.TipDateTime.Minute + "分"
                        + tipsTimeRow.TipDateTime.Second + "秒執行";
                }
                else if (tipsTimeRow.TipType == 1)
                {
                    e.Value = "每年的"
                        + tipsTimeRow.TipDateTime.Month + "月"
                        + tipsTimeRow.TipDateTime.Day + "日"
                        + tipsTimeRow.TipDateTime.Hour + "時"
                        + tipsTimeRow.TipDateTime.Minute + "分"
                        + tipsTimeRow.TipDateTime.Second + "秒執行";
                }
                else if (tipsTimeRow.TipType == 2)
                {
                    e.Value = "每月的"
                        + tipsTimeRow.TipDateTime.Day + "日"
                        + tipsTimeRow.TipDateTime.Hour + "時"
                        + tipsTimeRow.TipDateTime.Minute + "分"
                        + tipsTimeRow.TipDateTime.Second + "秒執行";
                }
                else if (tipsTimeRow.TipType == 3)
                {
                    e.Value = "每周";

                    if ((tipsTimeRow.Week & 1) > 0)
                    {
                        e.Value += " 日";
                    }
                    if ((tipsTimeRow.Week & 2) > 0)
                    {
                        e.Value += " 一";
                    }
                    if ((tipsTimeRow.Week & 4) > 0)
                    {
                        e.Value += " 二";
                    }
                    if ((tipsTimeRow.Week & 8) > 0)
                    {
                        e.Value += " 三";
                    }
                    if ((tipsTimeRow.Week & 16) > 0)
                    {
                        e.Value += " 四";
                    }
                    if ((tipsTimeRow.Week & 32) > 0)
                    {
                        e.Value += " 五";
                    }
                    if ((tipsTimeRow.Week & 64) > 0)
                    {
                        e.Value += " 六";
                    }


                    e.Value += " 的"
                        + tipsTimeRow.TipDateTime.Hour + "時"
                        + tipsTimeRow.TipDateTime.Minute + "分"
                        + tipsTimeRow.TipDateTime.Second + "秒執行";
                }
                else if (tipsTimeRow.TipType == 4)
                {
                    e.Value = "每日的"
                        + tipsTimeRow.TipDateTime.Hour + "時"
                        + tipsTimeRow.TipDateTime.Minute + "分"
                        + tipsTimeRow.TipDateTime.Second + "秒執行";
                }
                else if (tipsTimeRow.TipType == 5)
                {
                    e.Value = "每小時的"
                        + tipsTimeRow.TipDateTime.Minute + "分"
                        + tipsTimeRow.TipDateTime.Second + "秒執行";
                }

            }
            _ds.mutext.ReleaseMutex();
        }





    }
}
