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
using System.Windows.Shapes;
using TradeExample.Model;

namespace TradeExample.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для Orders.xaml
    /// </summary>
    public partial class Orders : Window
    {

        List<string> sortingArr = new List<string>() {
            "По умолчанию",
            "По ворастанию",
            "По убыванию"
        };

        List<string> filterArr = new List<string>() {
            "Все диапозоны",
            "0 - 10%",
            "11 - 14%",
            "15% и более"
        };

        public Orders()
        {
            InitializeComponent();
            Sort();
            SortingCB.ItemsSource = sortingArr;
            SortingCB.SelectedIndex = 0;

            FilterCB.ItemsSource = filterArr;
            FilterCB.SelectedIndex = 0;
            var orders = Context._con.Orders.ToList();
            OrdersLB.ItemsSource = orders;

        }

        public void Sort()
        {
            var totalProducts = Context._con.Orders.ToList();
            var order = totalProducts;
            OrdersLB.ItemsSource = order;

            switch (FilterCB.SelectedIndex)
            {
                case 0:
                    order = Context._con.Orders.ToList();
                    OrdersLB.ItemsSource = order;
                    break;
                case 1:
                    order = order.Where(p => p.TotalDiscount >= 0 && p.TotalDiscount < 10).ToList();
                    OrdersLB.ItemsSource = order;
                    break;
                case 2:
                    order = order.Where(p => p.TotalDiscount >= 10 && p.TotalDiscount < 15).ToList();
                    OrdersLB.ItemsSource = order;
                    break;
                case 3:
                    order = order.Where(p => p.TotalDiscount >= 15).ToList();
                    OrdersLB.ItemsSource = order;
                    break;
            }

            switch (SortingCB.SelectedIndex)
            {
                case 0:

                    OrdersLB.ItemsSource = order;
                    break;
                case 1:
                    order = order.OrderBy(p => p.TotalCostWithDiscount).ToList();
                    OrdersLB.ItemsSource = order;
                    break;
                case 2:
                    order = order.OrderByDescending(p => p.TotalCostWithDiscount).ToList();
                    OrdersLB.ItemsSource = order;
                    break;
            }

            

        }

        private void SortingCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Sort();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }
    }
}
