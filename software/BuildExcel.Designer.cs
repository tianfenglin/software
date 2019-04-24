namespace software
{
    partial class BuildExcel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildExcel));
            this.lab_filename = new System.Windows.Forms.Label();
            this.lab_wjmc = new System.Windows.Forms.Label();
            this.TryBuild = new System.Windows.Forms.Button();
            this.txt_table = new System.Windows.Forms.TextBox();
            this.lab_table = new System.Windows.Forms.Label();
            this.autobuild = new System.Windows.Forms.DataGridView();
            this.autofield = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldtype = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.OpenFile = new System.Windows.Forms.Button();
            this.Btn_UpdateSql = new System.Windows.Forms.Button();
            this.lab_where = new System.Windows.Forms.Label();
            this.txt_where = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.autobuild)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_filename
            // 
            this.lab_filename.AutoSize = true;
            this.lab_filename.BackColor = System.Drawing.Color.Transparent;
            this.lab_filename.Location = new System.Drawing.Point(109, 91);
            this.lab_filename.Name = "lab_filename";
            this.lab_filename.Size = new System.Drawing.Size(41, 12);
            this.lab_filename.TabIndex = 12;
            this.lab_filename.Text = "请选择";
            // 
            // lab_wjmc
            // 
            this.lab_wjmc.AutoSize = true;
            this.lab_wjmc.BackColor = System.Drawing.Color.Transparent;
            this.lab_wjmc.Location = new System.Drawing.Point(12, 91);
            this.lab_wjmc.Name = "lab_wjmc";
            this.lab_wjmc.Size = new System.Drawing.Size(65, 12);
            this.lab_wjmc.TabIndex = 13;
            this.lab_wjmc.Text = "文件名称：";
            // 
            // TryBuild
            // 
            this.TryBuild.BackColor = System.Drawing.Color.Transparent;
            this.TryBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TryBuild.Location = new System.Drawing.Point(663, 7);
            this.TryBuild.Name = "TryBuild";
            this.TryBuild.Size = new System.Drawing.Size(96, 41);
            this.TryBuild.TabIndex = 11;
            this.TryBuild.Text = "生成插入语句";
            this.TryBuild.UseVisualStyleBackColor = false;
            this.TryBuild.Click += new System.EventHandler(this.TryBuild_Click);
            // 
            // txt_table
            // 
            this.txt_table.Location = new System.Drawing.Point(111, 12);
            this.txt_table.Name = "txt_table";
            this.txt_table.Size = new System.Drawing.Size(170, 21);
            this.txt_table.TabIndex = 10;
            // 
            // lab_table
            // 
            this.lab_table.AutoSize = true;
            this.lab_table.BackColor = System.Drawing.Color.Transparent;
            this.lab_table.Location = new System.Drawing.Point(12, 15);
            this.lab_table.Name = "lab_table";
            this.lab_table.Size = new System.Drawing.Size(65, 12);
            this.lab_table.TabIndex = 9;
            this.lab_table.Text = "表 名 称：";
            // 
            // autobuild
            // 
            this.autobuild.BackgroundColor = System.Drawing.SystemColors.Info;
            this.autobuild.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autobuild.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autofield,
            this.fieldtype});
            this.autobuild.Location = new System.Drawing.Point(1, 121);
            this.autobuild.Name = "autobuild";
            this.autobuild.RowTemplate.Height = 23;
            this.autobuild.Size = new System.Drawing.Size(345, 327);
            this.autobuild.TabIndex = 8;
            // 
            // autofield
            // 
            this.autofield.HeaderText = "自动字段";
            this.autofield.Name = "autofield";
            this.autofield.Width = 150;
            // 
            // fieldtype
            // 
            this.fieldtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fieldtype.HeaderText = "类型";
            this.fieldtype.Items.AddRange(new object[] {
            "当前时间",
            "时间字符"});
            this.fieldtype.Name = "fieldtype";
            this.fieldtype.Width = 150;
            // 
            // OpenFile
            // 
            this.OpenFile.BackColor = System.Drawing.Color.Transparent;
            this.OpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFile.Location = new System.Drawing.Point(532, 7);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(96, 39);
            this.OpenFile.TabIndex = 7;
            this.OpenFile.Text = "打开文件";
            this.OpenFile.UseVisualStyleBackColor = false;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // Btn_UpdateSql
            // 
            this.Btn_UpdateSql.BackColor = System.Drawing.Color.Transparent;
            this.Btn_UpdateSql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_UpdateSql.Location = new System.Drawing.Point(663, 62);
            this.Btn_UpdateSql.Name = "Btn_UpdateSql";
            this.Btn_UpdateSql.Size = new System.Drawing.Size(96, 41);
            this.Btn_UpdateSql.TabIndex = 11;
            this.Btn_UpdateSql.Text = "生成更新语句";
            this.Btn_UpdateSql.UseVisualStyleBackColor = false;
            this.Btn_UpdateSql.Click += new System.EventHandler(this.Btn_UpdateSql_Click);
            // 
            // lab_where
            // 
            this.lab_where.AutoSize = true;
            this.lab_where.BackColor = System.Drawing.Color.Transparent;
            this.lab_where.Location = new System.Drawing.Point(12, 51);
            this.lab_where.Name = "lab_where";
            this.lab_where.Size = new System.Drawing.Size(65, 12);
            this.lab_where.TabIndex = 9;
            this.lab_where.Text = "条件字段：";
            // 
            // txt_where
            // 
            this.txt_where.Location = new System.Drawing.Point(111, 48);
            this.txt_where.Name = "txt_where";
            this.txt_where.Size = new System.Drawing.Size(170, 21);
            this.txt_where.TabIndex = 10;
            // 
            // BuildExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lab_filename);
            this.Controls.Add(this.lab_wjmc);
            this.Controls.Add(this.Btn_UpdateSql);
            this.Controls.Add(this.TryBuild);
            this.Controls.Add(this.txt_where);
            this.Controls.Add(this.txt_table);
            this.Controls.Add(this.lab_where);
            this.Controls.Add(this.lab_table);
            this.Controls.Add(this.autobuild);
            this.Controls.Add(this.OpenFile);
            this.Name = "BuildExcel";
            this.Text = "BuildExcel";
            ((System.ComponentModel.ISupportInitialize)(this.autobuild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_filename;
        private System.Windows.Forms.Label lab_wjmc;
        private System.Windows.Forms.Button TryBuild;
        private System.Windows.Forms.TextBox txt_table;
        private System.Windows.Forms.Label lab_table;
        private System.Windows.Forms.DataGridView autobuild;
        private System.Windows.Forms.DataGridViewTextBoxColumn autofield;
        private System.Windows.Forms.DataGridViewComboBoxColumn fieldtype;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button Btn_UpdateSql;
        private System.Windows.Forms.Label lab_where;
        private System.Windows.Forms.TextBox txt_where;
    }
}