using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeExample.Model
{
    partial class Order
    {
        public string DateCreateFormat
        {
            get
            {
                return OrderCreateDate.ToString("d");
            }
        }

        public string DateDeliveryFormat
        {
            get
            {
                return OrderDeliveryDate.ToString("d");
            }
        }
        public List<OrderProduct> ProductsOfOrder
        {
            get
            {
                var ordersOfProducts = Context._con.OrderProducts.ToList().Where(p => p.OrderID == OrderID).ToList();
                return ordersOfProducts;
            }
        }

        public decimal TotalCost
        {
            get
            {
                var ordersOfProducts = ProductsOfOrder;
                decimal sum = 0;
                if (ordersOfProducts == null)
                {
                    return sum;
                }
                sum = 0;
                foreach(var item in ordersOfProducts)
                {
                    var product = Context._con.Products.ToList().Where(p => p.ProductArticleNumber == item.ProductArticleNumber).FirstOrDefault();
                    
                    sum += product.ProductCost * item.ProductCount;
                }
                return sum;
            }
        }

        public decimal TotalCostWithDiscount
        {
            get
            {
                var ordersOfProducts = ProductsOfOrder;
                decimal sum = 0;
                if (ordersOfProducts == null)
                {
                    return sum;
                }
                sum = 0;
                foreach (var item in ordersOfProducts)
                {
                    var product = Context._con.Products.ToList().Where(p => p.ProductArticleNumber == item.ProductArticleNumber).FirstOrDefault();

                    sum += Math.Round(product.ProductCost * (1 - (product.ProductDiscountAmount) / 100), 2) * item.ProductCount;
                }
                return sum;
            }
        }

        public decimal TotalDiscount
        {
            get
            {
                
                
                if (TotalCost == 0)
                {
                    return 0;
                }
                return Math.Round(((TotalCost - TotalCostWithDiscount) / TotalCost * 100), 2);
            }
        }

        public string HasDiscount
        {
            get
            {
                if (TotalCost == TotalCostWithDiscount)
                {
                    return "Collapsed";
                } else
                {
                    return "Visible";
                }
            }
        }

        public string GetColor
        {
            get
            {
                var ordersOfProducts = ProductsOfOrder;
                bool haveLess3 = false;
                foreach (var item in ordersOfProducts)
                {
                    var product = Context._con.Products.ToList().Where(p => p.ProductArticleNumber == item.ProductArticleNumber).FirstOrDefault();
                    if (product.ProductQuantityInStock == 0 || product.ProductQuantityInStock == null)
                    {
                        return "#ff8c00";
                    }
                    if (product.ProductQuantityInStock < 3)
                    {
                        haveLess3 = true;
                    }


                }
                if (haveLess3 == true)
                {
                    return "white";
                }
                return "#20b2aa";
            }
        }

    }
}
