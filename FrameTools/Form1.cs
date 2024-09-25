using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FrameTools {

    public partial class MainForm : Form {

        private Utils utils;

        public static Version AssemblyVersion {
            get; private set;
        }

        public TextBox textBoxMessage {
            get {
                return textBox4;
            }
        }

        public MainForm() {
            InitializeComponent();

            CenterToScreen();

            utils = new Utils(this);

            AssemblyVersion = Assembly.GetExecutingAssembly().GetName().Version;
            Text = $"序列帧综合工具v{AssemblyVersion}@zijun";

            //DragDrop += new DragEventHandler(MainForm_DragDrop);

            utils.AppendText("请直接拖入含有图片的文件夹");
            utils.AppendTextln("支持png，jpg，bmp");
            utils.AppendTextln("关闭软件时，会自动清空备份");
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
                utils.AppendTextln($"已拖入文件夹：{files[0]}");
                textBox1.Text = files[0];

                if (checkBox1.Checked) {
                    button1_Click(sender, e);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                utils.AppendTextln("执行重命名！");
            }
            else {
                utils.AppendTextln("未设置目标路径！");
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                utils.AppendTextln("查看重命名预览");
            }
            else {
                utils.AppendTextln("无重命名预览");
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                utils.AppendTextln("打开备份文件夹");
            }
            else {
                utils.AppendTextln("无备份文件夹");
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                utils.AppendTextln("填充600帧空白图片");
            }
            else {
                utils.AppendTextln("未设置目标路径！");
            }

        }

        private void button5_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                utils.AppendTextln("填充360帧空白图片");
            }
            else {
                utils.AppendTextln("未设置目标路径！");
            }

        }

        private void button6_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                utils.AppendTextln("提取所有子文件夹图片");
            }
            else {
                utils.AppendTextln("未设置目标路径！");
            }

        }

        private void button7_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                utils.AppendTextln("删除所有子文件夹");
            }
            else {
                utils.AppendTextln("未设置目标路径！");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if (checkBox1.Checked) {
                utils.AppendTextln("启用自动执行");
            }
            else {
                utils.AppendTextln("禁用自动执行");
            }
        }
    }

    public class Utils {

        private MainForm mainForm;

        public Utils(MainForm mainForm) {
            this.mainForm = mainForm;
        }

        public void AppendText(string text) {
            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("HH:mm:ss");
            mainForm.textBoxMessage.AppendText($"【{formattedTime}】{text}");
        }

        public void AppendTextln(string text) {
            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("HH:mm:ss");
            mainForm.textBoxMessage.AppendText($"\r\n【{formattedTime}】{text}");
        }
    }
}