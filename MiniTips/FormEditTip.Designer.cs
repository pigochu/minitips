namespace MiniTips
{
    partial class FormEditTip
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
            this.components = new System.ComponentModel.Container();
            this.lbSubject = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.lbTipText = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lbUrl = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TipType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuTipsTime = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmi_EditTipsTime = new System.Windows.Forms.ToolStripMenuItem();
            this.tmi_DeleteTipsTime = new System.Windows.Forms.ToolStripMenuItem();
            this.TipsTimeDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_TipsTime = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDeleteTime = new System.Windows.Forms.Button();
            this.buttonEditTime = new System.Windows.Forms.Button();
            this.buttonNewTime = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuTipsTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_TipsTime)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Location = new System.Drawing.Point(12, 9);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(59, 12);
            this.lbSubject.TabIndex = 0;
            this.lbSubject.Text = "提醒標題 :";
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(77, 6);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(379, 22);
            this.tbSubject.TabIndex = 1;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(300, 446);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 101;
            this.btSave.Text = "儲存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClose
            // 
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.Location = new System.Drawing.Point(381, 446);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 102;
            this.btClose.Text = "取消";
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // lbTipText
            // 
            this.lbTipText.AutoSize = true;
            this.lbTipText.Location = new System.Drawing.Point(12, 37);
            this.lbTipText.Name = "lbTipText";
            this.lbTipText.Size = new System.Drawing.Size(59, 12);
            this.lbTipText.TabIndex = 5;
            this.lbTipText.Text = "提醒內容 :";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(77, 34);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(379, 96);
            this.tbDescription.TabIndex = 2;
            // 
            // lbUrl
            // 
            this.lbUrl.AutoSize = true;
            this.lbUrl.Location = new System.Drawing.Point(12, 139);
            this.lbUrl.Name = "lbUrl";
            this.lbUrl.Size = new System.Drawing.Size(59, 12);
            this.lbUrl.TabIndex = 7;
            this.lbUrl.Text = "參考網址 :";
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(77, 136);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(379, 22);
            this.tbUrl.TabIndex = 3;
            this.tbUrl.Text = "http://";
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Location = new System.Drawing.Point(12, 419);
            this.cbActive.Name = "cbActive";
            this.cbActive.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbActive.Size = new System.Drawing.Size(191, 16);
            this.cbActive.TabIndex = 10;
            this.cbActive.Text = "啟用(必須勾選,本提醒才會生效)";
            this.cbActive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btDelete.Location = new System.Drawing.Point(220, 446);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 100;
            this.btDelete.Text = "刪除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Visible = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.buttonDeleteTime);
            this.groupBox1.Controls.Add(this.buttonEditTime);
            this.groupBox1.Controls.Add(this.buttonNewTime);
            this.groupBox1.Location = new System.Drawing.Point(14, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 239);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "提醒時間設定";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipType,
            this.TipsTimeDescription});
            this.dataGridView1.DataSource = this.bs_TipsTime;
            this.dataGridView1.Location = new System.Drawing.Point(6, 50);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(430, 183);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // TipType
            // 
            this.TipType.ContextMenuStrip = this.contextMenuTipsTime;
            this.TipType.DataPropertyName = "TipType";
            this.TipType.HeaderText = "類型";
            this.TipType.Name = "TipType";
            // 
            // contextMenuTipsTime
            // 
            this.contextMenuTipsTime.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmi_EditTipsTime,
            this.tmi_DeleteTipsTime});
            this.contextMenuTipsTime.Name = "contextMenuTipsTime";
            this.contextMenuTipsTime.Size = new System.Drawing.Size(101, 48);
            this.contextMenuTipsTime.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuTipsTime_Opening);
            // 
            // tmi_EditTipsTime
            // 
            this.tmi_EditTipsTime.Name = "tmi_EditTipsTime";
            this.tmi_EditTipsTime.Size = new System.Drawing.Size(100, 22);
            this.tmi_EditTipsTime.Text = "編輯";
            this.tmi_EditTipsTime.Click += new System.EventHandler(this.onEditTipsTime);
            // 
            // tmi_DeleteTipsTime
            // 
            this.tmi_DeleteTipsTime.Name = "tmi_DeleteTipsTime";
            this.tmi_DeleteTipsTime.Size = new System.Drawing.Size(100, 22);
            this.tmi_DeleteTipsTime.Text = "刪除";
            this.tmi_DeleteTipsTime.Click += new System.EventHandler(this.onDeleteTipsTime);
            // 
            // TipsTimeDescription
            // 
            this.TipsTimeDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TipsTimeDescription.ContextMenuStrip = this.contextMenuTipsTime;
            this.TipsTimeDescription.HeaderText = "內容";
            this.TipsTimeDescription.Name = "TipsTimeDescription";
            this.TipsTimeDescription.ReadOnly = true;
            // 
            // bs_TipsTime
            // 
            this.bs_TipsTime.DataMember = "TipsTime";
            this.bs_TipsTime.DataSource = typeof(MiniTips.MiniTipsDataSet);
            // 
            // buttonDeleteTime
            // 
            this.buttonDeleteTime.Location = new System.Drawing.Point(344, 21);
            this.buttonDeleteTime.Name = "buttonDeleteTime";
            this.buttonDeleteTime.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteTime.TabIndex = 7;
            this.buttonDeleteTime.Text = "刪除";
            this.buttonDeleteTime.UseVisualStyleBackColor = true;
            this.buttonDeleteTime.Click += new System.EventHandler(this.onDeleteTipsTime);
            // 
            // buttonEditTime
            // 
            this.buttonEditTime.Location = new System.Drawing.Point(263, 21);
            this.buttonEditTime.Name = "buttonEditTime";
            this.buttonEditTime.Size = new System.Drawing.Size(75, 23);
            this.buttonEditTime.TabIndex = 6;
            this.buttonEditTime.Text = "編輯";
            this.buttonEditTime.UseVisualStyleBackColor = true;
            this.buttonEditTime.Click += new System.EventHandler(this.onEditTipsTime);
            // 
            // buttonNewTime
            // 
            this.buttonNewTime.Location = new System.Drawing.Point(182, 21);
            this.buttonNewTime.Name = "buttonNewTime";
            this.buttonNewTime.Size = new System.Drawing.Size(75, 23);
            this.buttonNewTime.TabIndex = 5;
            this.buttonNewTime.Text = "新增";
            this.buttonNewTime.UseVisualStyleBackColor = true;
            this.buttonNewTime.Click += new System.EventHandler(this.buttonNewTime_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Table";
            this.dataGridViewTextBoxColumn1.HeaderText = "Table";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Table";
            this.dataGridViewTextBoxColumn2.HeaderText = "Table";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // FormEditTip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(487, 482);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.cbActive);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.lbUrl);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lbTipText);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.lbSubject);
            this.Name = "FormEditTip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "編輯提醒內容";
            this.Load += new System.EventHandler(this.FormEditTip_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuTipsTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs_TipsTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label lbTipText;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lbUrl;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDeleteTime;
        private System.Windows.Forms.Button buttonEditTime;
        private System.Windows.Forms.Button buttonNewTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ContextMenuStrip contextMenuTipsTime;
        private System.Windows.Forms.ToolStripMenuItem tmi_EditTipsTime;
        private System.Windows.Forms.ToolStripMenuItem tmi_DeleteTipsTime;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bs_TipsTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipType;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipsTimeDescription;
    }
}