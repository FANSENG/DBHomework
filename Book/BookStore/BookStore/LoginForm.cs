using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
             // 获取账号
             string Id = TextBoxID.Text.Trim();
             // 获取密码
             string Pwd = TextBoxPsw.Text.Trim();

             if (Id == "" || Pwd == "")
             {
                 MessageBox.Show("请输入账号或密码","Error",MessageBoxButtons.OK);
             }
             else 
             {
                 string str = System.Configuration.ConfigurationManager.ConnectionStrings["library"].ConnectionString;
                 // 构造sql查询语句
                 string sql;
                 sql = "select aName from admin where aId='" + Id + "' and aPwd='" + Pwd + "'";
                // 构造连接对象
                try
                {
                    SqlConnection conn = new SqlConnection(str);
                     SqlCommand cmd = new SqlCommand(sql, conn);
                     // 打开数据库连接
                     conn.Open();                                          
                     // 执行查询语句,返回结果集第一行第一列
                     string name = "";

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        name = reader.GetString(reader.GetOrdinal("aName"));
                    }
                    reader.Close();
                    if (name != "")
                    {
                        // 登录窗体隐藏
                        this.Hide();
                        // 创建主窗体
                        MainForm mainForm = new MainForm();
                        // 将账号传给主窗体MainForm
                        mainForm.Id = Id;
                        // 用主窗体MainForm下的_Tag标记登陆的是用户还是管理员
                        mainForm._Tag = "admin";
                        mainForm.Name1 = name;
                        // 显示主窗体
                        mainForm.ShowDialog();                         
                    }
                    else 
                    {
                        MessageBox.Show("账号或密码错误！","登录失败");
                    }
                    conn.Close();
                }
                catch(Exception ee)
                {
                    MessageBox.Show("数据库连接错误：" + ee.Message.ToString());
                }
             }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
