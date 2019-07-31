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
    public partial class ReNameFile : Form
    {
        FileHelper fileHelper = new FileHelper();
        public ReNameFile()
        {
            InitializeComponent();
        }

        private void Btn_MoveFile_Click(object sender, EventArgs e)
        {
            string startpath = txt_firstpath.Text.Trim();
            string endpath = txt_endpath.Text.Trim();
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
            fileHelper.ReNamePathFileSuffix(startpath, endpath, suffix);
            MessageBox.Show("导出成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_FirstPath_Click(object sender, EventArgs e)
        {

        }

        private void Btn_EndPath_Click(object sender, EventArgs e)
        {

        }
    }
}
