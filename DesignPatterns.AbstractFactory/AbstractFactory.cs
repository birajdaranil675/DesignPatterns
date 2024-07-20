using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public interface IFood
    {
        void Eat();
    }

    public class VegPizza : IFood
    {
        public void Eat()
        {
            Console.WriteLine("Eat Veg pizzz..");
        }
    }

    public class NonVegPizza : IFood
    {
        public void Eat()
        {
            Console.WriteLine("Eat Non-Veg pizzz..");
        }
    }

    public class VegBurger : IFood
    {
        public void Eat()
        {
            Console.WriteLine("Eat veg Burger..");
        }
    }

    public class NonVegBurger : IFood
    {
        public void Eat()
        {
            Console.WriteLine("Eat Non-Veg Burger..");
        }
    }

    public interface IChef
    {
        IFood CreatePizza();
        IFood Createburger();
    }

    public class VegChef : IChef
    {
        public IFood CreatePizza()
        {
            Console.WriteLine("Created Veg pizzz..");
            return new VegPizza();
        }

        public IFood Createburger()
        {
            Console.WriteLine("Created veg Burger..");
            return new VegBurger();
        }
    }

    public class NonVegChef : IChef
    {
        public IFood CreatePizza()
        {
            Console.WriteLine("Created Non-Veg pizzz..");
            return new NonVegPizza();
        }

        public IFood Createburger()
        {
            Console.WriteLine("Created Non-Veg Burger..");
            return new NonVegBurger();
        }
    }

    public class AbWaiter //client
    {
        private IChef chef;
        public AbWaiter(string preference)
        {
            if(preference == "veg")
                chef = new VegChef();
            else
                chef = new NonVegChef();

        }
        public IFood GetFood(string foodType)
        {
            IFood food;
            switch (foodType)
            {
                case "pizza":
                    food = chef.CreatePizza();
                    break;
                default:
                    food = chef.Createburger();
                    break;
            }

            return food;
        }
    }
}
