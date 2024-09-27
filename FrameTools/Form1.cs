using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FrameTools {

    public partial class MainForm : Form {

        private Utils utils;

        public ToolStripStatusLabel tint {
            get {
                return toolStripStatusLabel1;
            }
        }

        public MainForm() {
            InitializeComponent();

            Assembly assembly = Assembly.GetExecutingAssembly();
            AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)Attribute.GetCustomAttribute(assembly, typeof(AssemblyTitleAttribute));
            Text = titleAttribute.Title.ToString();

            utils = new Utils(this);

            utils.tint("请直接拖入含有图片的文件夹，程序会自动创建备份");
        }

        private void clearFocus(object sender, EventArgs e) {
            ActiveControl = null;
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e) {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0) {
                utils.tint($"已拖入文件夹：{files[0]}");
                textBox1.Text = files[0];

                if (checkBox1.Checked) {
                    button1_Click(sender, e);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                utils.tint("执行重命名！");
            }
            else {
                utils.tint("未设置目标路径！");
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                utils.tint("查看重命名预览");
            }
            else {
                utils.tint("无重命名预览");
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                utils.tint("打开备份文件夹");
            }
            else {
                utils.tint("无备份文件夹");
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                utils.tint("填充600帧空白图片");
            }
            else {
                utils.tint("未设置目标路径！");
            }

        }

        private void button5_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                utils.tint("填充360帧空白图片");
            }
            else {
                utils.tint("未设置目标路径！");
            }

        }

        private void button6_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                utils.tint("提取所有子文件夹图片");
            }
            else {
                utils.tint("未设置目标路径！");
            }

        }

        private void button7_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                utils.tint("删除所有子文件夹");
            }
            else {
                utils.tint("未设置目标路径！");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if (checkBox1.Checked) {
                utils.tint("启用自动执行");
            }
            else {
                utils.tint("禁用自动执行");
            }
        }

        private void linkLabel1_Click(object sender, EventArgs e) {

            string url = "https://github.com/Junt62/FrameTools";

            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });

        }
    }

    public class Utils {

        private MainForm mainForm;

        public Utils(MainForm mainForm) {
            this.mainForm = mainForm;
        }

        public void tint(string text) {
            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("HH:mm:ss");
            mainForm.tint.Text = $"[{formattedTime}]提示: {text}";
        }

        //public void SetText(string text) {
        //    DateTime currentTime = DateTime.Now;
        //    string formattedTime = currentTime.ToString("HH:mm:ss");
        //    mainForm.textBoxMessage.AppendText($"\r\n【{formattedTime}】{text}");
        //}
    }
}