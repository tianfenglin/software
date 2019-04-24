using Common;
using SqlHelp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace software
{
    public partial class BuildObject : Form
    {
        private ISqlContent sqlContent;
        SqlCreat sqlCreat = new SqlCreat();
        public BuildObject()
        {
            InitializeComponent();
        }
        //连接数据库
        private void Btn_connect_Click(object sender, EventArgs e)
        {
            //获取数据库类型
            string jdbcType = cob_jdbctype.Text.Trim();
            string jdbc = txt_jdbcname.Text.Trim();
            string user = txt_user.Text.Trim();
            string password = txt_password.Text.Trim();
            DataTable dt = new DataTable();
            //sqlserver数据库
            if (jdbcType == "sqlserver")
            {
                string connect = string.Format("Data Source=.;Initial Catalog={0};uid={1};pwd={2};"
                    , jdbc, user, password);
                sqlContent = new SqlConnect_Ms(connect);
                dt = sqlContent.GetAllTableNames();
            }
            //mysql数据库
            else if (jdbcType == "mysql")
            {
                string connect = string.Format("server=127.0.0.1;port=3306;user={0};password={1}; database={2};"
                    , user, password, jdbc);
                sqlContent = new SqlConnect_My(connect);
                dt = sqlContent.GetAllTableNames();
            }
            MessageBox.Show("数据库连接成功", "提示", MessageBoxButtons.OK);

            List<string> items = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                items.Add(dt.Rows[i]["TABLE_NAME"].ToString());
            }
            items.Sort();
            cob_tablename.Items.Clear();//先清除所有项
            cob_tablename.Items.AddRange(items.ToArray());
        }

        private void But_choose_Click(object sender, EventArgs e)
        {
            string tablename = cob_tablename.Text.Trim();
            string sql = "";
            string jdbcType = cob_jdbctype.Text.Trim();
            string zdlx = cob_buildtype.Text.Trim();
            if (zdlx == "")
            {
                MessageBox.Show("请先选择要生成的类型", "提示", MessageBoxButtons.OK);
                return;
            }
            DataTable dt = new DataTable();
            if (jdbcType == "sqlserver")
            {
                sql = "select j.table_name,j.column_name as name,j.column_description as describes,d.data_type as type from (select "
                + "a.name as table_name,b.name as column_name,c.value as column_description from sys.tables a "
                + "inner join sys.columns b on b.object_id = a.object_id left join sys.extended_properties c "
                + "on c.major_id = b.object_id and c.minor_id = b.column_id where a.name = '" + tablename + "'"
                + ") j left join information_schema.columns d on j.column_name=d.column_name "
                + "where d.table_name = '" + tablename + "'";
                dt = sqlContent.GetTable(sql);
            }
            else if (jdbcType == "mysql")
            {
                sql = "select column_name as name,column_comment as describes,data_type as type from information_schema.columns where"
                    + " table_name='" + tablename + "'";
                dt = sqlContent.GetTable(sql);
            }

            DataTable table = new DataTable();
            table.Columns.Add("name");
            table.Columns.Add("type");
            table.Columns.Add("describes");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string name = dt.Rows[i]["name"].ToString();
                string type = dt.Rows[i]["type"].ToString();
                string describes = dt.Rows[i]["describes"].ToString();
                if (zdlx == "CSharp")
                {
                    type = sqlCreat.GetFieldTypeByCSharp(type);
                }
                else if (zdlx=="Java")
                {
                    type = sqlCreat.GetFieldTypeByJava(type);
                }
                DataRow row = table.NewRow();
                row["name"] = name;
                row["type"] = type;
                row["describes"] = describes;
                table.Rows.Add(row);
            }
            dgv_content.DataSource = table;
            dgv_content.Columns["name"].Width = 200;
            dgv_content.Columns["type"].Width = 200;
            dgv_content.Columns["describes"].Width = 500;
        }

        private void Btn_build_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgv_content.DataSource;
           
            string path = "";
            string bulidtype = cob_buildtype.Text.Trim();
            if (bulidtype == "CSharp")
            {
                path = sqlCreat.GetPathByNet(dt);
            }
            else if (bulidtype == "Java")
            {
                path = sqlCreat.GetPathByJava(dt);
            }

            if (MessageBox.Show("已生成，需要打开吗？", "打开文件", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Process.Start(path);
            }
        }
    }
}
