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
    public partial class ChangeImage : Form
    {
        ImageHelper imageHelper = new ImageHelper();
        public ChangeImage()
        {
            InitializeComponent();
        }

        private void Btn_FirstPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件夹";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                else
                {
                    txt_firstpath.Text = dialog.SelectedPath;
                }
            }
        }

        private void Btn_EndPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件夹";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                else
                {
                    txt_endpath.Text = dialog.SelectedPath;
                }
            }
        }

        private void Btn_ChangeImage_Click(object sender, EventArgs e)
        {
            string startpath = txt_firstpath.Text.Trim();
            string endpath = txt_endpath.Text.Trim();
            int width = Convert.ToInt32(txt_width.Text.Trim());
            int height = Convert.ToInt32(txt_height.Text.Trim());
            string suffix = txt_suffix.Text.Trim();
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
            imageHelper.ChangeImageFormat(startpath, endpath, width, height, suffix);
            MessageBox.Show("导出成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
