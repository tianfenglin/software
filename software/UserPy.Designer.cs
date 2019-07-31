namespace software
{
    partial class UserPy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPy));
            this.Try_Runing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Try_Runing
            // 
            this.Try_Runing.Location = new System.Drawing.Point(361, 139);
            this.Try_Runing.Name = "Try_Runing";
            this.Try_Runing.Size = new System.Drawing.Size(75, 30);
            this.Try_Runing.TabIndex = 0;
            this.Try_Runing.Text = "button1";
            this.Try_Runing.UseVisualStyleBackColor = true;
            this.Try_Runing.Click += new System.EventHandler(this.Try_Runing_Click);
            // 
            // UserPy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Try_Runing);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserPy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserPy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Try_Runing;
    }
}