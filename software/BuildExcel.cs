using ExcelHelp;
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

namespace software
{
    public partial class BuildExcel : Form
    {
        private string filepath = "";
        public BuildExcel()
        {
            InitializeComponent();
        }
        //打开文件
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

            }
        }

        private void TryBuild_Click(object sender, EventArgs e)
        {
            string table = txt_table.Text.Trim();
            if (table == "")
            {
                MessageBox.Show("表名称不能为空", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (filepath == "")
            {
                MessageBox.Show("请先选择文件", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<string> sqllist = new List<string>();
            //获取excel成datatable
            DataTable dt = NpoiHelper.ExcelToDataTable("mysheet", true, filepath);
            int dt_column_count = dt.Columns.Count;
            int dt_row_count = dt.Rows.Count;
            List<string> columns = new List<string>();//excel中字段列
            for (int i = 0; i < dt_column_count; i++)
            {
                columns.Add(dt.Columns[i].ColumnName);
            }
            object[] auto = GetGridviewValue();
            List<string> auto_columns = (List<string>)auto[0];//自动字段
            List<string> auto_values = (List<string>)auto[1];//自动字段类型
            List<string> all_columns = new List<string>();//插入的所有字段
            all_columns.AddRange(columns);
            all_columns.AddRange(auto_columns);
            for (int i = 0; i < dt_row_count; i++)
            {
                List<string> values = new List<string>();
                for (int j = 0; j < dt_column_count; j++)
                {
                    values.Add(dt.Rows[i][j].ToString());
                }
                //自动字段赋值
                for (int n = 0; n < auto_values.Count; n++)
                {
                    string autotype = auto_values[n];
                    if (autotype == "当前时间")
                    {
                        values.Add(DateTime.Now.ToString());
                    }
                    else if (autotype == "时间字符")
                    {
                        values.Add(DateTime.Now.ToString("yyyyMMddHHmmssfff"));
                    }
                    else if (autotype == "guid")
                    {

                    }
                }
                //拼写sql
                string sql_one = string.Format("insert into {0}({1}) values('{2}')", table, string.Join(",", all_columns)
                    , string.Join("','", values));
                sqllist.Add(sql_one);
            }
            //写入文本及导出
            string lujing = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "插入语句.txt");
            File.WriteAllLines(lujing, sqllist);
            if (MessageBox.Show("已生成，需要打开吗？", "打开文件", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Process.Start(lujing);
            }
        }

        /// <summary>
        /// 获取Gridview中字段及字段类型
        /// </summary>
        /// <returns></returns>
        public object[] GetGridviewValue()
        {
            List<string> columns = new List<string>();
            List<string> values = new List<string>();
            int rows = autobuild.RowCount;
            if (rows > 1)
            {
                for (int i = 0; i < rows - 1; i++)
                {
                    string valuetype = autobuild.Rows[i].Cells[1].Value.ToString();
                    if (valuetype == "")
                    {
                        continue;
                    }
                    string valuetext = autobuild.Rows[i].Cells[0].Value.ToString();
                    if (valuetext == "")
                    {
                        continue;
                    }
                    columns.Add(valuetext);
                    values.Add(valuetype);
                }
            }
            return new object[] { columns, values };
        }

        private void Btn_UpdateSql_Click(object sender, EventArgs e)
        {
            string table = txt_table.Text.Trim();
            string where_zd = txt_where.Text.Trim();
            if (table == "")
            {
                MessageBox.Show("表名称不能为空", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (filepath == "")
            {
                MessageBox.Show("请先选择文件", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<string> sqllist = new List<string>();
            //获取excel成datatable
            DataTable dt = NpoiHelper.ExcelToDataTable("mysheet", true, filepath);
            int dt_column_count = dt.Columns.Count;
            int dt_row_count = dt.Rows.Count;
            List<string> columns = new List<string>();//excel中字段列
            for (int i = 0; i < dt_column_count; i++)
            {
                columns.Add(dt.Columns[i].ColumnName);
            }
            object[] auto = GetGridviewValue();
            List<string> auto_columns = (List<string>)auto[0];//自动字段
            List<string> auto_values = (List<string>)auto[1];//自动字段类型
            List<string> all_columns = new List<string>();//插入的所有字段
            all_columns.AddRange(columns);
            all_columns.AddRange(auto_columns);
            string sql = "";
            for (int i = 0; i < dt_row_count; i++)
            {
                sql += dt.Rows[i]["userid"] + ",";
            }
            sqllist.Add(sql);

            #region MyRegion
            //for (int i = 0; i < dt_row_count; i++)
            //{
            //    List<string> values = new List<string>();
            //    for (int j = 0; j < dt_column_count; j++)
            //    {
            //        values.Add(dt.Rows[i][j].ToString());
            //    }
            //    //自动字段赋值
            //    for (int n = 0; n < auto_values.Count; n++)
            //    {
            //        string autotype = auto_values[n];
            //        if (autotype == "当前时间")
            //        {
            //            values.Add(DateTime.Now.ToString());
            //        }
            //        else if (autotype == "时间字符")
            //        {
            //            values.Add(DateTime.Now.ToString("yyyyMMddHHmmssfff"));
            //        }
            //    }
            //    string updatesql = "";
            //    for (int j = 0; j < all_columns.Count; j++)
            //    {
            //        if (j == 0)
            //        {
            //            updatesql += string.Format(" set {0} = {1},", all_columns[j], values[j]);
            //        }
            //        else if (j == all_columns.Count - 1)
            //        {
            //            updatesql += string.Format(" {0} = {1}", all_columns[j], values[j]);
            //        }
            //        else
            //        {
            //            updatesql += string.Format(" {0} = {1},", all_columns[j], values[j]);
            //        }

            //    }
            //    string where = string.Format(" where {0} = '{1}'", dt[]);
            //    //拼写sql
            //    string sql_one = string.Format("update {0} {1} {2}", table, updatesql
            //        , string.Join("','", values));
            //    sqllist.Add(sql_one);
            //} 
            #endregion

            //写入文本及导出
            string lujing = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "更新语句.txt");
            File.WriteAllLines(lujing, sqllist);
            if (MessageBox.Show("已生成，需要打开吗？", "打开文件", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Process.Start(lujing);
            }
        }
    }
}
