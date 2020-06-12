namespace LibraryManager
{
    partial class FindBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindBookForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ButtonNewBook = new System.Windows.Forms.ToolStripButton();
            this.ButtonSave = new System.Windows.Forms.ToolStripButton();
            this.ButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.ButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonFirstPage = new System.Windows.Forms.ToolStripButton();
            this.ButtonPreviousPage = new System.Windows.Forms.ToolStripButton();
            this.ButtonNextPage = new System.Windows.Forms.ToolStripButton();
            this.ButtonLastPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.ButtonBookName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ButtonImage = new System.Windows.Forms.ToolStripButton();
            this.ButtonInfo = new System.Windows.Forms.ToolStripButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.图书序列号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.书名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作者 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出版社 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出版日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.价格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.库存数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonNewBook,
            this.ButtonSave,
            this.ButtonRefresh,
            this.ButtonDelete,
            this.toolStripSeparator1,
            this.ButtonFirstPage,
            this.ButtonPreviousPage,
            this.ButtonNextPage,
            this.ButtonLastPage,
            this.toolStripSeparator2,
            this.ButtonSearch,
            this.ButtonBookName,
            this.toolStripLabel1,
            this.ButtonImage,
            this.ButtonInfo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1077, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ButtonNewBook
            // 
            this.ButtonNewBook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonNewBook.Image = ((System.Drawing.Image)(resources.GetObject("ButtonNewBook.Image")));
            this.ButtonNewBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonNewBook.Name = "ButtonNewBook";
            this.ButtonNewBook.Size = new System.Drawing.Size(36, 36);
            this.ButtonNewBook.Text = "书籍入库";
            this.ButtonNewBook.Click += new System.EventHandler(this.ButtonNewBook_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.AutoSize = false;
            this.ButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSave.Image")));
            this.ButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(33, 32);
            this.ButtonSave.Text = "保存修改";
            this.ButtonSave.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.AutoSize = false;
            this.ButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("ButtonRefresh.Image")));
            this.ButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(33, 32);
            this.ButtonRefresh.Text = "刷新书库";
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefersh_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDelete.Image")));
            this.ButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(36, 36);
            this.ButtonDelete.Text = "删除书籍";
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // ButtonFirstPage
            // 
            this.ButtonFirstPage.AutoSize = false;
            this.ButtonFirstPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonFirstPage.Image = ((System.Drawing.Image)(resources.GetObject("ButtonFirstPage.Image")));
            this.ButtonFirstPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonFirstPage.Name = "ButtonFirstPage";
            this.ButtonFirstPage.Size = new System.Drawing.Size(33, 32);
            this.ButtonFirstPage.Text = "跳转至第一页";
            this.ButtonFirstPage.Click += new System.EventHandler(this.ButtonFirstPage_Click);
            // 
            // ButtonPreviousPage
            // 
            this.ButtonPreviousPage.AutoSize = false;
            this.ButtonPreviousPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonPreviousPage.Image = ((System.Drawing.Image)(resources.GetObject("ButtonPreviousPage.Image")));
            this.ButtonPreviousPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonPreviousPage.Name = "ButtonPreviousPage";
            this.ButtonPreviousPage.Size = new System.Drawing.Size(33, 32);
            this.ButtonPreviousPage.Text = "跳转至上一页";
            this.ButtonPreviousPage.Click += new System.EventHandler(this.ButtonPreviousPage_Click);
            // 
            // ButtonNextPage
            // 
            this.ButtonNextPage.AutoSize = false;
            this.ButtonNextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonNextPage.Image = ((System.Drawing.Image)(resources.GetObject("ButtonNextPage.Image")));
            this.ButtonNextPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonNextPage.Name = "ButtonNextPage";
            this.ButtonNextPage.Size = new System.Drawing.Size(33, 32);
            this.ButtonNextPage.Text = "跳转至下一页";
            this.ButtonNextPage.Click += new System.EventHandler(this.ButtonNextPage_Click);
            // 
            // ButtonLastPage
            // 
            this.ButtonLastPage.AutoSize = false;
            this.ButtonLastPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonLastPage.Image = ((System.Drawing.Image)(resources.GetObject("ButtonLastPage.Image")));
            this.ButtonLastPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonLastPage.Name = "ButtonLastPage";
            this.ButtonLastPage.Size = new System.Drawing.Size(33, 32);
            this.ButtonLastPage.Text = "跳至最后一页";
            this.ButtonLastPage.Click += new System.EventHandler(this.ButtonLastPage_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ButtonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSearch.Image")));
            this.ButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(36, 36);
            this.ButtonSearch.Text = "按书名查找";
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonBookName
            // 
            this.ButtonBookName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ButtonBookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ButtonBookName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.ButtonBookName.Name = "ButtonBookName";
            this.ButtonBookName.Size = new System.Drawing.Size(167, 39);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(103, 36);
            this.toolStripLabel1.Text = "输入书名查找:";
            // 
            // ButtonImage
            // 
            this.ButtonImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonImage.Image = ((System.Drawing.Image)(resources.GetObject("ButtonImage.Image")));
            this.ButtonImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonImage.Name = "ButtonImage";
            this.ButtonImage.Size = new System.Drawing.Size(36, 36);
            this.ButtonImage.Text = "查看照片";
            this.ButtonImage.Click += new System.EventHandler(this.ButtonImage_Click);
            // 
            // ButtonInfo
            // 
            this.ButtonInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonInfo.Image = ((System.Drawing.Image)(resources.GetObject("ButtonInfo.Image")));
            this.ButtonInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonInfo.Name = "ButtonInfo";
            this.ButtonInfo.Size = new System.Drawing.Size(36, 36);
            this.ButtonInfo.Text = "查看简介";
            this.ButtonInfo.Click += new System.EventHandler(this.ButtonInfo_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.图书序列号,
            this.书名,
            this.作者,
            this.出版社,
            this.出版日期,
            this.ISBN,
            this.价格,
            this.库存数量});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 39);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(1077, 475);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            // 
            // 图书序列号
            // 
            this.图书序列号.DataPropertyName = "bNum";
            this.图书序列号.HeaderText = "图书序列号";
            this.图书序列号.MinimumWidth = 6;
            this.图书序列号.Name = "图书序列号";
            this.图书序列号.ReadOnly = true;
            this.图书序列号.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.图书序列号.Width = 90;
            // 
            // 书名
            // 
            this.书名.DataPropertyName = "bName";
            this.书名.HeaderText = "书名";
            this.书名.MinimumWidth = 6;
            this.书名.Name = "书名";
            this.书名.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.书名.Width = 140;
            // 
            // 作者
            // 
            this.作者.DataPropertyName = "bAuthor";
            this.作者.HeaderText = "作者";
            this.作者.MinimumWidth = 6;
            this.作者.Name = "作者";
            this.作者.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.作者.Width = 125;
            // 
            // 出版社
            // 
            this.出版社.DataPropertyName = "bPubCom";
            this.出版社.HeaderText = "出版社";
            this.出版社.MinimumWidth = 6;
            this.出版社.Name = "出版社";
            this.出版社.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.出版社.Width = 125;
            // 
            // 出版日期
            // 
            this.出版日期.DataPropertyName = "bPubDat";
            this.出版日期.HeaderText = "出版日期";
            this.出版日期.MinimumWidth = 6;
            this.出版日期.Name = "出版日期";
            this.出版日期.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.出版日期.Width = 80;
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.MinimumWidth = 6;
            this.ISBN.Name = "ISBN";
            this.ISBN.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ISBN.Width = 120;
            // 
            // 价格
            // 
            this.价格.DataPropertyName = "bPrice";
            this.价格.HeaderText = "价格";
            this.价格.MinimumWidth = 6;
            this.价格.Name = "价格";
            this.价格.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.价格.Width = 55;
            // 
            // 库存数量
            // 
            this.库存数量.DataPropertyName = "bTag";
            this.库存数量.HeaderText = "库存数量";
            this.库存数量.MinimumWidth = 6;
            this.库存数量.Name = "库存数量";
            this.库存数量.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.库存数量.Width = 80;
            // 
            // FindBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 514);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindBookForm";
            this.ShowIcon = false;
            this.Text = "书籍查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindBookForm_FormClosing);
            this.Load += new System.EventHandler(this.FindBookForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ButtonSave;
        private System.Windows.Forms.ToolStripButton ButtonFirstPage;
        private System.Windows.Forms.ToolStripButton ButtonLastPage;
        private System.Windows.Forms.ToolStripButton ButtonPreviousPage;
        private System.Windows.Forms.ToolStripButton ButtonNextPage;
        private System.Windows.Forms.ToolStripButton ButtonRefresh;
        private System.Windows.Forms.ToolStripButton ButtonNewBook;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ButtonSearch;
        private System.Windows.Forms.ToolStripTextBox ButtonBookName;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn 图书序列号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 书名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作者;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出版社;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出版日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn 价格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 库存数量;
        private System.Windows.Forms.ToolStripButton ButtonImage;
        private System.Windows.Forms.ToolStripButton ButtonInfo;
        private System.Windows.Forms.ToolStripButton ButtonDelete;
    }
}