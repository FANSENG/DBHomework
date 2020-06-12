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
    public partial class Sell : Form
    {
        public Sell()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 搜索书籍
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (TextBoxBookName.Text.Trim() == "")
            {
                MessageBox.Show("书名不能为空");
            }
            else
            {
                string sql = "select bNum,bName,bAuthor,bPubCom,bPrice,bTag from booksWithbookindex where bName like '%'+ @bName +'%'";
                MyDictionary dic = new MyDictionary();
                dic.Add("@bName", TextBoxBookName.Text.Trim());
                DataTable dt = SqlHelper.GetList(sql, dic);
                dataGridView.DataSource = dt;
            }
        }

        /// <summary>
        /// 购买书籍
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPurchase_Click(object sender, EventArgs e)
        {
            // 是否存在该用户
            if (TextBoxUserID.Text.Trim() == "")
            {
                MessageBox.Show("请填写用户名！", "警告");
                return;
            }
            else if (TextBoxBookNUm.Text.Trim() == "" || TextBoxBookName2.Text.Trim() == "" || TextBoxBookPrice.Text.Trim() == "")
            {
                MessageBox.Show("请选择书籍！", "警告");
            }
            else if (!SqlHelper.IsUserExists(TextBoxUserID.Text.Trim()))
            {
                MessageBox.Show("不存在该用户！", "警告");
                return;
            }
            else
            {
                // 自动获得图书序列号
                string sql = " select MAX(sId) from sell";
                string ID = (int.Parse(SqlHelper.ExecuteScalar(sql).ToString()) + 1).ToString();
                StringBuilder sb = new StringBuilder(ID);
                while (sb.Length != 8)
                {
                    sb.Insert(0, "0");
                }
                ID = sb.ToString();

                // 查询账户是否锁定
                sql = "select uBan from users where uId=@uId";
                MyDictionary dic1 = new MyDictionary();
                dic1.Add("@uId", TextBoxUserID.Text.Trim());
                string tag = SqlHelper.ExecuteScalar(sql, dic1).ToString();
                if (tag.Equals("1"))
                {
                    MessageBox.Show("该账户已被锁定！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 查询书籍库存量
                sql = "select bTag from books where bNum=@bNum";
                MyDictionary dic3 = new MyDictionary();
                dic3.Add("@bNum", TextBoxBookNUm.Text.Trim());
                string n = SqlHelper.ExecuteScalar(sql, dic3).ToString();
                if (n.Equals("0"))
                {
                    MessageBox.Show("该书籍库存量为零！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 获取书籍价格
                sql = "select bPrice from books where bNum=@bNum";
                MyDictionary dic11 = new MyDictionary();
                dic11.Add("@bNum", TextBoxBookNUm.Text.Trim());
                int price = Convert.ToInt32(SqlHelper.ExecuteScalar(sql, dic11).ToString());


                // 查看余额
                sql = "select uBlance from users where uId=@uId";
                MyDictionary dic4 = new MyDictionary();
                dic4.Add("@uId", TextBoxUserID.Text.Trim());
                double money = Convert.ToDouble(SqlHelper.ExecuteScalar(sql, dic4).ToString());
                if (money < price)
                {
                    MessageBox.Show("账户余额不足", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (money < 30)
                {
                    MessageBox.Show("账户余额不足十元，请及时充值", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // 减少余额
                sql = "update users set uBlance = uBlance -" + price + " where uId=@uId";
                MyDictionary dic5 = new MyDictionary();
                dic5.Add("@uId", TextBoxUserID.Text.Trim());
                SqlHelper.ExecuteScalar(sql, dic5);

                // 插入数据到购书表（borrow）
                sql = "insert into sell values(@ID,@uId,@bNum,@bPrice,GETDATE())";
                MyDictionary dic = new MyDictionary();
                dic.Add("@ID", ID);
                dic.Add("@uId", TextBoxUserID.Text.Trim());
                dic.Add("@bNum", TextBoxBookNUm.Text.Trim());
                dic.Add("@bPrice", TextBoxBookPrice.Text.Trim());
                int i = SqlHelper.ExecuteNonQuery(sql, dic);
                if (i > 0)
                {
                    n = (Convert.ToInt32(n) - 1).ToString(); // 库存量-1
                    sql = "update books set bTag=@bTag where bNum=@bNum";
                    MyDictionary dic2 = new MyDictionary();
                    dic2.Add("@bTag", n);
                    dic2.Add("@bNum", TextBoxBookNUm.Text.Trim());
                    SqlHelper.ExecuteScalar(sql, dic2);
                    MessageBox.Show("提交成功");
                }
            }
        }
        
        /// <summary>
        /// 同步数据到文本框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            // 开关文本框的锁定，将表格内的数据显示到文本框内
            int a = dataGridView.CurrentRow.Index;
            TextBoxBookNUm.ReadOnly = false;
            TextBoxBookName2.ReadOnly = false;
            TextBoxBookPrice.ReadOnly = false;
            TextBoxBookNUm.Text = dataGridView.Rows[a].Cells["bNum"].Value.ToString();
            TextBoxBookName2.Text = dataGridView.Rows[a].Cells["bbName"].Value.ToString();
            TextBoxBookPrice.Text = dataGridView.Rows[a].Cells["bPrice"].Value.ToString();
            TextBoxBookNUm.ReadOnly = true;
            TextBoxBookName2.ReadOnly = true;
            TextBoxBookPrice.ReadOnly = true;
        }

    }
}
