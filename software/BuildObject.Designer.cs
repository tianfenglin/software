namespace software
{
    partial class BuildObject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildObject));
            this.lab_jdbcname = new System.Windows.Forms.Label();
            this.Btn_connect = new System.Windows.Forms.Button();
            this.txt_jdbcname = new System.Windows.Forms.TextBox();
            this.lab_jdbctype = new System.Windows.Forms.Label();
            this.cob_jdbctype = new System.Windows.Forms.ComboBox();
            this.But_choose = new System.Windows.Forms.Button();
            this.dgv_content = new System.Windows.Forms.DataGridView();
            this.Btn_build = new System.Windows.Forms.Button();
            this.lab_user = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.lab_password = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lab_tablename = new System.Windows.Forms.Label();
            this.cob_tablename = new System.Windows.Forms.ComboBox();
            this.lab_buildtype = new System.Windows.Forms.Label();
            this.cob_buildtype = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_content)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            // txt_jdbcname
            // 
            this.txt_jdbcname.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_jdbcname.Location = new System.Drawing.Point(114, 68);
            this.txt_jdbcname.Name = "txt_jdbcname";
            this.txt_jdbcname.Size = new System.Drawing.Size(258, 29);
            this.txt_jdbcname.TabIndex = 2;
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
            // But_choose
            // 
            this.But_choose.BackColor = System.Drawing.Color.Transparent;
            this.But_choose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_choose.Location = new System.Drawing.Point(108, 149);
            this.But_choose.Name = "But_choose";
            this.But_choose.Size = new System.Drawing.Size(107, 35);
            this.But_choose.TabIndex = 1;
            this.But_choose.Text = "选择表名";
            this.But_choose.UseVisualStyleBackColor = false;
            this.But_choose.Click += new System.EventHandler(this.But_choose_Click);
            // 
            // dgv_content
            // 
            this.dgv_content.BackgroundColor = System.Drawing.Color.White;
            this.dgv_content.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_content.Location = new System.Drawing.Point(1, 265);
            this.dgv_content.Name = "dgv_content";
            this.dgv_content.RowTemplate.Height = 23;
            this.dgv_content.Size = new System.Drawing.Size(969, 223);
            this.dgv_content.TabIndex = 4;
            // 
            // Btn_build
            // 
            this.Btn_build.BackColor = System.Drawing.Color.Transparent;
            this.Btn_build.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_build.Location = new System.Drawing.Point(258, 145);
            this.Btn_build.Name = "Btn_build";
            this.Btn_build.Size = new System.Drawing.Size(108, 39);
            this.Btn_build.TabIndex = 1;
            this.Btn_build.Text = "生成代码";
            this.Btn_build.UseVisualStyleBackColor = false;
            this.Btn_build.Click += new System.EventHandler(this.Btn_build_Click);
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
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_user.Location = new System.Drawing.Point(114, 106);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(258, 29);
            this.txt_user.TabIndex = 2;
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
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_password.Location = new System.Drawing.Point(113, 147);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(258, 29);
            this.txt_password.TabIndex = 2;
            // 
            // lab_tablename
            // 
            this.lab_tablename.AutoSize = true;
            this.lab_tablename.BackColor = System.Drawing.Color.Transparent;
            this.lab_tablename.Location = new System.Drawing.Point(21, 94);
            this.lab_tablename.Name = "lab_tablename";
            this.lab_tablename.Size = new System.Drawing.Size(77, 12);
            this.lab_tablename.TabIndex = 0;
            this.lab_tablename.Text = "选择表名称：";
            // 
            // cob_tablename
            // 
            this.cob_tablename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_tablename.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cob_tablename.FormattingEnabled = true;
            this.cob_tablename.Location = new System.Drawing.Point(108, 84);
            this.cob_tablename.Name = "cob_tablename";
            this.cob_tablename.Size = new System.Drawing.Size(258, 28);
            this.cob_tablename.TabIndex = 3;
            // 
            // lab_buildtype
            // 
            this.lab_buildtype.AutoSize = true;
            this.lab_buildtype.BackColor = System.Drawing.Color.Transparent;
            this.lab_buildtype.Location = new System.Drawing.Point(21, 30);
            this.lab_buildtype.Name = "lab_buildtype";
            this.lab_buildtype.Size = new System.Drawing.Size(77, 12);
            this.lab_buildtype.TabIndex = 0;
            this.lab_buildtype.Text = "生成的类型：";
            // 
            // cob_buildtype
            // 
            this.cob_buildtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_buildtype.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cob_buildtype.FormattingEnabled = true;
            this.cob_buildtype.Items.AddRange(new object[] {
            "CSharp",
            "Java"});
            this.cob_buildtype.Location = new System.Drawing.Point(108, 24);
            this.cob_buildtype.Name = "cob_buildtype";
            this.cob_buildtype.Size = new System.Drawing.Size(258, 28);
            this.cob_buildtype.TabIndex = 3;
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
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 225);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据连接";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lab_tablename);
            this.groupBox2.Controls.Add(this.lab_buildtype);
            this.groupBox2.Controls.Add(this.cob_tablename);
            this.groupBox2.Controls.Add(this.Btn_build);
            this.groupBox2.Controls.Add(this.cob_buildtype);
            this.groupBox2.Controls.Add(this.But_choose);
            this.groupBox2.Location = new System.Drawing.Point(517, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 223);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "生成选择";
            // 
            // BuildObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(973, 489);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_content);
            this.Name = "BuildObject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "创建对象";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_content)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lab_jdbcname;
        private System.Windows.Forms.Button Btn_connect;
        private System.Windows.Forms.TextBox txt_jdbcname;
        private System.Windows.Forms.Label lab_jdbctype;
        private System.Windows.Forms.ComboBox cob_jdbctype;
        private System.Windows.Forms.Button But_choose;
        private System.Windows.Forms.DataGridView dgv_content;
        private System.Windows.Forms.Button Btn_build;
        private System.Windows.Forms.Label lab_user;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label lab_password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lab_tablename;
        private System.Windows.Forms.ComboBox cob_tablename;
        private System.Windows.Forms.Label lab_buildtype;
        private System.Windows.Forms.ComboBox cob_buildtype;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}