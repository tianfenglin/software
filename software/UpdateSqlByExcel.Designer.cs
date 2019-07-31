namespace software
{
    partial class UpdateSqlByExcel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSqlByExcel));
            this.lab_filename = new System.Windows.Forms.Label();
            this.lab_wjmc = new System.Windows.Forms.Label();
            this.txt_table = new System.Windows.Forms.TextBox();
            this.lab_table = new System.Windows.Forms.Label();
            this.OpenFile = new System.Windows.Forms.Button();
            this.Btn_UpdateSql = new System.Windows.Forms.Button();
            this.dgv_content = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_keyfield = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_content)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_filename
            // 
            this.lab_filename.AutoSize = true;
            this.lab_filename.BackColor = System.Drawing.Color.Transparent;
            this.lab_filename.Location = new System.Drawing.Point(94, 54);
            this.lab_filename.Name = "lab_filename";
            this.lab_filename.Size = new System.Drawing.Size(41, 12);
            this.lab_filename.TabIndex = 19;
            this.lab_filename.Text = "请选择";
            // 
            // lab_wjmc
            // 
            this.lab_wjmc.AutoSize = true;
            this.lab_wjmc.BackColor = System.Drawing.Color.Transparent;
            this.lab_wjmc.Location = new System.Drawing.Point(23, 54);
            this.lab_wjmc.Name = "lab_wjmc";
            this.lab_wjmc.Size = new System.Drawing.Size(65, 12);
            this.lab_wjmc.TabIndex = 20;
            this.lab_wjmc.Text = "文件名称：";
            // 
            // txt_table
            // 
            this.txt_table.Location = new System.Drawing.Point(88, 18);
            this.txt_table.Name = "txt_table";
            this.txt_table.Size = new System.Drawing.Size(170, 21);
            this.txt_table.TabIndex = 18;
            // 
            // lab_table
            // 
            this.lab_table.AutoSize = true;
            this.lab_table.BackColor = System.Drawing.Color.Transparent;
            this.lab_table.Location = new System.Drawing.Point(23, 18);
            this.lab_table.Name = "lab_table";
            this.lab_table.Size = new System.Drawing.Size(65, 12);
            this.lab_table.TabIndex = 16;
            this.lab_table.Text = "表 名 称：";
            // 
            // OpenFile
            // 
            this.OpenFile.BackColor = System.Drawing.Color.Transparent;
            this.OpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFile.Location = new System.Drawing.Point(543, 10);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(96, 39);
            this.OpenFile.TabIndex = 14;
            this.OpenFile.Text = "打开文件";
            this.OpenFile.UseVisualStyleBackColor = false;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // Btn_UpdateSql
            // 
            this.Btn_UpdateSql.BackColor = System.Drawing.Color.Transparent;
            this.Btn_UpdateSql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_UpdateSql.Location = new System.Drawing.Point(543, 65);
            this.Btn_UpdateSql.Name = "Btn_UpdateSql";
            this.Btn_UpdateSql.Size = new System.Drawing.Size(96, 41);
            this.Btn_UpdateSql.TabIndex = 21;
            this.Btn_UpdateSql.Text = "生成更新语句";
            this.Btn_UpdateSql.UseVisualStyleBackColor = false;
            this.Btn_UpdateSql.Click += new System.EventHandler(this.Btn_UpdateSql_Click);
            // 
            // dgv_content
            // 
            this.dgv_content.BackgroundColor = System.Drawing.Color.White;
            this.dgv_content.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_content.Location = new System.Drawing.Point(1, 192);
            this.dgv_content.Name = "dgv_content";
            this.dgv_content.RowTemplate.Height = 23;
            this.dgv_content.Size = new System.Drawing.Size(797, 257);
            this.dgv_content.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(23, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 12);
            this.label1.TabIndex = 26;
            this.label1.Text = "主键字段(多条件以,分隔)：";
            // 
            // txt_keyfield
            // 
            this.txt_keyfield.Location = new System.Drawing.Point(178, 85);
            this.txt_keyfield.Name = "txt_keyfield";
            this.txt_keyfield.Size = new System.Drawing.Size(194, 21);
            this.txt_keyfield.TabIndex = 24;
            // 
            // UpdateSqlByExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_keyfield);
            this.Controls.Add(this.dgv_content);
            this.Controls.Add(this.Btn_UpdateSql);
            this.Controls.Add(this.lab_filename);
            this.Controls.Add(this.lab_wjmc);
            this.Controls.Add(this.txt_table);
            this.Controls.Add(this.lab_table);
            this.Controls.Add(this.OpenFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateSqlByExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel创建更新语句";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_content)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_filename;
        private System.Windows.Forms.Label lab_wjmc;
        private System.Windows.Forms.TextBox txt_table;
        private System.Windows.Forms.Label lab_table;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button Btn_UpdateSql;
        private System.Windows.Forms.DataGridView dgv_content;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_keyfield;
    }
}