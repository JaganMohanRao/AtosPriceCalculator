using AtosPriceCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtosPriceCalculator
{
    class ApplesGrocery : Product
    {
        private double Discount = 0.5;
        double finalPrice = 0;
        public int Quantity { get; set; } = 0;

        public override double Calculate()
        {
            double calculatedPrice = this.Price * this.Quantity;

            
            if (calculatedPrice > 0)
            {
                finalPrice= calculatedPrice * Discount;
            }

            return finalPrice;
        }
    }

}
