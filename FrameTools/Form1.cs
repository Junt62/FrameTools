using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.DataFormats;

namespace FrameTools {


    public partial class Form1 : Form {

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        private readonly Utils utils;

        public string path = "";
        public string folder = "";
        public string backupFolderPath = "";
        public List<string> images = [];
        public List<string> imagesNew = [];
        public List<string> imagesPreview = [];

        public readonly string BACKUPFOLDERNAME = "备份文件夹";
        public readonly string BACKUPFOLDERSUFFIX = "_备份";
        public readonly string[] EXTENSIONS = ["*.png", "*.jpg", "*.jpeg", "*.bmp"];

        public ToolStripStatusLabel Tint => toolStripStatusLabel1;

        public Form1() {
            InitializeComponent();

            Text = Assembly.GetExecutingAssembly().GetName().Name;

            backupFolderPath = Path.Combine(Directory.GetCurrentDirectory(), BACKUPFOLDERNAME);

            utils = new Utils(this);

            utils.Tint("请直接拖入含有图片的文件夹");
        }

        private void Form1_DragEnter(object sender, DragEventArgs e) {
            if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop)) {
                if (e.Data.GetData(DataFormats.FileDrop) is string[] paths && paths.All(path => Directory.Exists(path))) {
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
                if (e.Data?.GetData(DataFormats.FileDrop) is string[] paths && paths.Length > 0) {
                    path = paths[0];

                    folder = Path.GetFileName(paths[0]);

                    utils.Tint($"已拖入文件夹：{folder}");

                    UpdateTextBox();

                    utils.GenerateBackup();

                    if (checkBox1.Checked) {
                        Button1_Click(sender, e);
                    }
                }
            }
        }

        private void UpdateTextBox() {
            textBox1.Text = path;

            images = [];
            images = utils.FindImages();
            textBox2.Text = ($"\"{String.Join("\", \"", images)}\"");

            imagesNew = [];
            imagesPreview = [];
            for (int i = 0; i < images.Count; i++) {
                string extension = Path.GetExtension(images[i]);
                string newName = $"{folder}{(i).ToString().PadLeft(3, '0')}{extension}";
                imagesPreview.Add($"{images[i]}  ->  {newName}");
                imagesNew.Add(newName);
            }
            textBox3.Text = ($"\"{String.Join("\", \"", imagesNew)}\"");
        }

        private void Button1_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                utils.RenameImages();

                UpdateTextBox();

                utils.Tint($"执行重命名完成: {folder}！");
            }
            else {
                utils.Tint("未设置目标路径！");
            }
        }

        private void Button2_Click(object sender, EventArgs e) {
            if (textBox3.Text == "" || textBox3.Text == "\"\"") {
                utils.Tint("无重命名预览");
            }
            else {
                utils.Tint("查看重命名预览");
                Form form = new() {
                    Text = "预览",
                    Width = 300,
                    Height = 400,
                    Owner = this,
                    FormBorderStyle = FormBorderStyle.FixedToolWindow,
                    StartPosition = FormStartPosition.CenterParent
                };
                TextBox textBox = new() {
                    ReadOnly = true,
                    Multiline = true,
                    Dock = DockStyle.Fill,
                    BackColor = Color.White,
                    ScrollBars = ScrollBars.Vertical,
                    Text = $"{String.Join(Environment.NewLine, imagesPreview)}",
                };
                form.Controls.Add(textBox);
                form.Shown += (sender, e) => textBox.SelectionLength = 0;
                form.ShowDialog();
            }
        }

        private void Button3_Click(object sender, EventArgs e) {
            if (Directory.Exists(backupFolderPath)) {
                var explorerProcesses = Process.GetProcessesByName("explorer").Where(p => p.MainWindowTitle.Contains(backupFolderPath));

                if (!explorerProcesses.Any()) {
                    Process.Start("explorer.exe", backupFolderPath);
                }
                else {
                    var windowHandle = explorerProcesses.First().MainWindowHandle;
                    SetForegroundWindow(windowHandle);
                }

                utils.Tint("打开备份文件夹");
            }
            else {
                utils.Tint("无备份文件夹");
            }
        }

        private void Button4_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                utils.Tint("填充600帧空白图片");
            }
            else {
                utils.Tint("未设置目标路径！");
            }
        }

        private void Button5_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                utils.Tint("填充360帧空白图片");
            }
            else {
                utils.Tint("未设置目标路径！");
            }
        }

        private void Button6_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                utils.Tint("提取所有子文件夹图片");
            }
            else {
                utils.Tint("未设置目标路径！");
            }
        }

        private void Button7_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                utils.Tint("删除所有子文件夹");
            }
            else {
                utils.Tint("未设置目标路径！");
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e) {
            if (checkBox1.Checked) {
                utils.Tint("启用自动执行");
            }
            else {
                utils.Tint("禁用自动执行");
            }
        }

    }

    public class Utils(Form1 form1) {
        private readonly Form1 form1 = form1;

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

        /// <returns>当前文件夹下所有图片的文件名，使用数字最小优先排序</returns>
        public List<string> FindImages() {
            var paths = new List<string>();
            foreach (var extension in form1.EXTENSIONS) {
                paths.AddRange(Directory.GetFiles(form1.path, extension, SearchOption.TopDirectoryOnly));
            }

            var images = new List<string>();
            foreach (var path in paths) {
                images.Add(Path.GetFileName(path));
            }

            static int ExtractNumber(string fileName) {
                var numberString = new string(fileName.Where(char.IsDigit).ToArray());
                return int.TryParse(numberString, out int number) ? number : int.MaxValue;
            }

            var sortedImages = images.OrderBy(f => ExtractNumber(Path.GetFileName(f))).ToList();

            return sortedImages;
        }

        public void RenameImages() {
            int count = 0;
            foreach (var image in form1.images) {
                string oldPath = Path.Combine(form1.path, image);
                string newPath = Path.Combine(form1.path, form1.imagesNew[count]);
                System.IO.File.Move(oldPath, newPath);
                count++;
            }
        }

        public void GenerateBackup() {
            string path = Path.Combine(form1.backupFolderPath, form1.folder + form1.BACKUPFOLDERSUFFIX);

            Directory.CreateDirectory(path);

            CopyDirectory(form1.path, path);

            static void CopyDirectory(string sourceDir, string destinationDir) {
                Directory.CreateDirectory(destinationDir);

                foreach (string file in Directory.GetFiles(sourceDir)) {
                    string fileName = Path.GetFileName(file);
                    string destFile = Path.Combine(destinationDir, fileName);
                    System.IO.File.Copy(file, destFile, true);
                }

                foreach (string directory in Directory.GetDirectories(sourceDir)) {
                    string dirName = Path.GetFileName(directory);
                    if (dirName != "备份文件夹") {
                        string destDir = Path.Combine(destinationDir, dirName);
                        CopyDirectory(directory, destDir);
                    }
                }
            }
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