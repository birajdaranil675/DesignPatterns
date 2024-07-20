using DesignPatterns.AbstractFactory;
using DesignPatterns.Factory;
using DesignPatterns.Singleton;

public class Program
{
    public static void Main(string[] args)
    {
        //MySingleton mySingleton = MySingleton.GetInstance();

        //factory
        //Waiter waiter = new Waiter();
        //IPizza pizza = waiter.GetPizz("Veg");
        //pizza.EatPizza();

        //AbstractFactory
        AbWaiter waiter = new AbWaiter("nonveg");
        IFood food = waiter.GetFood("pizza");
        food.Eat();
    }
}