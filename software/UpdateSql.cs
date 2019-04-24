using Common;
using SqlHelp;
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
    public partial class UpdateSql : Form
    {
        public UpdateSql()
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

        private void But_ChoosePath_Click(object sender, EventArgs e)
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
                    txt_choosepath.Text = dialog.SelectedPath;
                }
            }
        }

        private void But_ExportPath_Click(object sender, EventArgs e)
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

        private void But_Run_Click(object sender, EventArgs e)
        {
            string exportpath = txt_exportpath.Text.Trim();
            string choosetpath = txt_choosepath.Text.Trim();
            FileHelper fileHelper = new FileHelper();
            List<DirectoryInfo> folders = fileHelper.GetAllFoldersInPath(choosetpath);
            List<FileInfo> files = fileHelper.GetAllFilesInPaths(folders);
            #region 判断是否为空
            string keyfield = txt_keyfield.Text.Trim();
            if (keyfield == "")
            {
                MessageBox.Show("请输入主键字段", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string mainfield = txt_mainfield.Text.Trim();
            if (mainfield == "")
            {
                MessageBox.Show("请输入条件字段", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string replacefield = txt_replacefield.Text.Trim();
            if (replacefield == "")
            {
                MessageBox.Show("请输入替换字段", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string newname = txt_newname.Text.Trim();
            if (replacefield == "")
            {
                MessageBox.Show("请输入新的名称", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string tablename = txt_tablename.Text.Trim();
            if (tablename == "")
            {
                MessageBox.Show("请输入表的名称", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion
            DataTable table = (DataTable)dgv_content.DataSource;
            DataTable dt = table.Clone();
            //循环获取有图片的列表集合
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string name = table.Rows[i][mainfield].ToString();
                string photo = fileHelper.IsExistFile(name, files, "default.jpg", newname, exportpath);
                if (photo != "存在多条数据" && photo != "default.jpg")
                {
                    table.Rows[i][replacefield] = photo;
                    //使用ItemArray，解决该行已经属于另一个表
                    dt.Rows.Add(table.Rows[i].ItemArray);
                }
            }
            //遍历生成更新语句
            List<string> updatesql = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string sql = string.Format("update {0} set {1} = '{2}' where {3} = '{4}'", tablename, replacefield
                    , dt.Rows[i][replacefield].ToString(), keyfield, dt.Rows[i][keyfield].ToString());
                updatesql.Add(sql);
            }
            string lujing = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "更新语句.txt");
            File.WriteAllLines(lujing, updatesql);
            if (MessageBox.Show("已生成，需要打开吗？", "打开文件", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Process.Start(lujing);
            }
        }
    }
}
