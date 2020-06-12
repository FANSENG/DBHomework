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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string _id;// 账号
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        public string Name1 // 姓名
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _tag;
        public string _Tag
        {
            get { return _tag; }
            set { _tag = value; }
        }


        /// <summary>
        /// 关于
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("学号：201800800504\n姓名：樊昕昊\n系统：图书管理系统v0.1", "关于");
        }

        /// <summary>
        /// 退出时关闭所有窗口（login）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAlterPsw_Click(object sender, EventArgs e)
        {
            AlterPwdForm altPF = new AlterPwdForm();
            altPF.Id = Id;
            altPF.ShowDialog();
        }

        /// <summary>
        /// 修改个人信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButttonAlterData_Click(object sender, EventArgs e)
        {
            UpdateIndivForm uIF = new UpdateIndivForm();
            uIF.Id = Id;
            uIF._Tag = _Tag;
            uIF.ShowDialog();
        }


        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            UpdateIndivForm uIF = new UpdateIndivForm();
            uIF.Id = Id;
            uIF._Tag = _Tag;
            uIF.P = "1";
            uIF.Text = "新用户注册";
            uIF.ShowDialog();
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDeleteUser_Click(object sender, EventArgs e)
        {
            UpdateIndivForm deleteForm = new UpdateIndivForm();
            deleteForm.Text = "删除用户";
            deleteForm.P = "2";
            deleteForm.Id = Id;
            deleteForm._Tag = _Tag;
            deleteForm.ShowDialog();
        }

        /// <summary>
        /// 添加书籍
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddBook_Click(object sender, EventArgs e)
        {
            InsertNewBookForm iNB = new InsertNewBookForm();
            iNB.ShowDialog();
        }

        /// <summary>
        /// 书籍注销
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLogoutBook_Click(object sender, EventArgs e)
        {
            InsertNewBookForm iNB = new InsertNewBookForm();
            iNB.P = "1";
            iNB.Text = "注销书籍";
            iNB.ShowDialog();
        }

        /// <summary>
        /// 书籍查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonViewBook_Click(object sender, EventArgs e)
        {
            FindBookForm fbf = new FindBookForm();
            fbf.Tag1 = this._Tag;
            fbf.ShowDialog();
        }
        

        /// <summary>
        /// 借书办理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonBorrowBook_Click(object sender, EventArgs e)
        {
            BorrowBooks bb = new BorrowBooks();
            bb.ShowDialog();
        }        


        /// <summary>
        /// 还书办理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRetuenBook_Click(object sender, EventArgs e)
        {
            ReturnBooks rb = new ReturnBooks();
            rb.ShowDialog();
        }        

        /// <summary>
        /// 查看借书情况
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindRecord_Click(object sender, EventArgs e)
        {
            FindRecordForm fb = new FindRecordForm();
            fb.ID = _id;
            fb.NAME = _name;
            fb._Tag = _Tag;
            fb.ShowDialog();
        }
        

        /// <summary>
        /// 查看用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonViewUser_Click(object sender, EventArgs e)
        {
            UserDetailForm ud = new UserDetailForm();
            ud.ShowDialog();
        
        }

        /// <summary>
        /// 锁定用户处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLockUser_Click(object sender, EventArgs e)
        {
            LockUserForm lu = new LockUserForm();
            lu.ShowDialog();
        }
        
        /// <summary>
        /// 书籍销售
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonBookSell_Click(object sender, EventArgs e)
        {
            Sell sell = new Sell();
            sell.ShowDialog();
        }


        /// <summary>
        /// 查看销售书籍
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonViewSell_Click(object sender, EventArgs e)
        {
            SellRecordForm srf = new SellRecordForm();
            srf.ShowDialog();
        }
    }
}
