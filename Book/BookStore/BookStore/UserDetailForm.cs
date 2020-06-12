using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace LibraryManager
{
    public partial class UserDetailForm : Form
    {
        private SqlDataAdapter adapter = null;
        private DataSet dSet = null;
        private string _id = "";
        private bool changed = false;

        public UserDetailForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 获取数据到表格
        /// </summary>
        /// <param name="sql"></param>
        private void GetData(string sql)
        {
            string str = System.Configuration.ConfigurationManager.ConnectionStrings["library"].ConnectionString;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(str);
                conn.Open();
                adapter = new SqlDataAdapter(sql, conn);
                dSet = new DataSet();
                adapter.Fill(dSet);

                dataGridView.DataSource = dSet.Tables[0];
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
            finally
            {
                if(conn != null)
                {
                    conn.Close();
                }
            }
        }

        /// <summary>
        /// 加载初始数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserDetailForm_Load(object sender, EventArgs e)
        {
            string sql = "select uId, uName, uGender, uPhoNum, uBlance from users";
            GetData(sql);
        }

        /// <summary>
        /// 保存修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (changed)
            {
                //创建命令重建对象
                SqlCommandBuilder scb = new SqlCommandBuilder(adapter);

                //更新数据
                try
                {
                    //这里是关键
                    adapter.Update(dSet);
                    MessageBox.Show("保存成功！");
                    changed = false;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            string sql = "select uId, uName, uGender, uPhoNum, uBlance from users";
            GetData(sql);
        }

        /// <summary>
        /// 搜索用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (TextBoxUserID.Text.Trim().Equals(""))
            {
                MessageBox.Show("请输入账号！","警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                string sql = "select uId, uName, uGender, uPhoNum from users where uId = '"
                + TextBoxUserID.Text.Trim() + "'";
                GetData(sql);
            }
        }

        /// <summary>
        /// 重置密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonResetPsw_Click(object sender, EventArgs e)
        {
            if (_id.Equals(""))
            {
                MessageBox.Show("请选择账户！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("是否重置账号为" + _id + "的用户密码？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string str = System.Configuration.ConfigurationManager.ConnectionStrings["library"].ConnectionString;
                    SqlConnection conn = null;
                    string sql = "update users set uPwd = '000000' where uId = '" + _id + "'";
                    try
                    {
                        conn = new SqlConnection(str);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        int i = cmd.ExecuteNonQuery();
                        if (i == 1)
                        {
                            MessageBox.Show("密码重置成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            throw new MyException { MyInfo = "密码重置失败！" };
                        }
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message.ToString());
                    }
                    finally
                    {
                        if (conn != null)
                        {
                            conn.Close();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 同步数据到TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            int a = dataGridView.CurrentRow.Index;
            _id = dataGridView.Rows[a].Cells["uId"].Value.ToString();
        }

        /// <summary>
        /// 记录修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            changed = true;
        }

        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserDetailForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changed == true)
            {
                // 如果表格数据被改变过
                DialogResult result = MessageBox.Show("确定不保存更改？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    changed = false;
                    this.Close();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// 充值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRecharge_Click(object sender, EventArgs e)
        {
            string select = dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[0].Value.ToString();
            String str = Interaction.InputBox("输入充值金额（整数）：", "充值", "", 50, 50);
            if (str != "")
            {
                try
                {
                    int money = Convert.ToInt32(str);
                    string sql = "update users set uBlance = uBlance + " + money + " where uId = '" + select + "'";
                    string con = System.Configuration.ConfigurationManager.ConnectionStrings["library"].ConnectionString;
                    SqlConnection conn = null;
                    try
                    {
                        conn = new SqlConnection(con);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        int i = cmd.ExecuteNonQuery();
                        if (i == 1)
                        {
                            MessageBox.Show("充值成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            throw new MyException { MyInfo = "充值失败！" };
                        }
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message.ToString());
                    }
                    finally
                    {
                        if (conn != null)
                        {
                            conn.Close();
                        }
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show("输入金额有误");
                }
            }
        }

    }
}
