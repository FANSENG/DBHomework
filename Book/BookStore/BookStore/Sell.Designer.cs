namespace LibraryManager
{
    partial class Sell
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
            this.TextBoxBookNUm = new System.Windows.Forms.TextBox();
            this.ButtonPurchase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(587, 29);
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
            this.label1.Location = new System.Drawing.Point(153, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "书名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "购书用户：";
            // 
            // bName
            // 
            this.bName.AutoSize = true;
            this.bName.Location = new System.Drawing.Point(153, 156);
            this.bName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bName.Name = "bName";
            this.bName.Size = new System.Drawing.Size(52, 15);
            this.bName.TabIndex = 4;
            this.bName.Text = "书名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "书籍序列号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 209);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "书籍价格：";
            // 
            // TextBoxBookName
            // 
            this.TextBoxBookName.Location = new System.Drawing.Point(312, 31);
            this.TextBoxBookName.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxBookName.Name = "TextBoxBookName";
            this.TextBoxBookName.Size = new System.Drawing.Size(233, 25);
            this.TextBoxBookName.TabIndex = 7;
            // 
            // TextBoxBookName2
            // 
            this.TextBoxBookName2.Location = new System.Drawing.Point(235, 152);
            this.TextBoxBookName2.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxBookName2.Name = "TextBoxBookName2";
            this.TextBoxBookName2.ReadOnly = true;
            this.TextBoxBookName2.Size = new System.Drawing.Size(173, 25);
            this.TextBoxBookName2.TabIndex = 8;
            // 
            // TextBoxUserID
            // 
            this.TextBoxUserID.Location = new System.Drawing.Point(577, 91);
            this.TextBoxUserID.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxUserID.Name = "TextBoxUserID";
            this.TextBoxUserID.Size = new System.Drawing.Size(164, 25);
            this.TextBoxUserID.TabIndex = 9;
            // 
            // TextBoxBookPrice
            // 
            this.TextBoxBookPrice.Location = new System.Drawing.Point(235, 209);
            this.TextBoxBookPrice.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxBookPrice.Name = "TextBoxBookPrice";
            this.TextBoxBookPrice.ReadOnly = true;
            this.TextBoxBookPrice.Size = new System.Drawing.Size(173, 25);
            this.TextBoxBookPrice.TabIndex = 10;
            // 
            // TextBoxBookNUm
            // 
            this.TextBoxBookNUm.Location = new System.Drawing.Point(235, 91);
            this.TextBoxBookNUm.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxBookNUm.Name = "TextBoxBookNUm";
            this.TextBoxBookNUm.ReadOnly = true;
            this.TextBoxBookNUm.Size = new System.Drawing.Size(173, 25);
            this.TextBoxBookNUm.TabIndex = 11;
            // 
            // ButtonPurchase
            // 
            this.ButtonPurchase.Location = new System.Drawing.Point(556, 181);
            this.ButtonPurchase.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonPurchase.Name = "ButtonPurchase";
            this.ButtonPurchase.Size = new System.Drawing.Size(130, 70);
            this.ButtonPurchase.TabIndex = 14;
            this.ButtonPurchase.Text = "购买";
            this.ButtonPurchase.UseVisualStyleBackColor = true;
            this.ButtonPurchase.Click += new System.EventHandler(this.ButtonPurchase_Click);
            // 
            // Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 490);
            this.Controls.Add(this.ButtonPurchase);
            this.Controls.Add(this.TextBoxBookNUm);
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
            this.Name = "Sell";
            this.ShowIcon = false;
            this.Text = "购书";
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
        private System.Windows.Forms.TextBox TextBoxBookNUm;
        private System.Windows.Forms.Button ButtonPurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn bbName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPubCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn bTag;

    }
}