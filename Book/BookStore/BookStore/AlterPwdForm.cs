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
    public partial class AlterPwdForm : Form
    {
        public AlterPwdForm()
        {
            InitializeComponent();
        }
        private string _id;
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        
        /// <summary>
        /// 提交修改密码请求
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSubbmit_Click(object sender, EventArgs e)
        {
            string sql;
            if (textBoxNewPsw.Text.Trim() == "" || textBoxNewPsw2.Text.Trim() == "" || textBoxNewPsw.Text.Trim() != textBoxNewPsw2.Text.Trim())
            {
                MessageBox.Show("请检查输入", "警告");
            }
            else
            {
                sql = "update admin set aPwd = @uPwd where aId=@uId";
                MyDictionary dic1 = new MyDictionary();
                dic1.Add("@uPwd", textBoxNewPsw.Text.Trim());
                dic1.Add("@uId", _id);
                int n = SqlHelper.ExecuteNonQuery(sql, dic1);
                if (n > 0)
                {
                    MessageBox.Show("修改成功", "OK");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败", "警告");
                }
                
            }
        }
    }
}
