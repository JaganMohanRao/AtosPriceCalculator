using AtosPriceCalculator.Model;
using System.Collections.Generic;

namespace AtosPriceCalculator.FactoryMethods
{
    public interface IActivity
    {
        double CalculateItems(float money);
    }
}