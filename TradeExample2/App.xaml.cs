using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TradeExample.Model;

namespace TradeExample
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static User CurrentUser = null;
        //public static List<OrderProduct> OrderProducts = new List<OrderProduct>();
        public static List<Product> Products = new List<Product>();
        //public static List<int> Quantites = new List<int>();
        public static string OrderCode = null;
        public static int PickPointIndex = 0;
    }
}
