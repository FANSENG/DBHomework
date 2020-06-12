namespace LibraryManager
{
    partial class AlterPwdForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.textBoxNewPsw = new System.Windows.Forms.TextBox();
            this.textBoxNewPsw2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "再次输入新密码：";
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(159, 167);
            this.ButtonSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(100, 29);
            this.ButtonSubmit.TabIndex = 3;
            this.ButtonSubmit.Text = "提交";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubbmit_Click);
            // 
            // textBoxNewPsw
            // 
            this.textBoxNewPsw.Location = new System.Drawing.Point(182, 30);
            this.textBoxNewPsw.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNewPsw.Name = "textBoxNewPsw";
            this.textBoxNewPsw.PasswordChar = '*';
            this.textBoxNewPsw.Size = new System.Drawing.Size(196, 25);
            this.textBoxNewPsw.TabIndex = 5;
            // 
            // textBoxNewPsw2
            // 
            this.textBoxNewPsw2.Location = new System.Drawing.Point(182, 81);
            this.textBoxNewPsw2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNewPsw2.Name = "textBoxNewPsw2";
            this.textBoxNewPsw2.PasswordChar = '*';
            this.textBoxNewPsw2.Size = new System.Drawing.Size(196, 25);
            this.textBoxNewPsw2.TabIndex = 6;
            // 
            // AlterPwdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 211);
            this.Controls.Add(this.textBoxNewPsw2);
            this.Controls.Add(this.textBoxNewPsw);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlterPwdForm";
            this.ShowIcon = false;
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonSubmit;
        private System.Windows.Forms.TextBox textBoxNewPsw;
        private System.Windows.Forms.TextBox textBoxNewPsw2;
    }
}