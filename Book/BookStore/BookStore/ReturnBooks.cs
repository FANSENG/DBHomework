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
    public partial class ReturnBooks : Form
    {
        public ReturnBooks()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 搜索租借记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (ButtonSearch.Text.Trim() == "")
            {
                MessageBox.Show("账号不能为空");
            }
            else
            {
                ShowBorrowList();
            }
        }

        public void LoadData()
        {
            string sql = "select ID,uId,bName,bNum,bPrice,borrowDate,returnDate,Tag from borrow";
            MyDictionary dic = new MyDictionary();
            dic.Add("@uId", TextBoxUserID.Text.Trim());
            DataTable dt = SqlHelper.GetList(sql, dic);
            dataGridView.DataSource = dt;
        }

        /// <summary>
        /// 显示租借清单
        /// </summary>
        private void ShowBorrowList()
        {
            string sql = "select ID,uId,bName,bNum,bPrice,borrowDate,returnDate,Tag from borrow where uId =@uId";
            MyDictionary dic = new MyDictionary();
            dic.Add("@uId", TextBoxUserID.Text.Trim());
            DataTable dt = SqlHelper.GetList(sql, dic);
            dataGridView.DataSource = dt;
        }

        /// <summary>
        /// 同步数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            // 开关文本框的锁定，将表格内的数据显示到文本框内
            int a = dataGridView.CurrentRow.Index;
            TextBoxBorrowID.ReadOnly = false;
            TextBoxBookName.ReadOnly = false;
            TextBoxPrice.ReadOnly = false;
            TextBoxBookNum.ReadOnly = false;
            TextBoxUserID2.ReadOnly = false;
            TextBoxTag.ReadOnly = false;
            TextBoxBorrowDate.ReadOnly = false;
            TextBoxReturnDate.ReadOnly = false;
            TextBoxBorrowID.Text = dataGridView.Rows[a].Cells["ID"].Value.ToString();
            TextBoxBookName.Text = dataGridView.Rows[a].Cells["bName"].Value.ToString();
            TextBoxPrice.Text = dataGridView.Rows[a].Cells["bPrice"].Value.ToString();
            TextBoxBookNum.Text = dataGridView.Rows[a].Cells["bNum"].Value.ToString();
            TextBoxUserID2.Text = dataGridView.Rows[a].Cells["uId"].Value.ToString();
            TextBoxTag.Text = (dataGridView.Rows[a].Cells["Tag"].Value.ToString().Equals("1")) ? "是" : "否";
            TextBoxBorrowDate.Text = dataGridView.Rows[a].Cells["borrowDate"].Value.ToString();
            TextBoxReturnDate.Text = dataGridView.Rows[a].Cells["returnDate"].Value.ToString();
            TextBoxBorrowID.ReadOnly = true;
            TextBoxBookName.ReadOnly = true;
            TextBoxPrice.ReadOnly = true;
            TextBoxBookNum.ReadOnly = true;
            TextBoxUserID2.ReadOnly = true;
            TextBoxTag.ReadOnly = true;
            TextBoxBorrowDate.ReadOnly = true;
            TextBoxReturnDate.ReadOnly = true;
        }

        /// <summary>
        /// 处理逾期未还书的用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnBooks_Load(object sender, EventArgs e)
        {
            LoadData();
            // 文本框锁定
            TextBoxBorrowID.ReadOnly = true;
            TextBoxBookName.ReadOnly = true;
            TextBoxPrice.ReadOnly = true;
            TextBoxBookNum.ReadOnly = true;
            TextBoxUserID2.ReadOnly = true;
            TextBoxTag.ReadOnly = true;
            TextBoxBorrowDate.ReadOnly = true;
            TextBoxReturnDate.ReadOnly = true;
            string sql = "Date_Test";
            MyDictionary dic = new MyDictionary();
            SqlHelper.ExecuteNonQuery(sql, CommandType.StoredProcedure, dic);
        }

        /// <summary>
        /// 归还书籍
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string sql="select uBan from users where uId=@uID";
            MyDictionary dic3 = new MyDictionary();
            dic3.Add("@uID", TextBoxUserID2.Text.Trim());
            if (SqlHelper.ExecuteScalar(sql, dic3).ToString() == "1")
            {
                MessageBox.Show("因逾期未还书账户被锁定，请及时解锁，并缴纳罚款");
                return;
            }
            else 
            {
                // 办理借书手续
                // 删除借书记录 
                sql = "delete from borrow where ID=@ID";
                MyDictionary dic4 = new MyDictionary();
                dic4.Add("@ID", TextBoxBorrowID.Text.Trim());
                SqlHelper.ExecuteNonQuery(sql, dic4);

                // 得到书籍库存量 并+1
                sql = "select bTag from books where bNum=@bNum";
                MyDictionary dic5 = new MyDictionary();
                dic5.Add("@bNum", TextBoxBookNum.Text.Trim());
                int n = Convert.ToInt32(SqlHelper.ExecuteScalar(sql, dic5)) + 1;

                sql = "update books set bTag=@bTag where bNum=@bNum";
                MyDictionary dic6 = new MyDictionary();
                dic6.Add("@bTag", n.ToString());
                dic6.Add("@bNum", TextBoxBookNum.Text.Trim());
                SqlHelper.ExecuteNonQuery(sql, dic6);

                MessageBox.Show("还书提交完成");

                // 刷新借书单
                ShowBorrowList();

            }
        }
    }
}
