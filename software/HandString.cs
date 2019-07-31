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
    public partial class HandString : Form
    {
        public HandString()
        {
            InitializeComponent();
        }

        private void Btn_TryHand_Click(object sender, EventArgs e)
        {
            //分隔字符
            string split = txt_split.Text.Trim();
            //起始字符
            string start = txt_start.Text.Trim();
            //末尾字符
            string end = txt_end.Text.Trim();
            string[] initial = rtb_initial.Lines;
            string reult = start;
            for (int i = 0; i < initial.Length; i++)
            {
                if (i == initial.Length - 1)
                {
                    reult += initial[i].Trim();
                }
                else
                {
                    reult += initial[i].Trim() + split;
                }

            }
            reult += end;
            rtb_result.Text = reult;
        }

        private void Rtb_initial_TextChanged(object sender, EventArgs e)
        {
            int num = rtb_initial.Lines.Length;
            lab_num.Text = num.ToString();
        }
    }
}
