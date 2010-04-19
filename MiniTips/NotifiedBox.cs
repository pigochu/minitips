using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace MiniTips
{
    public partial class NotifiedBox : Form
    {

        private MiniTipsDataSet.TipsNotifiedRow _tipsNotifiedRow;

        public NotifiedBox(MiniTipsDataSet.TipsNotifiedRow row)
        {
            InitializeComponent();
            _tipsNotifiedRow = row;
        }

        private void NotifiedBox_Load(object sender, EventArgs e)
        {
            MiniTipsDataSet.TipsRow tipsRow;
            tipsRow = _tipsNotifiedRow.TipsRow;

            _tipsNotifiedRow.Viewed = true; // 設定為已經看過

            this.lb_Subject.Text = tipsRow.Subject;

            if (tipsRow.Url == "" || tipsRow.Url == "http://" || tipsRow.Url == "https://")
            {
                this.link_Url.Visible = false;
            }
            else
            {
                this.link_Url.Text = tipsRow.Url;
            }

            this.lb_NotifiedDate.Text = _tipsNotifiedRow.NotifiedDate.ToLongTimeString();
            this.lb_Description.Text = tipsRow.Description;

        }

        private void link_Url_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Process.Start( this.link_Url.Text );
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            MiniTipsDataSet ds = (MiniTipsDataSet)_tipsNotifiedRow.Table.DataSet;
            ds.mutext.WaitOne();
            _tipsNotifiedRow.Delete();
            _tipsNotifiedRow.AcceptChanges();
            ds.mutext.ReleaseMutex();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
