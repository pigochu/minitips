namespace MiniTips
{
    partial class FormList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NotifyIcon_Tip = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenuNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuNotifyIcon_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuNotifyIcon_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Timer_Tip = new System.Windows.Forms.Timer(this.components);
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ContextMenu_Tip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuTip_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuTip_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.NextTicks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridView_Tips = new System.Windows.Forms.DataGridView();
            this.activeDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.subjectDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BindingSource_Tips = new System.Windows.Forms.BindingSource(this.components);
            this.ContextMenu_Notified = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuNotified_View = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuNotified_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MainMenu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_Export = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_Import = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_Options = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.QuickButtonBar_Tips = new System.Windows.Forms.ToolStrip();
            this.QuickButton_AddTip = new System.Windows.Forms.ToolStripButton();
            this.QuickButton_EditTip = new System.Windows.Forms.ToolStripButton();
            this.QuickButton_DeleteTip = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridView_Notified = new System.Windows.Forms.DataGridView();
            this.ViewedIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.NotifiedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BindingSource_TipsNotified = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.QuickButtonBar_Notified = new System.Windows.Forms.ToolStrip();
            this.QuickButton_ViewNotified = new System.Windows.Forms.ToolStripButton();
            this.QuickButton_DeleteNotified = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog_Import = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_Export = new System.Windows.Forms.SaveFileDialog();
            this.ContextMenuNotifyIcon.SuspendLayout();
            this.ContextMenu_Tip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Tips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_Tips)).BeginInit();
            this.ContextMenu_Notified.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.QuickButtonBar_Tips.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Notified)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_TipsNotified)).BeginInit();
            this.panel2.SuspendLayout();
            this.QuickButtonBar_Notified.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotifyIcon_Tip
            // 
            this.NotifyIcon_Tip.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.NotifyIcon_Tip.BalloonTipText = "時間到了喔";
            this.NotifyIcon_Tip.BalloonTipTitle = "Mini Tips 提醒";
            this.NotifyIcon_Tip.ContextMenuStrip = this.ContextMenuNotifyIcon;
            this.NotifyIcon_Tip.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon_Tip.Icon")));
            this.NotifyIcon_Tip.Text = "Mini Tips 提醒";
            this.NotifyIcon_Tip.Visible = true;
            this.NotifyIcon_Tip.BalloonTipClicked += new System.EventHandler(this.NotifyIcon_Tip_BalloonTipClicked);
            this.NotifyIcon_Tip.DoubleClick += new System.EventHandler(this.notifyIconTip_DoubleClick);
            // 
            // ContextMenuNotifyIcon
            // 
            this.ContextMenuNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuNotifyIcon_Open,
            this.ContextMenuNotifyIcon_Exit});
            this.ContextMenuNotifyIcon.Name = "ContextMenuNotifyIcon";
            this.ContextMenuNotifyIcon.Size = new System.Drawing.Size(152, 48);
            // 
            // ContextMenuNotifyIcon_Open
            // 
            this.ContextMenuNotifyIcon_Open.Name = "ContextMenuNotifyIcon_Open";
            this.ContextMenuNotifyIcon_Open.Size = new System.Drawing.Size(151, 22);
            this.ContextMenuNotifyIcon_Open.Text = "打開 MiniTips";
            this.ContextMenuNotifyIcon_Open.Click += new System.EventHandler(this.ContextMenuNotifyIcon_Open_Click);
            // 
            // ContextMenuNotifyIcon_Exit
            // 
            this.ContextMenuNotifyIcon_Exit.Name = "ContextMenuNotifyIcon_Exit";
            this.ContextMenuNotifyIcon_Exit.Size = new System.Drawing.Size(151, 22);
            this.ContextMenuNotifyIcon_Exit.Text = "離開";
            this.ContextMenuNotifyIcon_Exit.Click += new System.EventHandler(this.ContextMenuNotifyIcon_Exit_Click);
            // 
            // Timer_Tip
            // 
            this.Timer_Tip.Interval = 2000;
            this.Timer_Tip.Tick += new System.EventHandler(this.TimerTip_Tick);
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.ContextMenuStrip = this.ContextMenu_Tip;
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "啟動";
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            // 
            // ContextMenu_Tip
            // 
            this.ContextMenu_Tip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuTip_Edit,
            this.ContextMenuTip_Delete});
            this.ContextMenu_Tip.Name = "contextMenuTipItem";
            this.ContextMenu_Tip.Size = new System.Drawing.Size(101, 48);
            // 
            // ContextMenuTip_Edit
            // 
            this.ContextMenuTip_Edit.Name = "ContextMenuTip_Edit";
            this.ContextMenuTip_Edit.Size = new System.Drawing.Size(100, 22);
            this.ContextMenuTip_Edit.Text = "編輯";
            this.ContextMenuTip_Edit.Click += new System.EventHandler(this.ContextMenuTip_Edit_Click);
            // 
            // ContextMenuTip_Delete
            // 
            this.ContextMenuTip_Delete.Name = "ContextMenuTip_Delete";
            this.ContextMenuTip_Delete.Size = new System.Drawing.Size(100, 22);
            this.ContextMenuTip_Delete.Text = "刪除";
            this.ContextMenuTip_Delete.Click += new System.EventHandler(this.ContextMenuTip_Delete_Click);
            // 
            // NextTicks
            // 
            this.NextTicks.ContextMenuStrip = this.ContextMenu_Tip;
            this.NextTicks.HeaderText = "下次提醒時間";
            this.NextTicks.Name = "NextTicks";
            this.NextTicks.ReadOnly = true;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.ContextMenuStrip = this.ContextMenu_Tip;
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "提醒標題";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.ContextMenuStrip = this.ContextMenu_Tip;
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "類型";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // DataGridView_Tips
            // 
            this.DataGridView_Tips.AllowUserToAddRows = false;
            this.DataGridView_Tips.AllowUserToDeleteRows = false;
            this.DataGridView_Tips.AutoGenerateColumns = false;
            this.DataGridView_Tips.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView_Tips.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_Tips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Tips.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.activeDataGridViewCheckBoxColumn1,
            this.subjectDataGridViewTextBoxColumn1,
            this.createDateDataGridViewTextBoxColumn});
            this.DataGridView_Tips.DataSource = this.BindingSource_Tips;
            this.DataGridView_Tips.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_Tips.Location = new System.Drawing.Point(0, 53);
            this.DataGridView_Tips.MinimumSize = new System.Drawing.Size(300, 0);
            this.DataGridView_Tips.MultiSelect = false;
            this.DataGridView_Tips.Name = "DataGridView_Tips";
            this.DataGridView_Tips.ReadOnly = true;
            this.DataGridView_Tips.RowHeadersVisible = false;
            this.DataGridView_Tips.RowTemplate.Height = 24;
            this.DataGridView_Tips.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_Tips.Size = new System.Drawing.Size(400, 331);
            this.DataGridView_Tips.TabIndex = 2;
            this.DataGridView_Tips.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Tips_CellContentClick);
            // 
            // activeDataGridViewCheckBoxColumn1
            // 
            this.activeDataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.activeDataGridViewCheckBoxColumn1.ContextMenuStrip = this.ContextMenu_Tip;
            this.activeDataGridViewCheckBoxColumn1.DataPropertyName = "Active";
            this.activeDataGridViewCheckBoxColumn1.HeaderText = "啟用";
            this.activeDataGridViewCheckBoxColumn1.MinimumWidth = 40;
            this.activeDataGridViewCheckBoxColumn1.Name = "activeDataGridViewCheckBoxColumn1";
            this.activeDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.activeDataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.activeDataGridViewCheckBoxColumn1.Width = 40;
            // 
            // subjectDataGridViewTextBoxColumn1
            // 
            this.subjectDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subjectDataGridViewTextBoxColumn1.ContextMenuStrip = this.ContextMenu_Tip;
            this.subjectDataGridViewTextBoxColumn1.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn1.HeaderText = "標題";
            this.subjectDataGridViewTextBoxColumn1.MinimumWidth = 250;
            this.subjectDataGridViewTextBoxColumn1.Name = "subjectDataGridViewTextBoxColumn1";
            this.subjectDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.ContextMenuStrip = this.ContextMenu_Tip;
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            dataGridViewCellStyle2.Format = "G";
            dataGridViewCellStyle2.NullValue = null;
            this.createDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.createDateDataGridViewTextBoxColumn.HeaderText = "建立日期";
            this.createDateDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BindingSource_Tips
            // 
            this.BindingSource_Tips.AllowNew = true;
            this.BindingSource_Tips.DataMember = "Tips";
            this.BindingSource_Tips.DataSource = typeof(MiniTips.MiniTipsDataSet);
            this.BindingSource_Tips.Sort = "Tipid DESC";
            // 
            // ContextMenu_Notified
            // 
            this.ContextMenu_Notified.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuNotified_View,
            this.ContextMenuNotified_Delete});
            this.ContextMenu_Notified.Name = "contextMenuNotified";
            this.ContextMenu_Notified.Size = new System.Drawing.Size(101, 48);
            // 
            // ContextMenuNotified_View
            // 
            this.ContextMenuNotified_View.Name = "ContextMenuNotified_View";
            this.ContextMenuNotified_View.Size = new System.Drawing.Size(100, 22);
            this.ContextMenuNotified_View.Text = "檢視";
            this.ContextMenuNotified_View.Click += new System.EventHandler(this.ContextMenuNotified_View_Click);
            // 
            // ContextMenuNotified_Delete
            // 
            this.ContextMenuNotified_Delete.Name = "ContextMenuNotified_Delete";
            this.ContextMenuNotified_Delete.Size = new System.Drawing.Size(100, 22);
            this.ContextMenuNotified_Delete.Text = "刪除";
            this.ContextMenuNotified_Delete.Click += new System.EventHandler(this.ContextMenuNotified_Delete_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenu_File,
            this.MainMenu_Help});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(634, 24);
            this.MainMenu.TabIndex = 3;
            this.MainMenu.Text = "menuStrip1";
            // 
            // MainMenu_File
            // 
            this.MainMenu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenu_Export,
            this.MainMenu_Import,
            this.MainMenu_Options,
            this.MainMenu_Exit});
            this.MainMenu_File.Name = "MainMenu_File";
            this.MainMenu_File.Size = new System.Drawing.Size(58, 20);
            this.MainMenu_File.Text = "檔案(&F)";
            // 
            // MainMenu_Export
            // 
            this.MainMenu_Export.Name = "MainMenu_Export";
            this.MainMenu_Export.Size = new System.Drawing.Size(163, 22);
            this.MainMenu_Export.Text = "匯出提醒設定(&E)";
            this.MainMenu_Export.Click += new System.EventHandler(this.MainMenu_Export_Click);
            // 
            // MainMenu_Import
            // 
            this.MainMenu_Import.Name = "MainMenu_Import";
            this.MainMenu_Import.Size = new System.Drawing.Size(163, 22);
            this.MainMenu_Import.Text = "匯入提醒設定(&I)";
            this.MainMenu_Import.Click += new System.EventHandler(this.MainMenu_Import_Click);
            // 
            // MainMenu_Options
            // 
            this.MainMenu_Options.Name = "MainMenu_Options";
            this.MainMenu_Options.Size = new System.Drawing.Size(163, 22);
            this.MainMenu_Options.Text = "選項設定(&O)";
            this.MainMenu_Options.Click += new System.EventHandler(this.MainMenu_Option_Click);
            // 
            // MainMenu_Exit
            // 
            this.MainMenu_Exit.Name = "MainMenu_Exit";
            this.MainMenu_Exit.Size = new System.Drawing.Size(163, 22);
            this.MainMenu_Exit.Text = "不玩了(&X)";
            this.MainMenu_Exit.Click += new System.EventHandler(this.MainMenu_Exit_Click);
            // 
            // MainMenu_Help
            // 
            this.MainMenu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenu_About});
            this.MainMenu_Help.Name = "MainMenu_Help";
            this.MainMenu_Help.Size = new System.Drawing.Size(61, 20);
            this.MainMenu_Help.Text = "說明(&H)";
            // 
            // MainMenu_About
            // 
            this.MainMenu_About.Name = "MainMenu_About";
            this.MainMenu_About.Size = new System.Drawing.Size(116, 22);
            this.MainMenu_About.Text = "關於(&A)";
            this.MainMenu_About.Click += new System.EventHandler(this.MainMenu_About_Click);
            // 
            // QuickButtonBar_Tips
            // 
            this.QuickButtonBar_Tips.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.QuickButtonBar_Tips.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.QuickButtonBar_Tips.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuickButton_AddTip,
            this.QuickButton_EditTip,
            this.QuickButton_DeleteTip});
            this.QuickButtonBar_Tips.Location = new System.Drawing.Point(0, 22);
            this.QuickButtonBar_Tips.Name = "QuickButtonBar_Tips";
            this.QuickButtonBar_Tips.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.QuickButtonBar_Tips.Size = new System.Drawing.Size(400, 31);
            this.QuickButtonBar_Tips.TabIndex = 4;
            this.QuickButtonBar_Tips.Text = "toolStrip1";
            // 
            // QuickButton_AddTip
            // 
            this.QuickButton_AddTip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.QuickButton_AddTip.Image = global::MiniTips.Properties.Resources.add_24;
            this.QuickButton_AddTip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.QuickButton_AddTip.Name = "QuickButton_AddTip";
            this.QuickButton_AddTip.Size = new System.Drawing.Size(28, 28);
            this.QuickButton_AddTip.Text = "新增提醒設定";
            this.QuickButton_AddTip.Click += new System.EventHandler(this.QuickButton_AddTip_Click);
            // 
            // QuickButton_EditTip
            // 
            this.QuickButton_EditTip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.QuickButton_EditTip.Image = global::MiniTips.Properties.Resources.edit_24;
            this.QuickButton_EditTip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.QuickButton_EditTip.Name = "QuickButton_EditTip";
            this.QuickButton_EditTip.Size = new System.Drawing.Size(28, 28);
            this.QuickButton_EditTip.Text = "編輯提醒設定";
            this.QuickButton_EditTip.Click += new System.EventHandler(this.QuickButton_EditTip_Click);
            // 
            // QuickButton_DeleteTip
            // 
            this.QuickButton_DeleteTip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.QuickButton_DeleteTip.Image = global::MiniTips.Properties.Resources.remove_24;
            this.QuickButton_DeleteTip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.QuickButton_DeleteTip.Name = "QuickButton_DeleteTip";
            this.QuickButton_DeleteTip.Size = new System.Drawing.Size(28, 28);
            this.QuickButton_DeleteTip.Text = "刪除提醒設定";
            this.QuickButton_DeleteTip.Click += new System.EventHandler(this.QuickButton_DeleteTip_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.DataGridView_Tips);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.DataGridView_Notified);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(634, 386);
            this.splitContainer1.SplitterDistance = 402;
            this.splitContainer1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.QuickButtonBar_Tips);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 53);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "提醒設定列表";
            // 
            // DataGridView_Notified
            // 
            this.DataGridView_Notified.AllowUserToAddRows = false;
            this.DataGridView_Notified.AllowUserToDeleteRows = false;
            this.DataGridView_Notified.AutoGenerateColumns = false;
            this.DataGridView_Notified.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView_Notified.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_Notified.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Notified.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ViewedIcon,
            this.NotifiedDate});
            this.DataGridView_Notified.DataSource = this.BindingSource_TipsNotified;
            this.DataGridView_Notified.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_Notified.Location = new System.Drawing.Point(0, 53);
            this.DataGridView_Notified.MinimumSize = new System.Drawing.Size(150, 0);
            this.DataGridView_Notified.MultiSelect = false;
            this.DataGridView_Notified.Name = "DataGridView_Notified";
            this.DataGridView_Notified.ReadOnly = true;
            this.DataGridView_Notified.RowHeadersVisible = false;
            this.DataGridView_Notified.RowTemplate.Height = 24;
            this.DataGridView_Notified.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_Notified.Size = new System.Drawing.Size(226, 331);
            this.DataGridView_Notified.TabIndex = 7;
            this.DataGridView_Notified.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView_Notified_CellFormatting);
            this.DataGridView_Notified.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView_Notified_CellMouseDoubleClick);
            // 
            // ViewedIcon
            // 
            this.ViewedIcon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ViewedIcon.ContextMenuStrip = this.ContextMenu_Notified;
            this.ViewedIcon.HeaderText = " ";
            this.ViewedIcon.Image = global::MiniTips.Properties.Resources.logo_16;
            this.ViewedIcon.MinimumWidth = 32;
            this.ViewedIcon.Name = "ViewedIcon";
            this.ViewedIcon.ReadOnly = true;
            this.ViewedIcon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ViewedIcon.Width = 32;
            // 
            // NotifiedDate
            // 
            this.NotifiedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NotifiedDate.ContextMenuStrip = this.ContextMenu_Notified;
            this.NotifiedDate.DataPropertyName = "NotifiedDate";
            this.NotifiedDate.HeaderText = "通知時間及標題";
            this.NotifiedDate.Name = "NotifiedDate";
            this.NotifiedDate.ReadOnly = true;
            // 
            // BindingSource_TipsNotified
            // 
            this.BindingSource_TipsNotified.DataMember = "TipsNotified";
            this.BindingSource_TipsNotified.DataSource = typeof(MiniTips.MiniTipsDataSet);
            this.BindingSource_TipsNotified.Sort = "NotifiedDate DESC";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.QuickButtonBar_Notified);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 53);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "已通知列表";
            // 
            // QuickButtonBar_Notified
            // 
            this.QuickButtonBar_Notified.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.QuickButtonBar_Notified.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.QuickButtonBar_Notified.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuickButton_ViewNotified,
            this.QuickButton_DeleteNotified});
            this.QuickButtonBar_Notified.Location = new System.Drawing.Point(0, 22);
            this.QuickButtonBar_Notified.Name = "QuickButtonBar_Notified";
            this.QuickButtonBar_Notified.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.QuickButtonBar_Notified.Size = new System.Drawing.Size(226, 31);
            this.QuickButtonBar_Notified.TabIndex = 6;
            this.QuickButtonBar_Notified.Text = "toolStrip1";
            // 
            // QuickButton_ViewNotified
            // 
            this.QuickButton_ViewNotified.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.QuickButton_ViewNotified.Image = global::MiniTips.Properties.Resources.search_24;
            this.QuickButton_ViewNotified.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.QuickButton_ViewNotified.Name = "QuickButton_ViewNotified";
            this.QuickButton_ViewNotified.Size = new System.Drawing.Size(28, 28);
            this.QuickButton_ViewNotified.Text = "檢視通知";
            this.QuickButton_ViewNotified.ToolTipText = "檢視通知";
            this.QuickButton_ViewNotified.Click += new System.EventHandler(this.QuickButton_ViewNotified_Click);
            // 
            // QuickButton_DeleteNotified
            // 
            this.QuickButton_DeleteNotified.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.QuickButton_DeleteNotified.Image = global::MiniTips.Properties.Resources.remove_24;
            this.QuickButton_DeleteNotified.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.QuickButton_DeleteNotified.Name = "QuickButton_DeleteNotified";
            this.QuickButton_DeleteNotified.Size = new System.Drawing.Size(28, 28);
            this.QuickButton_DeleteNotified.Text = "刪除通知";
            this.QuickButton_DeleteNotified.ToolTipText = "刪除通知";
            this.QuickButton_DeleteNotified.Click += new System.EventHandler(this.QuickButton_DeleteNotified_Click);
            // 
            // openFileDialog_Import
            // 
            this.openFileDialog_Import.DefaultExt = "xml";
            this.openFileDialog_Import.FileName = "data.xml";
            this.openFileDialog_Import.Filter = "XML檔案|*.xml|所有檔案|*.*";
            // 
            // saveFileDialog_Export
            // 
            this.saveFileDialog_Export.DefaultExt = "xml";
            this.saveFileDialog_Export.FileName = "data.xml";
            this.saveFileDialog_Export.Filter = "XML檔案|*.xml";
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(634, 410);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 100);
            this.MainMenuStrip = this.MainMenu;
            this.MinimumSize = new System.Drawing.Size(400, 38);
            this.Name = "FormList";
            this.Opacity = 0;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Tips";
            this.Load += new System.EventHandler(this.FormList_Load);
            this.Shown += new System.EventHandler(this.FormList_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormList_FormClosing);
            this.ContextMenuNotifyIcon.ResumeLayout(false);
            this.ContextMenu_Tip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Tips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_Tips)).EndInit();
            this.ContextMenu_Notified.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.QuickButtonBar_Tips.ResumeLayout(false);
            this.QuickButtonBar_Tips.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Notified)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_TipsNotified)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.QuickButtonBar_Notified.ResumeLayout(false);
            this.QuickButtonBar_Notified.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.BindingSource BindingSource_Tips;
        private System.Windows.Forms.NotifyIcon NotifyIcon_Tip;
        private System.Windows.Forms.Timer Timer_Tip;
        private System.Windows.Forms.ContextMenuStrip ContextMenu_Tip;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuTip_Edit;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuTip_Delete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NextTicks;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip ContextMenu_Notified;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuNotified_View;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuNotified_Delete;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MainMenu_File;
        private System.Windows.Forms.ToolStripMenuItem MainMenu_Export;
        private System.Windows.Forms.ToolStripMenuItem MainMenu_Import;
        private System.Windows.Forms.ToolStripMenuItem MainMenu_Options;
        private System.Windows.Forms.ToolStripMenuItem MainMenu_Exit;
        private System.Windows.Forms.ToolStripMenuItem MainMenu_Help;
        private System.Windows.Forms.ToolStripMenuItem MainMenu_About;
        private System.Windows.Forms.ToolStrip QuickButtonBar_Tips;
        private System.Windows.Forms.ToolStripButton QuickButton_AddTip;
        private System.Windows.Forms.ToolStripButton QuickButton_EditTip;
        private System.Windows.Forms.ToolStripButton QuickButton_DeleteTip;
        private System.Windows.Forms.DataGridView DataGridView_Tips;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip QuickButtonBar_Notified;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton QuickButton_ViewNotified;
        private System.Windows.Forms.ToolStripButton QuickButton_DeleteNotified;
        private System.Windows.Forms.DataGridView DataGridView_Notified;
        private System.Windows.Forms.BindingSource BindingSource_TipsNotified;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Import;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_Export;
        private System.Windows.Forms.ContextMenuStrip ContextMenuNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuNotifyIcon_Open;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuNotifyIcon_Exit;
        private System.Windows.Forms.DataGridViewImageColumn ViewedIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotifiedDate;


    }
}