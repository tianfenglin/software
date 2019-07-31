using ExcelHelp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace software
{
    public partial class UpdateSqlByExcel : Form
    {
        private string filepath = "";
        public UpdateSqlByExcel()
        {
            InitializeComponent();
        }

        private void Btn_UpdateSql_Click(object sender, EventArgs e)
        {
            string keyfield = txt_keyfield.Text.Trim();
            if (keyfield == "")
            {
                MessageBox.Show("请输入主键字段", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string tablename = txt_table.Text.Trim();
            if (tablename == "")
            {
                MessageBox.Show("请输入表的名称", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable table = (DataTable)dgv_content.DataSource;
            //遍历生成更新语句
            List<string> updatesql = new List<string>();
            //获取更新字段集合
            List<string> columns = new List<string>();
            for (int i = 0; i < table.Columns.Count; i++)
            {
                columns.Add(table.Columns[i].ColumnName);
            }

            //更新条件
            List<string> wherekey = new List<string>();
            if (keyfield.Contains(","))
            {
                wherekey.AddRange(keyfield.Split(','));
                //移除条件字段
                for (int i = 0; i < wherekey.Count; i++)
                {
                    columns.Remove(wherekey[i]);
                }
            }
            else
            {
                wherekey.Add(keyfield);
                //移除条件字段
                columns.Remove(keyfield);
            }
            //生成语句
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string setvalue = "";
                //更新字段
                for (int j = 0; j < columns.Count; j++)
                {
                    setvalue += columns[j] + " = '" + table.Rows[i][columns[j]].ToString() + "',";
                }
                //移除最后 ,
                setvalue = setvalue.Remove(setvalue.Length - 1, 1);
                //更新条件
                string updatewhere = "";
                for (int j = 0; j < wherekey.Count; j++)
                {
                    updatewhere += " and " + wherekey[j] + " = '" + table.Rows[i][wherekey[j]].ToString() + "'";
                }
                //移除最初 and 包含空格
                updatewhere = updatewhere.Remove(0, 5);
                string sql = string.Format("update {0} set {1} where {2}", tablename, setvalue, updatewhere);
                updatesql.Add(sql);
            }
            string lujing = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "更新语句.txt");
            File.WriteAllLines(lujing, updatesql);
            if (MessageBox.Show("已生成，需要打开吗？", "打开文件", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Process.Start(lujing);
            }
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
                DataTable dt = NpoiHelper.ExcelToDataTable("mysheet", true, filepath);
                dgv_content.DataSource = dt;
            }
        }
    }
}
