using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
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
        public string backupPath = "";
        public List<string> images = [];
        public List<string> imagesNew = [];
        public List<string> imagesPreview = [];

        public readonly string BACKUPFOLDERNAME = "备份文件夹";
        public readonly string BACKUPFOLDERSUFFIX = "备份";
        public readonly string EMPTYIMAGESFOLDERNAME = "empty_images";
        public readonly string[] EXTENSIONS = ["*.png", "*.jpg", "*.jpeg", "*.bmp"];
        public readonly string[] EXTENSIONS2 = [".png", ".jpg", ".jpeg", ".bmp"];

        public ToolStripStatusLabel Tint => toolStripStatusLabel1;

        public Form1() {
            InitializeComponent();

            Text = Assembly.GetExecutingAssembly().GetName().Name;

            backupPath = Path.Combine(Directory.GetCurrentDirectory(), BACKUPFOLDERNAME);

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
            if (path != "") {
                textBox1.Text = path;

                images = [];
                images = utils.FindImages();
                textBox2.Text = ($"\"{String.Join("\", \"", images)}\"");

                imagesNew = [];
                imagesPreview = [];
                for (int i = 0; i < images.Count; i++) {
                    string extension = Path.GetExtension(images[i]);

                    string newName = $"{folder}{(i).ToString().PadLeft(3, '0')}{extension}";

                    imagesNew.Add(newName);

                    imagesPreview.Add($"{images[i]}  ->  {newName}");
                }

                textBox3.Text = ($"\"{String.Join("\", \"", imagesNew)}\"");
            }
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
                UpdateTextBox();

                utils.ShowDialog("预览", imagesPreview);

                utils.Tint("查看重命名预览");
            }
        }

        private void Button3_Click(object sender, EventArgs e) {
            if (Directory.Exists(backupPath)) {
                var explorerProcesses = Process.GetProcessesByName("explorer").Where(p => p.MainWindowTitle.Contains(backupPath));

                if (!explorerProcesses.Any()) {
                    Process.Start("explorer.exe", backupPath);
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
                utils.FillImages(600);

                UpdateTextBox();

                utils.Tint("填充600帧空白图片");
            }
            else {
                utils.Tint("未设置目标路径！");
            }
        }

        private void Button5_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                utils.FillImages(360);

                UpdateTextBox();

                utils.Tint("填充360帧空白图片");
            }
            else {
                utils.Tint("未设置目标路径！");
            }
        }

        private void Button6_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                if (Directory.GetDirectories(path).Length != 0) {
                    utils.ExtractSubFolders();

                    UpdateTextBox();

                    utils.Tint("提取所有子文件夹图片");
                }
                else {
                    utils.Tint("未找到子文件夹");
                }
            }
            else {
                utils.Tint("未设置目标路径！");
            }
        }

        private void Button7_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                utils.RemoveSubFolders();

                utils.Tint("删除所有子文件夹");
            }
            else {
                utils.Tint("未设置目标路径！");
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e) {
            if (checkBox1.Checked) {
                UpdateTextBox();

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
            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("yyyy-MM-dd_HH-mm-ss");
            string path = Path.Combine(form1.backupPath, $"{formattedTime}_{form1.folder}_{form1.BACKUPFOLDERSUFFIX}");

            List<string> dirs = new List<string>(Directory.GetDirectories(form1.backupPath, "*", SearchOption.TopDirectoryOnly));
            while (dirs.Count >= 10) {
                Directory.Delete(Directory.GetDirectories(form1.backupPath, "*", SearchOption.TopDirectoryOnly)[0], true);
                dirs = new List<string>(Directory.GetDirectories(form1.backupPath, "*", SearchOption.TopDirectoryOnly));
            }

            if (!Path.Exists(path)) {
                Directory.CreateDirectory(path);

                CopyDirectory(form1.path, path);
            }

            static void CopyDirectory(string sourceDir, string destinationDir) {
                Directory.CreateDirectory(destinationDir);

                foreach (string file in Directory.GetFiles(sourceDir)) {
                    string fileName = Path.GetFileName(file);
                    string destFile = Path.Combine(destinationDir, fileName);
                    System.IO.File.Copy(file, destFile, true);
                }

                foreach (string directory in Directory.GetDirectories(sourceDir)) {
                    string dirName = Path.GetFileName(directory);
                    if (!dirName.Contains("备份文件夹")) {
                        string destDir = Path.Combine(destinationDir, dirName);
                        CopyDirectory(directory, destDir);
                    }
                }
            }
        }

        public void GenerateEmptyImages(int count) {
            string path = Path.Combine(form1.backupPath, form1.EMPTYIMAGESFOLDERNAME);
            string name = Path.GetFileNameWithoutExtension(form1.images[0]).ToLower();
            string extension = Path.GetExtension(form1.images[0]).ToLower();
            string emptyImage;
            int startNumber;

            if (!Path.Exists(path)) {
                Directory.CreateDirectory(path);
            }
            else {
                Directory.Delete(path, true);
                Directory.CreateDirectory(path);
            }

            Match match = Regex.Match(name, @"^(.*?)(\d+)$");
            if (match.Success) {
                emptyImage = name + extension;
                startNumber = int.Parse(match.Groups[2].Value[^3..]);
            }
            else {
                emptyImage = "000" + extension;
                startNumber = 0;
            }

            using (Bitmap bmp = new Bitmap(1, 1)) {
                bmp.SetPixel(0, 0, Color.Transparent);
                bmp.Save(Path.Combine(path, emptyImage));
            }

            for (int i = 1; i < count; i++) {
                string index = name[..^3] + (startNumber + i).ToString().PadLeft(3, '0');
                string oldName = Path.Combine(path, emptyImage);
                string newName = match.Groups[1].Value + index + extension;
                newName = Path.Combine(path, newName);
                System.IO.File.Copy(oldName, newName, true);
            }
        }

        public void FillImages(int count) {
            GenerateEmptyImages(count);

            string path = Path.Combine(form1.backupPath, form1.EMPTYIMAGESFOLDERNAME);

            if (Directory.Exists(path)) {
                string[] files = Directory.GetFiles(path);

                foreach (string file in files) {
                    string name = Path.GetFileName(file);
                    string target = Path.Combine(form1.path, name);

                    if (!System.IO.File.Exists(target)) {
                        System.IO.File.Copy(file, target);
                    }
                }
            }

            Directory.Delete(path, true);
        }

        public void ExtractSubFolders() {
            List<string> imagesPreview = [];

            string[] files = Directory.GetFiles(form1.path);
            foreach (string file in files) {
                System.IO.File.Delete(file);
            }

            foreach (string dir in Directory.GetDirectories(form1.path, "*", SearchOption.AllDirectories)) {
                foreach (string file in Directory.GetFiles(dir)) {
                    string extension = Path.GetExtension(file).ToLower();

                    if (Array.Exists(form1.EXTENSIONS2, ext => ext == extension)) {
                        string destinationFile = Path.Combine(form1.path, Path.GetFileName(file));
                        System.IO.File.Copy(file, destinationFile, true);
                    }
                }
            }
        }

        public void RemoveSubFolders() {
            string[] dirs = Directory.GetDirectories(form1.path);
            foreach (string dir in dirs) {
                Directory.Delete(dir, true);
            }
        }

        public void ShowDialog(String Title, string message) {
            Form form = new() {
                Text = Title,
                Width = 300,
                Height = 400,
                Owner = form1,
                FormBorderStyle = FormBorderStyle.FixedToolWindow,
                StartPosition = FormStartPosition.CenterParent
            };
            TextBox textBox = new() {
                ReadOnly = true,
                Multiline = true,
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                ScrollBars = ScrollBars.Vertical,
                Text = $"{String.Join(Environment.NewLine, message)}",
            };
            form.Controls.Add(textBox);
            form.Shown += (sender, e) => textBox.SelectionLength = 0;
            form.ShowDialog();
        }

        public void ShowDialog(String Title, string[] message) {
            Form form = new() {
                Text = Title,
                Width = 300,
                Height = 400,
                Owner = form1,
                FormBorderStyle = FormBorderStyle.FixedToolWindow,
                StartPosition = FormStartPosition.CenterParent
            };
            TextBox textBox = new() {
                ReadOnly = true,
                Multiline = true,
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                ScrollBars = ScrollBars.Vertical,
                Text = $"{String.Join(Environment.NewLine, message)}",
            };
            form.Controls.Add(textBox);
            form.Shown += (sender, e) => textBox.SelectionLength = 0;
            form.ShowDialog();
        }

        public void ShowDialog(String Title, List<string> message) {
            Form form = new() {
                Text = Title,
                Width = 300,
                Height = 400,
                Owner = form1,
                FormBorderStyle = FormBorderStyle.FixedToolWindow,
                StartPosition = FormStartPosition.CenterParent
            };
            TextBox textBox = new() {
                ReadOnly = true,
                Multiline = true,
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                ScrollBars = ScrollBars.Vertical,
                Text = $"{String.Join(Environment.NewLine, message)}",
            };
            form.Controls.Add(textBox);
            form.Shown += (sender, e) => textBox.SelectionLength = 0;
            form.ShowDialog();
        }
    }
}