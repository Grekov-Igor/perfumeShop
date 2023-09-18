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
    /// Логика взаимодействия для OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window
    {


        DateTime _orderDeliveryDate;
        

        public OrderWindow()
        {
            InitializeComponent();
            if (App.CurrentUser != null)
            {
                UserNameTB.Text = App.CurrentUser.UserSurname + " " + App.CurrentUser.UserName + " " + App.CurrentUser.UserPatronymic;
            }
            else
            {
                UserNameTB.Text = "Неавторизован";
            }
            ProductLB.ItemsSource = App.Products;
            PickPointCB.ItemsSource = Context._con.PickupPoints.ToList();

            PickPointCB.SelectedIndex = App.PickPointIndex;

            calcPrice();
            CreateDateTB.Text += DateTime.Now.ToString("d");
            bool isInStock = true;
            foreach(var product in App.Products)
            {
                if (product.ProductQuantityInStock <= 3)
                {
                    isInStock = false;
                    break;
                }
            }
            if (isInStock == false)
            {
                _orderDeliveryDate = DateTime.Now.AddDays(6);
                DeliveryDateTB.Text += _orderDeliveryDate.ToString("d");
            } else
            {
                _orderDeliveryDate = DateTime.Now.AddDays(3);
                DeliveryDateTB.Text += _orderDeliveryDate.ToString("d");
            }
            if (App.OrderCode == null)
            {
                Random random = new Random();
                App.OrderCode = Convert.ToString(random.Next(100, 999));
            }
            OrderCodeTB.Text += App.OrderCode;

        }

        public void calcPrice()
        {
            decimal totalCost = 0;
            decimal totalDiscount = 0;
            decimal totalCostWithDiscount = 0;
            var products = App.Products;
            int i = 0;
            foreach(var product in products)
            {
                totalCost += product.ProductCost* Convert.ToInt32(product.ProductCount);
                //totalCostWithDiscount += Math.Round(product.ProductCost * (1 - (product.ProductDiscountAmount) / 100), 2)* App.Quantites[i];
                totalCostWithDiscount += Math.Round(product.ProductCost * (1 - (product.ProductDiscountAmount) / 100), 2) * Convert.ToInt32(product.ProductCount);
                i++;
            }
            totalDiscount = (totalCost - totalCostWithDiscount) / totalCost * 100;
            totalCostTB.Text = totalCost.ToString();
            totalCostWithDiscountTB.Text = totalCostWithDiscount.ToString() + " руб.";
            totalDiscountTB.Text = Math.Round(totalDiscount, 2).ToString() + "%";
            if (totalCost == totalCostWithDiscount)
            {
                totalCostTB.Visibility = Visibility.Collapsed;
            }
            
        }

        private void DeleteFromOrder(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var currentProduct = button.DataContext as Product;
            var pr = App.Products.Where(p => p.ProductArticleNumber == currentProduct.ProductArticleNumber).FirstOrDefault();
            int index = App.Products.IndexOf(pr);
            App.Products.RemoveAt(index);


            //ProductLB.ItemsSource = App.Products;
            //DeliveryDateTB.Text = App.Products.Count.ToString();
            //ProductLB.Items.Clear();
            ProductLB.ItemsSource = App.Products;

            calcPrice();
            OrderWindow orderWindow = new OrderWindow();
            orderWindow.Show();
            this.Close();

        }



        private void numOfProductsTB_TextChanged(object sender, TextChangedEventArgs e)
        {

            var textBox = sender as TextBox;
            var currentProduct = textBox.DataContext as Product;
            //var pr = App.Products.Where(p => p.ProductArticleNumber == currentProduct.ProductArticleNumber).FirstOrDefault();
            //int index = App.Products.IndexOf(pr);
            
            if (textBox.Text == "0")
            {
                var pr = App.Products.Where(p => p.ProductArticleNumber == currentProduct.ProductArticleNumber).FirstOrDefault();
                int index = App.Products.IndexOf(pr);
                App.Products.RemoveAt(index);

                OrderWindow orderWindow = new OrderWindow();
                orderWindow.Show();
                this.Close();
                //ProductLB.ItemsSource = App.Products;
                //DeliveryDateTB.Text = App.Products.Count.ToString();
                ProductLB.ItemsSource = App.Products;
                return;
            }

            //totalDiscountTB.Text = index.ToString();
            if (textBox.Text != "")
            {
                App.Products.Where(p => p.ProductArticleNumber == currentProduct.ProductArticleNumber).FirstOrDefault().ProductCount = textBox.Text;
                
            } else
            {
                textBox.Text = "1";
                App.Products.Where(p => p.ProductArticleNumber == currentProduct.ProductArticleNumber).FirstOrDefault().ProductCount = "1";
            }
            calcPrice();
            //totalCostTB.Text = "";
            //foreach (int i in App.Quantites)
            //{
            //    totalCostTB.Text += i.ToString();
            //}
        }

        private void PickPointCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            App.PickPointIndex = PickPointCB.SelectedIndex;
        }

        private void CreateOrder(object sender, RoutedEventArgs e)
        {
            int numOrder = Context._con.Orders.ToList().Last().OrderID + 1;
            var currentPickPoint = PickPointCB.SelectedItem as PickupPoint;
            Order order = null;
            if (App.CurrentUser != null)
            {
                order = new Order
                {
                    OrderID = numOrder,
                    OrderStatus = 1,
                    OrderCreateDate = DateTime.Now,
                    OrderDeliveryDate = _orderDeliveryDate,
                    OrderPickupPoint = currentPickPoint.PointID,
                    OrderCode = Convert.ToInt32(App.OrderCode),
                    IDUser = App.CurrentUser.UserID
                };
            } else
            {
                order = new Order
                {
                    OrderID = numOrder,
                    OrderStatus = 1,
                    OrderCreateDate = DateTime.Now,
                    OrderDeliveryDate = _orderDeliveryDate,
                    OrderPickupPoint = currentPickPoint.PointID,
                    OrderCode = Convert.ToInt32(App.OrderCode),
                    IDUser = 51

                };
            }
            Context._con.Orders.Add(order);
            
            foreach (var product in App.Products)
            {
                OrderProduct orderProduct = new OrderProduct
                {
                    OrderID = numOrder,
                    ProductArticleNumber = product.ProductArticleNumber,
                    ProductCount = Convert.ToInt32(product.ProductCount)
                };
                
                Context._con.OrderProducts.Add(orderProduct);
            }
            Context._con.SaveChanges();
            MessageBox.Show("Заказ создан", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);


        }

        private void numOfProductsTB_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (char.IsControl(e.Text, 0)) return;
            if ((e.Text[0] >= '0') && (e.Text[0] <= '9')) return;


            e.Handled = true;
        }
    }
}
