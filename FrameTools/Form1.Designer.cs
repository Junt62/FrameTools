namespace FrameTools {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            Form1_tableLayoutPanel = new TableLayoutPanel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tablePage1_tableLayoutPanel = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            groupBox1_tableLayoutPanel = new TableLayoutPanel();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            groupBox2_tableLayoutPanel = new TableLayoutPanel();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            checkBoxAutoRunPictureRename = new CheckBox();
            buttonRunPictureRename = new Button();
            buttonShowRenamePreview = new Button();
            groupBox3 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonRemoveSubFolder = new Button();
            buttonExtractSubFolder = new Button();
            buttonFillPictures600 = new Button();
            buttonFillPictures360 = new Button();
            groupBox4 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            checkBoxRemoveBackupFolderWhenClose = new CheckBox();
            buttonRemoveBackupFolder = new Button();
            buttonOpenBackupFolder = new Button();
            tabPage2 = new TabPage();
            tablePage2_tableLayoutPanel = new TableLayoutPanel();
            label7 = new Label();
            linkLabel1 = new LinkLabel();
            tabPage3 = new TabPage();
            tabPage3_tableLayoutPanel = new TableLayoutPanel();
            label4 = new Label();
            statusStrip1.SuspendLayout();
            Form1_tableLayoutPanel.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tablePage1_tableLayoutPanel.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox1_tableLayoutPanel.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox2_tableLayoutPanel.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tabPage2.SuspendLayout();
            tablePage2_tableLayoutPanel.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage3_tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(3, 306);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(498, 22);
            statusStrip1.TabIndex = 15;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(35, 17);
            toolStripStatusLabel1.Text = "提示:";
            toolStripStatusLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1_tableLayoutPanel
            // 
            Form1_tableLayoutPanel.ColumnCount = 1;
            Form1_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Form1_tableLayoutPanel.Controls.Add(tabControl1, 0, 0);
            Form1_tableLayoutPanel.Dock = DockStyle.Fill;
            Form1_tableLayoutPanel.Location = new Point(3, 3);
            Form1_tableLayoutPanel.Name = "Form1_tableLayoutPanel";
            Form1_tableLayoutPanel.RowCount = 2;
            Form1_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Form1_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Form1_tableLayoutPanel.Size = new Size(498, 325);
            Form1_tableLayoutPanel.TabIndex = 16;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(0);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(498, 305);
            tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.WhiteSmoke;
            tabPage1.Controls.Add(tablePage1_tableLayoutPanel);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(490, 275);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "图片处理";
            // 
            // tablePage1_tableLayoutPanel
            // 
            tablePage1_tableLayoutPanel.BackColor = Color.Transparent;
            tablePage1_tableLayoutPanel.ColumnCount = 1;
            tablePage1_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablePage1_tableLayoutPanel.Controls.Add(groupBox1, 0, 0);
            tablePage1_tableLayoutPanel.Controls.Add(groupBox2, 0, 1);
            tablePage1_tableLayoutPanel.Controls.Add(groupBox3, 0, 2);
            tablePage1_tableLayoutPanel.Controls.Add(groupBox4, 0, 3);
            tablePage1_tableLayoutPanel.Dock = DockStyle.Fill;
            tablePage1_tableLayoutPanel.Location = new Point(0, 0);
            tablePage1_tableLayoutPanel.Name = "tablePage1_tableLayoutPanel";
            tablePage1_tableLayoutPanel.RowCount = 6;
            tablePage1_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tablePage1_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
            tablePage1_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tablePage1_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tablePage1_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tablePage1_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablePage1_tableLayoutPanel.Size = new Size(490, 275);
            tablePage1_tableLayoutPanel.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(groupBox1_tableLayoutPanel);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(484, 46);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "拖入文件夹设置目标路径：";
            // 
            // groupBox1_tableLayoutPanel
            // 
            groupBox1_tableLayoutPanel.ColumnCount = 1;
            groupBox1_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            groupBox1_tableLayoutPanel.Controls.Add(textBox1, 0, 0);
            groupBox1_tableLayoutPanel.Dock = DockStyle.Fill;
            groupBox1_tableLayoutPanel.Location = new Point(3, 19);
            groupBox1_tableLayoutPanel.Name = "groupBox1_tableLayoutPanel";
            groupBox1_tableLayoutPanel.RowCount = 1;
            groupBox1_tableLayoutPanel.RowStyles.Add(new RowStyle());
            groupBox1_tableLayoutPanel.Size = new Size(478, 24);
            groupBox1_tableLayoutPanel.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = SystemColors.Window;
            textBox1.Location = new Point(0, 0);
            textBox1.Margin = new Padding(0);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(478, 23);
            textBox1.TabIndex = 3;
            textBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(groupBox2_tableLayoutPanel);
            groupBox2.Location = new Point(3, 57);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(484, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "重命名操作";
            // 
            // groupBox2_tableLayoutPanel
            // 
            groupBox2_tableLayoutPanel.ColumnCount = 4;
            groupBox2_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            groupBox2_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            groupBox2_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            groupBox2_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            groupBox2_tableLayoutPanel.Controls.Add(textBox3, 1, 1);
            groupBox2_tableLayoutPanel.Controls.Add(textBox2, 1, 0);
            groupBox2_tableLayoutPanel.Controls.Add(label2, 0, 0);
            groupBox2_tableLayoutPanel.Controls.Add(label3, 0, 1);
            groupBox2_tableLayoutPanel.Controls.Add(checkBoxAutoRunPictureRename, 2, 2);
            groupBox2_tableLayoutPanel.Controls.Add(buttonRunPictureRename, 0, 2);
            groupBox2_tableLayoutPanel.Controls.Add(buttonShowRenamePreview, 1, 2);
            groupBox2_tableLayoutPanel.Dock = DockStyle.Fill;
            groupBox2_tableLayoutPanel.Location = new Point(3, 19);
            groupBox2_tableLayoutPanel.Name = "groupBox2_tableLayoutPanel";
            groupBox2_tableLayoutPanel.RowCount = 3;
            groupBox2_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            groupBox2_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            groupBox2_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            groupBox2_tableLayoutPanel.Size = new Size(478, 78);
            groupBox2_tableLayoutPanel.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox3.BackColor = SystemColors.Window;
            groupBox2_tableLayoutPanel.SetColumnSpan(textBox3, 3);
            textBox3.Location = new Point(121, 28);
            textBox3.Margin = new Padding(2, 2, 0, 2);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(357, 23);
            textBox3.TabIndex = 5;
            textBox3.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = SystemColors.Window;
            groupBox2_tableLayoutPanel.SetColumnSpan(textBox2, 3);
            textBox2.Location = new Point(121, 2);
            textBox2.Margin = new Padding(2, 2, 0, 2);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(357, 23);
            textBox2.TabIndex = 4;
            textBox2.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(0, 4);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(119, 17);
            label2.TabIndex = 1;
            label2.Text = "当前文件名：";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(0, 30);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(119, 17);
            label3.TabIndex = 2;
            label3.Text = "目标文件名：";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBoxAutoRunPictureRename
            // 
            checkBoxAutoRunPictureRename.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            checkBoxAutoRunPictureRename.AutoSize = true;
            checkBoxAutoRunPictureRename.Location = new Point(239, 53);
            checkBoxAutoRunPictureRename.Margin = new Padding(1);
            checkBoxAutoRunPictureRename.Name = "checkBoxAutoRunPictureRename";
            checkBoxAutoRunPictureRename.Padding = new Padding(4, 2, 0, 0);
            checkBoxAutoRunPictureRename.Size = new Size(117, 23);
            checkBoxAutoRunPictureRename.TabIndex = 7;
            checkBoxAutoRunPictureRename.Text = "自动执行重命名";
            checkBoxAutoRunPictureRename.UseVisualStyleBackColor = true;
            checkBoxAutoRunPictureRename.CheckedChanged += CheckBoxAutoRunPictureRename_CheckedChanged;
            // 
            // buttonRunPictureRename
            // 
            buttonRunPictureRename.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonRunPictureRename.AutoSize = true;
            buttonRunPictureRename.Location = new Point(1, 53);
            buttonRunPictureRename.Margin = new Padding(1);
            buttonRunPictureRename.Name = "buttonRunPictureRename";
            buttonRunPictureRename.Size = new Size(117, 24);
            buttonRunPictureRename.TabIndex = 0;
            buttonRunPictureRename.Text = "执行图片重命名";
            buttonRunPictureRename.UseVisualStyleBackColor = true;
            buttonRunPictureRename.Click += ButtonRunPictureRename_Click;
            // 
            // buttonShowRenamePreview
            // 
            buttonShowRenamePreview.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonShowRenamePreview.AutoSize = true;
            buttonShowRenamePreview.Location = new Point(120, 53);
            buttonShowRenamePreview.Margin = new Padding(1);
            buttonShowRenamePreview.Name = "buttonShowRenamePreview";
            buttonShowRenamePreview.Size = new Size(117, 24);
            buttonShowRenamePreview.TabIndex = 1;
            buttonShowRenamePreview.Text = "查看重命名预览";
            buttonShowRenamePreview.UseVisualStyleBackColor = true;
            buttonShowRenamePreview.Click += ButtonShowPicturePreview_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(tableLayoutPanel1);
            groupBox3.Location = new Point(3, 165);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(484, 50);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "图片操作";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(buttonRemoveSubFolder, 3, 0);
            tableLayoutPanel1.Controls.Add(buttonExtractSubFolder, 2, 0);
            tableLayoutPanel1.Controls.Add(buttonFillPictures600, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonFillPictures360, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(478, 28);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonRemoveSubFolder
            // 
            buttonRemoveSubFolder.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonRemoveSubFolder.AutoSize = true;
            buttonRemoveSubFolder.Location = new Point(358, 1);
            buttonRemoveSubFolder.Margin = new Padding(1);
            buttonRemoveSubFolder.Name = "buttonRemoveSubFolder";
            buttonRemoveSubFolder.Size = new Size(119, 26);
            buttonRemoveSubFolder.TabIndex = 6;
            buttonRemoveSubFolder.Text = "删除子文件夹";
            buttonRemoveSubFolder.UseVisualStyleBackColor = true;
            buttonRemoveSubFolder.Click += ButtonRemoveSubFolder_Click;
            // 
            // buttonExtractSubFolder
            // 
            buttonExtractSubFolder.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonExtractSubFolder.AutoSize = true;
            buttonExtractSubFolder.Location = new Point(239, 1);
            buttonExtractSubFolder.Margin = new Padding(1);
            buttonExtractSubFolder.Name = "buttonExtractSubFolder";
            buttonExtractSubFolder.Size = new Size(117, 26);
            buttonExtractSubFolder.TabIndex = 5;
            buttonExtractSubFolder.Text = "提取子文件夹图片";
            buttonExtractSubFolder.UseVisualStyleBackColor = true;
            buttonExtractSubFolder.Click += ButtonExtractSubFolder_Click;
            // 
            // buttonFillPictures600
            // 
            buttonFillPictures600.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonFillPictures600.AutoSize = true;
            buttonFillPictures600.Location = new Point(1, 1);
            buttonFillPictures600.Margin = new Padding(1);
            buttonFillPictures600.Name = "buttonFillPictures600";
            buttonFillPictures600.Size = new Size(117, 26);
            buttonFillPictures600.TabIndex = 3;
            buttonFillPictures600.Text = "填充600帧图片";
            buttonFillPictures600.UseVisualStyleBackColor = true;
            buttonFillPictures600.Click += ButtonFillPictures600_Click;
            // 
            // buttonFillPictures360
            // 
            buttonFillPictures360.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonFillPictures360.AutoSize = true;
            buttonFillPictures360.Location = new Point(120, 1);
            buttonFillPictures360.Margin = new Padding(1);
            buttonFillPictures360.Name = "buttonFillPictures360";
            buttonFillPictures360.Size = new Size(117, 26);
            buttonFillPictures360.TabIndex = 4;
            buttonFillPictures360.Text = "填充360帧图片";
            buttonFillPictures360.UseVisualStyleBackColor = true;
            buttonFillPictures360.Click += ButtonFillPictures360_Click;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(tableLayoutPanel3);
            groupBox4.Location = new Point(3, 221);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(484, 50);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "备份";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Controls.Add(checkBoxRemoveBackupFolderWhenClose, 2, 0);
            tableLayoutPanel3.Controls.Add(buttonRemoveBackupFolder, 1, 0);
            tableLayoutPanel3.Controls.Add(buttonOpenBackupFolder, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 19);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(478, 28);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // checkBoxRemoveBackupFolderWhenClose
            // 
            checkBoxRemoveBackupFolderWhenClose.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            checkBoxRemoveBackupFolderWhenClose.AutoSize = true;
            checkBoxRemoveBackupFolderWhenClose.Location = new Point(239, 2);
            checkBoxRemoveBackupFolderWhenClose.Margin = new Padding(1);
            checkBoxRemoveBackupFolderWhenClose.Name = "checkBoxRemoveBackupFolderWhenClose";
            checkBoxRemoveBackupFolderWhenClose.Padding = new Padding(4, 2, 0, 0);
            checkBoxRemoveBackupFolderWhenClose.Size = new Size(117, 23);
            checkBoxRemoveBackupFolderWhenClose.TabIndex = 8;
            checkBoxRemoveBackupFolderWhenClose.Text = "关闭时清空备份";
            checkBoxRemoveBackupFolderWhenClose.UseVisualStyleBackColor = true;
            checkBoxRemoveBackupFolderWhenClose.CheckedChanged += checkBoxRemoveBackupFolderWhenClose_CheckedChanged;
            // 
            // buttonRemoveBackupFolder
            // 
            buttonRemoveBackupFolder.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonRemoveBackupFolder.AutoSize = true;
            buttonRemoveBackupFolder.Location = new Point(120, 1);
            buttonRemoveBackupFolder.Margin = new Padding(1);
            buttonRemoveBackupFolder.Name = "buttonRemoveBackupFolder";
            buttonRemoveBackupFolder.Size = new Size(117, 26);
            buttonRemoveBackupFolder.TabIndex = 3;
            buttonRemoveBackupFolder.Text = "清除备份文件夹";
            buttonRemoveBackupFolder.UseVisualStyleBackColor = true;
            buttonRemoveBackupFolder.Click += ButtonRemoveBackupFolder_Click;
            // 
            // buttonOpenBackupFolder
            // 
            buttonOpenBackupFolder.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonOpenBackupFolder.AutoSize = true;
            buttonOpenBackupFolder.Location = new Point(1, 1);
            buttonOpenBackupFolder.Margin = new Padding(1);
            buttonOpenBackupFolder.Name = "buttonOpenBackupFolder";
            buttonOpenBackupFolder.Size = new Size(117, 26);
            buttonOpenBackupFolder.TabIndex = 2;
            buttonOpenBackupFolder.Text = "打开备份文件夹";
            buttonOpenBackupFolder.UseVisualStyleBackColor = true;
            buttonOpenBackupFolder.Click += ButtonOpenBackupFolder_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.WhiteSmoke;
            tabPage2.Controls.Add(tablePage2_tableLayoutPanel);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(490, 275);
            tabPage2.TabIndex = 2;
            tabPage2.Text = "软件更新";
            // 
            // tablePage2_tableLayoutPanel
            // 
            tablePage2_tableLayoutPanel.BackColor = Color.WhiteSmoke;
            tablePage2_tableLayoutPanel.ColumnCount = 1;
            tablePage2_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablePage2_tableLayoutPanel.Controls.Add(label7, 0, 0);
            tablePage2_tableLayoutPanel.Controls.Add(linkLabel1, 0, 1);
            tablePage2_tableLayoutPanel.Dock = DockStyle.Fill;
            tablePage2_tableLayoutPanel.Location = new Point(0, 0);
            tablePage2_tableLayoutPanel.Name = "tablePage2_tableLayoutPanel";
            tablePage2_tableLayoutPanel.RowCount = 2;
            tablePage2_tableLayoutPanel.RowStyles.Add(new RowStyle());
            tablePage2_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablePage2_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tablePage2_tableLayoutPanel.Size = new Size(490, 275);
            tablePage2_tableLayoutPanel.TabIndex = 1;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(6, 6);
            label7.Margin = new Padding(6);
            label7.Name = "label7";
            label7.Size = new Size(478, 119);
            label7.TabIndex = 0;
            label7.Text = "更新说明：\r\n\r\n目前该软件仅在github上提供镜像版本\r\n\r\n如果您有更多建议与需求\r\n\r\n请直接在github社区中向该项目发起issue\r\n";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(6, 137);
            linkLabel1.Margin = new Padding(6);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(45, 17);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "github";
            linkLabel1.LinkClicked += LinkLabel1_LinkClicked;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.WhiteSmoke;
            tabPage3.Controls.Add(tabPage3_tableLayoutPanel);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(490, 275);
            tabPage3.TabIndex = 1;
            tabPage3.Text = "关于";
            // 
            // tabPage3_tableLayoutPanel
            // 
            tabPage3_tableLayoutPanel.ColumnCount = 1;
            tabPage3_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tabPage3_tableLayoutPanel.Controls.Add(label4, 0, 0);
            tabPage3_tableLayoutPanel.Dock = DockStyle.Fill;
            tabPage3_tableLayoutPanel.Location = new Point(0, 0);
            tabPage3_tableLayoutPanel.Name = "tabPage3_tableLayoutPanel";
            tabPage3_tableLayoutPanel.RowCount = 2;
            tabPage3_tableLayoutPanel.RowStyles.Add(new RowStyle());
            tabPage3_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tabPage3_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tabPage3_tableLayoutPanel.Size = new Size(490, 275);
            tabPage3_tableLayoutPanel.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(6, 6);
            label4.Margin = new Padding(6);
            label4.Name = "label4";
            label4.Size = new Size(478, 153);
            label4.TabIndex = 0;
            label4.Text = "该软件主要作用于序列帧图片文件相关的整理与修改\r\n\r\n并且提供了数项方便快捷的功能\r\n\r\n使得我们在日常工作中可以免去繁琐的手动整理图片文件的痛苦\r\n\r\n更加专注于我们本身的工作\r\n\r\n至此！";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(504, 331);
            Controls.Add(statusStrip1);
            Controls.Add(Form1_tableLayoutPanel);
            Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            Padding = new Padding(3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "序列帧综合工具";
            DragDrop += Form1_DragDrop;
            DragEnter += Form1_DragEnter;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            Form1_tableLayoutPanel.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tablePage1_tableLayoutPanel.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1_tableLayoutPanel.ResumeLayout(false);
            groupBox1_tableLayoutPanel.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2_tableLayoutPanel.ResumeLayout(false);
            groupBox2_tableLayoutPanel.PerformLayout();
            groupBox3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tabPage2.ResumeLayout(false);
            tablePage2_tableLayoutPanel.ResumeLayout(false);
            tablePage2_tableLayoutPanel.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3_tableLayoutPanel.ResumeLayout(false);
            tabPage3_tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TableLayoutPanel Form1_tableLayoutPanel;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TableLayoutPanel tablePage1_tableLayoutPanel;
        private GroupBox groupBox1;
        private TableLayoutPanel groupBox1_tableLayoutPanel;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox2;
        private TableLayoutPanel groupBox2_tableLayoutPanel;
        private Button buttonOpenBackupFolder;
        private Button buttonShowRenamePreview;
        private Button buttonRunPictureRename;
        private Button buttonFillPictures600;
        private Button buttonFillPictures360;
        private Button buttonExtractSubFolder;
        private Button buttonRemoveSubFolder;
        private CheckBox checkBoxAutoRunPictureRename;
        private TabPage tabPage2;
        private TableLayoutPanel tablePage2_tableLayoutPanel;
        private Label label7;
        private LinkLabel linkLabel1;
        private TabPage tabPage3;
        private TableLayoutPanel tabPage3_tableLayoutPanel;
        private Label label4;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox4;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button buttonRemoveBackupFolder;
        private CheckBox checkBoxRemoveBackupFolderWhenClose;
    }
}
