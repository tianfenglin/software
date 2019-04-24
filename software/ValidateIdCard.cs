using Common;
using ExcelHelp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace software
{
    public partial class ValidateIdCard : Form
    {
        private string filepath = "";
        public ValidateIdCard()
        {
            InitializeComponent();
        }

        private void Btn_StartPath_Click(object sender, EventArgs e)
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
            ofd.Filter = "Excel-2003|*.xls|Excel-2007|*.xlsx|所有文件|*.*";
            //设置文件对话框当前选定的筛选器的索引
            ofd.FilterIndex = 2;
            //设置对话框是否记忆之前打开的目录
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //获取用户选择的文件完整路径
                filepath = ofd.FileName;
                //获取对话框中所选文件的文件名和扩展名，文件名不包括路径
                string fileName = ofd.SafeFileName;
                lab_filename.Text = fileName;

            }
        }

        private void Btn_EndPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择导出文件夹";
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

        private void Btn_TryRun_Click(object sender, EventArgs e)
        {
            GreatExcel();
        }

        private void GreatExcel()
        {
            string exportpath = txt_endpath.Text.Trim();
            if (filepath == "")
            {
                MessageBox.Show("请先选择文件", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //判断是否存在目录
            TableHelper tableHelper = new TableHelper();
            DataTable dt = ExcelHelper.ExcelToDataTable("mysheet", true, filepath);
            DataTable table = dt.Clone();
            ValidateHelper validateHelper = new ValidateHelper();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string idcard = dt.Rows[i]["idcard"].ToString();
                string userid = dt.Rows[i]["userid"].ToString();
                string username = dt.Rows[i]["username"].ToString();
                string areaname = dt.Rows[i]["areaname"].ToString();
                bool istrue = validateHelper.IsIdCard(idcard);
                if (!istrue)
                {
                    DataRow row = table.NewRow();
                    row["userid"] = userid;
                    row["username"] = username;
                    row["idcard"] = idcard;
                    row["areaname"] = areaname;
                    table.Rows.Add(row);
                }
            }
            ExcelHelper.DataTableToExcel(table, "mysheet", true, exportpath);
            MessageBox.Show("验证完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
