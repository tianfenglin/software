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
            this.Btn_MoveFile = new System.Windows.Forms.Button();
            this.Btn_HandString = new System.Windows.Forms.Button();
            this.Btn_ChangeImage = new System.Windows.Forms.Button();
            this.Btn_BuildObject = new System.Windows.Forms.Button();
            this.Btn_UpdateSql = new System.Windows.Forms.Button();
            this.Btn_UpdateSqlByExcel = new System.Windows.Forms.Button();
            this.Btn_TextToExcel = new System.Windows.Forms.Button();
            this.Btn_ValidateIdCard = new System.Windows.Forms.Button();
            this.Btn_MakeImages = new System.Windows.Forms.Button();
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
            this.Replace.Location = new System.Drawing.Point(136, 23);
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
            // Btn_MoveFile
            // 
            this.Btn_MoveFile.BackColor = System.Drawing.Color.Transparent;
            this.Btn_MoveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_MoveFile.Location = new System.Drawing.Point(248, 23);
            this.Btn_MoveFile.Name = "Btn_MoveFile";
            this.Btn_MoveFile.Size = new System.Drawing.Size(84, 37);
            this.Btn_MoveFile.TabIndex = 0;
            this.Btn_MoveFile.Text = "移动文件";
            this.Btn_MoveFile.UseVisualStyleBackColor = false;
            this.Btn_MoveFile.Click += new System.EventHandler(this.Btn_MoveFile_Click);
            this.Btn_MoveFile.MouseHover += new System.EventHandler(this.Replace_MouseHover);
            // 
            // Btn_HandString
            // 
            this.Btn_HandString.BackColor = System.Drawing.Color.Transparent;
            this.Btn_HandString.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_HandString.Location = new System.Drawing.Point(373, 23);
            this.Btn_HandString.Name = "Btn_HandString";
            this.Btn_HandString.Size = new System.Drawing.Size(84, 37);
            this.Btn_HandString.TabIndex = 0;
            this.Btn_HandString.Text = "字符处理";
            this.Btn_HandString.UseVisualStyleBackColor = false;
            this.Btn_HandString.Click += new System.EventHandler(this.Btn_HandString_Click);
            this.Btn_HandString.MouseHover += new System.EventHandler(this.Replace_MouseHover);
            // 
            // Btn_ChangeImage
            // 
            this.Btn_ChangeImage.BackColor = System.Drawing.Color.Transparent;
            this.Btn_ChangeImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ChangeImage.Location = new System.Drawing.Point(496, 23);
            this.Btn_ChangeImage.Name = "Btn_ChangeImage";
            this.Btn_ChangeImage.Size = new System.Drawing.Size(84, 37);
            this.Btn_ChangeImage.TabIndex = 0;
            this.Btn_ChangeImage.Text = "图片转换";
            this.Btn_ChangeImage.UseVisualStyleBackColor = false;
            this.Btn_ChangeImage.Click += new System.EventHandler(this.Btn_ChangeImage_Click);
            this.Btn_ChangeImage.MouseHover += new System.EventHandler(this.Replace_MouseHover);
            // 
            // Btn_BuildObject
            // 
            this.Btn_BuildObject.BackColor = System.Drawing.Color.Transparent;
            this.Btn_BuildObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_BuildObject.Location = new System.Drawing.Point(621, 23);
            this.Btn_BuildObject.Name = "Btn_BuildObject";
            this.Btn_BuildObject.Size = new System.Drawing.Size(84, 37);
            this.Btn_BuildObject.TabIndex = 0;
            this.Btn_BuildObject.Text = "构建类";
            this.Btn_BuildObject.UseVisualStyleBackColor = false;
            this.Btn_BuildObject.Click += new System.EventHandler(this.Btn_BuildObject_Click);
            this.Btn_BuildObject.MouseHover += new System.EventHandler(this.Replace_MouseHover);
            // 
            // Btn_UpdateSql
            // 
            this.Btn_UpdateSql.BackColor = System.Drawing.Color.Transparent;
            this.Btn_UpdateSql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_UpdateSql.Location = new System.Drawing.Point(21, 85);
            this.Btn_UpdateSql.Name = "Btn_UpdateSql";
            this.Btn_UpdateSql.Size = new System.Drawing.Size(84, 37);
            this.Btn_UpdateSql.TabIndex = 0;
            this.Btn_UpdateSql.Text = "更新sql一";
            this.Btn_UpdateSql.UseVisualStyleBackColor = false;
            this.Btn_UpdateSql.Click += new System.EventHandler(this.Btn_UpdateSql_Click);
            this.Btn_UpdateSql.MouseHover += new System.EventHandler(this.Replace_MouseHover);
            // 
            // Btn_UpdateSqlByExcel
            // 
            this.Btn_UpdateSqlByExcel.BackColor = System.Drawing.Color.Transparent;
            this.Btn_UpdateSqlByExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_UpdateSqlByExcel.Location = new System.Drawing.Point(136, 85);
            this.Btn_UpdateSqlByExcel.Name = "Btn_UpdateSqlByExcel";
            this.Btn_UpdateSqlByExcel.Size = new System.Drawing.Size(84, 37);
            this.Btn_UpdateSqlByExcel.TabIndex = 0;
            this.Btn_UpdateSqlByExcel.Text = "更新sql二";
            this.Btn_UpdateSqlByExcel.UseVisualStyleBackColor = false;
            this.Btn_UpdateSqlByExcel.Click += new System.EventHandler(this.Btn_UpdateSqlByExcel_Click);
            this.Btn_UpdateSqlByExcel.MouseHover += new System.EventHandler(this.Replace_MouseHover);
            // 
            // Btn_TextToExcel
            // 
            this.Btn_TextToExcel.BackColor = System.Drawing.Color.Transparent;
            this.Btn_TextToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_TextToExcel.Location = new System.Drawing.Point(250, 85);
            this.Btn_TextToExcel.Name = "Btn_TextToExcel";
            this.Btn_TextToExcel.Size = new System.Drawing.Size(84, 37);
            this.Btn_TextToExcel.TabIndex = 0;
            this.Btn_TextToExcel.Text = "txt转excel";
            this.Btn_TextToExcel.UseVisualStyleBackColor = false;
            this.Btn_TextToExcel.Click += new System.EventHandler(this.Btn_TextToExcel_Click);
            this.Btn_TextToExcel.MouseHover += new System.EventHandler(this.Replace_MouseHover);
            // 
            // Btn_ValidateIdCard
            // 
            this.Btn_ValidateIdCard.BackColor = System.Drawing.Color.Transparent;
            this.Btn_ValidateIdCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ValidateIdCard.Location = new System.Drawing.Point(373, 85);
            this.Btn_ValidateIdCard.Name = "Btn_ValidateIdCard";
            this.Btn_ValidateIdCard.Size = new System.Drawing.Size(84, 37);
            this.Btn_ValidateIdCard.TabIndex = 0;
            this.Btn_ValidateIdCard.Text = "身份证验证";
            this.Btn_ValidateIdCard.UseVisualStyleBackColor = false;
            this.Btn_ValidateIdCard.Click += new System.EventHandler(this.Btn_ValidateIdCard_Click);
            this.Btn_ValidateIdCard.MouseHover += new System.EventHandler(this.Replace_MouseHover);
            // 
            // Btn_MakeImages
            // 
            this.Btn_MakeImages.BackColor = System.Drawing.Color.Transparent;
            this.Btn_MakeImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_MakeImages.Location = new System.Drawing.Point(496, 85);
            this.Btn_MakeImages.Name = "Btn_MakeImages";
            this.Btn_MakeImages.Size = new System.Drawing.Size(84, 37);
            this.Btn_MakeImages.TabIndex = 0;
            this.Btn_MakeImages.Text = "压缩图片";
            this.Btn_MakeImages.UseVisualStyleBackColor = false;
            this.Btn_MakeImages.Click += new System.EventHandler(this.Btn_MakeImages_Click);
            this.Btn_MakeImages.MouseHover += new System.EventHandler(this.Replace_MouseHover);
            // 
            // ShowMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_MakeImages);
            this.Controls.Add(this.Btn_ValidateIdCard);
            this.Controls.Add(this.Btn_TextToExcel);
            this.Controls.Add(this.Btn_UpdateSqlByExcel);
            this.Controls.Add(this.Btn_UpdateSql);
            this.Controls.Add(this.Btn_BuildObject);
            this.Controls.Add(this.Btn_ChangeImage);
            this.Controls.Add(this.Btn_HandString);
            this.Controls.Add(this.Btn_MoveFile);
            this.Controls.Add(this.Replace);
            this.Controls.Add(this.CreatExcel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "功能菜单";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreatExcel;
        private System.Windows.Forms.Button Replace;
        private System.Windows.Forms.RichTextBox rtb_brief;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_MoveFile;
        private System.Windows.Forms.Button Btn_HandString;
        private System.Windows.Forms.Button Btn_ChangeImage;
        private System.Windows.Forms.Button Btn_BuildObject;
        private System.Windows.Forms.Button Btn_UpdateSql;
        private System.Windows.Forms.Button Btn_UpdateSqlByExcel;
        private System.Windows.Forms.Button Btn_TextToExcel;
        private System.Windows.Forms.Button Btn_ValidateIdCard;
        private System.Windows.Forms.Button Btn_MakeImages;
    }
}