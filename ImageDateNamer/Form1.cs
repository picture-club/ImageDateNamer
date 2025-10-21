using MyPictures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ImageDateNamer
{
    public partial class Form1 : Form
    {
        private List<IMAGE_INFO> imageList = new List<IMAGE_INFO>();
        private List<IMAGE_INFO> imageListNoDate = new List<IMAGE_INFO>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (Directory.Exists(tbxFolder.Text))
                {
                    fbd.SelectedPath = tbxFolder.Text;
                }

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    tbxFolder.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            int idx = 0, idxNoDate = 0;

            string destFilePath = "", destTextPath = "";
            
            foreach (var imageInfo in imageList)
            {
                var folderPath = Path.Combine(tbxDestFolder.Text, imageInfo.strDestFolderName);

                if (Directory.Exists(folderPath))
                {
                    int fileCount = Directory.GetFiles(folderPath, "*.*").Length;

                    if (fileCount >= 200)
                    {
                        for (char ch = 'a'; ch <= 'z'; ch++)
                        {
                            folderPath = Path.Combine(tbxDestFolder.Text, imageInfo.strDestFolderName + "_" + ch.ToString());

                            if (Directory.Exists(folderPath))
                            {
                                fileCount = Directory.GetFiles(folderPath, "*.*").Length;

                                if (fileCount >= 200)
                                {
                                    continue;
                                }
                                else
                                {
                                    destFilePath = Path.Combine(folderPath, imageInfo.strDestFileName + imageInfo.strExtension);
                                    if (File.Exists(destFilePath))
                                    {
                                        File.Delete(destFilePath);
                                    }
                                    File.Move(imageInfo.strFilePath, destFilePath);

                                    break;
                                }
                            }
                            else
                            {
                                Directory.CreateDirectory(folderPath);

                                destFilePath = Path.Combine(folderPath, imageInfo.strDestFileName + imageInfo.strExtension);
                                if (File.Exists(destFilePath))
                                {
                                    File.Delete(destFilePath);
                                }
                                File.Move(imageInfo.strFilePath, destFilePath);

                                break;
                            }
                        }
                    }
                    else
                    {
                        destFilePath = Path.Combine(folderPath, imageInfo.strDestFileName + imageInfo.strExtension);
                        if (File.Exists(destFilePath))
                        {
                            File.Delete(destFilePath);
                        }
                        File.Move(imageInfo.strFilePath, destFilePath);
                    }
                }
                else
                {
                    Directory.CreateDirectory(folderPath);

                    destFilePath = Path.Combine(folderPath, imageInfo.strDestFileName + imageInfo.strExtension);
                    if (File.Exists(destFilePath))
                    {
                        File.Delete(destFilePath);
                    }
                    File.Move(imageInfo.strFilePath, destFilePath);
                }

                lblImagesCnt.Text = (++idx).ToString();
                lblImagesCnt.Refresh();
            }

            foreach (var imageInfo in imageListNoDate)
            {
                var folderPath = Path.Combine(tbxDestFolder.Text, imageInfo.strDestFolderName);

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                destFilePath = Path.Combine(folderPath, imageInfo.strDestFileName + imageInfo.strExtension);
                if (File.Exists(destFilePath))
                {
                    File.Delete(destFilePath);
                }
                File.Move(imageInfo.strFilePath, destFilePath);

                lblImagesNoDateCnt.Text = (++idxNoDate).ToString();
                lblImagesNoDateCnt.Refresh();
            }

            DialogResult result = MessageBox.Show(
                "finished!",
                "Image Summary",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            if (result == DialogResult.OK)
            {
                btnRename.Enabled = false;
                btnRename.Refresh();
            }
        }

        private void btnDestBrowse_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (Directory.Exists(tbxDestFolder.Text))
                {
                    fbd.SelectedPath = tbxDestFolder.Text;
                }

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    tbxDestFolder.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string directoryPath = tbxFolder.Text.Trim();
            if (string.IsNullOrEmpty(directoryPath) || !Directory.Exists(directoryPath))
            {
                MessageBox.Show("Please select a valid directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get all image files recursively
            //string[] extensions = new[] { ".jpg", ".heic", ".png", ".jpeg" };
            string[] extensions = new[] { ".jpg", ".png", ".jpeg" };

            var imageFiles = Directory
                .EnumerateFiles(directoryPath, "*.*", SearchOption.AllDirectories)
                .Where(file => extensions.Contains(Path.GetExtension(file).ToLower()))
                .ToArray();

            if (imageFiles.Length == 0)
            {
                MessageBox.Show("No images found in the selected folder.");
                return;
            }

            imageList.Clear();
            imageListNoDate.Clear();

            int idx = 0;
            foreach (var file in imageFiles)
            {
                try
                {
                    using (Image img = Image.FromFile(file))
                    {
                        int width = img.Width;
                        int height = img.Height;
                        DateTime? dateTime = ImageUtil.GetDateTaken(img);
                        string maker = ImageUtil.GetPropStr(img, 0x010F);  // Manufacturer
                        string model = ImageUtil.GetPropStr(img, 0x0110); // Model

                        IMAGE_INFO imageInfo = null;

                        if (dateTime == null)
                        {
                            imageInfo = new IMAGE_INFO
                            {
                                strFilePath = file,
                                strFileName = Path.GetFileNameWithoutExtension(file),
                                strExtension = Path.GetExtension(file),
                                nWidth = width,
                                nHeight = height,
                                strCameraMaker = maker,
                                strCameraModel = model,
                                strDestFileName = Path.GetFileNameWithoutExtension(file),
                                strDestFolderName = "NoDate",
                            };

                            imageListNoDate.Add(imageInfo);
                        }
                        else
                        {
                            imageInfo = new IMAGE_INFO
                            {
                                strFilePath = file,
                                strFileName = Path.GetFileNameWithoutExtension(file),
                                strExtension = Path.GetExtension(file),
                                nWidth = width,
                                nHeight = height,
                                dateTime = (DateTime) dateTime,
                                strCameraMaker = maker,
                                strCameraModel = model,
                                strDestFileName = dateTime?.ToString("yyyyMMddHHmmss"),
                                strDestFolderName = dateTime?.ToString("yyyyMM"),
                            };

                            imageList.Add(imageInfo);
                        }

                        idx++;
                        lblLoadsCnt.Text = idx.ToString();
                        lblLoadsCnt.Refresh();
                    }
                }
                catch (Exception ex)
                {
                    // Handle unreadable or corrupted images
                    Console.WriteLine($"Error reading {file}: {ex.Message}");
                }
            }

            imageList.OrderBy(p => p.strDestFileName);

            DialogResult result = MessageBox.Show(
                $"Total images: {imageList.Count + imageListNoDate.Count}\n" +
                $"With date: {imageList.Count}\n" +
                $"Without date: {imageListNoDate.Count}",
                "Image Summary",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            if (result == DialogResult.OK)
            {
                btnRename.Enabled = true;
                btnRename.Refresh();
            }

            lblImageTotalCnt.Text = imageList.Count.ToString();
            lblImageNoDateTotalCnt.Text = imageListNoDate.Count.ToString();
        }
    }
}
