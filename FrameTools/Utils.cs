using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FrameTools {

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

            if (!Path.Exists(form1.backupPath)) {
                Directory.CreateDirectory(form1.backupPath);
            }

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


            if (!Path.Exists(path)) {
                Directory.CreateDirectory(path);
            }
            else {
                Directory.Delete(path, true);
                Directory.CreateDirectory(path);
            }

            Match match = Regex.Match(name, @"^(.*?)(\d+)$");
            string emptyImage;
            int startNumber;
            int nameLength = match.Groups[2].Value.Length;
            if (match.Success) {
                emptyImage = name + extension;
                startNumber = int.Parse(match.Groups[2].Value[^nameLength..]);
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
                string index = (startNumber + i).ToString().PadLeft(nameLength, '0');
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
