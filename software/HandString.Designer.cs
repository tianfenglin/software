namespace software
{
    partial class HandString
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HandString));
            this.Btn_TryHand = new System.Windows.Forms.Button();
            this.txt_split = new System.Windows.Forms.TextBox();
            this.lab_split = new System.Windows.Forms.Label();
            this.rtb_initial = new System.Windows.Forms.RichTextBox();
            this.rtb_result = new System.Windows.Forms.RichTextBox();
            this.lab_result = new System.Windows.Forms.Label();
            this.lab_lines = new System.Windows.Forms.Label();
            this.lab_num = new System.Windows.Forms.Label();
            this.lab_start = new System.Windows.Forms.Label();
            this.txt_start = new System.Windows.Forms.TextBox();
            this.lab_end = new System.Windows.Forms.Label();
            this.txt_end = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_TryHand
            // 
            this.Btn_TryHand.BackColor = System.Drawing.Color.Transparent;
            this.Btn_TryHand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_TryHand.Location = new System.Drawing.Point(307, 385);
            this.Btn_TryHand.Name = "Btn_TryHand";
            this.Btn_TryHand.Size = new System.Drawing.Size(96, 39);
            this.Btn_TryHand.TabIndex = 15;
            this.Btn_TryHand.Text = "开始处理";
            this.Btn_TryHand.UseVisualStyleBackColor = false;
            this.Btn_TryHand.Click += new System.EventHandler(this.Btn_TryHand_Click);
            // 
            // txt_split
            // 
            this.txt_split.Location = new System.Drawing.Point(77, 44);
            this.txt_split.Name = "txt_split";
            this.txt_split.Size = new System.Drawing.Size(244, 21);
            this.txt_split.TabIndex = 20;
            // 
            // lab_split
            // 
            this.lab_split.AutoSize = true;
            this.lab_split.BackColor = System.Drawing.Color.Transparent;
            this.lab_split.Location = new System.Drawing.Point(12, 46);
            this.lab_split.Name = "lab_split";
            this.lab_split.Size = new System.Drawing.Size(65, 12);
            this.lab_split.TabIndex = 19;
            this.lab_split.Text = "分隔字符：";
            // 
            // rtb_initial
            // 
            this.rtb_initial.Location = new System.Drawing.Point(1, 76);
            this.rtb_initial.Name = "rtb_initial";
            this.rtb_initial.Size = new System.Drawing.Size(328, 286);
            this.rtb_initial.TabIndex = 21;
            this.rtb_initial.Text = "";
            this.rtb_initial.TextChanged += new System.EventHandler(this.Rtb_initial_TextChanged);
            // 
            // rtb_result
            // 
            this.rtb_result.Location = new System.Drawing.Point(388, 76);
            this.rtb_result.Name = "rtb_result";
            this.rtb_result.Size = new System.Drawing.Size(321, 286);
            this.rtb_result.TabIndex = 21;
            this.rtb_result.Text = "";
            // 
            // lab_result
            // 
            this.lab_result.AutoSize = true;
            this.lab_result.BackColor = System.Drawing.Color.Transparent;
            this.lab_result.Location = new System.Drawing.Point(547, 44);
            this.lab_result.Name = "lab_result";
            this.lab_result.Size = new System.Drawing.Size(65, 12);
            this.lab_result.TabIndex = 19;
            this.lab_result.Text = "处理结果：";
            // 
            // lab_lines
            // 
            this.lab_lines.AutoSize = true;
            this.lab_lines.BackColor = System.Drawing.Color.Transparent;
            this.lab_lines.Location = new System.Drawing.Point(344, 130);
            this.lab_lines.Name = "lab_lines";
            this.lab_lines.Size = new System.Drawing.Size(29, 12);
            this.lab_lines.TabIndex = 19;
            this.lab_lines.Text = "行数";
            // 
            // lab_num
            // 
            this.lab_num.AutoSize = true;
            this.lab_num.BackColor = System.Drawing.Color.Transparent;
            this.lab_num.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_num.ForeColor = System.Drawing.Color.Red;
            this.lab_num.Location = new System.Drawing.Point(348, 161);
            this.lab_num.Name = "lab_num";
            this.lab_num.Size = new System.Drawing.Size(16, 16);
            this.lab_num.TabIndex = 19;
            this.lab_num.Text = "0";
            // 
            // lab_start
            // 
            this.lab_start.AutoSize = true;
            this.lab_start.BackColor = System.Drawing.Color.Transparent;
            this.lab_start.Location = new System.Drawing.Point(12, 12);
            this.lab_start.Name = "lab_start";
            this.lab_start.Size = new System.Drawing.Size(65, 12);
            this.lab_start.TabIndex = 19;
            this.lab_start.Text = "起始字符：";
            // 
            // txt_start
            // 
            this.txt_start.Location = new System.Drawing.Point(77, 9);
            this.txt_start.Name = "txt_start";
            this.txt_start.Size = new System.Drawing.Size(67, 21);
            this.txt_start.TabIndex = 20;
            // 
            // lab_end
            // 
            this.lab_end.AutoSize = true;
            this.lab_end.BackColor = System.Drawing.Color.Transparent;
            this.lab_end.Location = new System.Drawing.Point(186, 13);
            this.lab_end.Name = "lab_end";
            this.lab_end.Size = new System.Drawing.Size(65, 12);
            this.lab_end.TabIndex = 19;
            this.lab_end.Text = "末尾字符：";
            // 
            // txt_end
            // 
            this.txt_end.Location = new System.Drawing.Point(254, 9);
            this.txt_end.Name = "txt_end";
            this.txt_end.Size = new System.Drawing.Size(67, 21);
            this.txt_end.TabIndex = 20;
            // 
            // HandString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.rtb_result);
            this.Controls.Add(this.rtb_initial);
            this.Controls.Add(this.txt_end);
            this.Controls.Add(this.txt_start);
            this.Controls.Add(this.txt_split);
            this.Controls.Add(this.lab_result);
            this.Controls.Add(this.lab_num);
            this.Controls.Add(this.lab_lines);
            this.Controls.Add(this.lab_end);
            this.Controls.Add(this.lab_start);
            this.Controls.Add(this.lab_split);
            this.Controls.Add(this.Btn_TryHand);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HandString";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "字符处理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_TryHand;
        private System.Windows.Forms.TextBox txt_split;
        private System.Windows.Forms.Label lab_split;
        private System.Windows.Forms.RichTextBox rtb_initial;
        private System.Windows.Forms.RichTextBox rtb_result;
        private System.Windows.Forms.Label lab_result;
        private System.Windows.Forms.Label lab_lines;
        private System.Windows.Forms.Label lab_num;
        private System.Windows.Forms.Label lab_start;
        private System.Windows.Forms.TextBox txt_start;
        private System.Windows.Forms.Label lab_end;
        private System.Windows.Forms.TextBox txt_end;
    }
}