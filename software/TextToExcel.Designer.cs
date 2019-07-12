namespace software
{
    partial class TextToExcel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextToExcel));
            this.dgv_content = new System.Windows.Forms.DataGridView();
            this.txt_filepath = new System.Windows.Forms.TextBox();
            this.lab_filepath = new System.Windows.Forms.Label();
            this.But_CreatExcel = new System.Windows.Forms.Button();
            this.But_Select = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.Button();
            this.lab_exportpath = new System.Windows.Forms.Label();
            this.txt_exportpath = new System.Windows.Forms.TextBox();
            this.But_exportpath = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_content)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_content
            // 
            this.dgv_content.BackgroundColor = System.Drawing.Color.White;
            this.dgv_content.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_content.Location = new System.Drawing.Point(1, 149);
            this.dgv_content.Name = "dgv_content";
            this.dgv_content.RowTemplate.Height = 23;
            this.dgv_content.Size = new System.Drawing.Size(826, 302);
            this.dgv_content.TabIndex = 9;
            // 
            // txt_filepath
            // 
            this.txt_filepath.Location = new System.Drawing.Point(83, 54);
            this.txt_filepath.Name = "txt_filepath";
            this.txt_filepath.Size = new System.Drawing.Size(284, 21);
            this.txt_filepath.TabIndex = 11;
            // 
            // lab_filepath
            // 
            this.lab_filepath.AutoSize = true;
            this.lab_filepath.BackColor = System.Drawing.Color.Transparent;
            this.lab_filepath.Location = new System.Drawing.Point(12, 57);
            this.lab_filepath.Name = "lab_filepath";
            this.lab_filepath.Size = new System.Drawing.Size(65, 12);
            this.lab_filepath.TabIndex = 10;
            this.lab_filepath.Text = "文件路径：";
            // 
            // But_CreatExcel
            // 
            this.But_CreatExcel.BackColor = System.Drawing.Color.Transparent;
            this.But_CreatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_CreatExcel.Location = new System.Drawing.Point(237, 93);
            this.But_CreatExcel.Name = "But_CreatExcel";
            this.But_CreatExcel.Size = new System.Drawing.Size(130, 35);
            this.But_CreatExcel.TabIndex = 12;
            this.But_CreatExcel.Text = "创建Excel";
            this.But_CreatExcel.UseVisualStyleBackColor = false;
            this.But_CreatExcel.Click += new System.EventHandler(this.But_CreatExcel_Click);
            // 
            // But_Select
            // 
            this.But_Select.BackColor = System.Drawing.Color.Transparent;
            this.But_Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_Select.Location = new System.Drawing.Point(83, 93);
            this.But_Select.Name = "But_Select";
            this.But_Select.Size = new System.Drawing.Size(130, 35);
            this.But_Select.TabIndex = 13;
            this.But_Select.Text = "生成表格";
            this.But_Select.UseVisualStyleBackColor = false;
            this.But_Select.Click += new System.EventHandler(this.But_Select_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.BackColor = System.Drawing.Color.Transparent;
            this.OpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFile.Location = new System.Drawing.Point(396, 55);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(96, 23);
            this.OpenFile.TabIndex = 14;
            this.OpenFile.Text = "打开文件";
            this.OpenFile.UseVisualStyleBackColor = false;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // lab_exportpath
            // 
            this.lab_exportpath.AutoSize = true;
            this.lab_exportpath.BackColor = System.Drawing.Color.Transparent;
            this.lab_exportpath.Location = new System.Drawing.Point(12, 21);
            this.lab_exportpath.Name = "lab_exportpath";
            this.lab_exportpath.Size = new System.Drawing.Size(65, 12);
            this.lab_exportpath.TabIndex = 19;
            this.lab_exportpath.Text = "导出路径：";
            // 
            // txt_exportpath
            // 
            this.txt_exportpath.Location = new System.Drawing.Point(83, 18);
            this.txt_exportpath.Name = "txt_exportpath";
            this.txt_exportpath.Size = new System.Drawing.Size(284, 21);
            this.txt_exportpath.TabIndex = 20;
            // 
            // But_exportpath
            // 
            this.But_exportpath.BackColor = System.Drawing.Color.Transparent;
            this.But_exportpath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_exportpath.Location = new System.Drawing.Point(396, 18);
            this.But_exportpath.Name = "But_exportpath";
            this.But_exportpath.Size = new System.Drawing.Size(96, 23);
            this.But_exportpath.TabIndex = 21;
            this.But_exportpath.Text = "选择文件夹";
            this.But_exportpath.UseVisualStyleBackColor = false;
            this.But_exportpath.Click += new System.EventHandler(this.But_exportpath_Click);
            // 
            // TextToExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(827, 450);
            this.Controls.Add(this.But_exportpath);
            this.Controls.Add(this.lab_exportpath);
            this.Controls.Add(this.txt_exportpath);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.But_CreatExcel);
            this.Controls.Add(this.But_Select);
            this.Controls.Add(this.txt_filepath);
            this.Controls.Add(this.lab_filepath);
            this.Controls.Add(this.dgv_content);
            this.Name = "TextToExcel";
            this.Text = "TextToExcel";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_content)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_content;
        private System.Windows.Forms.TextBox txt_filepath;
        private System.Windows.Forms.Label lab_filepath;
        private System.Windows.Forms.Button But_CreatExcel;
        private System.Windows.Forms.Button But_Select;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Label lab_exportpath;
        private System.Windows.Forms.TextBox txt_exportpath;
        private System.Windows.Forms.Button But_exportpath;
    }
}