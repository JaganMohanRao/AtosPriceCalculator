using AtosPriceCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtosPriceCalculator
{
    class OrangesGrocery : Product
    {
        private double Discount = 1; // No Discount

        public int Quantity { get; set; } = 0;
        double finalPrice = 0;

        public override double Calculate()
        {
            double calculatedPrice = this.Price * this.Quantity;

            // VAT
            if (calculatedPrice > 0)
            {
                finalPrice = calculatedPrice * Discount;
            }

            return finalPrice;
        }
    }
}
