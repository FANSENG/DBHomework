using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Windows.Controls.Image;

namespace BookStore.MyClass
{

    class BookData
    {
        public string BookISBN;
        public string BookName;
        public string BookAuthor;
        public string BookCategory;
        public byte[] BookPicture;
        public string PictureFormat;
        public int BookNum;
        public int BrandNewBookNum;
        public double BookPrice;
        public byte[] BookSummary;
        public string Remarks;
    }
}
