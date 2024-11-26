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

        public readonly string BACKUPFOLDERNAME = "�����ļ���";
        public readonly string BACKUPFOLDERSUFFIX = "����";
        public readonly string EMPTYIMAGESFOLDERNAME = "empty_images";
        public readonly string[] EXTENSIONS = ["*.png", "*.jpg", "*.jpeg", "*.bmp"];
        public readonly string[] EXTENSIONS2 = [".png", ".jpg", ".jpeg", ".bmp"];

        public ToolStripStatusLabel Tint => toolStripStatusLabel1;

        public Form1() {
            InitializeComponent();

            Text = Assembly.GetExecutingAssembly().GetName().Name;

            backupPath = Path.Combine(Directory.GetCurrentDirectory(), BACKUPFOLDERNAME);

            utils = new Utils(this);

            utils.Tint("��ֱ�����뺬��ͼƬ���ļ���");
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

                    utils.Tint($"�������ļ��У�{folder}");

                    UpdateTextBox();

                    utils.GenerateBackup();

                    if (checkBoxAutoRunPictureRename.Checked) {
                        ButtonRunPictureRename_Click(sender, e);
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

        private void ButtonRunPictureRename_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                utils.RenameImages();

                UpdateTextBox();

                utils.Tint($"ִ�����������: {folder}��");
            }
            else {
                utils.Tint("δ����Ŀ��·����");
            }
        }

        private void ButtonShowPicturePreview_Click(object sender, EventArgs e) {
            if (textBox3.Text == "" || textBox3.Text == "\"\"") {
                utils.Tint("��������Ԥ��");
            }
            else {
                UpdateTextBox();

                utils.ShowDialog("Ԥ��", imagesPreview);

                utils.Tint("�鿴������Ԥ��");
            }
        }

        private void ButtonOpenBackupFolder_Click(object sender, EventArgs e) {
            if (Directory.Exists(backupPath)) {
                var explorerProcesses = Process.GetProcessesByName("explorer").Where(p => p.MainWindowTitle.Contains(backupPath));

                if (!explorerProcesses.Any()) {
                    Process.Start("explorer.exe", backupPath);
                }
                else {
                    var windowHandle = explorerProcesses.First().MainWindowHandle;
                    SetForegroundWindow(windowHandle);
                }

                utils.Tint("�򿪱����ļ���");
            }
            else {
                utils.Tint("�ޱ����ļ���");
            }
        }

        private void ButtonRemoveBackupFolder_Click(object sender, EventArgs e) {
            if (Directory.Exists(backupPath)) {
                string[] dirs = Directory.GetDirectories(backupPath);
                foreach (string dir in dirs) {
                    Directory.Delete(dir, true);
                }

                utils.Tint("����ձ����ļ���");
            }
            else {
                utils.Tint("�ޱ����ļ���");
            }
        }

        private void ButtonFillPictures600_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                utils.FillImages(600);

                UpdateTextBox();

                utils.Tint("���600֡�հ�ͼƬ");
            }
            else {
                utils.Tint("δ����Ŀ��·����");
            }
        }

        private void ButtonFillPictures360_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                utils.FillImages(360);

                UpdateTextBox();

                utils.Tint("���360֡�հ�ͼƬ");
            }
            else {
                utils.Tint("δ����Ŀ��·����");
            }
        }

        private void ButtonExtractSubFolder_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                if (Directory.GetDirectories(path).Length != 0) {
                    utils.ExtractSubFolders();

                    UpdateTextBox();

                    utils.Tint("��ȡ�������ļ���ͼƬ");
                }
                else {
                    utils.Tint("δ�ҵ����ļ���");
                }
            }
            else {
                utils.Tint("δ����Ŀ��·����");
            }
        }

        private void ButtonRemoveSubFolder_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                utils.RemoveSubFolders();

                utils.Tint("ɾ���������ļ���");
            }
            else {
                utils.Tint("δ����Ŀ��·����");
            }
        }

        private void CheckBoxAutoRunPictureRename_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxAutoRunPictureRename.Checked) {
                UpdateTextBox();

                utils.Tint("�����Զ�ִ��������");
            }
            else {
                utils.Tint("�����Զ�ִ��������");
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(new ProcessStartInfo {
                FileName = "https://github.com/Junt62",
                UseShellExecute = true
            });
        }

        private void checkBoxRemoveBackupFolderWhenClose_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxRemoveBackupFolderWhenClose.Checked) {
                utils.Tint("���ùر�ʱ��ձ����ļ���");
            }
            else {
                utils.Tint("���ùر�ʱ��ձ����ļ���");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            if (checkBoxRemoveBackupFolderWhenClose.Checked) {
                if (Directory.Exists(backupPath)) {
                    string[] dirs = Directory.GetDirectories(backupPath);
                    foreach (string dir in dirs) {
                        Directory.Delete(dir, true);
                    }
                }
            }
        }

    }

}