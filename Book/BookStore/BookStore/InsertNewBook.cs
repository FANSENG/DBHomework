using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class InsertNewBookForm : Form
    {
        private byte[] image;
        private byte[] file;
        public InsertNewBookForm()
        {
            InitializeComponent();
        }

        private string _p;  // p=="1"时为书籍注销操作
        public string P
        {
            get { return _p; }
            set { _p = value; }
        }

        private void NewBookForm_Load(object sender, EventArgs e)
        {
            if (P != "1")
            {
                DeleteBookpanel.Visible = false;
            }
        }

        /// <summary>
        /// 将照片转为byte[]
        /// </summary>
        /// <param name="imagepath"></param>
        /// <returns></returns>
        public byte[] GetData(string imagepath)
        {
            //根据图片文件的路径使用文件流打开，并保存为byte[] 
            FileStream fs = new FileStream(imagepath, FileMode.Open);
            byte[] byData = new byte[fs.Length];
            fs.Read(byData, 0, byData.Length);
            fs.Close();
            return byData;
        }


        /// <summary>
        /// 完成增加图书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddBook_Click(object sender, EventArgs e)
        {
            if (TextBoxBookName.Text.Trim() == "" || TextBoxBookAuthor.Text.Trim() == "" || TextBoxPress.Text.Trim() == "" || TextBoxBookISBN.Text.Trim() == "" || TextBoxBookNum.Text.Trim() == "" || TextBoxBookPrice.Text.Trim() == "" || TextBoxDate.Text.Trim() == "")
            {
                MessageBox.Show("请填写完整信息", "失败");
            }
            else
            {
                try
                {
                    // 自动获得图书序列号
                    string sql = " select MAX(bNum) from books";
                    string bNum = (int.Parse(SqlHelper.ExecuteScalar(sql).ToString()) + 1).ToString();
                    StringBuilder sb = new StringBuilder(bNum);
                    while (sb.Length != 6)
                    {
                        sb.Insert(0, "0");
                    }
                    bNum = sb.ToString();

                    // 添加操作
                    sql = "insert into books values(@bNum,@bName,@bAuthor,@bPubCom,@bPubDat,@ISBN,@bPrice,@bTag,@bImage,@bFile)";
                    MyDictionary dic = new MyDictionary();
                    dic.Add("@bNum", bNum);
                    dic.Add("@bName", TextBoxBookName.Text.Trim());
                    dic.Add("@bAuthor", TextBoxBookAuthor.Text.Trim());
                    dic.Add("@bPubCom", TextBoxPress.Text.Trim());
                    dic.Add("@bPubDat", TextBoxDate.Text.Trim());
                    dic.Add("@ISBN", TextBoxBookISBN.Text.Trim());
                    dic.Add("@bPrice", TextBoxBookPrice.Text.Trim());
                    dic.Add("@bTag", TextBoxBookNum.Text.Trim());
                    int i = SqlHelper.ExecuteNonQuery(sql, dic, image, file);
                    if (i == 1)
                    {
                        MessageBox.Show("添加成功,图书序列号为" + bNum);
                    }
                }
                catch(Exception ee)
                {
                    MessageBox.Show(ee.Message.ToString());
                }
            }
        }

        /// <summary>
        /// 删除图书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDeleteBook_Click(object sender, EventArgs e)
        {
            // 判断账号是否存在
            if (!SqlHelper.IsBookExistsWithNum(TextBoxDeleteBook.Text.Trim()))
            {
                MessageBox.Show("书籍不存在", "操作失败");
                return;
            }
            else
            {
                DialogResult dt = MessageBox.Show("确定要注销此书吗", "提示", MessageBoxButtons.OKCancel);
                if (dt != DialogResult.OK)
                {
                    return;
                }
                else
                {
                    string bSql = "select COUNT(*) from borrow where bNum = '" + TextBoxDeleteBook.Text.Trim() + "'";
                    string sql = "delete from books where bNum=@bNum";
                    try
                    {
                        int bookCount = Convert.ToInt32(SqlHelper.ExecuteScalar(bSql));
                        if (bookCount == 0)
                        {
                            MyDictionary dic = new MyDictionary();
                            dic.Add("@bNum", TextBoxDeleteBook.Text.Trim());
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
                this.Close();
            }
        }

        /// <summary>
        /// 读取书籍图片只限jpg格式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = File.OpenRead(openFile.FileName);
                image = new Byte[(int)fs.Length];
                fs.Read(image, 0, (int)fs.Length);
                fs.Close();
            }
        }

        /// <summary>
        /// 读取书籍简介只限txt格式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddIntro_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                file = GetData(openFile.FileName);
            }
        }
    }
}
