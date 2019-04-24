namespace baidu
{
    partial class DiscernText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscernText));
            this.But_ChooseImages = new System.Windows.Forms.Button();
            this.lab_filepath = new System.Windows.Forms.Label();
            this.txt_filepath = new System.Windows.Forms.TextBox();
            this.rtb_content = new System.Windows.Forms.RichTextBox();
            this.Btn_TryOrc_One = new System.Windows.Forms.Button();
            this.ptb_images = new System.Windows.Forms.PictureBox();
            this.Btn_BuildTxt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_images)).BeginInit();
            this.SuspendLayout();
            // 
            // But_ChooseImages
            // 
            this.But_ChooseImages.BackColor = System.Drawing.Color.Transparent;
            this.But_ChooseImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_ChooseImages.Location = new System.Drawing.Point(548, 85);
            this.But_ChooseImages.Name = "But_ChooseImages";
            this.But_ChooseImages.Size = new System.Drawing.Size(101, 30);
            this.But_ChooseImages.TabIndex = 0;
            this.But_ChooseImages.Text = "选择图片";
            this.But_ChooseImages.UseVisualStyleBackColor = false;
            this.But_ChooseImages.Click += new System.EventHandler(this.But_ChooseImages_Click);
            // 
            // lab_filepath
            // 
            this.lab_filepath.AutoSize = true;
            this.lab_filepath.BackColor = System.Drawing.Color.Transparent;
            this.lab_filepath.Location = new System.Drawing.Point(139, 94);
            this.lab_filepath.Name = "lab_filepath";
            this.lab_filepath.Size = new System.Drawing.Size(65, 12);
            this.lab_filepath.TabIndex = 1;
            this.lab_filepath.Text = "文件路径：";
            // 
            // txt_filepath
            // 
            this.txt_filepath.Location = new System.Drawing.Point(222, 91);
            this.txt_filepath.Name = "txt_filepath";
            this.txt_filepath.Size = new System.Drawing.Size(291, 21);
            this.txt_filepath.TabIndex = 2;
            // 
            // rtb_content
            // 
            this.rtb_content.Location = new System.Drawing.Point(436, 218);
            this.rtb_content.Name = "rtb_content";
            this.rtb_content.Size = new System.Drawing.Size(342, 207);
            this.rtb_content.TabIndex = 3;
            this.rtb_content.Text = "";
            // 
            // Btn_TryOrc_One
            // 
            this.Btn_TryOrc_One.BackColor = System.Drawing.Color.Transparent;
            this.Btn_TryOrc_One.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_TryOrc_One.Location = new System.Drawing.Point(548, 121);
            this.Btn_TryOrc_One.Name = "Btn_TryOrc_One";
            this.Btn_TryOrc_One.Size = new System.Drawing.Size(101, 30);
            this.Btn_TryOrc_One.TabIndex = 0;
            this.Btn_TryOrc_One.Text = "一般识别";
            this.Btn_TryOrc_One.UseVisualStyleBackColor = false;
            this.Btn_TryOrc_One.Click += new System.EventHandler(this.Btn_TryOrc_One_Click);
            // 
            // ptb_images
            // 
            this.ptb_images.BackColor = System.Drawing.Color.Transparent;
            this.ptb_images.Location = new System.Drawing.Point(25, 218);
            this.ptb_images.Name = "ptb_images";
            this.ptb_images.Size = new System.Drawing.Size(387, 207);
            this.ptb_images.TabIndex = 4;
            this.ptb_images.TabStop = false;
            // 
            // Btn_BuildTxt
            // 
            this.Btn_BuildTxt.BackColor = System.Drawing.Color.Transparent;
            this.Btn_BuildTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_BuildTxt.Location = new System.Drawing.Point(548, 157);
            this.Btn_BuildTxt.Name = "Btn_BuildTxt";
            this.Btn_BuildTxt.Size = new System.Drawing.Size(101, 30);
            this.Btn_BuildTxt.TabIndex = 0;
            this.Btn_BuildTxt.Text = "生成文本";
            this.Btn_BuildTxt.UseVisualStyleBackColor = false;
            this.Btn_BuildTxt.Click += new System.EventHandler(this.Btn_BuildTxt_Click);
            // 
            // DiscernText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ptb_images);
            this.Controls.Add(this.rtb_content);
            this.Controls.Add(this.txt_filepath);
            this.Controls.Add(this.lab_filepath);
            this.Controls.Add(this.Btn_BuildTxt);
            this.Controls.Add(this.Btn_TryOrc_One);
            this.Controls.Add(this.But_ChooseImages);
            this.Name = "DiscernText";
            this.Text = "图片识别文字";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_images)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button But_ChooseImages;
        private System.Windows.Forms.Label lab_filepath;
        private System.Windows.Forms.TextBox txt_filepath;
        private System.Windows.Forms.RichTextBox rtb_content;
        private System.Windows.Forms.Button Btn_TryOrc_One;
        private System.Windows.Forms.PictureBox ptb_images;
        private System.Windows.Forms.Button Btn_BuildTxt;
    }
}