using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookStore
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void dataGrid_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void setAllPanelCollapsed()
        {
            WelcomePanel.Visibility = Visibility.Collapsed;
            MemberManagePanel.Visibility = Visibility.Collapsed;
            BookLeasePanel.Visibility = Visibility.Collapsed;
            BookSellPanel.Visibility = Visibility.Collapsed;
            PurchaseManagePanel.Visibility = Visibility.Collapsed;
            FinanceManagePanel.Visibility = Visibility.Collapsed;
            SearchBookPanel.Visibility = Visibility.Collapsed;
        }

        private void button_click_MainButton(object sender, RoutedEventArgs e)
        {
            setAllPanelCollapsed();
            Button click = sender as Button;
            if (click == buttonMemberManage)
            {
                MemberManagePanel.Visibility = Visibility.Visible;
            }
            else if (click == buttonBookLease)
            {
                BookLeasePanel.Visibility = Visibility.Visible;
            }
            else if (click == buttonBookSell)
            {
                BookSellPanel.Visibility = Visibility.Visible;
            }
            else if (click == buttonPurchaseManage)
            {
                PurchaseManagePanel.Visibility = Visibility.Visible;
            }
            else if (click == buttonFinanceManage)
            {
                FinanceManagePanel.Visibility = Visibility.Visible;
            }
            else if (click == ButtonSearchBook)
            {
                SearchBookPanel.Visibility = Visibility.Visible;
            }
        }

        private void MenuItemCheckBook_Click(object sender, RoutedEventArgs e)
        {
            BookDetailedSuface.AddBook addBook = new BookDetailedSuface.AddBook();
            addBook.Show();
            this.Hide();
            //if ((sender as MenuItem) == MenuItemAddBook)
            //{
            //    BookDetailedSuface.AddBook addBook = new BookDetailedSuface.AddBook();
            //    addBook.Show();
            //    this.Hide();
            //}
        }
    }
}
