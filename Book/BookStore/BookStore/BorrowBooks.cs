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
    public partial class BorrowBooks : Form
    {
        public BorrowBooks()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 搜索书籍并加载到dataGridView中
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
        /// 提交借书操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            // 检查用户存在
            if (TextBoxUserID.Text.Trim() == ""|| comboBoxBorrowDuration.Text.ToString().Trim() == "")
            {
                MessageBox.Show("请填写用户名和借阅时间！", "警告");
                return;
            }
            else if (TextBoxBookNum.Text.Trim() == "" || TextBoxBookName2.Text.Trim() == "" || TextBoxBookPrice.Text.Trim() == "")
            {
                MessageBox.Show("请选择书籍！","警告");
            }
            else if (!SqlHelper.IsUserExists(TextBoxUserID.Text.Trim()))
            {
                MessageBox.Show("不存在该用户！", "警告");
                return;
            }
            else
            {
                // 自动获得图书序列号
                string sql = " select MAX(ID) from borrow";
                string ID = (int.Parse(SqlHelper.ExecuteScalar(sql).ToString()) + 1).ToString();
                StringBuilder sb = new StringBuilder(ID);
                while (sb.Length != 6)
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
                    MessageBox.Show("该账户已被锁定！","警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return ;
                }

                // 查询书籍库存量
                sql = "select bTag from books where bNum=@bNum";
                MyDictionary dic3 = new MyDictionary();
                dic3.Add("@bNum", TextBoxBookNum.Text.Trim());
                string n = SqlHelper.ExecuteScalar(sql, dic3).ToString();
                if (n.Equals("0"))
                {
                    MessageBox.Show("该书籍库存量为零！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                sql = "select uBlance from users where uId=@uId";
                MyDictionary dic4 = new MyDictionary();
                dic4.Add("@uId", TextBoxUserID.Text.Trim());
                double money = Convert.ToDouble(SqlHelper.ExecuteScalar(sql, dic4).ToString());
                int len = Convert.ToInt32(comboBoxBorrowDuration.Text.ToString().Substring(0, 2));
                if (money<len/10)
                {
                    MessageBox.Show("账户余额不足", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }else if (money < 30)
                {
                    MessageBox.Show("账户余额不足十元，请及时充值", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // 减少余额
                sql = "update users set uBlance = uBlance -"+ (len/10) +" where uId=@uId";
                MyDictionary dic5 = new MyDictionary();
                dic5.Add("@uId", TextBoxUserID.Text.Trim());
                SqlHelper.ExecuteScalar(sql, dic5);

                // 插入数据到借书表（borrow）
                sql = "insert into borrow values(@ID,@uId,@bName,@bNum,@bPrice,convert(varchar(20),GETDATE() ,111),convert(varchar(20),dateadd(day," + comboBoxBorrowDuration.Text.ToString().Substring(0, 2) + ",CONVERT(varchar(20),GETDATE() ,111)),111),@Tag)";
                MyDictionary dic = new MyDictionary();
                dic.Add("@ID", ID);
                dic.Add("@uId", TextBoxUserID.Text.Trim());
                dic.Add("@bName", TextBoxBookName2.Text.Trim());
                dic.Add("@bNum", TextBoxBookNum.Text.Trim());
                dic.Add("@bPrice", TextBoxBookPrice.Text.Trim());
                dic.Add("@Tag", "0");// Tag = 0 标记该书未超归还期限 
                int i = SqlHelper.ExecuteNonQuery(sql, dic);
                if (i > 0)
                {
                   n = (Convert.ToInt32(n) - 1).ToString(); // 库存量-1
                    sql = "update books set bTag=@bTag where bNum=@bNum";
                    MyDictionary dic2 = new MyDictionary();
                    dic2.Add("@bTag", n);
                    dic2.Add("@bNum", TextBoxBookNum.Text.Trim());
                    SqlHelper.ExecuteScalar(sql, dic2);
                    MessageBox.Show("提交成功");
                }
            }
        }
        
        /// <summary>
        /// 鼠标松开左右键时加载选中数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            // 开关文本框的锁定，将表格内的数据显示到文本框内
            int a = dataGridView.CurrentRow.Index;
            TextBoxBookNum.ReadOnly = false;
            TextBoxBookName2.ReadOnly = false;
            TextBoxBookPrice.ReadOnly = false;
            TextBoxBookNum.Text = dataGridView.Rows[a].Cells["bNum"].Value.ToString();
            TextBoxBookName2.Text = dataGridView.Rows[a].Cells["bbName"].Value.ToString();
            TextBoxBookPrice.Text = dataGridView.Rows[a].Cells["bPrice"].Value.ToString();
            TextBoxBookNum.ReadOnly = true;
            TextBoxBookName2.ReadOnly = true;
            TextBoxBookPrice.ReadOnly = true;
        }

    }
}
