namespace software
{
    partial class MakeSql
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeSql));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lab_jdbcname = new System.Windows.Forms.Label();
            this.lab_user = new System.Windows.Forms.Label();
            this.lab_password = new System.Windows.Forms.Label();
            this.lab_jdbctype = new System.Windows.Forms.Label();
            this.cob_jdbctype = new System.Windows.Forms.ComboBox();
            this.txt_jdbcname = new System.Windows.Forms.TextBox();
            this.Btn_connect = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtb_sql = new System.Windows.Forms.RichTextBox();
            this.But_Select = new System.Windows.Forms.Button();
            this.dgv_content = new System.Windows.Forms.DataGridView();
            this.But_CreatSql = new System.Windows.Forms.Button();
            this.txt_tablename = new System.Windows.Forms.TextBox();
            this.lab_tablename = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_content)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lab_jdbcname);
            this.groupBox1.Controls.Add(this.lab_user);
            this.groupBox1.Controls.Add(this.lab_password);
            this.groupBox1.Controls.Add(this.lab_jdbctype);
            this.groupBox1.Controls.Add(this.cob_jdbctype);
            this.groupBox1.Controls.Add(this.txt_jdbcname);
            this.groupBox1.Controls.Add(this.Btn_connect);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.txt_user);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 225);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据连接";
            // 
            // lab_jdbcname
            // 
            this.lab_jdbcname.AutoSize = true;
            this.lab_jdbcname.BackColor = System.Drawing.Color.Transparent;
            this.lab_jdbcname.Location = new System.Drawing.Point(6, 74);
            this.lab_jdbcname.Name = "lab_jdbcname";
            this.lab_jdbcname.Size = new System.Drawing.Size(77, 12);
            this.lab_jdbcname.TabIndex = 0;
            this.lab_jdbcname.Text = "数据库名称：";
            // 
            // lab_user
            // 
            this.lab_user.AutoSize = true;
            this.lab_user.BackColor = System.Drawing.Color.Transparent;
            this.lab_user.Location = new System.Drawing.Point(6, 111);
            this.lab_user.Name = "lab_user";
            this.lab_user.Size = new System.Drawing.Size(77, 12);
            this.lab_user.TabIndex = 0;
            this.lab_user.Text = "用  户  名：";
            // 
            // lab_password
            // 
            this.lab_password.AutoSize = true;
            this.lab_password.BackColor = System.Drawing.Color.Transparent;
            this.lab_password.Location = new System.Drawing.Point(6, 154);
            this.lab_password.Name = "lab_password";
            this.lab_password.Size = new System.Drawing.Size(77, 12);
            this.lab_password.TabIndex = 0;
            this.lab_password.Text = "密      码：";
            // 
            // lab_jdbctype
            // 
            this.lab_jdbctype.AutoSize = true;
            this.lab_jdbctype.BackColor = System.Drawing.Color.Transparent;
            this.lab_jdbctype.Location = new System.Drawing.Point(6, 32);
            this.lab_jdbctype.Name = "lab_jdbctype";
            this.lab_jdbctype.Size = new System.Drawing.Size(77, 12);
            this.lab_jdbctype.TabIndex = 0;
            this.lab_jdbctype.Text = "数据库类型：";
            // 
            // cob_jdbctype
            // 
            this.cob_jdbctype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_jdbctype.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cob_jdbctype.FormattingEnabled = true;
            this.cob_jdbctype.Items.AddRange(new object[] {
            "sqlserver",
            "mysql",
            "oracle"});
            this.cob_jdbctype.Location = new System.Drawing.Point(114, 26);
            this.cob_jdbctype.Name = "cob_jdbctype";
            this.cob_jdbctype.Size = new System.Drawing.Size(258, 28);
            this.cob_jdbctype.TabIndex = 3;
            // 
            // txt_jdbcname
            // 
            this.txt_jdbcname.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_jdbcname.Location = new System.Drawing.Point(114, 68);
            this.txt_jdbcname.Name = "txt_jdbcname";
            this.txt_jdbcname.Size = new System.Drawing.Size(258, 29);
            this.txt_jdbcname.TabIndex = 2;
            // 
            // Btn_connect
            // 
            this.Btn_connect.BackColor = System.Drawing.Color.Transparent;
            this.Btn_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_connect.Location = new System.Drawing.Point(160, 184);
            this.Btn_connect.Name = "Btn_connect";
            this.Btn_connect.Size = new System.Drawing.Size(130, 35);
            this.Btn_connect.TabIndex = 1;
            this.Btn_connect.Text = "连接数据库";
            this.Btn_connect.UseVisualStyleBackColor = false;
            this.Btn_connect.Click += new System.EventHandler(this.Btn_connect_Click);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_password.Location = new System.Drawing.Point(113, 147);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(258, 29);
            this.txt_password.TabIndex = 2;
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_user.Location = new System.Drawing.Point(114, 106);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(258, 29);
            this.txt_user.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rtb_sql);
            this.groupBox2.Controls.Add(this.lab_tablename);
            this.groupBox2.Controls.Add(this.But_CreatSql);
            this.groupBox2.Controls.Add(this.But_Select);
            this.groupBox2.Controls.Add(this.txt_tablename);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(480, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 225);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询语句";
            // 
            // rtb_sql
            // 
            this.rtb_sql.Location = new System.Drawing.Point(6, 16);
            this.rtb_sql.Name = "rtb_sql";
            this.rtb_sql.Size = new System.Drawing.Size(472, 119);
            this.rtb_sql.TabIndex = 0;
            this.rtb_sql.Text = "";
            // 
            // But_Select
            // 
            this.But_Select.BackColor = System.Drawing.Color.Transparent;
            this.But_Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_Select.Location = new System.Drawing.Point(76, 182);
            this.But_Select.Name = "But_Select";
            this.But_Select.Size = new System.Drawing.Size(130, 35);
            this.But_Select.TabIndex = 1;
            this.But_Select.Text = "查询数据库";
            this.But_Select.UseVisualStyleBackColor = false;
            this.But_Select.Click += new System.EventHandler(this.But_Select_Click);
            // 
            // dgv_content
            // 
            this.dgv_content.BackgroundColor = System.Drawing.Color.White;
            this.dgv_content.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_content.Location = new System.Drawing.Point(2, 243);
            this.dgv_content.Name = "dgv_content";
            this.dgv_content.RowTemplate.Height = 23;
            this.dgv_content.Size = new System.Drawing.Size(969, 270);
            this.dgv_content.TabIndex = 8;
            // 
            // But_CreatSql
            // 
            this.But_CreatSql.BackColor = System.Drawing.Color.Transparent;
            this.But_CreatSql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_CreatSql.Location = new System.Drawing.Point(275, 182);
            this.But_CreatSql.Name = "But_CreatSql";
            this.But_CreatSql.Size = new System.Drawing.Size(130, 35);
            this.But_CreatSql.TabIndex = 1;
            this.But_CreatSql.Text = "创建插入语句";
            this.But_CreatSql.UseVisualStyleBackColor = false;
            this.But_CreatSql.Click += new System.EventHandler(this.But_CreatSql_Click);
            // 
            // txt_tablename
            // 
            this.txt_tablename.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_tablename.Location = new System.Drawing.Point(112, 142);
            this.txt_tablename.Name = "txt_tablename";
            this.txt_tablename.Size = new System.Drawing.Size(258, 29);
            this.txt_tablename.TabIndex = 2;
            // 
            // lab_tablename
            // 
            this.lab_tablename.AutoSize = true;
            this.lab_tablename.BackColor = System.Drawing.Color.Transparent;
            this.lab_tablename.Location = new System.Drawing.Point(6, 147);
            this.lab_tablename.Name = "lab_tablename";
            this.lab_tablename.Size = new System.Drawing.Size(77, 12);
            this.lab_tablename.TabIndex = 0;
            this.lab_tablename.Text = "表  名  称：";
            // 
            // MakeSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(976, 516);
            this.Controls.Add(this.dgv_content);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MakeSql";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MakeSql";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_content)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lab_jdbcname;
        private System.Windows.Forms.Label lab_user;
        private System.Windows.Forms.Label lab_password;
        private System.Windows.Forms.Label lab_jdbctype;
        private System.Windows.Forms.ComboBox cob_jdbctype;
        private System.Windows.Forms.TextBox txt_jdbcname;
        private System.Windows.Forms.Button Btn_connect;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtb_sql;
        private System.Windows.Forms.DataGridView dgv_content;
        private System.Windows.Forms.Button But_Select;
        private System.Windows.Forms.Button But_CreatSql;
        private System.Windows.Forms.Label lab_tablename;
        private System.Windows.Forms.TextBox txt_tablename;
    }
}