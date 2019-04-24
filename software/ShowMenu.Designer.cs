namespace software
{
    partial class ShowMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowMenu));
            this.CreatExcel = new System.Windows.Forms.Button();
            this.Replace = new System.Windows.Forms.Button();
            this.rtb_brief = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreatExcel
            // 
            this.CreatExcel.BackColor = System.Drawing.Color.Transparent;
            this.CreatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatExcel.Location = new System.Drawing.Point(21, 23);
            this.CreatExcel.Name = "CreatExcel";
            this.CreatExcel.Size = new System.Drawing.Size(84, 37);
            this.CreatExcel.TabIndex = 0;
            this.CreatExcel.Text = "构建excel";
            this.CreatExcel.UseVisualStyleBackColor = false;
            this.CreatExcel.Click += new System.EventHandler(this.CreatExcel_Click);
            this.CreatExcel.MouseHover += new System.EventHandler(this.CreatExcel_MouseHover);
            // 
            // Replace
            // 
            this.Replace.BackColor = System.Drawing.Color.Transparent;
            this.Replace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Replace.Location = new System.Drawing.Point(152, 23);
            this.Replace.Name = "Replace";
            this.Replace.Size = new System.Drawing.Size(84, 37);
            this.Replace.TabIndex = 0;
            this.Replace.Text = "替换excel";
            this.Replace.UseVisualStyleBackColor = false;
            this.Replace.Click += new System.EventHandler(this.Replace_Click);
            this.Replace.MouseHover += new System.EventHandler(this.Replace_MouseHover);
            // 
            // rtb_brief
            // 
            this.rtb_brief.Location = new System.Drawing.Point(6, 20);
            this.rtb_brief.Name = "rtb_brief";
            this.rtb_brief.Size = new System.Drawing.Size(764, 176);
            this.rtb_brief.TabIndex = 1;
            this.rtb_brief.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rtb_brief);
            this.groupBox1.Location = new System.Drawing.Point(12, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 202);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能说明";
            // 
            // ShowMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Replace);
            this.Controls.Add(this.CreatExcel);
            this.Name = "ShowMenu";
            this.Text = "功能菜单";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreatExcel;
        private System.Windows.Forms.Button Replace;
        private System.Windows.Forms.RichTextBox rtb_brief;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}