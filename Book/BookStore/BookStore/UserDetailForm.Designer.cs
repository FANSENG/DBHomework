namespace LibraryManager
{
    partial class UserDetailForm
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
            this.uId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uPhoNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uBlance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.TextBoxUserID = new System.Windows.Forms.TextBox();
            this.ButtonResetPsw = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.ButtonRecharge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uId,
            this.uName,
            this.uGender,
            this.uPhoNum,
            this.uBlance});
            this.dataGridView.Location = new System.Drawing.Point(31, 150);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 27;
            this.dataGridView.Size = new System.Drawing.Size(598, 389);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            this.dataGridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseUp);
            // 
            // uId
            // 
            this.uId.DataPropertyName = "uId";
            this.uId.HeaderText = "账号";
            this.uId.MinimumWidth = 6;
            this.uId.Name = "uId";
            this.uId.ReadOnly = true;
            this.uId.Width = 110;
            // 
            // uName
            // 
            this.uName.DataPropertyName = "uName";
            this.uName.HeaderText = "姓名";
            this.uName.MinimumWidth = 6;
            this.uName.Name = "uName";
            this.uName.Width = 110;
            // 
            // uGender
            // 
            this.uGender.DataPropertyName = "uGender";
            this.uGender.HeaderText = "性别";
            this.uGender.MinimumWidth = 6;
            this.uGender.Name = "uGender";
            this.uGender.Width = 95;
            // 
            // uPhoNum
            // 
            this.uPhoNum.DataPropertyName = "uPhoNum";
            this.uPhoNum.HeaderText = "联系电话";
            this.uPhoNum.MinimumWidth = 6;
            this.uPhoNum.Name = "uPhoNum";
            this.uPhoNum.Width = 110;
            // 
            // uBlance
            // 
            this.uBlance.DataPropertyName = "uBlance";
            this.uBlance.HeaderText = "余额";
            this.uBlance.MinimumWidth = 6;
            this.uBlance.Name = "uBlance";
            this.uBlance.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(49, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "按账号搜索用户：";
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(494, 21);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(90, 34);
            this.ButtonSearch.TabIndex = 2;
            this.ButtonSearch.Text = "搜索";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // TextBoxUserID
            // 
            this.TextBoxUserID.Location = new System.Drawing.Point(236, 28);
            this.TextBoxUserID.Name = "TextBoxUserID";
            this.TextBoxUserID.Size = new System.Drawing.Size(235, 25);
            this.TextBoxUserID.TabIndex = 3;
            // 
            // ButtonResetPsw
            // 
            this.ButtonResetPsw.Location = new System.Drawing.Point(249, 82);
            this.ButtonResetPsw.Name = "ButtonResetPsw";
            this.ButtonResetPsw.Size = new System.Drawing.Size(90, 34);
            this.ButtonResetPsw.TabIndex = 4;
            this.ButtonResetPsw.Text = "重置密码";
            this.ButtonResetPsw.UseVisualStyleBackColor = true;
            this.ButtonResetPsw.Click += new System.EventHandler(this.ButtonResetPsw_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(119, 82);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(90, 34);
            this.ButtonSave.TabIndex = 5;
            this.ButtonSave.Text = "保存修改";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Location = new System.Drawing.Point(371, 82);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(90, 34);
            this.ButtonRefresh.TabIndex = 6;
            this.ButtonRefresh.Text = "刷新";
            this.ButtonRefresh.UseVisualStyleBackColor = true;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // ButtonRecharge
            // 
            this.ButtonRecharge.Location = new System.Drawing.Point(494, 82);
            this.ButtonRecharge.Name = "ButtonRecharge";
            this.ButtonRecharge.Size = new System.Drawing.Size(90, 34);
            this.ButtonRecharge.TabIndex = 7;
            this.ButtonRecharge.Text = "充值";
            this.ButtonRecharge.UseVisualStyleBackColor = true;
            this.ButtonRecharge.Click += new System.EventHandler(this.ButtonRecharge_Click);
            // 
            // UserDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 551);
            this.Controls.Add(this.ButtonRecharge);
            this.Controls.Add(this.ButtonRefresh);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonResetPsw);
            this.Controls.Add(this.TextBoxUserID);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserDetailForm";
            this.ShowIcon = false;
            this.Text = "用户信息";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserDetailForm_FormClosing);
            this.Load += new System.EventHandler(this.UserDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.TextBox TextBoxUserID;
        private System.Windows.Forms.Button ButtonResetPsw;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonRefresh;
        private System.Windows.Forms.Button ButtonRecharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn uId;
        private System.Windows.Forms.DataGridViewTextBoxColumn uName;
        private System.Windows.Forms.DataGridViewTextBoxColumn uGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn uPhoNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn uBlance;
    }
}