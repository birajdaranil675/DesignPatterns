using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public interface IPizza
    {
        void EatPizza();
    }

    public class VegPizza : IPizza
    {
        public void EatPizza()
        {
            Console.WriteLine("Eat Veg pizzz..");
        }
    }

    public class NonVegPizza : IPizza
    {
        public void EatPizza()
        {
            Console.WriteLine("Eat Non-Veg pizzz..");
        }
    }

    public interface ICheif
    {
        IPizza CreatePizza();
    }

    public class VegPizzCheif : ICheif
    {
        public IPizza CreatePizza()
        {
            Console.WriteLine("Created Veg pizzz..");
            return new VegPizza();
        }
    }

    public class NonVegPizzCheif : ICheif
    {
        public IPizza CreatePizza()
        {
            Console.WriteLine("Created Non-Veg pizzz..");
            return new NonVegPizza();
        }
    }

    public class Waiter //client
    {
        public IPizza GetPizz(string pizzaType)
        {
            ICheif cheif;
            switch (pizzaType)
            {
                case "Veg":
                    cheif = new VegPizzCheif();
                    break;
                default:
                    cheif = new NonVegPizzCheif();
                    break;
            }

            return cheif.CreatePizza();
        }
    }
}
