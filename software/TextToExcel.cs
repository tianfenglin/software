using ExcelHelp;
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
    public partial class TextToExcel : Form
    {
        public TextToExcel()
        {
            InitializeComponent();
        }

        private void But_Select_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            string filepath = txt_filepath.Text.Trim();
            string[] lines = File.ReadAllLines(filepath, Encoding.Default);
            string[] heards = lines[0].TrimEnd().Split(' ');
            for (int i = 0; i < heards.Length; i++)
            {
                table.Columns.Add(heards[i]);
            }
            for (int i = 1; i < lines.Length; i++)
            {
                string[] row = lines[i].Split(' ');
                table.Rows.Add(row);
            }
            dgv_content.DataSource = table;
        }

        private void OpenFile_Click(object sender, EventArgs e)
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

        private void But_CreatExcel_Click(object sender, EventArgs e)
        {
            string exportpath = txt_exportpath.Text.Trim();
            DataTable table = (DataTable)dgv_content.DataSource;
            EpplusHelper.DataTableToExcel(table, "mysheet", exportpath);
            MessageBox.Show("导出成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void But_exportpath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择存储导出Excel的文件夹";
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
    }
}
