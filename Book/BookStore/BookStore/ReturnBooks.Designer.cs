namespace LibraryManager
{
    partial class ReturnBooks
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
            this.TextBoxUserID = new System.Windows.Forms.TextBox();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxBorrowID = new System.Windows.Forms.TextBox();
            this.TextBoxBookName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxBookNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxUserID2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBoxBorrowDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TextBoxReturnDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.TextBoxPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TextBoxTag = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxUserID
            // 
            this.TextBoxUserID.Location = new System.Drawing.Point(98, 17);
            this.TextBoxUserID.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxUserID.Name = "TextBoxUserID";
            this.TextBoxUserID.Size = new System.Drawing.Size(229, 25);
            this.TextBoxUserID.TabIndex = 0;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(335, 13);
            this.ButtonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(215, 29);
            this.ButtonSearch.TabIndex = 1;
            this.ButtonSearch.Text = "搜索";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.uId,
            this.bNum,
            this.bName,
            this.bPrice,
            this.borrowDate,
            this.returnDate,
            this.Tag});
            this.dataGridView.Location = new System.Drawing.Point(-3, 250);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(744, 315);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseUp);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "借书单号";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 80;
            // 
            // uId
            // 
            this.uId.DataPropertyName = "uId";
            this.uId.HeaderText = "用户账号";
            this.uId.MinimumWidth = 6;
            this.uId.Name = "uId";
            this.uId.ReadOnly = true;
            this.uId.Width = 80;
            // 
            // bNum
            // 
            this.bNum.DataPropertyName = "bNum";
            this.bNum.HeaderText = "书籍序列号";
            this.bNum.MinimumWidth = 6;
            this.bNum.Name = "bNum";
            this.bNum.ReadOnly = true;
            this.bNum.Width = 80;
            // 
            // bName
            // 
            this.bName.DataPropertyName = "bName";
            this.bName.HeaderText = "书名";
            this.bName.MinimumWidth = 6;
            this.bName.Name = "bName";
            this.bName.ReadOnly = true;
            this.bName.Width = 80;
            // 
            // bPrice
            // 
            this.bPrice.DataPropertyName = "bPrice";
            this.bPrice.HeaderText = "价格";
            this.bPrice.MinimumWidth = 6;
            this.bPrice.Name = "bPrice";
            this.bPrice.ReadOnly = true;
            this.bPrice.Width = 80;
            // 
            // borrowDate
            // 
            this.borrowDate.DataPropertyName = "borrowDate";
            this.borrowDate.HeaderText = "借出日期";
            this.borrowDate.MinimumWidth = 6;
            this.borrowDate.Name = "borrowDate";
            this.borrowDate.ReadOnly = true;
            this.borrowDate.Width = 80;
            // 
            // returnDate
            // 
            this.returnDate.DataPropertyName = "returnDate";
            this.returnDate.HeaderText = "归还日期";
            this.returnDate.MinimumWidth = 6;
            this.returnDate.Name = "returnDate";
            this.returnDate.ReadOnly = true;
            this.returnDate.Width = 80;
            // 
            // Tag
            // 
            this.Tag.DataPropertyName = "Tag";
            this.Tag.HeaderText = "是否逾期";
            this.Tag.MinimumWidth = 6;
            this.Tag.Name = "Tag";
            this.Tag.ReadOnly = true;
            this.Tag.Width = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "账号:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "借书单号：";
            // 
            // TextBoxBorrowID
            // 
            this.TextBoxBorrowID.Location = new System.Drawing.Point(109, 78);
            this.TextBoxBorrowID.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxBorrowID.Name = "TextBoxBorrowID";
            this.TextBoxBorrowID.Size = new System.Drawing.Size(153, 25);
            this.TextBoxBorrowID.TabIndex = 8;
            // 
            // TextBoxBookName
            // 
            this.TextBoxBookName.Location = new System.Drawing.Point(110, 211);
            this.TextBoxBookName.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxBookName.Name = "TextBoxBookName";
            this.TextBoxBookName.Size = new System.Drawing.Size(159, 25);
            this.TextBoxBookName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "书籍序列号：";
            // 
            // TextBoxBookNum
            // 
            this.TextBoxBookNum.Location = new System.Drawing.Point(386, 78);
            this.TextBoxBookNum.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxBookNum.Name = "TextBoxBookNum";
            this.TextBoxBookNum.Size = new System.Drawing.Size(159, 25);
            this.TextBoxBookNum.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 211);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "书名：";
            // 
            // TextBoxUserID2
            // 
            this.TextBoxUserID2.Location = new System.Drawing.Point(110, 124);
            this.TextBoxUserID2.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxUserID2.Name = "TextBoxUserID2";
            this.TextBoxUserID2.Size = new System.Drawing.Size(152, 25);
            this.TextBoxUserID2.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 128);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "用户账号：";
            // 
            // TextBoxBorrowDate
            // 
            this.TextBoxBorrowDate.Location = new System.Drawing.Point(386, 161);
            this.TextBoxBorrowDate.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxBorrowDate.Name = "TextBoxBorrowDate";
            this.TextBoxBorrowDate.Size = new System.Drawing.Size(164, 25);
            this.TextBoxBorrowDate.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(291, 165);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "借出日期：";
            // 
            // TextBoxReturnDate
            // 
            this.TextBoxReturnDate.Location = new System.Drawing.Point(386, 208);
            this.TextBoxReturnDate.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxReturnDate.Name = "TextBoxReturnDate";
            this.TextBoxReturnDate.Size = new System.Drawing.Size(164, 25);
            this.TextBoxReturnDate.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 211);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "归还日期：";
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(572, 128);
            this.ButtonSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(154, 47);
            this.ButtonSubmit.TabIndex = 19;
            this.ButtonSubmit.Text = "提交";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.Location = new System.Drawing.Point(386, 125);
            this.TextBoxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.Size = new System.Drawing.Size(159, 25);
            this.TextBoxPrice.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(294, 128);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "书籍价格：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 174);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "是否逾期：";
            // 
            // TextBoxTag
            // 
            this.TextBoxTag.Location = new System.Drawing.Point(110, 171);
            this.TextBoxTag.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxTag.Name = "TextBoxTag";
            this.TextBoxTag.Size = new System.Drawing.Size(152, 25);
            this.TextBoxTag.TabIndex = 23;
            // 
            // ReturnBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 565);
            this.Controls.Add(this.TextBoxTag);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TextBoxPrice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.TextBoxBorrowDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TextBoxReturnDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TextBoxUserID2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TextBoxBookNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBoxBookName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxBorrowID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.TextBoxUserID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReturnBooks";
            this.ShowIcon = false;
            this.Text = "还书办理";
            this.Load += new System.EventHandler(this.ReturnBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxUserID;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxBorrowID;
        private System.Windows.Forms.TextBox TextBoxBookName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxBookNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxUserID2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBoxBorrowDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextBoxReturnDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ButtonSubmit;
        private System.Windows.Forms.TextBox TextBoxPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TextBoxTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn uId;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn bName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tag;
    }
}