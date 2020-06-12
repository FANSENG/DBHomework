namespace LibraryManager
{
    partial class BorrowBooks
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
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.bNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bbName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPubCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxBookName = new System.Windows.Forms.TextBox();
            this.TextBoxBookName2 = new System.Windows.Forms.TextBox();
            this.TextBoxUserID = new System.Windows.Forms.TextBox();
            this.TextBoxBookPrice = new System.Windows.Forms.TextBox();
            this.TextBoxBookNum = new System.Windows.Forms.TextBox();
            this.comboBoxBorrowDuration = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(655, 88);
            this.ButtonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(140, 29);
            this.ButtonSearch.TabIndex = 0;
            this.ButtonSearch.Text = "查询";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bNum,
            this.bbName,
            this.bAuthor,
            this.bPubCom,
            this.bPrice,
            this.bTag});
            this.dataGridView.Location = new System.Drawing.Point(-1, 284);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(859, 206);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseUp);
            // 
            // bNum
            // 
            this.bNum.DataPropertyName = "bNum";
            this.bNum.HeaderText = "书籍序列号";
            this.bNum.MinimumWidth = 6;
            this.bNum.Name = "bNum";
            this.bNum.ReadOnly = true;
            this.bNum.Width = 125;
            // 
            // bbName
            // 
            this.bbName.DataPropertyName = "bName";
            this.bbName.HeaderText = "书名";
            this.bbName.MinimumWidth = 6;
            this.bbName.Name = "bbName";
            this.bbName.ReadOnly = true;
            this.bbName.Width = 125;
            // 
            // bAuthor
            // 
            this.bAuthor.DataPropertyName = "bAuthor";
            this.bAuthor.HeaderText = "作者";
            this.bAuthor.MinimumWidth = 6;
            this.bAuthor.Name = "bAuthor";
            this.bAuthor.ReadOnly = true;
            this.bAuthor.Width = 125;
            // 
            // bPubCom
            // 
            this.bPubCom.DataPropertyName = "bPubCom";
            this.bPubCom.HeaderText = "出版社";
            this.bPubCom.MinimumWidth = 6;
            this.bPubCom.Name = "bPubCom";
            this.bPubCom.ReadOnly = true;
            this.bPubCom.Width = 125;
            // 
            // bPrice
            // 
            this.bPrice.DataPropertyName = "bPrice";
            this.bPrice.HeaderText = "价格";
            this.bPrice.MinimumWidth = 6;
            this.bPrice.Name = "bPrice";
            this.bPrice.ReadOnly = true;
            this.bPrice.Width = 125;
            // 
            // bTag
            // 
            this.bTag.DataPropertyName = "bTag";
            this.bTag.HeaderText = "库存量";
            this.bTag.MinimumWidth = 6;
            this.bTag.Name = "bTag";
            this.bTag.ReadOnly = true;
            this.bTag.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "书名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "借书用户：";
            // 
            // bName
            // 
            this.bName.AutoSize = true;
            this.bName.Location = new System.Drawing.Point(64, 156);
            this.bName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bName.Name = "bName";
            this.bName.Size = new System.Drawing.Size(52, 15);
            this.bName.TabIndex = 4;
            this.bName.Text = "书名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "书籍序列号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 209);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "书籍价格：";
            // 
            // TextBoxBookName
            // 
            this.TextBoxBookName.Location = new System.Drawing.Point(400, 92);
            this.TextBoxBookName.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxBookName.Name = "TextBoxBookName";
            this.TextBoxBookName.Size = new System.Drawing.Size(233, 25);
            this.TextBoxBookName.TabIndex = 7;
            // 
            // TextBoxBookName2
            // 
            this.TextBoxBookName2.Location = new System.Drawing.Point(146, 152);
            this.TextBoxBookName2.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxBookName2.Name = "TextBoxBookName2";
            this.TextBoxBookName2.ReadOnly = true;
            this.TextBoxBookName2.Size = new System.Drawing.Size(173, 25);
            this.TextBoxBookName2.TabIndex = 8;
            // 
            // TextBoxUserID
            // 
            this.TextBoxUserID.Location = new System.Drawing.Point(423, 152);
            this.TextBoxUserID.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxUserID.Name = "TextBoxUserID";
            this.TextBoxUserID.Size = new System.Drawing.Size(164, 25);
            this.TextBoxUserID.TabIndex = 9;
            // 
            // TextBoxBookPrice
            // 
            this.TextBoxBookPrice.Location = new System.Drawing.Point(146, 209);
            this.TextBoxBookPrice.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxBookPrice.Name = "TextBoxBookPrice";
            this.TextBoxBookPrice.ReadOnly = true;
            this.TextBoxBookPrice.Size = new System.Drawing.Size(173, 25);
            this.TextBoxBookPrice.TabIndex = 10;
            // 
            // TextBoxBookNum
            // 
            this.TextBoxBookNum.Location = new System.Drawing.Point(146, 91);
            this.TextBoxBookNum.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxBookNum.Name = "TextBoxBookNum";
            this.TextBoxBookNum.ReadOnly = true;
            this.TextBoxBookNum.Size = new System.Drawing.Size(173, 25);
            this.TextBoxBookNum.TabIndex = 11;
            // 
            // comboBoxBorrowDuration
            // 
            this.comboBoxBorrowDuration.FormattingEnabled = true;
            this.comboBoxBorrowDuration.Items.AddRange(new object[] {
            "30天",
            "60天",
            "90天"});
            this.comboBoxBorrowDuration.Location = new System.Drawing.Point(436, 208);
            this.comboBoxBorrowDuration.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxBorrowDuration.Name = "comboBoxBorrowDuration";
            this.comboBoxBorrowDuration.Size = new System.Drawing.Size(160, 23);
            this.comboBoxBorrowDuration.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 212);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "借书时长：";
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(644, 156);
            this.ButtonSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(120, 53);
            this.ButtonSubmit.TabIndex = 14;
            this.ButtonSubmit.Text = "提交";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // BorrowBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 490);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxBorrowDuration);
            this.Controls.Add(this.TextBoxBookNum);
            this.Controls.Add(this.TextBoxBookPrice);
            this.Controls.Add(this.TextBoxUserID);
            this.Controls.Add(this.TextBoxBookName2);
            this.Controls.Add(this.TextBoxBookName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.ButtonSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BorrowBooks";
            this.ShowIcon = false;
            this.Text = "借书办理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label bName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxBookName;
        private System.Windows.Forms.TextBox TextBoxBookName2;
        private System.Windows.Forms.TextBox TextBoxUserID;
        private System.Windows.Forms.TextBox TextBoxBookPrice;
        private System.Windows.Forms.TextBox TextBoxBookNum;
        private System.Windows.Forms.ComboBox comboBoxBorrowDuration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ButtonSubmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn bbName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPubCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn bTag;

    }
}