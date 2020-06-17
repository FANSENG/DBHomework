﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class SellRecordForm : Form
    {
        private String _tag;
        public String _Tag
        {
            get { return _tag; }
            set { _tag = value; }
        }
        private String _id;
        public String ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private String _name;
        public String NAME
        {
            get { return _name; }
            set { _name = value; }
        }
        public SellRecordForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 全部销售记录
        /// </summary>
        private void FindRecord()
        {
            string sql = "select sell.uId, users.uName, bNum, bPrice, purchaseDate from sell join users on sell.uId = users.uId";
            MyDictionary dic = new MyDictionary();
            DataTable dt = SqlHelper.GetList(sql, dic);
            dataGridView.DataSource = dt;
        }

        /// <summary>
        /// 搜索销售记录
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        private void FindRecord(String type, String id)
        {
            string sql = "select sell.uId, users.uName, bNum, bPrice, purchaseDate from sell join users on sell.uId = users.uId";
            MyDictionary dic = new MyDictionary();
            try
            {
                if (type.Equals("bNum"))
                {
                    sql += " where bNum = '" + id + "'";
                    DataTable dt = SqlHelper.GetList(sql, dic);
                    dataGridView.DataSource = dt;
                }
                else
                {
                    sql += " where sell.uId = '" + id + "'";
                    DataTable dt = SqlHelper.GetList(sql, dic);
                    dataGridView.DataSource = dt;
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }

        /// <summary>
        /// 加载销售记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindRecord_Load(object sender, EventArgs e)
        {
                adminPanel.Visible = true;
                FindRecord();
        }

        /// <summary>
        /// 通过用户ID搜索销售记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSearchByUserID_Click(object sender, EventArgs e)
        {
            FindRecord("uId", TextBoxUserID.Text.Trim());
            TextBoxUserID.Text = "";
        }

        /// <summary>
        /// 通过书籍号搜索销售记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSearchByBookNum_Click(object sender, EventArgs e)
        {
            FindRecord("bNum", TextBoxBookNum.Text.Trim());
            TextBoxBookNum.Text = "";
        }

        /// <summary>
        /// 搜索所有销售记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSearchAll_Click(object sender, EventArgs e)
        {
            TextBoxUserID.Text = "";
            TextBoxBookNum.Text = "";
            FindRecord();
        }

        #region 清除输入框
        private void IdTextBox_Enter(object sender, EventArgs e)
        {
            TextBoxBookNum.Text = "";
        }

        private void bookNumTextBox_Enter(object sender, EventArgs e)
        {
            TextBoxUserID.Text = "";
        }
        #endregion
    }
}