using ExcelHelp;
using SqlHelp;
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
    public partial class MakeExcel : Form
    {
        public MakeExcel()
        {
            InitializeComponent();
        }
        private ISqlContent sqlContent;
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

        private void But_Select_Click(object sender, EventArgs e)
        {
            string sql = rtb_sql.Text.TrimEnd();
            DataTable dt = sqlContent.GetTable(sql);
            dgv_content.DataSource = dt;
        }

        private void But_CreatExcel_Click(object sender, EventArgs e)
        {
            string sql = rtb_sql.Text.TrimEnd();
            DataTable dt = sqlContent.GetTable(sql);
            string exportpath = txt_exportpath.Text.Trim();
            EpplusHelper.DataTableToExcel(dt, "mysheet",exportpath);
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
