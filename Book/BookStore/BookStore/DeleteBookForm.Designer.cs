namespace LibraryManager
{
    partial class DeleteBookForm
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.ButtonSearchAll = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxBookName = new System.Windows.Forms.TextBox();
            this.bNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(532, 5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(86, 32);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "删除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // ButtonSearchAll
            // 
            this.ButtonSearchAll.Location = new System.Drawing.Point(412, 5);
            this.ButtonSearchAll.Name = "ButtonSearchAll";
            this.ButtonSearchAll.Size = new System.Drawing.Size(114, 32);
            this.ButtonSearchAll.TabIndex = 18;
            this.ButtonSearchAll.Text = "显示所有";
            this.ButtonSearchAll.UseVisualStyleBackColor = true;
            this.ButtonSearchAll.Click += new System.EventHandler(this.ButtonSearchAll_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bNum,
            this.bName,
            this.bAuthor,
            this.ISBN,
            this.bPrice});
            this.dataGridView.Location = new System.Drawing.Point(1, 49);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 27;
            this.dataGridView.Size = new System.Drawing.Size(682, 443);
            this.dataGridView.TabIndex = 17;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(332, 5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(74, 32);
            this.buttonSearch.TabIndex = 16;
            this.buttonSearch.Text = "查找";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "书名：";
            // 
            // TextBoxBookName
            // 
            this.TextBoxBookName.Location = new System.Drawing.Point(87, 5);
            this.TextBoxBookName.Name = "TextBoxBookName";
            this.TextBoxBookName.Size = new System.Drawing.Size(239, 25);
            this.TextBoxBookName.TabIndex = 14;
            // 
            // bNum
            // 
            this.bNum.DataPropertyName = "bNum";
            this.bNum.HeaderText = "书号";
            this.bNum.MinimumWidth = 6;
            this.bNum.Name = "bNum";
            this.bNum.ReadOnly = true;
            this.bNum.Width = 125;
            // 
            // bName
            // 
            this.bName.DataPropertyName = "bName";
            this.bName.HeaderText = "书名";
            this.bName.MinimumWidth = 6;
            this.bName.Name = "bName";
            this.bName.ReadOnly = true;
            this.bName.Width = 125;
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
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.MinimumWidth = 6;
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            this.ISBN.Width = 125;
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
            // DeleteBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 496);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.ButtonSearchAll);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxBookName);
            this.Name = "DeleteBookForm";
            this.Text = "DeleteBookForm";
            this.Load += new System.EventHandler(this.DeleteBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button ButtonSearchAll;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn bName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPrice;
    }
}