using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace software
{
    public partial class MakeImages : Form
    {
        ImageHelper imageHelper = new ImageHelper();
        public MakeImages()
        {
            InitializeComponent();
        }

        private void But_OpenFile_Click(object sender, EventArgs e)
        {
            //定义一个文件打开控件
            OpenFileDialog ofd = new OpenFileDialog();
            //设置打开对话框的初始目录，默认目录为exe运行文件所在的路径
            ofd.InitialDirectory = Application.StartupPath;
            //设置打开对话框的标题
            ofd.Title = "请选择要打开的文件";
            //设置打开对话框可以多选
            ofd.Multiselect = true;
            //设置对话框打开的文件类型
            ofd.Filter = "文本文件|*.txt";
            //设置文件对话框当前选定的筛选器的索引
            ofd.FilterIndex = 2;
            //设置对话框是否记忆之前打开的目录
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //获取对话框中所选文件的文件名和扩展名包括路径
                string fileName = ofd.FileName;
                txt_filepath.Text = fileName;

            }
        }

        private void But_ImportPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择导入图片的文件夹";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                else
                {
                    txt_importpath.Text = dialog.SelectedPath;
                }
            }
        }

        private void But_exportpath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择导出图片的文件夹";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                else
                {
                    txt_exportpath.Text = dialog.SelectedPath;
                }
            }
        }

        private void But_OneImage_Click(object sender, EventArgs e)
        {
            string importfile = txt_filepath.Text;
            string exportpath = txt_exportpath.Text;
            //判断是否存在目录
            if (importfile == "")
            {
                MessageBox.Show("请选择文件", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //判断是否存在目录
            if (!Directory.Exists(exportpath))
            {
                MessageBox.Show("导出文件路径不存在", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            imageHelper.CompressImage(importfile, exportpath);
            MessageBox.Show("导出成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void But_MoreImage_Click(object sender, EventArgs e)
        {
            string importpath = txt_importpath.Text;
            string exportpath = txt_exportpath.Text;
            //判断是否存在目录
            if (!Directory.Exists(importpath))
            {
                MessageBox.Show("导入文件路径不存在", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //判断是否存在目录
            if (!Directory.Exists(exportpath))
            {
                MessageBox.Show("导出文件路径不存在", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            imageHelper.CompressImages(importpath, exportpath);
            MessageBox.Show("导出成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
