namespace software
{
    partial class ReNameFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReNameFile));
            this.txt_firstpath = new System.Windows.Forms.TextBox();
            this.lab_firstpath = new System.Windows.Forms.Label();
            this.txt_endpath = new System.Windows.Forms.TextBox();
            this.lab_endpath = new System.Windows.Forms.Label();
            this.Btn_FirstPath = new System.Windows.Forms.Button();
            this.Btn_MoveFile = new System.Windows.Forms.Button();
            this.Btn_EndPath = new System.Windows.Forms.Button();
            this.lab_suffix = new System.Windows.Forms.Label();
            this.txt_suffix = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_firstpath
            // 
            this.txt_firstpath.Location = new System.Drawing.Point(242, 143);
            this.txt_firstpath.Name = "txt_firstpath";
            this.txt_firstpath.Size = new System.Drawing.Size(305, 21);
            this.txt_firstpath.TabIndex = 8;
            // 
            // lab_firstpath
            // 
            this.lab_firstpath.AutoSize = true;
            this.lab_firstpath.BackColor = System.Drawing.Color.Transparent;
            this.lab_firstpath.Location = new System.Drawing.Point(145, 143);
            this.lab_firstpath.Name = "lab_firstpath";
            this.lab_firstpath.Size = new System.Drawing.Size(65, 12);
            this.lab_firstpath.TabIndex = 6;
            this.lab_firstpath.Text = "初始路径：";
            // 
            // txt_endpath
            // 
            this.txt_endpath.Location = new System.Drawing.Point(242, 188);
            this.txt_endpath.Name = "txt_endpath";
            this.txt_endpath.Size = new System.Drawing.Size(305, 21);
            this.txt_endpath.TabIndex = 9;
            // 
            // lab_endpath
            // 
            this.lab_endpath.AutoSize = true;
            this.lab_endpath.BackColor = System.Drawing.Color.Transparent;
            this.lab_endpath.Location = new System.Drawing.Point(145, 188);
            this.lab_endpath.Name = "lab_endpath";
            this.lab_endpath.Size = new System.Drawing.Size(65, 12);
            this.lab_endpath.TabIndex = 7;
            this.lab_endpath.Text = "最终路径：";
            // 
            // Btn_FirstPath
            // 
            this.Btn_FirstPath.BackColor = System.Drawing.Color.Transparent;
            this.Btn_FirstPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_FirstPath.Location = new System.Drawing.Point(581, 141);
            this.Btn_FirstPath.Name = "Btn_FirstPath";
            this.Btn_FirstPath.Size = new System.Drawing.Size(75, 23);
            this.Btn_FirstPath.TabIndex = 3;
            this.Btn_FirstPath.Text = "选择文件夹";
            this.Btn_FirstPath.UseVisualStyleBackColor = false;
            this.Btn_FirstPath.Click += new System.EventHandler(this.Btn_FirstPath_Click);
            // 
            // Btn_MoveFile
            // 
            this.Btn_MoveFile.BackColor = System.Drawing.Color.Transparent;
            this.Btn_MoveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_MoveFile.Location = new System.Drawing.Point(298, 284);
            this.Btn_MoveFile.Name = "Btn_MoveFile";
            this.Btn_MoveFile.Size = new System.Drawing.Size(189, 47);
            this.Btn_MoveFile.TabIndex = 4;
            this.Btn_MoveFile.Text = "移动文件";
            this.Btn_MoveFile.UseVisualStyleBackColor = false;
            this.Btn_MoveFile.Click += new System.EventHandler(this.Btn_MoveFile_Click);
            // 
            // Btn_EndPath
            // 
            this.Btn_EndPath.BackColor = System.Drawing.Color.Transparent;
            this.Btn_EndPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EndPath.Location = new System.Drawing.Point(581, 188);
            this.Btn_EndPath.Name = "Btn_EndPath";
            this.Btn_EndPath.Size = new System.Drawing.Size(75, 23);
            this.Btn_EndPath.TabIndex = 5;
            this.Btn_EndPath.Text = "选择文件夹";
            this.Btn_EndPath.UseVisualStyleBackColor = false;
            this.Btn_EndPath.Click += new System.EventHandler(this.Btn_EndPath_Click);
            // 
            // lab_suffix
            // 
            this.lab_suffix.AutoSize = true;
            this.lab_suffix.BackColor = System.Drawing.Color.Transparent;
            this.lab_suffix.Location = new System.Drawing.Point(145, 230);
            this.lab_suffix.Name = "lab_suffix";
            this.lab_suffix.Size = new System.Drawing.Size(65, 12);
            this.lab_suffix.TabIndex = 7;
            this.lab_suffix.Text = "文件后缀：";
            // 
            // txt_suffix
            // 
            this.txt_suffix.Location = new System.Drawing.Point(242, 230);
            this.txt_suffix.Name = "txt_suffix";
            this.txt_suffix.Size = new System.Drawing.Size(305, 21);
            this.txt_suffix.TabIndex = 9;
            // 
            // ReNameFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_firstpath);
            this.Controls.Add(this.lab_firstpath);
            this.Controls.Add(this.txt_suffix);
            this.Controls.Add(this.txt_endpath);
            this.Controls.Add(this.lab_suffix);
            this.Controls.Add(this.lab_endpath);
            this.Controls.Add(this.Btn_FirstPath);
            this.Controls.Add(this.Btn_MoveFile);
            this.Controls.Add(this.Btn_EndPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReNameFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "重命名文件";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_firstpath;
        private System.Windows.Forms.Label lab_firstpath;
        private System.Windows.Forms.TextBox txt_endpath;
        private System.Windows.Forms.Label lab_endpath;
        private System.Windows.Forms.Button Btn_FirstPath;
        private System.Windows.Forms.Button Btn_MoveFile;
        private System.Windows.Forms.Button Btn_EndPath;
        private System.Windows.Forms.Label lab_suffix;
        private System.Windows.Forms.TextBox txt_suffix;
    }
}