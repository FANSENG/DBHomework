namespace LibraryManager
{
    partial class DeleteUserForm
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
            this.ButtonSearchAll = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxUserID = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.uId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phonenum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Blance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSearchAll
            // 
            this.ButtonSearchAll.Location = new System.Drawing.Point(412, 24);
            this.ButtonSearchAll.Name = "ButtonSearchAll";
            this.ButtonSearchAll.Size = new System.Drawing.Size(114, 32);
            this.ButtonSearchAll.TabIndex = 12;
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
            this.uId,
            this.UserName,
            this.userGender,
            this.Phonenum,
            this.Blance});
            this.dataGridView.Location = new System.Drawing.Point(1, 68);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 27;
            this.dataGridView.Size = new System.Drawing.Size(682, 443);
            this.dataGridView.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "账号：";
            // 
            // TextBoxUserID
            // 
            this.TextBoxUserID.Location = new System.Drawing.Point(87, 24);
            this.TextBoxUserID.Name = "TextBoxUserID";
            this.TextBoxUserID.Size = new System.Drawing.Size(239, 25);
            this.TextBoxUserID.TabIndex = 8;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(332, 24);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(74, 32);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "查找";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(532, 24);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(86, 32);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "删除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
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
            // userGender
            // 
            this.userGender.DataPropertyName = "uGender";
            this.userGender.HeaderText = "性别";
            this.userGender.MinimumWidth = 6;
            this.userGender.Name = "userGender";
            this.userGender.ReadOnly = true;
            this.userGender.Width = 125;
            // 
            // Phonenum
            // 
            this.Phonenum.DataPropertyName = "uPhoNum";
            this.Phonenum.HeaderText = "手机号码";
            this.Phonenum.MinimumWidth = 6;
            this.Phonenum.Name = "Phonenum";
            this.Phonenum.ReadOnly = true;
            this.Phonenum.Width = 125;
            // 
            // Blance
            // 
            this.Blance.DataPropertyName = "uBlance";
            this.Blance.HeaderText = "余额";
            this.Blance.MinimumWidth = 6;
            this.Blance.Name = "Blance";
            this.Blance.ReadOnly = true;
            this.Blance.Width = 125;
            // 
            // DeleteUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 511);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.ButtonSearchAll);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxUserID);
            this.Name = "DeleteUserForm";
            this.Text = "删除用户";
            this.Load += new System.EventHandler(this.删除用户_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSearchAll;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxUserID;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn uId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phonenum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Blance;
    }
}