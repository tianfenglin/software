namespace software
{
    partial class ChangeImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeImage));
            this.txt_firstpath = new System.Windows.Forms.TextBox();
            this.lab_firstpath = new System.Windows.Forms.Label();
            this.txt_suffix = new System.Windows.Forms.TextBox();
            this.txt_endpath = new System.Windows.Forms.TextBox();
            this.lab_suffix = new System.Windows.Forms.Label();
            this.lab_endpath = new System.Windows.Forms.Label();
            this.Btn_FirstPath = new System.Windows.Forms.Button();
            this.Btn_ChangeImage = new System.Windows.Forms.Button();
            this.Btn_EndPath = new System.Windows.Forms.Button();
            this.lab_width = new System.Windows.Forms.Label();
            this.txt_width = new System.Windows.Forms.TextBox();
            this.lab_height = new System.Windows.Forms.Label();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_firstpath
            // 
            this.txt_firstpath.Location = new System.Drawing.Point(242, 132);
            this.txt_firstpath.Name = "txt_firstpath";
            this.txt_firstpath.Size = new System.Drawing.Size(305, 21);
            this.txt_firstpath.TabIndex = 16;
            // 
            // lab_firstpath
            // 
            this.lab_firstpath.AutoSize = true;
            this.lab_firstpath.BackColor = System.Drawing.Color.Transparent;
            this.lab_firstpath.Location = new System.Drawing.Point(145, 132);
            this.lab_firstpath.Name = "lab_firstpath";
            this.lab_firstpath.Size = new System.Drawing.Size(65, 12);
            this.lab_firstpath.TabIndex = 13;
            this.lab_firstpath.Text = "初始路径：";
            // 
            // txt_suffix
            // 
            this.txt_suffix.Location = new System.Drawing.Point(242, 219);
            this.txt_suffix.Name = "txt_suffix";
            this.txt_suffix.Size = new System.Drawing.Size(305, 21);
            this.txt_suffix.TabIndex = 17;
            // 
            // txt_endpath
            // 
            this.txt_endpath.Location = new System.Drawing.Point(242, 177);
            this.txt_endpath.Name = "txt_endpath";
            this.txt_endpath.Size = new System.Drawing.Size(305, 21);
            this.txt_endpath.TabIndex = 18;
            // 
            // lab_suffix
            // 
            this.lab_suffix.AutoSize = true;
            this.lab_suffix.BackColor = System.Drawing.Color.Transparent;
            this.lab_suffix.Location = new System.Drawing.Point(145, 219);
            this.lab_suffix.Name = "lab_suffix";
            this.lab_suffix.Size = new System.Drawing.Size(65, 12);
            this.lab_suffix.TabIndex = 14;
            this.lab_suffix.Text = "文件后缀：";
            // 
            // lab_endpath
            // 
            this.lab_endpath.AutoSize = true;
            this.lab_endpath.BackColor = System.Drawing.Color.Transparent;
            this.lab_endpath.Location = new System.Drawing.Point(145, 177);
            this.lab_endpath.Name = "lab_endpath";
            this.lab_endpath.Size = new System.Drawing.Size(65, 12);
            this.lab_endpath.TabIndex = 15;
            this.lab_endpath.Text = "最终路径：";
            // 
            // Btn_FirstPath
            // 
            this.Btn_FirstPath.BackColor = System.Drawing.Color.Transparent;
            this.Btn_FirstPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_FirstPath.Location = new System.Drawing.Point(581, 130);
            this.Btn_FirstPath.Name = "Btn_FirstPath";
            this.Btn_FirstPath.Size = new System.Drawing.Size(75, 23);
            this.Btn_FirstPath.TabIndex = 10;
            this.Btn_FirstPath.Text = "选择文件夹";
            this.Btn_FirstPath.UseVisualStyleBackColor = false;
            this.Btn_FirstPath.Click += new System.EventHandler(this.Btn_FirstPath_Click);
            // 
            // Btn_ChangeImage
            // 
            this.Btn_ChangeImage.BackColor = System.Drawing.Color.Transparent;
            this.Btn_ChangeImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ChangeImage.Location = new System.Drawing.Point(294, 297);
            this.Btn_ChangeImage.Name = "Btn_ChangeImage";
            this.Btn_ChangeImage.Size = new System.Drawing.Size(189, 47);
            this.Btn_ChangeImage.TabIndex = 11;
            this.Btn_ChangeImage.Text = "转换图片";
            this.Btn_ChangeImage.UseVisualStyleBackColor = false;
            this.Btn_ChangeImage.Click += new System.EventHandler(this.Btn_ChangeImage_Click);
            // 
            // Btn_EndPath
            // 
            this.Btn_EndPath.BackColor = System.Drawing.Color.Transparent;
            this.Btn_EndPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EndPath.Location = new System.Drawing.Point(581, 177);
            this.Btn_EndPath.Name = "Btn_EndPath";
            this.Btn_EndPath.Size = new System.Drawing.Size(75, 23);
            this.Btn_EndPath.TabIndex = 12;
            this.Btn_EndPath.Text = "选择文件夹";
            this.Btn_EndPath.UseVisualStyleBackColor = false;
            this.Btn_EndPath.Click += new System.EventHandler(this.Btn_EndPath_Click);
            // 
            // lab_width
            // 
            this.lab_width.AutoSize = true;
            this.lab_width.BackColor = System.Drawing.Color.Transparent;
            this.lab_width.Location = new System.Drawing.Point(145, 75);
            this.lab_width.Name = "lab_width";
            this.lab_width.Size = new System.Drawing.Size(65, 12);
            this.lab_width.TabIndex = 14;
            this.lab_width.Text = "图片宽度：";
            // 
            // txt_width
            // 
            this.txt_width.Location = new System.Drawing.Point(242, 73);
            this.txt_width.Name = "txt_width";
            this.txt_width.Size = new System.Drawing.Size(305, 21);
            this.txt_width.TabIndex = 17;
            // 
            // lab_height
            // 
            this.lab_height.AutoSize = true;
            this.lab_height.BackColor = System.Drawing.Color.Transparent;
            this.lab_height.Location = new System.Drawing.Point(145, 100);
            this.lab_height.Name = "lab_height";
            this.lab_height.Size = new System.Drawing.Size(65, 12);
            this.lab_height.TabIndex = 14;
            this.lab_height.Text = "图片高度：";
            // 
            // txt_height
            // 
            this.txt_height.Location = new System.Drawing.Point(242, 100);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(305, 21);
            this.txt_height.TabIndex = 17;
            // 
            // ChangeImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_firstpath);
            this.Controls.Add(this.lab_firstpath);
            this.Controls.Add(this.txt_height);
            this.Controls.Add(this.txt_width);
            this.Controls.Add(this.txt_suffix);
            this.Controls.Add(this.txt_endpath);
            this.Controls.Add(this.lab_height);
            this.Controls.Add(this.lab_width);
            this.Controls.Add(this.lab_suffix);
            this.Controls.Add(this.lab_endpath);
            this.Controls.Add(this.Btn_FirstPath);
            this.Controls.Add(this.Btn_ChangeImage);
            this.Controls.Add(this.Btn_EndPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图片转换";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_firstpath;
        private System.Windows.Forms.Label lab_firstpath;
        private System.Windows.Forms.TextBox txt_suffix;
        private System.Windows.Forms.TextBox txt_endpath;
        private System.Windows.Forms.Label lab_suffix;
        private System.Windows.Forms.Label lab_endpath;
        private System.Windows.Forms.Button Btn_FirstPath;
        private System.Windows.Forms.Button Btn_ChangeImage;
        private System.Windows.Forms.Button Btn_EndPath;
        private System.Windows.Forms.Label lab_width;
        private System.Windows.Forms.TextBox txt_width;
        private System.Windows.Forms.Label lab_height;
        private System.Windows.Forms.TextBox txt_height;
    }
}