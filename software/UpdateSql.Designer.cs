namespace software
{
    partial class UpdateSql
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSql));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtb_sql = new System.Windows.Forms.RichTextBox();
            this.But_Select = new System.Windows.Forms.Button();
            this.lab_tablename = new System.Windows.Forms.Label();
            this.txt_tablename = new System.Windows.Forms.TextBox();
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
            this.dgv_content = new System.Windows.Forms.DataGridView();
            this.But_ChoosePath = new System.Windows.Forms.Button();
            this.txt_choosepath = new System.Windows.Forms.TextBox();
            this.txt_keyfield = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mainfield = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_replacefield = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.But_ExportPath = new System.Windows.Forms.Button();
            this.txt_exportpath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.But_Run = new System.Windows.Forms.Button();
            this.txt_newname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_content)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rtb_sql);
            this.groupBox2.Controls.Add(this.But_Select);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(473, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 225);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询语句";
            // 
            // rtb_sql
            // 
            this.rtb_sql.Location = new System.Drawing.Point(6, 16);
            this.rtb_sql.Name = "rtb_sql";
            this.rtb_sql.Size = new System.Drawing.Size(472, 160);
            this.rtb_sql.TabIndex = 0;
            this.rtb_sql.Text = "";
            // 
            // But_Select
            // 
            this.But_Select.BackColor = System.Drawing.Color.Transparent;
            this.But_Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_Select.Location = new System.Drawing.Point(168, 184);
            this.But_Select.Name = "But_Select";
            this.But_Select.Size = new System.Drawing.Size(130, 35);
            this.But_Select.TabIndex = 1;
            this.But_Select.Text = "查询数据库";
            this.But_Select.UseVisualStyleBackColor = false;
            this.But_Select.Click += new System.EventHandler(this.But_Select_Click);
            // 
            // lab_tablename
            // 
            this.lab_tablename.AutoSize = true;
            this.lab_tablename.BackColor = System.Drawing.Color.Transparent;
            this.lab_tablename.Location = new System.Drawing.Point(26, 151);
            this.lab_tablename.Name = "lab_tablename";
            this.lab_tablename.Size = new System.Drawing.Size(77, 12);
            this.lab_tablename.TabIndex = 0;
            this.lab_tablename.Text = "表  名  称：";
            // 
            // txt_tablename
            // 
            this.txt_tablename.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_tablename.Location = new System.Drawing.Point(109, 142);
            this.txt_tablename.Name = "txt_tablename";
            this.txt_tablename.Size = new System.Drawing.Size(258, 29);
            this.txt_tablename.TabIndex = 2;
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
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 225);
            this.groupBox1.TabIndex = 8;
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
            // dgv_content
            // 
            this.dgv_content.BackgroundColor = System.Drawing.Color.White;
            this.dgv_content.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_content.Location = new System.Drawing.Point(10, 233);
            this.dgv_content.Name = "dgv_content";
            this.dgv_content.RowTemplate.Height = 23;
            this.dgv_content.Size = new System.Drawing.Size(448, 210);
            this.dgv_content.TabIndex = 10;
            // 
            // But_ChoosePath
            // 
            this.But_ChoosePath.BackColor = System.Drawing.Color.Transparent;
            this.But_ChoosePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_ChoosePath.Location = new System.Drawing.Point(388, 24);
            this.But_ChoosePath.Name = "But_ChoosePath";
            this.But_ChoosePath.Size = new System.Drawing.Size(57, 23);
            this.But_ChoosePath.TabIndex = 11;
            this.But_ChoosePath.Text = "选择";
            this.But_ChoosePath.UseVisualStyleBackColor = false;
            this.But_ChoosePath.Click += new System.EventHandler(this.But_ChoosePath_Click);
            // 
            // txt_choosepath
            // 
            this.txt_choosepath.Location = new System.Drawing.Point(96, 26);
            this.txt_choosepath.Name = "txt_choosepath";
            this.txt_choosepath.Size = new System.Drawing.Size(265, 21);
            this.txt_choosepath.TabIndex = 13;
            // 
            // txt_keyfield
            // 
            this.txt_keyfield.Location = new System.Drawing.Point(97, 83);
            this.txt_keyfield.Name = "txt_keyfield";
            this.txt_keyfield.Size = new System.Drawing.Size(100, 21);
            this.txt_keyfield.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(26, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "主键字段：";
            // 
            // txt_mainfield
            // 
            this.txt_mainfield.Location = new System.Drawing.Point(281, 83);
            this.txt_mainfield.Name = "txt_mainfield";
            this.txt_mainfield.Size = new System.Drawing.Size(100, 21);
            this.txt_mainfield.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(213, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "条件字段：";
            // 
            // txt_replacefield
            // 
            this.txt_replacefield.Location = new System.Drawing.Point(97, 115);
            this.txt_replacefield.Name = "txt_replacefield";
            this.txt_replacefield.Size = new System.Drawing.Size(100, 21);
            this.txt_replacefield.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(26, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "替换字段：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(26, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "文件路径：";
            // 
            // But_ExportPath
            // 
            this.But_ExportPath.BackColor = System.Drawing.Color.Transparent;
            this.But_ExportPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_ExportPath.Location = new System.Drawing.Point(388, 53);
            this.But_ExportPath.Name = "But_ExportPath";
            this.But_ExportPath.Size = new System.Drawing.Size(57, 21);
            this.But_ExportPath.TabIndex = 11;
            this.But_ExportPath.Text = "选择";
            this.But_ExportPath.UseVisualStyleBackColor = false;
            this.But_ExportPath.Click += new System.EventHandler(this.But_ExportPath_Click);
            // 
            // txt_exportpath
            // 
            this.txt_exportpath.Location = new System.Drawing.Point(97, 53);
            this.txt_exportpath.Name = "txt_exportpath";
            this.txt_exportpath.Size = new System.Drawing.Size(264, 21);
            this.txt_exportpath.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(27, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "导出路径：";
            // 
            // But_Run
            // 
            this.But_Run.BackColor = System.Drawing.Color.Transparent;
            this.But_Run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_Run.Location = new System.Drawing.Point(148, 187);
            this.But_Run.Name = "But_Run";
            this.But_Run.Size = new System.Drawing.Size(130, 33);
            this.But_Run.TabIndex = 11;
            this.But_Run.Text = "执行";
            this.But_Run.UseVisualStyleBackColor = false;
            this.But_Run.Click += new System.EventHandler(this.But_Run_Click);
            // 
            // txt_newname
            // 
            this.txt_newname.Location = new System.Drawing.Point(281, 112);
            this.txt_newname.Name = "txt_newname";
            this.txt_newname.Size = new System.Drawing.Size(100, 21);
            this.txt_newname.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(213, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "新的名称：";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lab_tablename);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_tablename);
            this.groupBox3.Controls.Add(this.txt_exportpath);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.But_ExportPath);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_mainfield);
            this.groupBox3.Controls.Add(this.txt_choosepath);
            this.groupBox3.Controls.Add(this.txt_replacefield);
            this.groupBox3.Controls.Add(this.But_ChoosePath);
            this.groupBox3.Controls.Add(this.txt_newname);
            this.groupBox3.Controls.Add(this.But_Run);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_keyfield);
            this.groupBox3.Location = new System.Drawing.Point(493, 233);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(464, 226);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "执行生成";
            // 
            // UpdateSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(980, 462);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgv_content);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UpdateSql";
            this.Text = "UpdateSql";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_content)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtb_sql;
        private System.Windows.Forms.Label lab_tablename;
        private System.Windows.Forms.Button But_Select;
        private System.Windows.Forms.TextBox txt_tablename;
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
        private System.Windows.Forms.DataGridView dgv_content;
        private System.Windows.Forms.Button But_ChoosePath;
        private System.Windows.Forms.TextBox txt_choosepath;
        private System.Windows.Forms.TextBox txt_keyfield;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mainfield;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_replacefield;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button But_ExportPath;
        private System.Windows.Forms.TextBox txt_exportpath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button But_Run;
        private System.Windows.Forms.TextBox txt_newname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}