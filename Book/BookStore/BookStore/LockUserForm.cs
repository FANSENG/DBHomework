using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class LockUserForm : Form
    {
        private String _id = "";
        public LockUserForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载初始界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LockUserForm_Load(object sender, EventArgs e)
        {
            string sql = "select uId,uName,uGender,uPhoNum,uBan from users where uBan = '1'";
            MyDictionary dic = new MyDictionary();
            DataTable dt = SqlHelper.GetList(sql, dic);
            dataGridView.DataSource = dt;
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                dataGridView.Rows[i].Cells["uBan"].Value = "是";
            }
        }

        /// <summary>
        /// 搜索被锁用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string sql = "select uId,uName,uGender,uPhoNum,uBan from users where uBan = '1' and uId = @uId";
            MyDictionary dic = new MyDictionary();
            dic.Add("@uId", IdTextBox.Text.Trim());
            DataTable dt = SqlHelper.GetList(sql, dic);
            dataGridView.DataSource = dt;
        }

        /// <summary>
        /// 刷新界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            string sql = "select uId,uName,uGender,uPhoNum,uBan from users where uBan = '1'";
            MyDictionary dic = new MyDictionary();
            DataTable dt = SqlHelper.GetList(sql, dic);
            dataGridView.DataSource = dt;
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                dataGridView.Rows[i].Cells["uBan"].Value = "是";
            }
        }

        /// <summary>
        /// 解锁选中用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUnlock_Click(object sender, EventArgs e)
        {
            if (_id.Equals(""))
            {
                MessageBox.Show("请选择需解锁用户！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("确定解锁用户" + _id + "吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sql = "select uBlance from users where uId=@uId";
                    MyDictionary dic4 = new MyDictionary();
                    dic4.Add("@uId", _id);
                    double money = Convert.ToDouble(SqlHelper.ExecuteScalar(sql, dic4).ToString());
                    if (money < 5)
                    {
                        MessageBox.Show("账户余额不足", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // 减少余额
                    sql = "update users set uBlance = uBlance -5 where uId=@uId";
                    MyDictionary dic5 = new MyDictionary();
                    dic5.Add("@uId", _id);
                    SqlHelper.ExecuteScalar(sql, dic5);

                    sql = "update users set uBan = '0' where uId = '" + _id + "'";
                    string str = System.Configuration.ConfigurationManager.ConnectionStrings["library"].ConnectionString;
                    SqlConnection conn = null;
                    try
                    {
                        conn = new SqlConnection(str);
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        // 打开数据库连接
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("已解锁用户" + _id);
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message.ToString());
                    }
                    finally
                    {
                        if (conn != null)
                        {
                            //关闭数据库连接
                            conn.Close();
                        }
                    }
                    sql = "select uId,uName,uGender,uPhoNum,uBan from users where uBan = '1'";
                    MyDictionary dic = new MyDictionary();
                    DataTable dt = SqlHelper.GetList(sql, dic);
                    dataGridView.DataSource = dt;
                    for (int i = 0; i < dataGridView.RowCount; i++)
                    {
                        dataGridView.Rows[i].Cells["uBan"].Value = "是";
                    }
                }
                else { return; }
            }
        }

        /// <summary>
        /// 同步信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = dataGridView.CurrentRow.Index;
            _id = dataGridView.Rows[a].Cells["uId"].Value.ToString();
        }
    }
}
