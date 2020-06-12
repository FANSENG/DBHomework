namespace LibraryManager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ButtonAddBook = new System.Windows.Forms.ToolStripButton();
            this.ButtonViewBook = new System.Windows.Forms.ToolStripButton();
            this.ButtonBorrowBook = new System.Windows.Forms.ToolStripButton();
            this.ButtonReturnBook = new System.Windows.Forms.ToolStripButton();
            this.ButtonDeleteBook = new System.Windows.Forms.ToolStripButton();
            this.ButtonBorrowRecord = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonViewUser = new System.Windows.Forms.ToolStripButton();
            this.ButtonAddUser = new System.Windows.Forms.ToolStripButton();
            this.ButtonDeleteUser = new System.Windows.Forms.ToolStripButton();
            this.ButtonAlterData = new System.Windows.Forms.ToolStripButton();
            this.ButtonAlterPsw = new System.Windows.Forms.ToolStripButton();
            this.ButtonLockUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonBookSell = new System.Windows.Forms.ToolStripButton();
            this.ButtonViewSell = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonAddBook,
            this.ButtonViewBook,
            this.ButtonBorrowBook,
            this.ButtonReturnBook,
            this.ButtonDeleteBook,
            this.ButtonBorrowRecord,
            this.toolStripSeparator2,
            this.ButtonViewUser,
            this.ButtonAddUser,
            this.ButtonDeleteUser,
            this.ButtonAlterData,
            this.ButtonAlterPsw,
            this.ButtonLockUser,
            this.toolStripSeparator4,
            this.ButtonBookSell,
            this.ButtonViewSell,
            this.toolStripSeparator1,
            this.ButtonAbout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1109, 66);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ButtonAddBook
            // 
            this.ButtonAddBook.AutoSize = false;
            this.ButtonAddBook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonAddBook.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAddBook.Image")));
            this.ButtonAddBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonAddBook.Name = "ButtonAddBook";
            this.ButtonAddBook.Size = new System.Drawing.Size(49, 44);
            this.ButtonAddBook.Text = "添加书籍";
            this.ButtonAddBook.Click += new System.EventHandler(this.ButtonAddBook_Click);
            // 
            // ButtonViewBook
            // 
            this.ButtonViewBook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonViewBook.Image = ((System.Drawing.Image)(resources.GetObject("ButtonViewBook.Image")));
            this.ButtonViewBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonViewBook.Name = "ButtonViewBook";
            this.ButtonViewBook.Size = new System.Drawing.Size(44, 63);
            this.ButtonViewBook.Text = "查找图书";
            this.ButtonViewBook.Click += new System.EventHandler(this.ButtonViewBook_Click);
            // 
            // ButtonBorrowBook
            // 
            this.ButtonBorrowBook.AutoSize = false;
            this.ButtonBorrowBook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonBorrowBook.Image = ((System.Drawing.Image)(resources.GetObject("ButtonBorrowBook.Image")));
            this.ButtonBorrowBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonBorrowBook.Name = "ButtonBorrowBook";
            this.ButtonBorrowBook.Size = new System.Drawing.Size(49, 44);
            this.ButtonBorrowBook.Text = "借书办理";
            this.ButtonBorrowBook.Click += new System.EventHandler(this.ButtonBorrowBook_Click);
            // 
            // ButtonReturnBook
            // 
            this.ButtonReturnBook.AutoSize = false;
            this.ButtonReturnBook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonReturnBook.Image = ((System.Drawing.Image)(resources.GetObject("ButtonReturnBook.Image")));
            this.ButtonReturnBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonReturnBook.Name = "ButtonReturnBook";
            this.ButtonReturnBook.Size = new System.Drawing.Size(49, 44);
            this.ButtonReturnBook.Text = "还书办理";
            this.ButtonReturnBook.Click += new System.EventHandler(this.ButtonRetuenBook_Click);
            // 
            // ButtonDeleteBook
            // 
            this.ButtonDeleteBook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonDeleteBook.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDeleteBook.Image")));
            this.ButtonDeleteBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonDeleteBook.Name = "ButtonDeleteBook";
            this.ButtonDeleteBook.Size = new System.Drawing.Size(44, 63);
            this.ButtonDeleteBook.Text = "删除图书";
            this.ButtonDeleteBook.Click += new System.EventHandler(this.ButtonLogoutBook_Click);
            // 
            // ButtonBorrowRecord
            // 
            this.ButtonBorrowRecord.AutoSize = false;
            this.ButtonBorrowRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonBorrowRecord.Image = ((System.Drawing.Image)(resources.GetObject("ButtonBorrowRecord.Image")));
            this.ButtonBorrowRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonBorrowRecord.Name = "ButtonBorrowRecord";
            this.ButtonBorrowRecord.Size = new System.Drawing.Size(49, 44);
            this.ButtonBorrowRecord.Text = "查询借书记录";
            this.ButtonBorrowRecord.Click += new System.EventHandler(this.FindRecord_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(7, 45);
            // 
            // ButtonViewUser
            // 
            this.ButtonViewUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonViewUser.Image = ((System.Drawing.Image)(resources.GetObject("ButtonViewUser.Image")));
            this.ButtonViewUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonViewUser.Name = "ButtonViewUser";
            this.ButtonViewUser.Size = new System.Drawing.Size(44, 63);
            this.ButtonViewUser.Text = "查看用户";
            this.ButtonViewUser.Click += new System.EventHandler(this.ButtonViewUser_Click);
            // 
            // ButtonAddUser
            // 
            this.ButtonAddUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonAddUser.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAddUser.Image")));
            this.ButtonAddUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonAddUser.Name = "ButtonAddUser";
            this.ButtonAddUser.Size = new System.Drawing.Size(44, 63);
            this.ButtonAddUser.Text = "添加用户";
            this.ButtonAddUser.Click += new System.EventHandler(this.ButtonAddUser_Click);
            // 
            // ButtonDeleteUser
            // 
            this.ButtonDeleteUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDeleteUser.Image")));
            this.ButtonDeleteUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonDeleteUser.Name = "ButtonDeleteUser";
            this.ButtonDeleteUser.Size = new System.Drawing.Size(44, 63);
            this.ButtonDeleteUser.Text = "删除用户";
            this.ButtonDeleteUser.Click += new System.EventHandler(this.ButtonDeleteUser_Click);
            // 
            // ButtonAlterData
            // 
            this.ButtonAlterData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonAlterData.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAlterData.Image")));
            this.ButtonAlterData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonAlterData.Name = "ButtonAlterData";
            this.ButtonAlterData.Size = new System.Drawing.Size(44, 63);
            this.ButtonAlterData.Text = "修改信息";
            this.ButtonAlterData.Click += new System.EventHandler(this.ButttonAlterData_Click);
            // 
            // ButtonAlterPsw
            // 
            this.ButtonAlterPsw.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonAlterPsw.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAlterPsw.Image")));
            this.ButtonAlterPsw.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonAlterPsw.Name = "ButtonAlterPsw";
            this.ButtonAlterPsw.Size = new System.Drawing.Size(44, 63);
            this.ButtonAlterPsw.Text = "修改密码";
            this.ButtonAlterPsw.Click += new System.EventHandler(this.ButtonAlterPsw_Click);
            // 
            // ButtonLockUser
            // 
            this.ButtonLockUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonLockUser.Image = ((System.Drawing.Image)(resources.GetObject("ButtonLockUser.Image")));
            this.ButtonLockUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonLockUser.Name = "ButtonLockUser";
            this.ButtonLockUser.Size = new System.Drawing.Size(44, 63);
            this.ButtonLockUser.Text = "锁定用户处理";
            this.ButtonLockUser.Click += new System.EventHandler(this.ButtonLockUser_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.AutoSize = false;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(7, 45);
            // 
            // ButtonBookSell
            // 
            this.ButtonBookSell.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonBookSell.Image = ((System.Drawing.Image)(resources.GetObject("ButtonBookSell.Image")));
            this.ButtonBookSell.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonBookSell.Name = "ButtonBookSell";
            this.ButtonBookSell.Size = new System.Drawing.Size(44, 63);
            this.ButtonBookSell.Text = "书籍销售";
            this.ButtonBookSell.Click += new System.EventHandler(this.ButtonBookSell_Click);
            // 
            // ButtonViewSell
            // 
            this.ButtonViewSell.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonViewSell.Image = ((System.Drawing.Image)(resources.GetObject("ButtonViewSell.Image")));
            this.ButtonViewSell.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonViewSell.Name = "ButtonViewSell";
            this.ButtonViewSell.Size = new System.Drawing.Size(44, 63);
            this.ButtonViewSell.Text = "查看销售";
            this.ButtonViewSell.Click += new System.EventHandler(this.ButtonViewSell_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(7, 45);
            // 
            // ButtonAbout
            // 
            this.ButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAbout.Image")));
            this.ButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonAbout.Name = "ButtonAbout";
            this.ButtonAbout.Size = new System.Drawing.Size(44, 63);
            this.ButtonAbout.Text = "关于";
            this.ButtonAbout.Click += new System.EventHandler(this.ButtonAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1109, 665);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1127, 712);
            this.Name = "MainForm";
            this.Text = "图书管理系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ButtonAddBook;
        private System.Windows.Forms.ToolStripButton ButtonBorrowBook;
        private System.Windows.Forms.ToolStripButton ButtonReturnBook;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ButtonBorrowRecord;
        private System.Windows.Forms.ToolStripButton ButtonDeleteBook;
        private System.Windows.Forms.ToolStripButton ButtonViewBook;
        private System.Windows.Forms.ToolStripButton ButtonViewUser;
        private System.Windows.Forms.ToolStripButton ButtonAddUser;
        private System.Windows.Forms.ToolStripButton ButtonDeleteUser;
        private System.Windows.Forms.ToolStripButton ButtonAlterData;
        private System.Windows.Forms.ToolStripButton ButtonAlterPsw;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ButtonAbout;
        private System.Windows.Forms.ToolStripButton ButtonLockUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton ButtonBookSell;
        private System.Windows.Forms.ToolStripButton ButtonViewSell;
    }
}