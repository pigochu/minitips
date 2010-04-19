namespace MiniTips
{
    partial class OptionsBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_EnableSound = new System.Windows.Forms.CheckBox();
            this.cb_CloseHide = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Accept = new System.Windows.Forms.Button();
            this.cb_StartupHide = new System.Windows.Forms.CheckBox();
            this.cb_CheckNotify = new System.Windows.Forms.CheckBox();
            this.nud_CheckNotifyMinutes = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CheckNotifyMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_EnableSound
            // 
            this.cb_EnableSound.AutoSize = true;
            this.cb_EnableSound.Location = new System.Drawing.Point(12, 12);
            this.cb_EnableSound.Name = "cb_EnableSound";
            this.cb_EnableSound.Size = new System.Drawing.Size(156, 16);
            this.cb_EnableSound.TabIndex = 0;
            this.cb_EnableSound.Text = "當提醒時間到時發出音效";
            this.cb_EnableSound.UseVisualStyleBackColor = true;
            // 
            // cb_CloseHide
            // 
            this.cb_CloseHide.AutoSize = true;
            this.cb_CloseHide.Location = new System.Drawing.Point(12, 34);
            this.cb_CloseHide.Name = "cb_CloseHide";
            this.cb_CloseHide.Size = new System.Drawing.Size(180, 16);
            this.cb_CloseHide.TabIndex = 1;
            this.cb_CloseHide.Text = "當關閉視窗時縮成右下角圖示";
            this.cb_CloseHide.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.button_Cancel);
            this.panel1.Controls.Add(this.button_Accept);
            this.panel1.Location = new System.Drawing.Point(16, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 40);
            this.panel1.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(260, 3);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // button_Cancel
            // 
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(182, 9);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 22;
            this.button_Cancel.Text = "取消";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // button_Accept
            // 
            this.button_Accept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_Accept.Location = new System.Drawing.Point(101, 9);
            this.button_Accept.Name = "button_Accept";
            this.button_Accept.Size = new System.Drawing.Size(75, 23);
            this.button_Accept.TabIndex = 21;
            this.button_Accept.Text = "確定";
            this.button_Accept.UseVisualStyleBackColor = true;
            this.button_Accept.Click += new System.EventHandler(this.button_Accept_Click);
            // 
            // cb_StartupHide
            // 
            this.cb_StartupHide.AutoSize = true;
            this.cb_StartupHide.Location = new System.Drawing.Point(12, 56);
            this.cb_StartupHide.Name = "cb_StartupHide";
            this.cb_StartupHide.Size = new System.Drawing.Size(228, 16);
            this.cb_StartupHide.TabIndex = 3;
            this.cb_StartupHide.Text = "啟動軟體時隱藏視窗並縮到右下角圖示";
            this.cb_StartupHide.UseVisualStyleBackColor = true;
            // 
            // cb_CheckNotify
            // 
            this.cb_CheckNotify.AutoSize = true;
            this.cb_CheckNotify.Location = new System.Drawing.Point(12, 78);
            this.cb_CheckNotify.Name = "cb_CheckNotify";
            this.cb_CheckNotify.Size = new System.Drawing.Size(252, 16);
            this.cb_CheckNotify.TabIndex = 4;
            this.cb_CheckNotify.Text = "每隔一段時間提醒使用者有尚未檢視的通知";
            this.cb_CheckNotify.UseVisualStyleBackColor = true;
            this.cb_CheckNotify.CheckedChanged += new System.EventHandler(this.cb_CheckNotify_CheckedChanged);
            // 
            // nud_CheckNotifyMinutes
            // 
            this.nud_CheckNotifyMinutes.Location = new System.Drawing.Point(51, 95);
            this.nud_CheckNotifyMinutes.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nud_CheckNotifyMinutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_CheckNotifyMinutes.Name = "nud_CheckNotifyMinutes";
            this.nud_CheckNotifyMinutes.Size = new System.Drawing.Size(45, 22);
            this.nud_CheckNotifyMinutes.TabIndex = 5;
            this.nud_CheckNotifyMinutes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "分檢查";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "每";
            // 
            // OptionsBox
            // 
            this.AcceptButton = this.button_Accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(296, 200);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_CheckNotifyMinutes);
            this.Controls.Add(this.cb_CheckNotify);
            this.Controls.Add(this.cb_StartupHide);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cb_CloseHide);
            this.Controls.Add(this.cb_EnableSound);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsBox";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Tips 選項設定";
            this.Load += new System.EventHandler(this.OptionsBox_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_CheckNotifyMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_EnableSound;
        private System.Windows.Forms.CheckBox cb_CloseHide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Accept;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.CheckBox cb_StartupHide;
        private System.Windows.Forms.CheckBox cb_CheckNotify;
        private System.Windows.Forms.NumericUpDown nud_CheckNotifyMinutes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}