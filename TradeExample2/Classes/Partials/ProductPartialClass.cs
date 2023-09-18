using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeExample.Model
{
    partial class Product
    {
        public string GetColor
        {
            get
            {
                if(ProductDiscountAmount > 15)
                {
                    return "#7fff00";
                } else
                {
                    return "white";
                }
            }
        }

        public string GetAmountDiscount
        {
            get
            {
                return $"Скидка: {ProductDiscountAmount}%";
            }
        }

        public string GetCostWithDiscount
        {
            get
            {
                
                return $"{Math.Round(ProductCost * (1 - (ProductDiscountAmount) / 100), 2)} руб.";
              
            }
        }

        public string HasDiscountVisability
        {
            get
            {
                if (ProductDiscountAmount == 0 || ProductDiscountAmount == null)
                {
                    return "Collapsed";
                }
                else
                {
                    return "Visible";
                }
            }
        }

        int itemCounter = 0;
        public string ProductCount
        {
            get
            {
                return ItemCounter.ToString();
            }
            set
            {
                ItemCounter = Convert.ToInt32(value);
            }
        }
        public int ItemCounter
        {
            get
            {
                return itemCounter;
            }
            set
            {
                itemCounter = value;
            }
        }
    }
}
