using AtosPriceCalculator.Model;
using System;
using System.Collections.Generic;

namespace AtosPriceCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            ApplesGrocery applesItem = new ApplesGrocery();
            applesItem.Name = "apples";
            applesItem.Price = 30;
            applesItem.Quantity = 2;

            OrangesGrocery orangesItem = new OrangesGrocery();
            orangesItem.Name = "Oranges";
            orangesItem.Price = 50;
            orangesItem.Quantity = 3;

            ShoppingCart cart = new ShoppingCart();
            cart.Orders = new List<Product>();
            cart.Orders.Add(applesItem);
            cart.Orders.Add(orangesItem);

            double price = cart.Calculate();
            Console.WriteLine("Price: {0}", price);
            Console.ReadKey();
        }
    }
}
