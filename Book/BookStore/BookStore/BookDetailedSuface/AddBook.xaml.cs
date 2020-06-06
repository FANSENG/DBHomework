using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WinForm = System.Windows.Forms;
using Button = System.Windows.Controls.Button;
using BookStore.MyClass;


namespace BookStore.BookDetailedSuface
{
    /// <summary>
    /// AddBook.xaml 的交互逻辑
    /// </summary>
    public partial class AddBook : Window
    {
        BookData book = new BookData();
        private string imagePath;
        public AddBook()
        {
            InitializeComponent();
        }

        public byte[] GetData(string imagepath)
        {
            //根据图片文件的路径使用文件流打开，并保存为byte[] 
            FileStream fs = new FileStream(imagepath, FileMode.Open);
            byte[] byData = new byte[fs.Length];
            fs.Read(byData, 0, byData.Length);
            fs.Close();
            return byData;
        }

        public bool save()
        {
            string sql = String.Format(
                "INSERT INTO BookData(BookISBN, BookName, BookAuthor, BookCategory,BookPicture, PictureFormat,BookNum,BrandNewBookNum,BookPrice,BookSummary,Remarks) VALUES ('{0}', '{1}', '{2}', '{3}', @image, '{4}', {5}, {6}, {7}, @summary, '{8}')"
            ,book.BookISBN,book.BookName,book.BookAuthor,book.BookCategory,book.PictureFormat,book.BookNum,book.BrandNewBookNum,book.BookPrice,book.Remarks);
            MessageBox.Show(sql);
            return (DbHelperSQL.ExecuteSqlInsertImgAndSummary(sql, book.BookPicture, book.BookSummary)) == 1 ? true:false;
        }

        public void button_click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button == buttonBookSummary)
            {
                WinForm.OpenFileDialog openFile = new WinForm.OpenFileDialog();
                WinForm.DialogResult result = openFile.ShowDialog();
                if (result == WinForm.DialogResult.OK)
                {
                    TextBoxBookSummaryPath.Text = openFile.FileName;
                    book.BookSummary = GetData(openFile.FileName);
                }
            }
            else if(sender as Button == buttonBookPicture)
            {
                WinForm.OpenFileDialog openFile = new WinForm.OpenFileDialog();
                if (openFile.ShowDialog() == WinForm.DialogResult.OK)
                {
                    imageBook.Source = new BitmapImage(new Uri(openFile.FileName));
                    FileStream fs = File.OpenRead(openFile.FileName);
                    book.BookPicture = new Byte[(int)fs.Length];
                    fs.Read(book.BookPicture, 0, (int) fs.Length);
                    fs.Close();
                    string[] str = openFile.FileName.Split('.');
                    book.PictureFormat = str[str.Length - 1];
                }
            }
            else
            {
                book.BookAuthor = TextBoxBookAuthor.Text;
                book.BookCategory = ComboBoxSearchBookClasses.Text;
                book.BookISBN = TextBoxBookISBN.Text;
                book.BookName = TextBoxBookName.Text;
                book.Remarks = TextBoxBookRemarks.Text;
                book.BookPrice = Convert.ToDouble(TextBoxBookPrice.Text);
                book.BookNum = 0;
                book.BrandNewBookNum = 0;
                if(save())
                    MessageBox.Show("成功","标题");
                else
                {
                    MessageBox.Show("失败","标题");
                }
            }
        }
    }
}
