using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class DeleteUserForm : Form
    {
        public DeleteUserForm()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            string sql = "select uId, uName, uGender, uPhoNum, uBlance from users";
            MyDictionary dic = new MyDictionary();
            DataTable dt = SqlHelper.GetList(sql, dic);
            dataGridView.DataSource = dt;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string sql = "select uId, uName, uGender, uPhoNum, uBlance from users where uId like '%"+TextBoxUserID.Text+"%'";
            MyDictionary dic = new MyDictionary();
            DataTable dt = SqlHelper.GetList(sql, dic);
            dataGridView.DataSource = dt;
        }

        private void ButtonSearchAll_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int a = dataGridView.CurrentRow.Index;
            string blance = dataGridView.Rows[a].Cells["Blance"].Value.ToString();
            string userID = dataGridView.Rows[a].Cells["uId"].Value.ToString();
            // 查看余额是否为0
            if (Convert.ToDouble(blance) != 0.0)
            {
                DialogResult result = MessageBox.Show("用户余额不为0，确认删除？", "警告", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            // 查看是否有租借中图书
            if (SqlHelper.IsUserBorrowExists(userID))
            {
                MessageBox.Show("此用户存在租借图书，不可删除用户!","Error",MessageBoxButtons.OK);
                return;
            }
            // 删除
            SqlHelper.DeleteUser(userID);
            LoadData();
        }

        private void 删除用户_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
