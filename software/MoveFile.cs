using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace software
{
    public partial class MoveFile : Form
    {
        public MoveFile()
        {
            InitializeComponent();
        }

        private void Btn_FirstPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择Txt所在文件夹";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
            }
            txt_firstpath.Text = dialog.SelectedPath;
        }

        private void Btn_EndPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择Txt所在文件夹";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
            }
            txt_endpath.Text = dialog.SelectedPath;
        }

        private void Btn_MoveFile_Click(object sender, EventArgs e)
        {
            int length = Convert.ToInt32(txt_length.Text.Trim());
            string number = txt_startnum.Text.Trim();
            bool isdesc = ckb_child.Checked;
            if (number == "")
            {
                number = "0";
            }
            int startnum = Convert.ToInt32(number);
            string startpath = txt_firstpath.Text.Trim();
            string endpath = txt_endpath.Text.Trim();
            if (endpath == "")
            {
                endpath = startpath;
            }
            //判断是否存在目录
            if (!Directory.Exists(startpath))
            {
                MessageBox.Show("文件路径不存在", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //判断是否存在目录
            if (!Directory.Exists(endpath))
            {
                MessageBox.Show("文件路径不存在", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<DirectoryInfo> folders = fileHelper.GetAllFoldersInPath(startpath);
            bool ischild = ckb_child.Checked;
            //是否包含子目录，如果包含子目录则输出文件路径就是本身路径
            //不包含子目录，如果输出路径没写则输出文件路径就是本身路径，否则就是填写的路径
            if (ischild)
            {
                for (int i = 0; i < folders.Count; i++)
                {
                    if (length == 0)
                    {
                        TryMoveFiles(folders[i].FullName, folders[i].FullName, startnum, isdesc);
                    }
                    else
                    {
                        TryMoveFiles(folders[i].FullName, folders[i].FullName, startnum, length, isdesc);
                    }

                }
            }
            else
            {
                if (length == 0)
                {
                    TryMoveFiles(startpath, endpath, startnum, isdesc);
                }
                else
                {
                    TryMoveFiles(startpath, endpath, startnum, length, isdesc);

                }

            }


            //string expression = @"(\d+)";
            // Match reg = Regex.Match(name, expression);
            //string newname = reg.Groups[1].Value;
            MessageBox.Show("导出成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        FileHelper fileHelper = new FileHelper();
        private void TryMoveFiles(string startpath, string endpath, int number, bool desc)
        {

            List<FileInfo> files = fileHelper.GetAllFilesInPath(startpath);
            if (files.Count == 0)
            {
                return;
            }
            FileIComparer fileIComparer = new FileIComparer();
            //筛选视屏文件
            List<FileInfo> files_videos = files.Where(t =>
            {
                string[] list = t.Name.Split('.');
                string houzhui = list[list.Length - 1].ToLower();
                if (houzhui == "mp4" || houzhui == "mov" || houzhui == "avi")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }).ToList();
            //筛选图片文件
            List<FileInfo> files_images = files.Where(t =>
            {
                string[] list = t.Name.Split('.');
                string houzhui = list[list.Length - 1].ToLower();
                if (houzhui == "jpg" || houzhui == "png" || houzhui == "jpeg" || houzhui == "gif")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }).ToList();

            //文件排序
            if (desc)
            {
                fileIComparer.FileComparerByNameAsc(ref files_videos);
                fileIComparer.FileComparerByNameAsc(ref files_images);
            }
            else
            {
                fileIComparer.FileComparerByNameDesc(ref files_videos);
                fileIComparer.FileComparerByNameDesc(ref files_images);
            }
            for (int i = 0; i < files_videos.Count; i++)
            {
                string newname = "v" + (i + number).ToString();
                string name = files_videos[i].Name;
                string[] list = name.Split('.');
                string houzhui = list[list.Length - 1].ToLower();
                string allname = newname + "." + houzhui;
                files_videos[i].MoveTo(endpath + "\\" + allname);
            }
            for (int i = 0; i < files_images.Count; i++)
            {
                string newname = (i + number).ToString();
                string name = files_images[i].Name;
                string[] list = name.Split('.');
                string houzhui = list[list.Length - 1].ToLower();
                string allname = newname + "." + houzhui;
                files_images[i].MoveTo(endpath + "\\" + allname);
            }
        }

        private void TryMoveFiles(string startpath, string endpath, int number, int length, bool desc)
        {

            List<FileInfo> files = fileHelper.GetAllFilesInPath(startpath);
            if (files.Count == 0)
            {
                return;
            }
            FileIComparer fileIComparer = new FileIComparer();
            //筛选视屏文件
            List<FileInfo> files_videos = files.Where(t =>
            {
                string[] list = t.Name.Split('.');
                string houzhui = list[list.Length - 1].ToLower();
                if (houzhui == "mp4" || houzhui == "mov" || houzhui == "avi")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }).ToList();
            //筛选图片文件
            List<FileInfo> files_images = files.Where(t =>
            {
                string[] list = t.Name.Split('.');
                string houzhui = list[list.Length - 1].ToLower();
                if (houzhui == "jpg" || houzhui == "png" || houzhui == "jpeg" || houzhui == "gif")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }).ToList();

            //文件排序
            if (desc)
            {
                fileIComparer.FileComparerByNameAsc(ref files_videos);
                fileIComparer.FileComparerByNameAsc(ref files_images);
            }
            else
            {
                fileIComparer.FileComparerByNameDesc(ref files_videos);
                fileIComparer.FileComparerByNameDesc(ref files_images);
            }
            for (int i = 0; i < files_videos.Count; i++)
            {
                string newname = "v" + GetStringLength((i + number).ToString(), length);
                string name = files_videos[i].Name;
                string[] list = name.Split('.');
                string houzhui = list[list.Length - 1].ToLower();
                string allname = newname + "." + houzhui;
                files_videos[i].MoveTo(endpath + "\\" + allname);
            }
            for (int i = 0; i < files_images.Count; i++)
            {
                string newname = GetStringLength((i + number).ToString(), length);
                string name = files_images[i].Name;
                string[] list = name.Split('.');
                string houzhui = list[list.Length - 1].ToLower();
                string allname = newname + "." + houzhui;
                files_images[i].MoveTo(endpath + "\\" + allname);
            }
        }

        public string GetStringLength(string value, int length)
        {
            string result = "";
            for (int i = 0; i < length; i++)
            {
                if (length - value.Length == 0)
                {
                    result = value;
                }
                else if (length - value.Length == 1)
                {
                    result = "0" + value;
                }
                else if (length - value.Length == 2)
                {
                    result = "00" + value;
                }
                else if (length - value.Length == 3)
                {
                    result = "000" + value;
                }
            }
            return result;
        }
    }
}
