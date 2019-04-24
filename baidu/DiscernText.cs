using BaiDuApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baidu
{
    public partial class DiscernText : Form
    {
        WordsOrc wordsOrc = new WordsOrc();
        //private string filepath = "";
        public DiscernText()
        {
            InitializeComponent();
        }

        private void But_ChooseImages_Click(object sender, EventArgs e)
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
            ofd.Filter = "png图片|*.png|jpg图片|*.jpg|所有文件|*.*";
            //设置文件对话框当前选定的筛选器的索引
            ofd.FilterIndex = 2;
            //设置对话框是否记忆之前打开的目录
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //获取用户选择的文件完整路径
                //filepath = ofd.FileName;
                //获取对话框中所选文件的文件名和扩展名，文件名不包括路径
                //string fileName = ofd.SafeFileName;
                txt_filepath.Text = ofd.FileName;

            }
            ptb_images.ImageLocation = txt_filepath.Text.Trim();
        }

        private void Btn_TryOrc_One_Click(object sender, EventArgs e)
        {
            string path = txt_filepath.Text.Trim();
            List<string> list= wordsOrc.GeneralBasic(path);
            string value = "";
            for (int i = 0; i < list.Count; i++)
            {
                value += list[i];
            }
            rtb_content.Text = value;
        }

        private void Btn_BuildTxt_Click(object sender, EventArgs e)
        {

        }
    }
}
