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
using TradeExample.Model;

namespace TradeExample.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        List<string> sortingArr = new List<string>() { 
            "По умолчанию",
            "По ворастанию",
            "По убыванию"
        };

        List<string> filterArr = new List<string>() {
            "Все диапозоны",
            "0 - 9,99%",
            "10 - 14,99%",
            "15% и более"
        };

        public MainMenu()
        {
            InitializeComponent();
            Sort();
            
            SortingCB.ItemsSource = sortingArr;
            SortingCB.SelectedIndex = 0;

            FilterCB.ItemsSource = filterArr;
            FilterCB.SelectedIndex = 0;

            if (App.CurrentUser != null)
            {
                UserNameTB.Text = App.CurrentUser.UserSurname + " " + App.CurrentUser.UserName + " " + App.CurrentUser.UserPatronymic;
                if(App.CurrentUser.UserRole == 1 || App.CurrentUser.UserRole == 3)
                {
                    GoToOrdersBTN.Visibility = Visibility.Visible;
                }
            } else
            {
                UserNameTB.Text = "Неавторизован";
            }
            

        }

        private void SortingCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Sort();
        }

        public void Sort()
        {
            var totalProducts = Context._con.Products.ToList();
            var product = totalProducts;
            ProductLB.ItemsSource = product;

            switch (FilterCB.SelectedIndex)
            {
                case 0:
                    product = Context._con.Products.ToList();
                    ProductLB.ItemsSource = product;
                    break;
                case 1:
                    product = product.Where(p => p.ProductDiscountAmount>=0 && p.ProductDiscountAmount<10).ToList();
                    ProductLB.ItemsSource = product;
                    break;
                case 2:
                    product = product.Where(p => p.ProductDiscountAmount>=10 && p.ProductDiscountAmount<15).ToList();
                    ProductLB.ItemsSource = product;
                    break;
                case 3:
                    product = product.Where(p => p.ProductDiscountAmount >= 15).ToList();
                    ProductLB.ItemsSource = product;
                    break;
            }

            switch (SortingCB.SelectedIndex)
            {
                case 0:
                    
                    ProductLB.ItemsSource = product;
                    break;
                case 1:
                    product = product.OrderBy(p => p.ProductCost).ToList();
                    ProductLB.ItemsSource = product;
                    break;
                case 2:
                    product = product.OrderByDescending(p => p.ProductCost).ToList();
                    ProductLB.ItemsSource = product;
                    break;
            }

            product = product.Where(p => p.ProductName.ToLower().Contains(SearchTB.Text.ToLower())).ToList();
            ProductLB.ItemsSource = product;
            CountTB.Text = product.Count + " из " + totalProducts.Count;

        }

        private void Search(object sender, TextChangedEventArgs e)
        {
            Sort();
        }

        private void AddToOrder(object sender, RoutedEventArgs e)
        {
            
            var currentProduct = ProductLB.SelectedItem as Product;
            //var numOrder = Context._con.Orders.ToList().Last().OrderID+1;
            currentProduct.ProductCount = "1";
            App.Products.Add(currentProduct);
            
            //MessageBox.Show($"{numOrder}");
            //OrderProduct product = new OrderProduct
            //{
            //    OrderID = numOrder,
            //    ProductArticleNumber = currentProduct.ProductArticleNumber,
            //    ProductCount = 1
            //};
            //App.OrderProducts.Add(product);
            GoToOrderBTN.Visibility = Visibility.Visible;
        }

        private void GoToOrder(object sender, RoutedEventArgs e)
        {
            OrderWindow orderWindow = new OrderWindow();
            orderWindow.ShowDialog();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
            App.CurrentUser = null;
            App.Products = new List<Product>();
            
            App.OrderCode = null;
            App.PickPointIndex = 0;
        }

        private void GoToOrders(object sender, RoutedEventArgs e)
        {
            Orders orders = new Orders();
            orders.Show();
            this.Close();
        }
    }
}
