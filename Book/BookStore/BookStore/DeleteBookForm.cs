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
    public partial class DeleteBookForm : Form
    {
        public DeleteBookForm()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            string sql = "select bNum, bName, bAuthor, ISBN, bPrice from books";
            MyDictionary dic = new MyDictionary();
            DataTable dt = SqlHelper.GetList(sql, dic);
            dataGridView.DataSource = dt;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string sql = "select bNum, bName, bAuthor, ISBN, bPrice from books where bName like '%"+TextBoxBookName.Text+"%'";
            MyDictionary dic = new MyDictionary();
            DataTable dt = SqlHelper.GetList(sql, dic);
            dataGridView.DataSource = dt;
        }

        private void DeleteBookForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ButtonSearchAll_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // 查看是否被租借中
            int a = dataGridView.CurrentRow.Index;
            string bNum = dataGridView.Rows[a].Cells["bNum"].Value.ToString();
            if (SqlHelper.IsBookBorrowExists(bNum))
            {
                MessageBox.Show("图书被租借中，不可删除!", "Error", MessageBoxButtons.OK);
                return;
            }
            // 删除
            SqlHelper.DeleteBook(bNum);
            LoadData();
        }
    }
}
