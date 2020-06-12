using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace LibraryManager
{

    public partial class FindBookForm : Form
    {
        //bindingsource组件用于管理控件和数据源绑定工作，简化这个绑定管理
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter adapter;

        // 标记表格数据是否改变过
        private bool changed = false;

        public FindBookForm()
        {
            InitializeComponent();
        }
        private string _tag;
        public string Tag1
        {
            get { return _tag; }
            set { _tag = value; }
        }

        // 当前页数
        private int pageIndex;
        // 总页数
        int maxIndex;

        /// <summary>
        /// 添加书籍
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNewBook_Click(object sender, EventArgs e)
        {
            InsertNewBookForm iNB = new InsertNewBookForm();
            iNB.ShowDialog();
        }

        /// <summary>
        /// 删除书籍
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            string select = dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[0].Value.ToString();
            string bSql = "select COUNT(*) from borrow where bNum = '" + select + "'";
            string sql = "delete from books where bNum=@bNum";
            try
            {
                int bookCount = Convert.ToInt32(SqlHelper.ExecuteScalar(bSql));
                if (bookCount == 0)
                {
                    MyDictionary dic = new MyDictionary();
                    dic.Add("@bNum", select);
                    int i = SqlHelper.ExecuteNonQuery(sql, dic);
                    if (i == 1)
                    {
                        MessageBox.Show("注销成功");
                    }
                }
                else
                {
                    MessageBox.Show("书籍存在借阅记录，所有图书归还后方可删除书籍信息！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }

        /// <summary>
        /// 初始加载页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindBookForm_Load(object sender, EventArgs e)
        {
            pageIndex = 1;
            GetData();
            dataGridView.DataSource = bindingSource1;
        }

        /// <summary>
        /// 加载数据
        /// </summary>
        private void GetData()
        {
            // 获取页大小
            int pageSize = 14;
            // 计算最多有多少页--Math.Ceiling--向上取整
            // Convert.ToInt32(SqlHelper.ExecuteScalar("select count(*) from books"))得到数据记录总数
            maxIndex = (int)Math.Ceiling((Convert.ToInt32(SqlHelper.ExecuteScalar("select count(*) from books")) * 1.0 / pageSize));
            // 获取连接字符串
            string str = System.Configuration.ConfigurationManager.ConnectionStrings["library"].ConnectionString;
            // 得到连接
            using (SqlConnection conn = new SqlConnection(str))
            {
                // 判断是否有数据
                // Convert.ToInt32(SqlHelper.ExecuteScalar("select count(*) from books"))得到数据记录总数
                if (Convert .ToInt32 (SqlHelper.ExecuteScalar("select count(*) from books")) > 0 && pageIndex > 0)
                {
                    // 确定有数据才进行查询
                    // 创建表格，用来存储数据
                    DataTable dt = new DataTable();
                    // 构造带分页功能的 sql 语句
                    string sql = "select bNum,bName,bAuthor,bPubCom,bPubDat,ISBN,bPrice,bTag from booksWithbookindex where bookindex between @sIndex and @eIndex";
                    // 构造适配器对象
                    adapter = new SqlDataAdapter(sql, conn);
                    // 传递参数
                    // 本页第一条数据
                    adapter.SelectCommand.Parameters.AddWithValue("@sIndex", ((pageIndex - 1) * pageSize + 1));
                    // 本页最后一条数据
                    adapter.SelectCommand.Parameters.AddWithValue("@eIndex", pageIndex * pageSize);
                    // 执行查询
                    conn.Open();
                    adapter.Fill(dt);
                    bindingSource1.DataSource = dt;
                }
                else if (pageIndex <= 0)
                {
                    pageIndex = 1;
                }
                else
                {
                    MessageBox.Show("没有获取到数据","警告");
                }
            }
        }

        /// <summary>
        /// 点击刷新按钮重新加载数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRefersh_Click(object sender, EventArgs e)
        {
            if (pageIndex <= 0)
            {
                pageIndex = 1;
            }
            GetData();
        }

        /// <summary>
        /// 加载第一页数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFirstPage_Click(object sender, EventArgs e)
        {
            pageIndex = 1;
            GetData();
        }

        /// <summary>
        /// 加载前一页数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPreviousPage_Click(object sender, EventArgs e)
        {
            pageIndex--;
            if (pageIndex <= 0)
            {
                pageIndex = 1;
            }
            GetData();
        }

        /// <summary>
        /// 加载下一页数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNextPage_Click(object sender, EventArgs e)
        {
            pageIndex++;
            if (pageIndex > maxIndex )
            {
                pageIndex--;
                MessageBox.Show("哎呀，到底啦 ！","提示");
            }
            GetData();
        }

        /// <summary>
        /// 加载最后一页数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLastPage_Click(object sender, EventArgs e)
        {
            pageIndex = maxIndex;
            GetData();
        }

        /// <summary>
        /// 保存修改数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            string str = System.Configuration.ConfigurationManager.ConnectionStrings["library"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(str))
            {
                // 构造UpdateCommand
                string update = "update books set bName=@bName, bAuthor=@bAuthor,bPubCom=@bPubCom,bPubDat=@bPubDat,ISBN=@ISBN,bPrice=@bPrice,bTag=@bTag where bNum=@bNum";
                SqlCommand updateCmd = new SqlCommand(update, conn);
                updateCmd.Parameters.Add("@bName", SqlDbType.NVarChar, 60, "bName");
                updateCmd.Parameters.Add("@bAuthor", SqlDbType.NVarChar, 60, "bAuthor");
                updateCmd.Parameters.Add("@bPubCom", SqlDbType.NVarChar, 50, "bPubCom");
                updateCmd.Parameters.Add("@bPubDat", SqlDbType.NVarChar, 20, "bPubDat");
                updateCmd.Parameters.Add("@ISBN", SqlDbType.NVarChar, 50, "ISBN");
                updateCmd.Parameters.Add("@bPrice", SqlDbType.NVarChar, 10, "bPrice");
                updateCmd.Parameters.Add("@bTag", SqlDbType.NVarChar, 10, "bTag");
                updateCmd.Parameters.Add("@bNum", SqlDbType.NVarChar, 10, "bNum");
                adapter.UpdateCommand = updateCmd;
                adapter.Update((DataTable)bindingSource1.DataSource);
            }

            // 刷新数据
            GetData();
            MessageBox.Show("保存成功");
            changed = false;

            //// 若绑定数据源则用dgv_list.DataSource as DataTable;
            //// 未绑定则用DgvToTable()强制转换
            //// = DgvToTable(dgv_list);
            //DataTable dt=dgv_list.DataSource as DataTable;
            //// 完成adapter的UpdateCommand
            //string str = System.Configuration.ConfigurationManager.ConnectionStrings["library"].ConnectionString;
            //using (SqlConnection conn = new SqlConnection(str))
            //{

            //    SqlDataAdapter adapter = new SqlDataAdapter();

            //    // 构造UpdateCommand
            //    string update = "update books set bName=@bName, bAuthor=@bAuthor,bPubCom=@bPubCom,bPubDat=@bPubDat,ISBN=@ISBN,bPrice=@bPrice,bTag=@bTag where bNum=@bNum";
            //    SqlCommand updateCmd = new SqlCommand(update, conn);
            //    updateCmd.Parameters.Add("@bName", SqlDbType.NVarChar , 60, "bName");
            //    updateCmd.Parameters.Add("@bAuthor", SqlDbType.NVarChar, 60, "bAuthor");
            //    updateCmd.Parameters.Add("@bPubCom", SqlDbType.NVarChar, 50, "bPubCom");
            //    updateCmd.Parameters.Add("@bPubDat", SqlDbType.NVarChar, 20, "bPubDat");
            //    updateCmd.Parameters.Add("@ISBN", SqlDbType.NVarChar, 50, "ISBN");
            //    updateCmd.Parameters.Add("@bPrice", SqlDbType.NVarChar, 10, "bPrice");
            //    updateCmd.Parameters.Add("@bTag", SqlDbType.NVarChar, 10, "bTag");
            //    updateCmd.Parameters.Add("@bNum", SqlDbType.NVarChar, 10, "bNum");
            //    adapter.UpdateCommand = updateCmd;

            //    // 执行
            //    conn.Open();
            //    adapter.Update(dt);
            //}

            //// 刷新数据
            //GetData();
            //MessageBox.Show("保存成功");

            //MessageBox.Show("功能暂未开放");
        }

        /// <summary>
        /// 搜索图书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (!ButtonBookName.Text.Trim().Equals(""))
            {
                string sql = "select bNum,bName,bAuthor,bPubCom,bPubDat,ISBN,bPrice,bTag from booksWithbookindex where bName like '%'+ @bName +'%'";
                MyDictionary dic = new MyDictionary();
                dic.Add("@bName", ButtonBookName.Text.Trim());
                DataTable dt = SqlHelper.GetList(sql, dic);
                bindingSource1.DataSource = dt;
            }
        }

        /// <summary>
        /// 关闭页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindBookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changed == true)
            {
                // 如果表格数据被改变过
                DialogResult result = MessageBox.Show("确定不保存更改？", "提示", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if(result == DialogResult.OK)
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
        /// 记录表格被编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            changed = true;
        }

        /// <summary>
        /// 打开图像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonImage_Click(object sender, EventArgs e)
        {
            string select = dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[0].Value.ToString();
            string sql = String.Format("select bImage from books where bNum = '{0}'", select);
            byte[] image = (byte[])SqlHelper.ExecuteScalar(sql);
            imageForm im = new imageForm();
            if(!im.setImage(image))
                MessageBox.Show("图片显示错误");
            else
            {
                im.ShowDialog();
            }
        }

        /// <summary>
        /// 打开图书简介
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonInfo_Click(object sender, EventArgs e)
        {
            string select = dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[0].Value.ToString();
            string sql = String.Format("select bFile from books where bNum = '{0}'", select);
            byte[] file = (byte[])SqlHelper.ExecuteScalar(sql);
            UTF8Encoding data = new UTF8Encoding(true);
            Text = data.GetString(file);
            MessageBox.Show(Text,"图书简介");
        }

    }

}
