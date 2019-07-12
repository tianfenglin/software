namespace software
{
    partial class MakeImages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeImages));
            this.But_exportpath = new System.Windows.Forms.Button();
            this.lab_exportpath = new System.Windows.Forms.Label();
            this.txt_exportpath = new System.Windows.Forms.TextBox();
            this.But_OpenFile = new System.Windows.Forms.Button();
            this.But_MoreImage = new System.Windows.Forms.Button();
            this.But_OneImage = new System.Windows.Forms.Button();
            this.txt_filepath = new System.Windows.Forms.TextBox();
            this.lab_filepath = new System.Windows.Forms.Label();
            this.txt_importpath = new System.Windows.Forms.TextBox();
            this.lab_importpath = new System.Windows.Forms.Label();
            this.But_ImportPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // But_exportpath
            // 
            this.But_exportpath.BackColor = System.Drawing.Color.Transparent;
            this.But_exportpath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_exportpath.Location = new System.Drawing.Point(544, 170);
            this.But_exportpath.Name = "But_exportpath";
            this.But_exportpath.Size = new System.Drawing.Size(82, 23);
            this.But_exportpath.TabIndex = 29;
            this.But_exportpath.Text = "选择文件夹";
            this.But_exportpath.UseVisualStyleBackColor = false;
            this.But_exportpath.Click += new System.EventHandler(this.But_exportpath_Click);
            // 
            // lab_exportpath
            // 
            this.lab_exportpath.AutoSize = true;
            this.lab_exportpath.BackColor = System.Drawing.Color.Transparent;
            this.lab_exportpath.Location = new System.Drawing.Point(160, 173);
            this.lab_exportpath.Name = "lab_exportpath";
            this.lab_exportpath.Size = new System.Drawing.Size(65, 12);
            this.lab_exportpath.TabIndex = 27;
            this.lab_exportpath.Text = "导出路径：";
            // 
            // txt_exportpath
            // 
            this.txt_exportpath.Location = new System.Drawing.Point(231, 170);
            this.txt_exportpath.Name = "txt_exportpath";
            this.txt_exportpath.Size = new System.Drawing.Size(284, 21);
            this.txt_exportpath.TabIndex = 28;
            // 
            // But_OpenFile
            // 
            this.But_OpenFile.BackColor = System.Drawing.Color.Transparent;
            this.But_OpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_OpenFile.Location = new System.Drawing.Point(544, 101);
            this.But_OpenFile.Name = "But_OpenFile";
            this.But_OpenFile.Size = new System.Drawing.Size(82, 23);
            this.But_OpenFile.TabIndex = 26;
            this.But_OpenFile.Text = "打开文件";
            this.But_OpenFile.UseVisualStyleBackColor = false;
            this.But_OpenFile.Click += new System.EventHandler(this.But_OpenFile_Click);
            // 
            // But_MoreImage
            // 
            this.But_MoreImage.BackColor = System.Drawing.Color.Transparent;
            this.But_MoreImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_MoreImage.Location = new System.Drawing.Point(385, 245);
            this.But_MoreImage.Name = "But_MoreImage";
            this.But_MoreImage.Size = new System.Drawing.Size(130, 35);
            this.But_MoreImage.TabIndex = 24;
            this.But_MoreImage.Text = "多文件操作";
            this.But_MoreImage.UseVisualStyleBackColor = false;
            this.But_MoreImage.Click += new System.EventHandler(this.But_MoreImage_Click);
            // 
            // But_OneImage
            // 
            this.But_OneImage.BackColor = System.Drawing.Color.Transparent;
            this.But_OneImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_OneImage.Location = new System.Drawing.Point(231, 245);
            this.But_OneImage.Name = "But_OneImage";
            this.But_OneImage.Size = new System.Drawing.Size(130, 35);
            this.But_OneImage.TabIndex = 25;
            this.But_OneImage.Text = "单文件操作";
            this.But_OneImage.UseVisualStyleBackColor = false;
            this.But_OneImage.Click += new System.EventHandler(this.But_OneImage_Click);
            // 
            // txt_filepath
            // 
            this.txt_filepath.Location = new System.Drawing.Point(231, 100);
            this.txt_filepath.Name = "txt_filepath";
            this.txt_filepath.Size = new System.Drawing.Size(284, 21);
            this.txt_filepath.TabIndex = 23;
            // 
            // lab_filepath
            // 
            this.lab_filepath.AutoSize = true;
            this.lab_filepath.BackColor = System.Drawing.Color.Transparent;
            this.lab_filepath.Location = new System.Drawing.Point(160, 103);
            this.lab_filepath.Name = "lab_filepath";
            this.lab_filepath.Size = new System.Drawing.Size(65, 12);
            this.lab_filepath.TabIndex = 22;
            this.lab_filepath.Text = "文件路径：";
            // 
            // txt_importpath
            // 
            this.txt_importpath.Location = new System.Drawing.Point(231, 137);
            this.txt_importpath.Name = "txt_importpath";
            this.txt_importpath.Size = new System.Drawing.Size(284, 21);
            this.txt_importpath.TabIndex = 28;
            // 
            // lab_importpath
            // 
            this.lab_importpath.AutoSize = true;
            this.lab_importpath.BackColor = System.Drawing.Color.Transparent;
            this.lab_importpath.Location = new System.Drawing.Point(160, 140);
            this.lab_importpath.Name = "lab_importpath";
            this.lab_importpath.Size = new System.Drawing.Size(65, 12);
            this.lab_importpath.TabIndex = 27;
            this.lab_importpath.Text = "导入路径：";
            // 
            // But_ImportPath
            // 
            this.But_ImportPath.BackColor = System.Drawing.Color.Transparent;
            this.But_ImportPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_ImportPath.Location = new System.Drawing.Point(544, 137);
            this.But_ImportPath.Name = "But_ImportPath";
            this.But_ImportPath.Size = new System.Drawing.Size(82, 23);
            this.But_ImportPath.TabIndex = 29;
            this.But_ImportPath.Text = "选择文件夹";
            this.But_ImportPath.UseVisualStyleBackColor = false;
            this.But_ImportPath.Click += new System.EventHandler(this.But_ImportPath_Click);
            // 
            // MakeImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.But_ImportPath);
            this.Controls.Add(this.But_exportpath);
            this.Controls.Add(this.lab_importpath);
            this.Controls.Add(this.txt_importpath);
            this.Controls.Add(this.lab_exportpath);
            this.Controls.Add(this.txt_exportpath);
            this.Controls.Add(this.But_OpenFile);
            this.Controls.Add(this.But_MoreImage);
            this.Controls.Add(this.But_OneImage);
            this.Controls.Add(this.txt_filepath);
            this.Controls.Add(this.lab_filepath);
            this.Name = "MakeImages";
            this.Text = "图片编辑";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button But_exportpath;
        private System.Windows.Forms.Label lab_exportpath;
        private System.Windows.Forms.TextBox txt_exportpath;
        private System.Windows.Forms.Button But_OpenFile;
        private System.Windows.Forms.Button But_MoreImage;
        private System.Windows.Forms.Button But_OneImage;
        private System.Windows.Forms.TextBox txt_filepath;
        private System.Windows.Forms.Label lab_filepath;
        private System.Windows.Forms.TextBox txt_importpath;
        private System.Windows.Forms.Label lab_importpath;
        private System.Windows.Forms.Button But_ImportPath;
    }
}