namespace LibraryManager
{
    partial class UpdateIndivForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.PhonetextBox = new System.Windows.Forms.TextBox();
            this.Submitbutton = new System.Windows.Forms.Button();
            this.ManradioButton = new System.Windows.Forms.RadioButton();
            this.WomanradioButton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AddUserpanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TextBoxUserID = new System.Windows.Forms.TextBox();
            this.TextBoxPsw = new System.Windows.Forms.TextBox();
            this.TextBoxUserName = new System.Windows.Forms.TextBox();
            this.TextBoxPhoneNum = new System.Windows.Forms.TextBox();
            this.RegisterrButtonMan = new System.Windows.Forms.RadioButton();
            this.RegisterrButtonWoman = new System.Windows.Forms.RadioButton();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.DeleteUserpanel = new System.Windows.Forms.Panel();
            this.TextBoxDelete = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.AddUserpanel.SuspendLayout();
            this.DeleteUserpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "电话号码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "性别";
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(283, 45);
            this.IdtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(189, 25);
            this.IdtextBox.TabIndex = 5;
            this.IdtextBox.TextChanged += new System.EventHandler(this.textBoxUserID_TextChanged);
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(283, 86);
            this.NametextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(189, 25);
            this.NametextBox.TabIndex = 6;
            this.NametextBox.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            // 
            // PhonetextBox
            // 
            this.PhonetextBox.Location = new System.Drawing.Point(283, 161);
            this.PhonetextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PhonetextBox.Name = "PhonetextBox";
            this.PhonetextBox.Size = new System.Drawing.Size(189, 25);
            this.PhonetextBox.TabIndex = 8;
            this.PhonetextBox.TextChanged += new System.EventHandler(this.TextBoxPhoneNum_TextChanged);
            // 
            // Submitbutton
            // 
            this.Submitbutton.Location = new System.Drawing.Point(247, 336);
            this.Submitbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Submitbutton.Name = "Submitbutton";
            this.Submitbutton.Size = new System.Drawing.Size(100, 29);
            this.Submitbutton.TabIndex = 10;
            this.Submitbutton.Text = "提交";
            this.Submitbutton.UseVisualStyleBackColor = true;
            this.Submitbutton.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // ManradioButton
            // 
            this.ManradioButton.AutoSize = true;
            this.ManradioButton.Location = new System.Drawing.Point(300, 130);
            this.ManradioButton.Margin = new System.Windows.Forms.Padding(4);
            this.ManradioButton.Name = "ManradioButton";
            this.ManradioButton.Size = new System.Drawing.Size(43, 19);
            this.ManradioButton.TabIndex = 11;
            this.ManradioButton.TabStop = true;
            this.ManradioButton.Text = "男";
            this.ManradioButton.UseVisualStyleBackColor = true;
            this.ManradioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // WomanradioButton
            // 
            this.WomanradioButton.AutoSize = true;
            this.WomanradioButton.Location = new System.Drawing.Point(392, 130);
            this.WomanradioButton.Margin = new System.Windows.Forms.Padding(4);
            this.WomanradioButton.Name = "WomanradioButton";
            this.WomanradioButton.Size = new System.Drawing.Size(43, 19);
            this.WomanradioButton.TabIndex = 12;
            this.WomanradioButton.TabStop = true;
            this.WomanradioButton.Text = "女";
            this.WomanradioButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 258);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "状态";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 258);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "label7";
            // 
            // AddUserpanel
            // 
            this.AddUserpanel.Controls.Add(this.label3);
            this.AddUserpanel.Controls.Add(this.label8);
            this.AddUserpanel.Controls.Add(this.label9);
            this.AddUserpanel.Controls.Add(this.label10);
            this.AddUserpanel.Controls.Add(this.label11);
            this.AddUserpanel.Controls.Add(this.TextBoxUserID);
            this.AddUserpanel.Controls.Add(this.TextBoxPsw);
            this.AddUserpanel.Controls.Add(this.TextBoxUserName);
            this.AddUserpanel.Controls.Add(this.TextBoxPhoneNum);
            this.AddUserpanel.Controls.Add(this.RegisterrButtonMan);
            this.AddUserpanel.Controls.Add(this.RegisterrButtonWoman);
            this.AddUserpanel.Controls.Add(this.ButtonSubmit);
            this.AddUserpanel.Location = new System.Drawing.Point(47, 13);
            this.AddUserpanel.Margin = new System.Windows.Forms.Padding(4);
            this.AddUserpanel.Name = "AddUserpanel";
            this.AddUserpanel.Size = new System.Drawing.Size(501, 376);
            this.AddUserpanel.TabIndex = 15;
            this.AddUserpanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "账号：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 90);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "密码：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(89, 145);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "姓名：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(89, 192);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "性别";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(89, 242);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "电话号码";
            // 
            // TextBoxUserID
            // 
            this.TextBoxUserID.Location = new System.Drawing.Point(225, 38);
            this.TextBoxUserID.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxUserID.Name = "TextBoxUserID";
            this.TextBoxUserID.Size = new System.Drawing.Size(189, 25);
            this.TextBoxUserID.TabIndex = 21;
            // 
            // TextBoxPsw
            // 
            this.TextBoxPsw.Location = new System.Drawing.Point(225, 86);
            this.TextBoxPsw.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPsw.Name = "TextBoxPsw";
            this.TextBoxPsw.PasswordChar = '*';
            this.TextBoxPsw.Size = new System.Drawing.Size(189, 25);
            this.TextBoxPsw.TabIndex = 22;
            // 
            // TextBoxUserName
            // 
            this.TextBoxUserName.Location = new System.Drawing.Point(225, 141);
            this.TextBoxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxUserName.Name = "TextBoxUserName";
            this.TextBoxUserName.Size = new System.Drawing.Size(189, 25);
            this.TextBoxUserName.TabIndex = 23;
            // 
            // TextBoxPhoneNum
            // 
            this.TextBoxPhoneNum.Location = new System.Drawing.Point(225, 239);
            this.TextBoxPhoneNum.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPhoneNum.Name = "TextBoxPhoneNum";
            this.TextBoxPhoneNum.Size = new System.Drawing.Size(189, 25);
            this.TextBoxPhoneNum.TabIndex = 24;
            // 
            // RegisterrButtonMan
            // 
            this.RegisterrButtonMan.AutoSize = true;
            this.RegisterrButtonMan.Checked = true;
            this.RegisterrButtonMan.Location = new System.Drawing.Point(243, 190);
            this.RegisterrButtonMan.Margin = new System.Windows.Forms.Padding(4);
            this.RegisterrButtonMan.Name = "RegisterrButtonMan";
            this.RegisterrButtonMan.Size = new System.Drawing.Size(43, 19);
            this.RegisterrButtonMan.TabIndex = 25;
            this.RegisterrButtonMan.TabStop = true;
            this.RegisterrButtonMan.Text = "男";
            this.RegisterrButtonMan.UseVisualStyleBackColor = true;
            // 
            // RegisterrButtonWoman
            // 
            this.RegisterrButtonWoman.AutoSize = true;
            this.RegisterrButtonWoman.Location = new System.Drawing.Point(307, 188);
            this.RegisterrButtonWoman.Margin = new System.Windows.Forms.Padding(4);
            this.RegisterrButtonWoman.Name = "RegisterrButtonWoman";
            this.RegisterrButtonWoman.Size = new System.Drawing.Size(43, 19);
            this.RegisterrButtonWoman.TabIndex = 26;
            this.RegisterrButtonWoman.Text = "女";
            this.RegisterrButtonWoman.UseVisualStyleBackColor = true;
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(203, 302);
            this.ButtonSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(100, 29);
            this.ButtonSubmit.TabIndex = 0;
            this.ButtonSubmit.Text = "完成";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // DeleteUserpanel
            // 
            this.DeleteUserpanel.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteUserpanel.Controls.Add(this.TextBoxDelete);
            this.DeleteUserpanel.Controls.Add(this.label12);
            this.DeleteUserpanel.Controls.Add(this.ButtonDelete);
            this.DeleteUserpanel.Location = new System.Drawing.Point(24, 13);
            this.DeleteUserpanel.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteUserpanel.Name = "DeleteUserpanel";
            this.DeleteUserpanel.Size = new System.Drawing.Size(555, 376);
            this.DeleteUserpanel.TabIndex = 27;
            // 
            // TextBoxDelete
            // 
            this.TextBoxDelete.Location = new System.Drawing.Point(241, 120);
            this.TextBoxDelete.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxDelete.Name = "TextBoxDelete";
            this.TextBoxDelete.Size = new System.Drawing.Size(168, 25);
            this.TextBoxDelete.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(67, 124);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "请输入要删除的账号：";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(175, 181);
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(160, 87);
            this.ButtonDelete.TabIndex = 0;
            this.ButtonDelete.Text = "删除";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // UpdateIndivForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 406);
            this.Controls.Add(this.DeleteUserpanel);
            this.Controls.Add(this.AddUserpanel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.WomanradioButton);
            this.Controls.Add(this.ManradioButton);
            this.Controls.Add(this.Submitbutton);
            this.Controls.Add(this.PhonetextBox);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.IdtextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateIndivForm";
            this.ShowIcon = false;
            this.Text = "个人信息";
            this.Load += new System.EventHandler(this.UpdateIndivForm_Load);
            this.AddUserpanel.ResumeLayout(false);
            this.AddUserpanel.PerformLayout();
            this.DeleteUserpanel.ResumeLayout(false);
            this.DeleteUserpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox PhonetextBox;
        private System.Windows.Forms.Button Submitbutton;
        private System.Windows.Forms.RadioButton ManradioButton;
        private System.Windows.Forms.RadioButton WomanradioButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel AddUserpanel;
        private System.Windows.Forms.Button ButtonSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TextBoxUserID;
        private System.Windows.Forms.TextBox TextBoxPsw;
        private System.Windows.Forms.TextBox TextBoxUserName;
        private System.Windows.Forms.TextBox TextBoxPhoneNum;
        private System.Windows.Forms.RadioButton RegisterrButtonMan;
        private System.Windows.Forms.RadioButton RegisterrButtonWoman;
        private System.Windows.Forms.Panel DeleteUserpanel;
        private System.Windows.Forms.TextBox TextBoxDelete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button ButtonDelete;
    }
}