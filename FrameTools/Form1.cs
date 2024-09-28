using System.Reflection;
using System.Windows.Forms;

namespace FrameTools {

    public partial class Form1 : Form {

        private Utils utils;

        public string path = "";
        public string folder = "";

        public static string PREVIEW = "preview.txt";
        public static string BACKUPFOLDER = "backup";
        public static string BACKUPSUFFIX = "_bak";
        public static string[] EXTENSIONS = ["*.png", "*.jpg", "*.jpeg", "*.bmp"];

        public ToolStripStatusLabel Tint => toolStripStatusLabel1;

        public Form1() {
            InitializeComponent();

            Text = Assembly.GetExecutingAssembly().GetName().Name;

            utils = new Utils(this);

            utils.Tint("请直接拖入含有图片的文件夹，程序会自动创建备份");
        }

        private void Form1_DragEnter(object sender, DragEventArgs e) {
            if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop)) {

                string[]? paths = e.Data.GetData(DataFormats.FileDrop) as string[];

                if (paths != null && paths.All(path => Directory.Exists(path))) {
                    e.Effect = DragDropEffects.Copy;
                }
                else {
                    e.Effect = DragDropEffects.None;
                }
            }
            else {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e) {
            if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop)) {

                string[]? paths = e.Data?.GetData(DataFormats.FileDrop) as string[];

                if (paths != null && paths.Length > 0) {

                    path = paths[0];

                    folder = Path.GetFileName(paths[0]);

                    updateTextBox1();

                    updateTextBox2();

                    if (checkBox1.Checked) {
                        button1_Click(sender, e);
                    }
                }
            }
        }

        private void updateTextBox1() {
            textBox1.Text = path;
            utils.Tint($"已拖入文件夹：{folder}");
        }

        private void updateTextBox2() {
            var files = new List<string>();

            foreach (var extension in EXTENSIONS) {
                files.AddRange(Directory.GetFiles(path, extension, SearchOption.TopDirectoryOnly));
            }

            textBox2.Text = String.Join(" ", files);
        }

        private void updateTextBox3() {

        }

        private void button1_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                utils.Tint("执行重命名！");
            }
            else {
                utils.Tint("未设置目标路径！");
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                utils.Tint("查看重命名预览");
            }
            else {
                utils.Tint("无重命名预览");
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                utils.Tint("打开备份文件夹");
            }
            else {
                utils.Tint("无备份文件夹");
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                utils.Tint("填充600帧空白图片");
            }
            else {
                utils.Tint("未设置目标路径！");
            }
        }

        private void button5_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                utils.Tint("填充360帧空白图片");
            }
            else {
                utils.Tint("未设置目标路径！");
            }
        }

        private void button6_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                utils.Tint("提取所有子文件夹图片");
            }
            else {
                utils.Tint("未设置目标路径！");
            }
        }

        private void button7_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                utils.Tint("删除所有子文件夹");
            }
            else {
                utils.Tint("未设置目标路径！");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if (checkBox1.Checked) {
                utils.Tint("启用自动执行");
            }
            else {
                utils.Tint("禁用自动执行");
            }
        }

    }

    public class Utils {
        private Form1 form1;

        public Utils(Form1 form1) {
            this.form1 = form1;
        }

        public void Tint(string text) {
            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("HH:mm:ss");

            if (text.Length > 30) {
                form1.Tint.Text = $"[{formattedTime}]提示: {text.Substring(0, 30) + "..."}";
            }
            else {
                form1.Tint.Text = $"[{formattedTime}]提示: {text}";
            }
        }

        public string[] SortImages(string[] images) {
            return [""];
        }

        public string[] FindImages(string[] images) {
            return [""];
        }

        public void RenameImages(string[] images) {

        }

        public void GeneratePreview(string[] images) {

        }

        public void GenerateBackup(string[] images) {

        }

        public void GenerateEmptyImages(string[] images) {

        }

        public void RemoveEmptyImages(string[] images) {

        }

        public void FillImages(string[] images) {

        }

        public void ExtractSubFolders(string[] images) {

        }

        public void RemoveSubFolders(string[] images) {

        }

    }
}