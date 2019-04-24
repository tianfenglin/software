namespace software
{
    partial class MoveFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoveFile));
            this.Btn_EndPath = new System.Windows.Forms.Button();
            this.lab_endpath = new System.Windows.Forms.Label();
            this.txt_endpath = new System.Windows.Forms.TextBox();
            this.Btn_MoveFile = new System.Windows.Forms.Button();
            this.Btn_FirstPath = new System.Windows.Forms.Button();
            this.lab_firstpath = new System.Windows.Forms.Label();
            this.txt_firstpath = new System.Windows.Forms.TextBox();
            this.ckb_child = new System.Windows.Forms.CheckBox();
            this.lab_startnum = new System.Windows.Forms.Label();
            this.txt_startnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_length = new System.Windows.Forms.TextBox();
            this.ckb_listway = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Btn_EndPath
            // 
            this.Btn_EndPath.BackColor = System.Drawing.Color.Transparent;
            this.Btn_EndPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EndPath.Location = new System.Drawing.Point(536, 191);
            this.Btn_EndPath.Name = "Btn_EndPath";
            this.Btn_EndPath.Size = new System.Drawing.Size(75, 23);
            this.Btn_EndPath.TabIndex = 0;
            this.Btn_EndPath.Text = "选择文件夹";
            this.Btn_EndPath.UseVisualStyleBackColor = false;
            this.Btn_EndPath.Click += new System.EventHandler(this.Btn_EndPath_Click);
            // 
            // lab_endpath
            // 
            this.lab_endpath.AutoSize = true;
            this.lab_endpath.BackColor = System.Drawing.Color.Transparent;
            this.lab_endpath.Location = new System.Drawing.Point(100, 191);
            this.lab_endpath.Name = "lab_endpath";
            this.lab_endpath.Size = new System.Drawing.Size(65, 12);
            this.lab_endpath.TabIndex = 1;
            this.lab_endpath.Text = "最终路径：";
            // 
            // txt_endpath
            // 
            this.txt_endpath.Location = new System.Drawing.Point(197, 191);
            this.txt_endpath.Name = "txt_endpath";
            this.txt_endpath.Size = new System.Drawing.Size(305, 21);
            this.txt_endpath.TabIndex = 2;
            // 
            // Btn_MoveFile
            // 
            this.Btn_MoveFile.BackColor = System.Drawing.Color.Transparent;
            this.Btn_MoveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_MoveFile.Location = new System.Drawing.Point(257, 265);
            this.Btn_MoveFile.Name = "Btn_MoveFile";
            this.Btn_MoveFile.Size = new System.Drawing.Size(189, 47);
            this.Btn_MoveFile.TabIndex = 0;
            this.Btn_MoveFile.Text = "移动文件";
            this.Btn_MoveFile.UseVisualStyleBackColor = false;
            this.Btn_MoveFile.Click += new System.EventHandler(this.Btn_MoveFile_Click);
            // 
            // Btn_FirstPath
            // 
            this.Btn_FirstPath.BackColor = System.Drawing.Color.Transparent;
            this.Btn_FirstPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_FirstPath.Location = new System.Drawing.Point(536, 144);
            this.Btn_FirstPath.Name = "Btn_FirstPath";
            this.Btn_FirstPath.Size = new System.Drawing.Size(75, 23);
            this.Btn_FirstPath.TabIndex = 0;
            this.Btn_FirstPath.Text = "选择文件夹";
            this.Btn_FirstPath.UseVisualStyleBackColor = false;
            this.Btn_FirstPath.Click += new System.EventHandler(this.Btn_FirstPath_Click);
            // 
            // lab_firstpath
            // 
            this.lab_firstpath.AutoSize = true;
            this.lab_firstpath.BackColor = System.Drawing.Color.Transparent;
            this.lab_firstpath.Location = new System.Drawing.Point(100, 146);
            this.lab_firstpath.Name = "lab_firstpath";
            this.lab_firstpath.Size = new System.Drawing.Size(65, 12);
            this.lab_firstpath.TabIndex = 1;
            this.lab_firstpath.Text = "初始路径：";
            // 
            // txt_firstpath
            // 
            this.txt_firstpath.Location = new System.Drawing.Point(197, 146);
            this.txt_firstpath.Name = "txt_firstpath";
            this.txt_firstpath.Size = new System.Drawing.Size(305, 21);
            this.txt_firstpath.TabIndex = 2;
            // 
            // ckb_child
            // 
            this.ckb_child.AutoSize = true;
            this.ckb_child.BackColor = System.Drawing.Color.Transparent;
            this.ckb_child.Location = new System.Drawing.Point(347, 53);
            this.ckb_child.Name = "ckb_child";
            this.ckb_child.Size = new System.Drawing.Size(84, 16);
            this.ckb_child.TabIndex = 3;
            this.ckb_child.Text = "包含子目录";
            this.ckb_child.UseVisualStyleBackColor = false;
            // 
            // lab_startnum
            // 
            this.lab_startnum.AutoSize = true;
            this.lab_startnum.BackColor = System.Drawing.Color.Transparent;
            this.lab_startnum.Location = new System.Drawing.Point(100, 95);
            this.lab_startnum.Name = "lab_startnum";
            this.lab_startnum.Size = new System.Drawing.Size(65, 12);
            this.lab_startnum.TabIndex = 4;
            this.lab_startnum.Text = "开始编号：";
            // 
            // txt_startnum
            // 
            this.txt_startnum.Location = new System.Drawing.Point(197, 92);
            this.txt_startnum.Name = "txt_startnum";
            this.txt_startnum.Size = new System.Drawing.Size(126, 21);
            this.txt_startnum.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(345, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "字符长度：";
            // 
            // txt_length
            // 
            this.txt_length.Location = new System.Drawing.Point(442, 92);
            this.txt_length.Name = "txt_length";
            this.txt_length.Size = new System.Drawing.Size(126, 21);
            this.txt_length.TabIndex = 5;
            // 
            // ckb_listway
            // 
            this.ckb_listway.AutoSize = true;
            this.ckb_listway.BackColor = System.Drawing.Color.Transparent;
            this.ckb_listway.Location = new System.Drawing.Point(197, 53);
            this.ckb_listway.Name = "ckb_listway";
            this.ckb_listway.Size = new System.Drawing.Size(72, 16);
            this.ckb_listway.TabIndex = 3;
            this.ckb_listway.Text = "是否倒序";
            this.ckb_listway.UseVisualStyleBackColor = false;
            // 
            // MoveFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_length);
            this.Controls.Add(this.txt_startnum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_startnum);
            this.Controls.Add(this.ckb_listway);
            this.Controls.Add(this.ckb_child);
            this.Controls.Add(this.txt_firstpath);
            this.Controls.Add(this.lab_firstpath);
            this.Controls.Add(this.txt_endpath);
            this.Controls.Add(this.lab_endpath);
            this.Controls.Add(this.Btn_FirstPath);
            this.Controls.Add(this.Btn_MoveFile);
            this.Controls.Add(this.Btn_EndPath);
            this.Name = "MoveFile";
            this.Text = "移动文件";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_EndPath;
        private System.Windows.Forms.Label lab_endpath;
        private System.Windows.Forms.TextBox txt_endpath;
        private System.Windows.Forms.Button Btn_MoveFile;
        private System.Windows.Forms.Button Btn_FirstPath;
        private System.Windows.Forms.Label lab_firstpath;
        private System.Windows.Forms.TextBox txt_firstpath;
        private System.Windows.Forms.CheckBox ckb_child;
        private System.Windows.Forms.Label lab_startnum;
        private System.Windows.Forms.TextBox txt_startnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_length;
        private System.Windows.Forms.CheckBox ckb_listway;
    }
}