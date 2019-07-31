
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
    public partial class ShowMenu : Form
    {
        public ShowMenu()
        {
            InitializeComponent();
        }
        //构建Excel
        private void CreatExcel_Click(object sender, EventArgs e)
        {
            BuildExcel app = new BuildExcel();
            app.Show();
        }
        //替换Excel
        private void Replace_Click(object sender, EventArgs e)
        {
            Replace app = new Replace();
            app.Show();
        }

        private void CreatExcel_MouseHover(object sender, EventArgs e)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.ini");
            IniHelper inihelp = new IniHelper(path);
            string value = inihelp.IniReadValue("excel", "build");
            rtb_brief.Text = value;
        }

        private void Replace_MouseHover(object sender, EventArgs e)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.ini");
            IniHelper inihelp = new IniHelper(path);
            string value = inihelp.IniReadValue("excel", "replace");
            rtb_brief.Text = value;
        }

        private void Btn_MoveFile_Click(object sender, EventArgs e)
        {
            MoveFile app = new MoveFile();
            app.Show();
        }

        private void Btn_HandString_Click(object sender, EventArgs e)
        {
            HandString app = new HandString();
            app.Show();
        }

        private void Btn_ChangeImage_Click(object sender, EventArgs e)
        {
            ChangeImage app = new ChangeImage();
            app.Show();
        }

        private void Btn_BuildObject_Click(object sender, EventArgs e)
        {
            BuildObject app = new BuildObject();
            app.Show();
        }

        private void Btn_UpdateSql_Click(object sender, EventArgs e)
        {
            UpdateSql app = new UpdateSql();
            app.Show();
        }

        private void Btn_UpdateSqlByExcel_Click(object sender, EventArgs e)
        {
            UpdateSqlByExcel app = new UpdateSqlByExcel();
            app.Show();
        }

        private void Btn_ValidateIdCard_Click(object sender, EventArgs e)
        {
            ValidateIdCard app = new ValidateIdCard();
            app.Show();
        }

        private void Btn_TextToExcel_Click(object sender, EventArgs e)
        {
            TextToExcel app = new TextToExcel();
            app.Show();
        }

        private void Btn_MakeImages_Click(object sender, EventArgs e)
        {
            MakeImages app = new MakeImages();
            app.Show();
        }
    }
}
