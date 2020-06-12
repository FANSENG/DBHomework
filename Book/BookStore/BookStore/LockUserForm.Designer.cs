namespace LibraryManager
{
    partial class LockUserForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.uID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uPhoNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonUnlock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.ButtonSearchUser = new System.Windows.Forms.Button();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uID,
            this.uName,
            this.uGender,
            this.uPhoNum,
            this.uBan});
            this.dataGridView.Location = new System.Drawing.Point(12, 83);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 27;
            this.dataGridView.Size = new System.Drawing.Size(724, 255);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // uID
            // 
            this.uID.DataPropertyName = "uId";
            this.uID.HeaderText = "ID";
            this.uID.MinimumWidth = 6;
            this.uID.Name = "uID";
            this.uID.ReadOnly = true;
            this.uID.Width = 125;
            // 
            // uName
            // 
            this.uName.DataPropertyName = "uName";
            this.uName.HeaderText = "姓名";
            this.uName.MinimumWidth = 6;
            this.uName.Name = "uName";
            this.uName.ReadOnly = true;
            this.uName.Width = 125;
            // 
            // uGender
            // 
            this.uGender.DataPropertyName = "uGender";
            this.uGender.HeaderText = "性别";
            this.uGender.MinimumWidth = 6;
            this.uGender.Name = "uGender";
            this.uGender.ReadOnly = true;
            this.uGender.Width = 125;
            // 
            // uPhoNum
            // 
            this.uPhoNum.DataPropertyName = "uPhoNum";
            this.uPhoNum.HeaderText = "联系电话";
            this.uPhoNum.MinimumWidth = 6;
            this.uPhoNum.Name = "uPhoNum";
            this.uPhoNum.ReadOnly = true;
            this.uPhoNum.Width = 125;
            // 
            // uBan
            // 
            this.uBan.DataPropertyName = "uBan";
            this.uBan.HeaderText = "是否锁定";
            this.uBan.MinimumWidth = 6;
            this.uBan.Name = "uBan";
            this.uBan.ReadOnly = true;
            this.uBan.Width = 125;
            // 
            // ButtonUnlock
            // 
            this.ButtonUnlock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonUnlock.Location = new System.Drawing.Point(297, 360);
            this.ButtonUnlock.Name = "ButtonUnlock";
            this.ButtonUnlock.Size = new System.Drawing.Size(153, 49);
            this.ButtonUnlock.TabIndex = 1;
            this.ButtonUnlock.Text = "解锁";
            this.ButtonUnlock.UseVisualStyleBackColor = true;
            this.ButtonUnlock.Click += new System.EventHandler(this.ButtonUnlock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "账号：";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(182, 26);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(244, 25);
            this.IdTextBox.TabIndex = 3;
            // 
            // ButtonSearchUser
            // 
            this.ButtonSearchUser.Location = new System.Drawing.Point(462, 16);
            this.ButtonSearchUser.Name = "ButtonSearchUser";
            this.ButtonSearchUser.Size = new System.Drawing.Size(100, 40);
            this.ButtonSearchUser.TabIndex = 4;
            this.ButtonSearchUser.Text = "搜索";
            this.ButtonSearchUser.UseVisualStyleBackColor = true;
            this.ButtonSearchUser.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Location = new System.Drawing.Point(596, 16);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(100, 40);
            this.ButtonRefresh.TabIndex = 5;
            this.ButtonRefresh.Text = "刷新";
            this.ButtonRefresh.UseVisualStyleBackColor = true;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // LockUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 439);
            this.Controls.Add(this.ButtonRefresh);
            this.Controls.Add(this.ButtonSearchUser);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonUnlock);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LockUserForm";
            this.ShowIcon = false;
            this.Text = "锁定用户管理";
            this.Load += new System.EventHandler(this.LockUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button ButtonUnlock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Button ButtonSearchUser;
        private System.Windows.Forms.Button ButtonRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn uID;
        private System.Windows.Forms.DataGridViewTextBoxColumn uName;
        private System.Windows.Forms.DataGridViewTextBoxColumn uGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn uPhoNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn uBan;
    }
}