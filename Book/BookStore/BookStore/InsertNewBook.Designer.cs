namespace LibraryManager
{
    partial class InsertNewBookForm
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
            this.ButtonAddBook = new System.Windows.Forms.Button();
            this.TextBoxBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxBookAuthor = new System.Windows.Forms.TextBox();
            this.TextBoxPress = new System.Windows.Forms.TextBox();
            this.TextBoxDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBoxBookISBN = new System.Windows.Forms.TextBox();
            this.TextBoxBookPrice = new System.Windows.Forms.TextBox();
            this.TextBoxBookNum = new System.Windows.Forms.TextBox();
            this.DeleteBookpanel = new System.Windows.Forms.Panel();
            this.TextBoxDeleteBook = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonAddPicture = new System.Windows.Forms.Button();
            this.ButtonAddIntro = new System.Windows.Forms.Button();
            this.DeleteBookpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonAddBook
            // 
            this.ButtonAddBook.Location = new System.Drawing.Point(288, 346);
            this.ButtonAddBook.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAddBook.Name = "ButtonAddBook";
            this.ButtonAddBook.Size = new System.Drawing.Size(100, 29);
            this.ButtonAddBook.TabIndex = 0;
            this.ButtonAddBook.Text = "完成";
            this.ButtonAddBook.UseVisualStyleBackColor = true;
            this.ButtonAddBook.Click += new System.EventHandler(this.ButtonAddBook_Click);
            // 
            // TextBoxBookName
            // 
            this.TextBoxBookName.Location = new System.Drawing.Point(169, 56);
            this.TextBoxBookName.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxBookName.Name = "TextBoxBookName";
            this.TextBoxBookName.Size = new System.Drawing.Size(161, 25);
            this.TextBoxBookName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "书名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "作者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "出版社：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "出版年月：";
            // 
            // TextBoxBookAuthor
            // 
            this.TextBoxBookAuthor.Location = new System.Drawing.Point(455, 56);
            this.TextBoxBookAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxBookAuthor.Name = "TextBoxBookAuthor";
            this.TextBoxBookAuthor.Size = new System.Drawing.Size(164, 25);
            this.TextBoxBookAuthor.TabIndex = 6;
            // 
            // TextBoxPress
            // 
            this.TextBoxPress.Location = new System.Drawing.Point(169, 119);
            this.TextBoxPress.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPress.Name = "TextBoxPress";
            this.TextBoxPress.Size = new System.Drawing.Size(161, 25);
            this.TextBoxPress.TabIndex = 7;
            // 
            // TextBoxDate
            // 
            this.TextBoxDate.Location = new System.Drawing.Point(169, 251);
            this.TextBoxDate.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxDate.Name = "TextBoxDate";
            this.TextBoxDate.Size = new System.Drawing.Size(161, 25);
            this.TextBoxDate.TabIndex = 8;
            this.TextBoxDate.Text = "yyyy-mm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "价格：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "ISBN：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 189);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "数量：";
            // 
            // TextBoxBookISBN
            // 
            this.TextBoxBookISBN.Location = new System.Drawing.Point(455, 119);
            this.TextBoxBookISBN.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxBookISBN.Name = "TextBoxBookISBN";
            this.TextBoxBookISBN.Size = new System.Drawing.Size(161, 25);
            this.TextBoxBookISBN.TabIndex = 12;
            // 
            // TextBoxBookPrice
            // 
            this.TextBoxBookPrice.Location = new System.Drawing.Point(455, 185);
            this.TextBoxBookPrice.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxBookPrice.Name = "TextBoxBookPrice";
            this.TextBoxBookPrice.Size = new System.Drawing.Size(164, 25);
            this.TextBoxBookPrice.TabIndex = 13;
            // 
            // TextBoxBookNum
            // 
            this.TextBoxBookNum.Location = new System.Drawing.Point(169, 185);
            this.TextBoxBookNum.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxBookNum.Name = "TextBoxBookNum";
            this.TextBoxBookNum.Size = new System.Drawing.Size(161, 25);
            this.TextBoxBookNum.TabIndex = 14;
            // 
            // DeleteBookpanel
            // 
            this.DeleteBookpanel.Controls.Add(this.TextBoxDeleteBook);
            this.DeleteBookpanel.Controls.Add(this.label9);
            this.DeleteBookpanel.Controls.Add(this.ButtonDelete);
            this.DeleteBookpanel.Location = new System.Drawing.Point(53, 36);
            this.DeleteBookpanel.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteBookpanel.Name = "DeleteBookpanel";
            this.DeleteBookpanel.Size = new System.Drawing.Size(649, 339);
            this.DeleteBookpanel.TabIndex = 16;
            // 
            // TextBoxDeleteBook
            // 
            this.TextBoxDeleteBook.Location = new System.Drawing.Point(315, 115);
            this.TextBoxDeleteBook.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxDeleteBook.Name = "TextBoxDeleteBook";
            this.TextBoxDeleteBook.Size = new System.Drawing.Size(179, 25);
            this.TextBoxDeleteBook.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(156, 119);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "请输入书籍序列号：";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(260, 215);
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(100, 29);
            this.ButtonDelete.TabIndex = 0;
            this.ButtonDelete.Text = "删除书籍";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDeleteBook_Click);
            // 
            // ButtonAddPicture
            // 
            this.ButtonAddPicture.Location = new System.Drawing.Point(478, 223);
            this.ButtonAddPicture.Name = "ButtonAddPicture";
            this.ButtonAddPicture.Size = new System.Drawing.Size(135, 47);
            this.ButtonAddPicture.TabIndex = 17;
            this.ButtonAddPicture.Text = "添加照片";
            this.ButtonAddPicture.UseVisualStyleBackColor = true;
            this.ButtonAddPicture.Click += new System.EventHandler(this.ButtonAddPicture_Click);
            // 
            // ButtonAddIntro
            // 
            this.ButtonAddIntro.Location = new System.Drawing.Point(478, 276);
            this.ButtonAddIntro.Name = "ButtonAddIntro";
            this.ButtonAddIntro.Size = new System.Drawing.Size(135, 45);
            this.ButtonAddIntro.TabIndex = 18;
            this.ButtonAddIntro.Text = "添加简介";
            this.ButtonAddIntro.UseVisualStyleBackColor = true;
            this.ButtonAddIntro.Click += new System.EventHandler(this.ButtonAddIntro_Click);
            // 
            // InsertNewBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 418);
            this.Controls.Add(this.DeleteBookpanel);
            this.Controls.Add(this.TextBoxBookNum);
            this.Controls.Add(this.TextBoxBookPrice);
            this.Controls.Add(this.TextBoxBookISBN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxDate);
            this.Controls.Add(this.TextBoxPress);
            this.Controls.Add(this.TextBoxBookAuthor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxBookName);
            this.Controls.Add(this.ButtonAddBook);
            this.Controls.Add(this.ButtonAddPicture);
            this.Controls.Add(this.ButtonAddIntro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InsertNewBookForm";
            this.ShowIcon = false;
            this.Text = "新书入库";
            this.Load += new System.EventHandler(this.NewBookForm_Load);
            this.DeleteBookpanel.ResumeLayout(false);
            this.DeleteBookpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddBook;
        private System.Windows.Forms.TextBox TextBoxBookName;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxBookAuthor;
        private System.Windows.Forms.TextBox TextBoxPress;
        private System.Windows.Forms.TextBox TextBoxDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBoxBookISBN;
        private System.Windows.Forms.TextBox TextBoxBookPrice;
        private System.Windows.Forms.TextBox TextBoxBookNum;
        private System.Windows.Forms.Panel DeleteBookpanel;
        private System.Windows.Forms.TextBox TextBoxDeleteBook;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonAddPicture;
        private System.Windows.Forms.Button ButtonAddIntro;
    }
}