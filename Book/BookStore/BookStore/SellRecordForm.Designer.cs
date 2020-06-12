namespace LibraryManager
{
    partial class SellRecordForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BorrowID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bookname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.NametoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.ButtonSearchAllPurchase = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.uId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonSearchByBookNum = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxBookNum = new System.Windows.Forms.TextBox();
            this.ButtonSearchByUserID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxUserID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.adminPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BorrowID,
            this.UserId,
            this.Bookname,
            this.BookId,
            this.price,
            this.borrowTime,
            this.returnTime,
            this.Tag});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1086, 494);
            this.dataGridView1.TabIndex = 0;
            // 
            // BorrowID
            // 
            this.BorrowID.DataPropertyName = "ID";
            this.BorrowID.HeaderText = "ID";
            this.BorrowID.MinimumWidth = 6;
            this.BorrowID.Name = "BorrowID";
            this.BorrowID.ReadOnly = true;
            this.BorrowID.Width = 125;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "uId";
            this.UserId.HeaderText = "账户";
            this.UserId.MinimumWidth = 6;
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Width = 125;
            // 
            // Bookname
            // 
            this.Bookname.DataPropertyName = "bName";
            this.Bookname.HeaderText = "书名";
            this.Bookname.MinimumWidth = 6;
            this.Bookname.Name = "Bookname";
            this.Bookname.ReadOnly = true;
            this.Bookname.Width = 125;
            // 
            // BookId
            // 
            this.BookId.DataPropertyName = "bNum";
            this.BookId.HeaderText = "书籍编号";
            this.BookId.MinimumWidth = 6;
            this.BookId.Name = "BookId";
            this.BookId.ReadOnly = true;
            this.BookId.Width = 125;
            // 
            // price
            // 
            this.price.DataPropertyName = "bPrice";
            this.price.HeaderText = "价格";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 125;
            // 
            // borrowTime
            // 
            this.borrowTime.DataPropertyName = "purchaseDate";
            this.borrowTime.HeaderText = "销售时间";
            this.borrowTime.MinimumWidth = 6;
            this.borrowTime.Name = "borrowTime";
            this.borrowTime.ReadOnly = true;
            this.borrowTime.Width = 125;
            // 
            // returnTime
            // 
            this.returnTime.MinimumWidth = 6;
            this.returnTime.Name = "returnTime";
            this.returnTime.ReadOnly = true;
            this.returnTime.Width = 125;
            // 
            // Tag
            // 
            this.Tag.MinimumWidth = 6;
            this.Tag.Name = "Tag";
            this.Tag.ReadOnly = true;
            this.Tag.Width = 125;
            // 
            // borrowBindingSource
            // 
            this.borrowBindingSource.DataMember = "sell";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NametoolStripStatusLabel,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 505);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(924, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // NametoolStripStatusLabel
            // 
            this.NametoolStripStatusLabel.Name = "NametoolStripStatusLabel";
            this.NametoolStripStatusLabel.Size = new System.Drawing.Size(41, 20);
            this.NametoolStripStatusLabel.Text = "xxxx";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(294, 20);
            this.toolStripStatusLabel2.Text = "，您的借阅书单如上，请按时归还图书哦！";
            // 
            // adminPanel
            // 
            this.adminPanel.Controls.Add(this.ButtonSearchAllPurchase);
            this.adminPanel.Controls.Add(this.dataGridView);
            this.adminPanel.Controls.Add(this.ButtonSearchByBookNum);
            this.adminPanel.Controls.Add(this.label2);
            this.adminPanel.Controls.Add(this.TextBoxBookNum);
            this.adminPanel.Controls.Add(this.ButtonSearchByUserID);
            this.adminPanel.Controls.Add(this.label1);
            this.adminPanel.Controls.Add(this.TextBoxUserID);
            this.adminPanel.Location = new System.Drawing.Point(0, 2);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(1110, 529);
            this.adminPanel.TabIndex = 2;
            // 
            // ButtonSearchAllPurchase
            // 
            this.ButtonSearchAllPurchase.Location = new System.Drawing.Point(785, 11);
            this.ButtonSearchAllPurchase.Name = "ButtonSearchAllPurchase";
            this.ButtonSearchAllPurchase.Size = new System.Drawing.Size(114, 76);
            this.ButtonSearchAllPurchase.TabIndex = 7;
            this.ButtonSearchAllPurchase.Text = "显示所有购买";
            this.ButtonSearchAllPurchase.UseVisualStyleBackColor = true;
            this.ButtonSearchAllPurchase.Click += new System.EventHandler(this.ButtonSearchAll_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uId,
            this.UserName,
            this.bID,
            this.Bprice,
            this.purchaseDate});
            this.dataGridView.Location = new System.Drawing.Point(3, 132);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 27;
            this.dataGridView.Size = new System.Drawing.Size(843, 394);
            this.dataGridView.TabIndex = 6;
            // 
            // uId
            // 
            this.uId.DataPropertyName = "uId";
            this.uId.HeaderText = "账户";
            this.uId.MinimumWidth = 6;
            this.uId.Name = "uId";
            this.uId.ReadOnly = true;
            this.uId.Width = 125;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "uName";
            this.UserName.HeaderText = "用户姓名";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 125;
            // 
            // bID
            // 
            this.bID.DataPropertyName = "bNum";
            this.bID.HeaderText = "书序列号";
            this.bID.MinimumWidth = 6;
            this.bID.Name = "bID";
            this.bID.ReadOnly = true;
            this.bID.Width = 125;
            // 
            // Bprice
            // 
            this.Bprice.DataPropertyName = "bPrice";
            this.Bprice.HeaderText = "书籍单价";
            this.Bprice.MinimumWidth = 6;
            this.Bprice.Name = "Bprice";
            this.Bprice.ReadOnly = true;
            this.Bprice.Width = 125;
            // 
            // purchaseDate
            // 
            this.purchaseDate.DataPropertyName = "purchaseDate";
            this.purchaseDate.HeaderText = "销售时间";
            this.purchaseDate.MinimumWidth = 6;
            this.purchaseDate.Name = "purchaseDate";
            this.purchaseDate.ReadOnly = true;
            this.purchaseDate.Width = 125;
            // 
            // ButtonSearchByBookNum
            // 
            this.ButtonSearchByBookNum.Location = new System.Drawing.Point(482, 53);
            this.ButtonSearchByBookNum.Name = "ButtonSearchByBookNum";
            this.ButtonSearchByBookNum.Size = new System.Drawing.Size(133, 32);
            this.ButtonSearchByBookNum.TabIndex = 5;
            this.ButtonSearchByBookNum.Text = "按书序列号查找";
            this.ButtonSearchByBookNum.UseVisualStyleBackColor = true;
            this.ButtonSearchByBookNum.Click += new System.EventHandler(this.ButtonSearchByBookNum_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(356, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "书序列号：";
            // 
            // TextBoxBookNum
            // 
            this.TextBoxBookNum.Location = new System.Drawing.Point(471, 10);
            this.TextBoxBookNum.Name = "TextBoxBookNum";
            this.TextBoxBookNum.Size = new System.Drawing.Size(239, 25);
            this.TextBoxBookNum.TabIndex = 3;
            this.TextBoxBookNum.Enter += new System.EventHandler(this.bookNumTextBox_Enter);
            // 
            // ButtonSearchByUserID
            // 
            this.ButtonSearchByUserID.Location = new System.Drawing.Point(87, 53);
            this.ButtonSearchByUserID.Name = "ButtonSearchByUserID";
            this.ButtonSearchByUserID.Size = new System.Drawing.Size(133, 32);
            this.ButtonSearchByUserID.TabIndex = 2;
            this.ButtonSearchByUserID.Text = "按用户查找";
            this.ButtonSearchByUserID.UseVisualStyleBackColor = true;
            this.ButtonSearchByUserID.Click += new System.EventHandler(this.ButtonSearchByUserID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "账号：";
            // 
            // TextBoxUserID
            // 
            this.TextBoxUserID.Location = new System.Drawing.Point(87, 11);
            this.TextBoxUserID.Name = "TextBoxUserID";
            this.TextBoxUserID.Size = new System.Drawing.Size(239, 25);
            this.TextBoxUserID.TabIndex = 0;
            this.TextBoxUserID.Enter += new System.EventHandler(this.IdTextBox_Enter);
            // 
            // SellRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 531);
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SellRecordForm";
            this.ShowIcon = false;
            this.Text = "购买历史";
            this.Load += new System.EventHandler(this.FindRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.adminPanel.ResumeLayout(false);
            this.adminPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        //private libraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource borrowBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bookname;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tag;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel NametoolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.Button ButtonSearchByUserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxUserID;
        private System.Windows.Forms.Button ButtonSearchByBookNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxBookNum;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button ButtonSearchAllPurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn uId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDate;
    }
}