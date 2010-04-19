using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MiniTips
{
    public partial class OptionsBox : Form
    {
        public OptionsBox()
        {
            InitializeComponent();
        }

        private void button_Accept_Click(object sender, EventArgs e)
        {
            ApplicationConfig.EnableSound = this.cb_EnableSound.Checked;
            ApplicationConfig.CloseHide = this.cb_CloseHide.Checked;
            ApplicationConfig.StartupHide = this.cb_StartupHide.Checked;
            ApplicationConfig.CheckNotify = this.cb_CheckNotify.Checked;
            ApplicationConfig.CheckNotifyMinutes = (Int32)this.nud_CheckNotifyMinutes.Value;
        }


        private void OptionsBox_Load(object sender, EventArgs e)
        {
            this.cb_EnableSound.Checked = ApplicationConfig.EnableSound;
            this.cb_CloseHide.Checked = ApplicationConfig.CloseHide;
            this.cb_StartupHide.Checked = ApplicationConfig.StartupHide;
            this.cb_CheckNotify.Checked = ApplicationConfig.CheckNotify;
            this.nud_CheckNotifyMinutes.Enabled = cb_CheckNotify.Checked;
        }

        private void cb_CheckNotify_CheckedChanged(object sender, EventArgs e)
        {
            this.nud_CheckNotifyMinutes.Enabled = cb_CheckNotify.Checked;
        }



    }
}
