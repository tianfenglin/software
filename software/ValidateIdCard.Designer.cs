namespace software
{
    partial class ValidateIdCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValidateIdCard));
            this.Btn_StartPath = new System.Windows.Forms.Button();
            this.lab_startpath = new System.Windows.Forms.Label();
            this.Btn_EndPath = new System.Windows.Forms.Button();
            this.lab_endpath = new System.Windows.Forms.Label();
            this.txt_endpath = new System.Windows.Forms.TextBox();
            this.Btn_TryRun = new System.Windows.Forms.Button();
            this.lab_filename = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_StartPath
            // 
            this.Btn_StartPath.BackColor = System.Drawing.Color.Transparent;
            this.Btn_StartPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_StartPath.Location = new System.Drawing.Point(500, 115);
            this.Btn_StartPath.Name = "Btn_StartPath";
            this.Btn_StartPath.Size = new System.Drawing.Size(71, 22);
            this.Btn_StartPath.TabIndex = 0;
            this.Btn_StartPath.Text = "选择文件";
            this.Btn_StartPath.UseVisualStyleBackColor = false;
            this.Btn_StartPath.Click += new System.EventHandler(this.Btn_StartPath_Click);
            // 
            // lab_startpath
            // 
            this.lab_startpath.AutoSize = true;
            this.lab_startpath.BackColor = System.Drawing.Color.Transparent;
            this.lab_startpath.Location = new System.Drawing.Point(86, 118);
            this.lab_startpath.Name = "lab_startpath";
            this.lab_startpath.Size = new System.Drawing.Size(65, 12);
            this.lab_startpath.TabIndex = 1;
            this.lab_startpath.Text = "文件路径：";
            // 
            // Btn_EndPath
            // 
            this.Btn_EndPath.BackColor = System.Drawing.Color.Transparent;
            this.Btn_EndPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EndPath.Location = new System.Drawing.Point(500, 165);
            this.Btn_EndPath.Name = "Btn_EndPath";
            this.Btn_EndPath.Size = new System.Drawing.Size(71, 22);
            this.Btn_EndPath.TabIndex = 0;
            this.Btn_EndPath.Text = "选择路径";
            this.Btn_EndPath.UseVisualStyleBackColor = false;
            this.Btn_EndPath.Click += new System.EventHandler(this.Btn_EndPath_Click);
            // 
            // lab_endpath
            // 
            this.lab_endpath.AutoSize = true;
            this.lab_endpath.BackColor = System.Drawing.Color.Transparent;
            this.lab_endpath.Location = new System.Drawing.Point(86, 168);
            this.lab_endpath.Name = "lab_endpath";
            this.lab_endpath.Size = new System.Drawing.Size(65, 12);
            this.lab_endpath.TabIndex = 1;
            this.lab_endpath.Text = "导出路径：";
            // 
            // txt_endpath
            // 
            this.txt_endpath.Location = new System.Drawing.Point(150, 165);
            this.txt_endpath.Name = "txt_endpath";
            this.txt_endpath.Size = new System.Drawing.Size(329, 21);
            this.txt_endpath.TabIndex = 2;
            // 
            // Btn_TryRun
            // 
            this.Btn_TryRun.BackColor = System.Drawing.Color.Transparent;
            this.Btn_TryRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_TryRun.Location = new System.Drawing.Point(273, 258);
            this.Btn_TryRun.Name = "Btn_TryRun";
            this.Btn_TryRun.Size = new System.Drawing.Size(144, 31);
            this.Btn_TryRun.TabIndex = 0;
            this.Btn_TryRun.Text = "开始执行";
            this.Btn_TryRun.UseVisualStyleBackColor = false;
            this.Btn_TryRun.Click += new System.EventHandler(this.Btn_TryRun_Click);
            // 
            // lab_filename
            // 
            this.lab_filename.AutoSize = true;
            this.lab_filename.BackColor = System.Drawing.Color.Transparent;
            this.lab_filename.Location = new System.Drawing.Point(157, 118);
            this.lab_filename.Name = "lab_filename";
            this.lab_filename.Size = new System.Drawing.Size(53, 12);
            this.lab_filename.TabIndex = 1;
            this.lab_filename.Text = "文件名称";
            // 
            // ValidateIdCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_endpath);
            this.Controls.Add(this.lab_endpath);
            this.Controls.Add(this.Btn_TryRun);
            this.Controls.Add(this.Btn_EndPath);
            this.Controls.Add(this.lab_filename);
            this.Controls.Add(this.lab_startpath);
            this.Controls.Add(this.Btn_StartPath);
            this.Name = "ValidateIdCard";
            this.Text = "验证身份证";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_StartPath;
        private System.Windows.Forms.Label lab_startpath;
        private System.Windows.Forms.Button Btn_EndPath;
        private System.Windows.Forms.Label lab_endpath;
        private System.Windows.Forms.TextBox txt_endpath;
        private System.Windows.Forms.Button Btn_TryRun;
        private System.Windows.Forms.Label lab_filename;
    }
}