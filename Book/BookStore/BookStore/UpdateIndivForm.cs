using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace LibraryManager
{
    public partial class UpdateIndivForm : Form
    {
        public UpdateIndivForm()
        {
            InitializeComponent();
        }
        private string _id;
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _tag;
        public string _Tag
        {
            get { return _tag; }
            set { _tag = value; }
        }
        // 决定显示的面板
        private string _p;
        public string P
        {
            get { return _p; }
            set { _p = value; }
        }

        /// <summary>
        /// 加载个人信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateIndivForm_Load(object sender, EventArgs e)
        {
            if (P == "1")       // p == "1"  为注册新用户功能
            {
                AddUserpanel.Visible = true;
                DeleteUserpanel.Visible = false;
            }
            else if (P == "2")  // p == "2"  为删除用户功能
            {
                DeleteUserpanel.Visible = true;
                AddUserpanel.Visible = false;
            }
            else                //          为修改个人信息
            {
                IdtextBox.ReadOnly = true;
                AddUserpanel.Visible = false;
                DeleteUserpanel.Visible = false ;
                string str = System.Configuration.ConfigurationManager.ConnectionStrings["library"].ConnectionString;
                string sql;
                if (_Tag == "user")
                {
                    sql = "select * from users where uId='" + Id + "'";
                }
                else
                {
                    sql = "select * from admin where aId='" + Id + "'";
                }
                using (SqlConnection conn = new SqlConnection(str))
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    // ExecuteReader()返回一个Datareader对象，这个对象的内容就是与命令匹配的所有行
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        r.Read();
                        IdtextBox.Text = r.GetString(0);
                        NametextBox.Text = r.GetString(2);
                        PhonetextBox.Text = r.GetString(4);
                        if (_Tag == "user")
                        {
                            if (r.GetString(5) == "1")
                            {
                                label7.Text = "被锁定,请尽快联系管理员办理解锁";
                            }
                            else
                            {
                                label7.Text = "正常";
                            }
                        }
                        else
                        {
                            label7.Text = "正常";
                        }

                        if (r.GetString(3) == "男")
                        {
                            ManradioButton.Checked = true;
                        }
                        else
                        {
                            WomanradioButton.Checked = true;
                        }
                    }
                    cmd.Dispose();
                }
                Submitbutton.Visible = false;
            }
        }

        /// <summary>
        /// 修改名字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            Submitbutton.Visible = true;
        }

        /// <summary>
        /// 修改UserID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxUserID_TextChanged(object sender, EventArgs e)
        {
            if (IdtextBox.Text!= Id)
            {
                Submitbutton.Visible = true;
            }
            else
            {
                Submitbutton.Visible = false;
            }
        }

        /// <summary>
        /// 修改性别
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Submitbutton.Visible = true;
        }

        /// <summary>
        /// 修改手机号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxPhoneNum_TextChanged(object sender, EventArgs e)
        {
            Submitbutton.Visible = true;
        }

        /// <summary>
        /// 提交修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSubmit_Click(object sender, EventArgs e)
        { 
            // 判断账号是否存在
            if (IdtextBox.Text != Id)
            {
                if (SqlHelper.IsUserExists(TextBoxUserID.Text.Trim()))
                {
                    MessageBox.Show("账号已存在", "操作失败");
                    return;
                }
            }

            // 完成用户的修改
            string uName = NametextBox.Text.Trim();
            string uId = IdtextBox.Text.Trim();
            string uPhoNum = PhonetextBox.Text.Trim();
            string uGender;
            if (ManradioButton.Checked == true)
            {
                uGender = "男";
            }
            else
            {
                uGender = "女";
            }
            // 构造sql语句
            string sql;
            if (_Tag == "user")
            {
                sql = "update users set uId =@uId,uName=@uName,uGender=@uGender,uPhoNum=@uPhoNum where uId=@ID";
            }
            else
            {
                sql = "update admin set aId =@uId,aName=@uName,aGender=@uGender,aPhoNum=@uPhoNum where aId=@ID";
            }
            MyDictionary dic = new MyDictionary();
            dic.Add("@uId", uId);
            dic.Add("@uName", uName);
            dic.Add("@uGender", uGender);
            dic.Add("@uPhoNum", uPhoNum);
            dic.Add("@ID", Id);
            // 执行并返回
            int i = SqlHelper.ExecuteNonQuery(sql, dic);

            if (i == 1)
            {
                MessageBox.Show("提交完成");
            }
            this.Close();

        }

        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            string uGender = "";
            if (TextBoxUserID.Text.Trim().Length < 6)
            {
                MessageBox.Show("账号长度应该大于6");
            }
            else if (TextBoxPsw.Text.Trim().Length < 6)
            {
                MessageBox.Show("密码长度应该大于6");
            }
            else if (TextBoxUserName.Text.Trim().Length < 2 || TextBoxUserName.Text.Trim().Length > 15)
            {
                MessageBox.Show("姓名长度应该大于1并且小于等于15");
            }
            else if (RegisterrButtonMan.Checked == false && RegisterrButtonWoman.Checked == false)
            {
                MessageBox.Show("请选择性别");
            }
            else if (Regex.IsMatch(TextBoxPhoneNum.Text.Trim(), @"^1\d{10}$") != true && Regex.IsMatch(TextBoxPhoneNum.Text.Trim(), @"^(\d{3,4}-)?\d{6,8}$") != true)
            {
                MessageBox.Show("请输入合法的手机号码或电话号码");
            }
            else
            {
                // 判断判断账号是否存在
                if (SqlHelper.IsUserExists(TextBoxUserID.Text.Trim()))
                {
                    MessageBox.Show("账号已存在","操作失败");
                    return;
                }
                
                if(RegisterrButtonMan.Checked == true )
                {
                    uGender ="男";
                }
                else 
                {
                    uGender ="女";
                }

                // 添加新用户
                string sql = "insert into users(uId,uPwd,uName,uGender,uPhoNum,uBan) values(@id,@pwd,@name,@gender,@phonum,'0')";
                MyDictionary  dic = new MyDictionary ();
                dic.Add("@id", TextBoxUserID.Text.Trim());
                dic.Add("@pwd", TextBoxPsw.Text.Trim());
                dic.Add("@name", TextBoxUserName.Text.Trim());
                dic.Add("@gender", uGender);
                dic.Add("@phonum", TextBoxPhoneNum.Text.Trim());
                int i = SqlHelper.ExecuteNonQuery(sql, dic);
                if (i == 1)
                {
                    MessageBox.Show("成功注册新用户");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("操作失败,请联系管理员");
                }
            }
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            // 判断账号是否存在
            if (!SqlHelper.IsUserExists(TextBoxDelete.Text.Trim()))
            {
                MessageBox.Show("账号不存在", "操作失败");
                return;
            }
            else
            {
                DialogResult dt = MessageBox.Show("确定要删除此用户吗", "提示", MessageBoxButtons.OKCancel);
                if (dt != DialogResult.OK)
                {
                    return;
                }
                else
                {
                    string bSql = "select COUNT(*) from borrow where uId = '" + TextBoxDelete.Text.Trim() + "'";
                    string sql = "delete from users where uId=@id";
                    try
                    {
                        int userCount = Convert.ToInt32(SqlHelper.ExecuteScalar(bSql));
                        if(userCount == 0)
                        {
                            MyDictionary dic = new MyDictionary();
                            dic.Add("@id", TextBoxDelete.Text.Trim());
                            int i = SqlHelper.ExecuteNonQuery(sql, dic);
                            if (i == 1)
                            {
                                MessageBox.Show("删除成功");
                            }
                        }
                        else
                        {
                            MessageBox.Show("用户存在借阅记录，请归还图书后再删除账户！","错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch(Exception ee)
                    {
                        MessageBox.Show(ee.Message.ToString());
                    }
                }
            }
        }
    }
}
