
namespace AtosPriceCalculator.FactoryMethods
{
    abstract class Factory
    {
        public abstract IActivity factoryMethod();

        public IActivity getActivity()
        {
            return factoryMethod();
        }

        
    }

   
}
