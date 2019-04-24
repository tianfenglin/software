
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
    }
}
