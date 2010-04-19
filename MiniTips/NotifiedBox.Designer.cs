namespace MiniTips
{
    partial class NotifiedBox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.lb_Subject = new System.Windows.Forms.Label();
            this.link_Url = new System.Windows.Forms.LinkLabel();
            this.lb_Url = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_NotifiedDate = new System.Windows.Forms.Label();
            this.lb_Description = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Cancel);
            this.panel1.Controls.Add(this.button_Delete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 247);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 39);
            this.panel1.TabIndex = 0;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(238, 9);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.Text = "關閉";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // button_Delete
            // 
            this.button_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Delete.Location = new System.Drawing.Point(157, 9);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 0;
            this.button_Delete.Text = "刪除";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // lb_Subject
            // 
            this.lb_Subject.AutoSize = true;
            this.lb_Subject.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_Subject.Location = new System.Drawing.Point(13, 13);
            this.lb_Subject.Name = "lb_Subject";
            this.lb_Subject.Size = new System.Drawing.Size(61, 16);
            this.lb_Subject.TabIndex = 1;
            this.lb_Subject.Text = "Subject";
            // 
            // link_Url
            // 
            this.link_Url.AutoSize = true;
            this.link_Url.Location = new System.Drawing.Point(79, 59);
            this.link_Url.Name = "link_Url";
            this.link_Url.Size = new System.Drawing.Size(20, 12);
            this.link_Url.TabIndex = 2;
            this.link_Url.TabStop = true;
            this.link_Url.Text = "Url";
            this.link_Url.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Url_LinkClicked);
            // 
            // lb_Url
            // 
            this.lb_Url.AutoSize = true;
            this.lb_Url.Location = new System.Drawing.Point(14, 59);
            this.lb_Url.Name = "lb_Url";
            this.lb_Url.Size = new System.Drawing.Size(59, 12);
            this.lb_Url.TabIndex = 3;
            this.lb_Url.Text = "參考網址 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "通知時間 :";
            // 
            // lb_NotifiedDate
            // 
            this.lb_NotifiedDate.AutoSize = true;
            this.lb_NotifiedDate.Location = new System.Drawing.Point(79, 38);
            this.lb_NotifiedDate.Name = "lb_NotifiedDate";
            this.lb_NotifiedDate.Size = new System.Drawing.Size(88, 12);
            this.lb_NotifiedDate.TabIndex = 5;
            this.lb_NotifiedDate.Text = "NotifiedDateTime";
            // 
            // lb_Description
            // 
            this.lb_Description.AutoSize = true;
            this.lb_Description.Location = new System.Drawing.Point(16, 84);
            this.lb_Description.Name = "lb_Description";
            this.lb_Description.Size = new System.Drawing.Size(58, 12);
            this.lb_Description.TabIndex = 6;
            this.lb_Description.Text = "Description";
            // 
            // NotifiedBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(325, 286);
            this.Controls.Add(this.lb_Description);
            this.Controls.Add(this.lb_NotifiedDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_Url);
            this.Controls.Add(this.link_Url);
            this.Controls.Add(this.lb_Subject);
            this.Controls.Add(this.panel1);
            this.Name = "NotifiedBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniTips 提醒";
            this.Load += new System.EventHandler(this.NotifiedBox_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Label lb_Subject;
        private System.Windows.Forms.LinkLabel link_Url;
        private System.Windows.Forms.Label lb_Url;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_NotifiedDate;
        private System.Windows.Forms.Label lb_Description;
    }
}