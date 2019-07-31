using SqlHelp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace software
{
    public partial class MakeSql : Form
    {
        private ISqlContent sqlContent;
        public MakeSql()
        {
            InitializeComponent();
        }

        private void But_Select_Click(object sender, EventArgs e)
        {
            string sql = rtb_sql.Text.TrimEnd();
            DataTable dt = sqlContent.GetTable(sql);
            dgv_content.DataSource = dt;
        }

        private void Btn_connect_Click(object sender, EventArgs e)
        {
            //获取数据库类型
            string jdbcType = cob_jdbctype.Text.Trim();
            string jdbc = txt_jdbcname.Text.Trim();
            string user = txt_user.Text.Trim();
            string password = txt_password.Text.Trim();
            //sqlserver数据库
            if (jdbcType == "sqlserver")
            {
                string connect = string.Format("Data Source=.;Initial Catalog={0};uid={1};pwd={2};"
                    , jdbc, user, password);
                sqlContent = new SqlConnect_Ms(connect);
            }
            //mysql数据库
            else if (jdbcType == "mysql")
            {
                string connect = string.Format("server=127.0.0.1;port=3306;user={0};password={1}; database={2};"
                    , user, password, jdbc);
                sqlContent = new SqlConnect_My(connect);
            }
            MessageBox.Show("数据库连接成功", "提示", MessageBoxButtons.OK);
        }

        private void But_CreatSql_Click(object sender, EventArgs e)
        {
            string table = txt_tablename.Text.Trim();
            List<string> sqllist = new List<string>();
            string sql = rtb_sql.Text.TrimEnd();
            DataTable dt = sqlContent.GetTable(sql);
            int dt_column_count = dt.Columns.Count;
            int dt_row_count = dt.Rows.Count;
            List<string> columns = new List<string>();
            for (int i = 0; i < dt_column_count; i++)
            {
                columns.Add(dt.Columns[i].ColumnName);
            }
            for (int i = 0; i < dt_row_count; i++)
            {
                List<string> values = new List<string>();
                for (int j = 0; j < dt_column_count; j++)
                {
                    values.Add(dt.Rows[i][j].ToString());
                }
                //拼写sql
                string sql_one = string.Format("insert into {0}({1}) values('{2}')", table, string.Join(",", columns)
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
    }
}
