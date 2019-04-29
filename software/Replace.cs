using Common;
using ExcelHelp;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace software
{
    public partial class Replace : Form
    {
        private string filepath = "";
        DataTable dt = new DataTable();
        public Replace()
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
                dt = null;
                dt = NpoiHelper.ExcelToDataTable("mysheet", true, filepath);
            }
        }

        private void Choose_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择Txt所在文件夹";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
            }

        }

        private void Export_Click(object sender, EventArgs e)
        {
            GreatExcel();
        }
        private void GreatExcel()
        {
            string path = txt_filepath.Text.Trim();
            string exportpath = txt_exportpath.Text.Trim();
            string exportphoto = txt_exportphoto.Text.Trim();

            if (path == "")
            {
                MessageBox.Show("文件路径不能为空", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //判断是否存在目录
            if (!Directory.Exists(path))
            {
                MessageBox.Show("文件路径不存在", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (filepath == "")
            {
                MessageBox.Show("请先选择文件", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //判断是否存在目录
            TableHelper tableHelper = new TableHelper();
            DataTable dt = NpoiHelper.ExcelToDataTable("mysheet", true, filepath);
            //dt = tableHelper.ReplaceData(dt, "sfzz");
            //dt = tableHelper.ReplaceData(dt, "sfxr");
            FileHelper fileHelper = new FileHelper();
            List<DirectoryInfo> folders = fileHelper.GetAllFoldersInPath(path);
            List<FileInfo> files = fileHelper.GetAllFilesInPaths(folders);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string name = dt.Rows[i]["name"].ToString();
                string newname = dt.Rows[i]["newname"].ToString();
                if (name.Contains(" "))
                {
                    name = name.Replace(" ", "");
                    dt.Rows[i]["name"] = name;
                }
                string photo = fileHelper.IsExistFile(name, files, "default.jpg", newname, exportphoto);
                dt.Rows[i]["photo"] = photo;
            }
            NpoiHelper.DataTableToExcel(dt, "mysheet", true, exportpath);
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

        private void But_exportphoto_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择存储导出图片的文件夹";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                else
                {
                    txt_exportphoto.Text = dialog.SelectedPath;
                }
            }
        }

        //导出重名
        private void Btn_SameName_Click(object sender, EventArgs e)
        {
            string path = txt_filepath.Text.Trim();
            string exportpath = txt_exportpath.Text.Trim();
            TableHelper tableHelper = new TableHelper();
            DataTable dt = NpoiHelper.ExcelToDataTable("mysheet", true, filepath);
            DataTable table = dt.Clone();
            List<string> record = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Regex reg = new Regex(@"\s/g");
                string name = reg.Replace(dt.Rows[i]["name"].ToString(), "");
                dt.Rows[i]["name"] = name;
                if (record.Contains(name))
                {
                    continue;
                }
                record.Add(name);
                DataRow[] rows = dt.Select("name = '" + name + "'");
                if (rows.Length > 1)
                {
                    foreach (DataRow item in rows)
                    {
                        //解决该行已经属于另一个表
                        table.Rows.Add(item.ItemArray);
                    }

                }
            }
            NpoiHelper.DataTableToExcel(table, "mysheet", true, exportpath);
            MessageBox.Show("导出成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_Change_Click(object sender, EventArgs e)
        {


            //获取列名称
            string columnname = txt_columnname.Text.Trim();
            if (columnname == "")
            {
                MessageBox.Show("请填写列名", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!dt.Columns.Contains(columnname))
            {
                MessageBox.Show("不存在此列名", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //条件判断，智能取其中一个


            #region 条件一
            if (Ckb_isuseone.Checked)
            {
                //查找相同 删除重复数据，并把重复数据导入到新建的excel中
                if (ckb_issame.Checked)
                {
                    string path = txt_filepath.Text.Trim();
                    string exportpath = txt_exportpath.Text.Trim();
                    DataTable table = dt.Clone();
                    List<string> names = new List<string>();
                    Regex reg = new Regex(@"\s");
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        string name = reg.Replace(dt.Rows[i][columnname].ToString(), "", 999);
                        //去除中间空格及左右空格，防止数据错误
                        dt.Rows[i][columnname] = name;
                        //判断是否已经处理过这名字
                        if (names.Contains(name))
                        {
                            continue;
                        }
                        names.Add(name);
                        List<DataRow> rows = dt.Select().Where(t => reg.Replace(t[columnname].ToString(), "",999) == name).ToList();
                        if (rows.Count > 1)
                        {

                            foreach (DataRow item in rows)
                            {
                                //删除空格
                                item[columnname] = reg.Replace(item[columnname].ToString(), "",999);
                                //解决该行已经属于另一个表
                                table.Rows.Add(item.ItemArray);
                                //删除重复数据
                                dt.Rows.Remove(item);

                            }

                        }
                    }
                    NpoiHelper.DataTableToExcel(table, "mysheet", true, exportpath);
                    MessageBox.Show("导出成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            #endregion

            #region 条件二
            if (Ckb_isusetwo.Checked)
            {
                string where_one = txt_whereone.Text.Trim();
                string where_two = txt_wheretwo.Text.Trim();
                string where_three = txt_wherethree.Text.Trim();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string value = dt.Rows[i][columnname].ToString();
                    //去除中间空格及左右空格，防止数据错误
                    value = value.Trim().Replace(" ", "");
                    if (value == where_one)
                    {
                        value = txt_resultone.Text.Trim();
                    }
                    else if (value == where_two)
                    {
                        value = txt_resulttwo.Text.Trim();
                    }
                    else if (value == where_three)
                    {
                        value = txt_resultthree.Text.Trim();
                    }
                    dt.Rows[i][columnname] = value;
                }
            }

            #endregion

            #region 条件三
            if (Ckb_isusethree.Checked)
            {

                //是否是身份证
                if (ckb_isidcard.Checked)
                {
                    ValidateHelper validateHelper = new ValidateHelper();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string value = dt.Rows[i][columnname].ToString();
                        //去除中间空格及左右空格，防止数据错误
                        value = value.Trim().Replace(" ", "");
                        if (value != "")
                        {
                            bool istrue = validateHelper.IsIdCard(value);
                            if (!istrue)
                            {
                                dt.Rows[i][columnname] = value + "数据错误";
                            }
                        }

                    }
                }
            }

            #endregion
            MessageBox.Show("更改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void Ckb_isuseone_CheckedChanged(object sender, EventArgs e)
        {
            //只能启用一个条件项
            if (Ckb_isuseone.Checked)
            {
                Ckb_isusetwo.Checked = false;
                Ckb_isusethree.Checked = false;
            }
        }

        private void Ckb_isusetwo_CheckedChanged(object sender, EventArgs e)
        {
            //只能启用一个条件项
            if (Ckb_isusetwo.Checked)
            {
                Ckb_isuseone.Checked = false;
                Ckb_isusethree.Checked = false;
            }
        }

        private void Ckb_isusethree_CheckedChanged(object sender, EventArgs e)
        {
            //只能启用一个条件项
            if (Ckb_isusethree.Checked)
            {
                Ckb_isuseone.Checked = false;
                Ckb_isusetwo.Checked = false;
            }
        }

        private void Btn_Dddc_Click(object sender, EventArgs e)
        {
            string exportpath = txt_exportpath.Text.Trim();
            NpoiHelper.DataTableToExcel(dt, "mysheet", true, exportpath);
            MessageBox.Show("导出成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
