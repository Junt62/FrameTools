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
            mainForm_tableLayoutPanel = new TableLayoutPanel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tablePage1_tableLayoutPanel = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            groupBox1_tableLayoutPanel = new TableLayoutPanel();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            groupBox2_tableLayoutPanel = new TableLayoutPanel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            checkBox1 = new CheckBox();
            tabPage2 = new TabPage();
            tablePage2_tableLayoutPanel = new TableLayoutPanel();
            label7 = new Label();
            linkLabel1 = new LinkLabel();
            tabPage3 = new TabPage();
            tabPage3_tableLayoutPanel = new TableLayoutPanel();
            label4 = new Label();
            statusStrip1.SuspendLayout();
            mainForm_tableLayoutPanel.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tablePage1_tableLayoutPanel.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox1_tableLayoutPanel.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox2_tableLayoutPanel.SuspendLayout();
            tabPage2.SuspendLayout();
            tablePage2_tableLayoutPanel.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage3_tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(3, 236);
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
            // mainForm_tableLayoutPanel
            // 
            mainForm_tableLayoutPanel.ColumnCount = 1;
            mainForm_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainForm_tableLayoutPanel.Controls.Add(tabControl1, 0, 0);
            mainForm_tableLayoutPanel.Dock = DockStyle.Fill;
            mainForm_tableLayoutPanel.Location = new Point(3, 3);
            mainForm_tableLayoutPanel.Name = "mainForm_tableLayoutPanel";
            mainForm_tableLayoutPanel.RowCount = 2;
            mainForm_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainForm_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainForm_tableLayoutPanel.Size = new Size(498, 255);
            mainForm_tableLayoutPanel.TabIndex = 16;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(3, 3);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(492, 229);
            tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.WhiteSmoke;
            tabPage1.Controls.Add(tablePage1_tableLayoutPanel);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(484, 199);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "图片处理";
            // 
            // tablePage1_tableLayoutPanel
            // 
            tablePage1_tableLayoutPanel.ColumnCount = 1;
            tablePage1_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablePage1_tableLayoutPanel.Controls.Add(groupBox1, 0, 0);
            tablePage1_tableLayoutPanel.Controls.Add(groupBox2, 0, 1);
            tablePage1_tableLayoutPanel.Dock = DockStyle.Fill;
            tablePage1_tableLayoutPanel.Location = new Point(3, 3);
            tablePage1_tableLayoutPanel.Name = "tablePage1_tableLayoutPanel";
            tablePage1_tableLayoutPanel.RowCount = 3;
            tablePage1_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 112F));
            tablePage1_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 86F));
            tablePage1_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablePage1_tableLayoutPanel.Size = new Size(478, 193);
            tablePage1_tableLayoutPanel.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox1_tableLayoutPanel);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(2, 2);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(474, 108);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "目标选择";
            // 
            // groupBox1_tableLayoutPanel
            // 
            groupBox1_tableLayoutPanel.ColumnCount = 2;
            groupBox1_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            groupBox1_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            groupBox1_tableLayoutPanel.Controls.Add(textBox3, 1, 2);
            groupBox1_tableLayoutPanel.Controls.Add(textBox2, 1, 1);
            groupBox1_tableLayoutPanel.Controls.Add(textBox1, 1, 0);
            groupBox1_tableLayoutPanel.Controls.Add(label1, 0, 0);
            groupBox1_tableLayoutPanel.Controls.Add(label2, 0, 1);
            groupBox1_tableLayoutPanel.Controls.Add(label3, 0, 2);
            groupBox1_tableLayoutPanel.Dock = DockStyle.Fill;
            groupBox1_tableLayoutPanel.Location = new Point(3, 19);
            groupBox1_tableLayoutPanel.Margin = new Padding(0);
            groupBox1_tableLayoutPanel.Name = "groupBox1_tableLayoutPanel";
            groupBox1_tableLayoutPanel.RowCount = 3;
            groupBox1_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            groupBox1_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33334F));
            groupBox1_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33334F));
            groupBox1_tableLayoutPanel.Size = new Size(468, 86);
            groupBox1_tableLayoutPanel.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox3.BackColor = SystemColors.Window;
            textBox3.Location = new Point(80, 59);
            textBox3.Margin = new Padding(0);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(388, 23);
            textBox3.TabIndex = 5;
            textBox3.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = SystemColors.Window;
            textBox2.Location = new Point(80, 30);
            textBox2.Margin = new Padding(0);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(388, 23);
            textBox2.TabIndex = 4;
            textBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = SystemColors.Window;
            textBox1.Location = new Point(80, 2);
            textBox1.Margin = new Padding(0);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(388, 23);
            textBox1.TabIndex = 3;
            textBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(80, 28);
            label1.TabIndex = 0;
            label1.Text = "文件夹路径：";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(0, 28);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(80, 28);
            label2.TabIndex = 1;
            label2.Text = "当前文件名：";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(0, 56);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(80, 30);
            label3.TabIndex = 2;
            label3.Text = "目标文件名：";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox2_tableLayoutPanel);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(2, 114);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(474, 82);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "操作选项";
            // 
            // groupBox2_tableLayoutPanel
            // 
            groupBox2_tableLayoutPanel.ColumnCount = 4;
            groupBox2_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            groupBox2_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            groupBox2_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            groupBox2_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            groupBox2_tableLayoutPanel.Controls.Add(button3, 2, 0);
            groupBox2_tableLayoutPanel.Controls.Add(button2, 1, 0);
            groupBox2_tableLayoutPanel.Controls.Add(button1, 0, 0);
            groupBox2_tableLayoutPanel.Controls.Add(button4, 0, 1);
            groupBox2_tableLayoutPanel.Controls.Add(button5, 1, 1);
            groupBox2_tableLayoutPanel.Controls.Add(button6, 2, 1);
            groupBox2_tableLayoutPanel.Controls.Add(button7, 3, 1);
            groupBox2_tableLayoutPanel.Controls.Add(checkBox1, 3, 0);
            groupBox2_tableLayoutPanel.Dock = DockStyle.Fill;
            groupBox2_tableLayoutPanel.Location = new Point(3, 19);
            groupBox2_tableLayoutPanel.Margin = new Padding(4);
            groupBox2_tableLayoutPanel.Name = "groupBox2_tableLayoutPanel";
            groupBox2_tableLayoutPanel.RowCount = 2;
            groupBox2_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            groupBox2_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            groupBox2_tableLayoutPanel.Size = new Size(468, 60);
            groupBox2_tableLayoutPanel.TabIndex = 1;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button3.AutoSize = true;
            button3.Location = new Point(235, 1);
            button3.Margin = new Padding(1);
            button3.Name = "button3";
            button3.Size = new Size(115, 27);
            button3.TabIndex = 2;
            button3.Text = "打开备份文件夹";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button2.AutoSize = true;
            button2.Location = new Point(118, 1);
            button2.Margin = new Padding(1);
            button2.Name = "button2";
            button2.Size = new Size(115, 27);
            button2.TabIndex = 1;
            button2.Text = "查看重命名预览";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.Location = new Point(1, 1);
            button1.Margin = new Padding(1);
            button1.Name = "button1";
            button1.Size = new Size(115, 27);
            button1.TabIndex = 0;
            button1.Text = "执行重命名";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button4.AutoSize = true;
            button4.Enabled = false;
            button4.Location = new Point(1, 31);
            button4.Margin = new Padding(1);
            button4.Name = "button4";
            button4.Size = new Size(115, 27);
            button4.TabIndex = 3;
            button4.Text = "填充600帧";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Button4_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button5.AutoSize = true;
            button5.Enabled = false;
            button5.Location = new Point(118, 31);
            button5.Margin = new Padding(1);
            button5.Name = "button5";
            button5.Size = new Size(115, 27);
            button5.TabIndex = 4;
            button5.Text = "填充360帧";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Button5_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button6.AutoSize = true;
            button6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button6.Enabled = false;
            button6.Location = new Point(235, 31);
            button6.Margin = new Padding(1);
            button6.Name = "button6";
            button6.Size = new Size(115, 27);
            button6.TabIndex = 5;
            button6.Text = "提取子文件夹图片";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Button6_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button7.AutoSize = true;
            button7.Enabled = false;
            button7.Location = new Point(352, 31);
            button7.Margin = new Padding(1);
            button7.Name = "button7";
            button7.Size = new Size(115, 27);
            button7.TabIndex = 6;
            button7.Text = "删除子文件夹";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Button7_Click;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(352, 4);
            checkBox1.Margin = new Padding(1);
            checkBox1.Name = "checkBox1";
            checkBox1.Padding = new Padding(1, 0, 0, 0);
            checkBox1.Size = new Size(115, 21);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "自动执行重命名";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.WhiteSmoke;
            tabPage2.Controls.Add(tablePage2_tableLayoutPanel);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(484, 199);
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
            tablePage2_tableLayoutPanel.Location = new Point(3, 3);
            tablePage2_tableLayoutPanel.Name = "tablePage2_tableLayoutPanel";
            tablePage2_tableLayoutPanel.RowCount = 2;
            tablePage2_tableLayoutPanel.RowStyles.Add(new RowStyle());
            tablePage2_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablePage2_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tablePage2_tableLayoutPanel.Size = new Size(478, 193);
            tablePage2_tableLayoutPanel.TabIndex = 1;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(472, 153);
            label7.TabIndex = 0;
            label7.Text = "\r\n更新说明：\r\n\r\n目前该软件仅在github上提供镜像版本\r\n\r\n如果您有更多建议与需求\r\n\r\n请直接在github社区中向该项目发起issue\r\n\r\n";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(3, 153);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(45, 17);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "github";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.WhiteSmoke;
            tabPage3.Controls.Add(tabPage3_tableLayoutPanel);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(484, 199);
            tabPage3.TabIndex = 1;
            tabPage3.Text = "关于";
            // 
            // tabPage3_tableLayoutPanel
            // 
            tabPage3_tableLayoutPanel.ColumnCount = 1;
            tabPage3_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tabPage3_tableLayoutPanel.Controls.Add(label4, 0, 0);
            tabPage3_tableLayoutPanel.Dock = DockStyle.Fill;
            tabPage3_tableLayoutPanel.Location = new Point(3, 3);
            tabPage3_tableLayoutPanel.Name = "tabPage3_tableLayoutPanel";
            tabPage3_tableLayoutPanel.RowCount = 2;
            tabPage3_tableLayoutPanel.RowStyles.Add(new RowStyle());
            tabPage3_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tabPage3_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tabPage3_tableLayoutPanel.Size = new Size(478, 193);
            tabPage3_tableLayoutPanel.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(472, 170);
            label4.TabIndex = 0;
            label4.Text = "\r\n该软件主要作用于序列帧图片文件相关的整理与修改\r\n\r\n并且提供了数项方便快捷的功能\r\n\r\n使得我们在日常工作中可以免去繁琐的手动整理图片文件的痛苦\r\n\r\n更加专注于我们本身的工作\r\n\r\n至此！";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(504, 261);
            Controls.Add(statusStrip1);
            Controls.Add(mainForm_tableLayoutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimumSize = new Size(520, 300);
            Name = "Form1";
            Padding = new Padding(3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "序列帧综合工具";
            DragDrop += Form1_DragDrop;
            DragEnter += Form1_DragEnter;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            mainForm_tableLayoutPanel.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tablePage1_tableLayoutPanel.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1_tableLayoutPanel.ResumeLayout(false);
            groupBox1_tableLayoutPanel.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2_tableLayoutPanel.ResumeLayout(false);
            groupBox2_tableLayoutPanel.PerformLayout();
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
        private TableLayoutPanel mainForm_tableLayoutPanel;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TableLayoutPanel tablePage1_tableLayoutPanel;
        private GroupBox groupBox1;
        private TableLayoutPanel groupBox1_tableLayoutPanel;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox2;
        private TableLayoutPanel groupBox2_tableLayoutPanel;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private CheckBox checkBox1;
        private TabPage tabPage2;
        private TableLayoutPanel tablePage2_tableLayoutPanel;
        private Label label7;
        private LinkLabel linkLabel1;
        private TabPage tabPage3;
        private TableLayoutPanel tabPage3_tableLayoutPanel;
        private Label label4;
    }
}
