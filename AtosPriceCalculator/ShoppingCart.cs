using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtosPriceCalculator.Model;


namespace AtosPriceCalculator
{
    class ShoppingCart
    {
        private List<Product> orders;

        public List<Product> Orders
        {
            get
            {
                return orders;
            }
            set
            {
                orders = value;
            }
        }

        public double Calculate()
        {
            double price = 0;
            if (this.Orders != null)
            {

                foreach (Product order in this.Orders)
                {
                    price += order.Calculate();
                }

            }
            return price;

        }
    }
}

