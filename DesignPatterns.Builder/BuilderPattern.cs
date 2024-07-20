using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class Product
    {
        private ProductDetails productDetails;

        public Product(ProductDetails details)
        {
            productDetails = details;
        }
        public void GetFinalProduct()
        {
            Console.WriteLine("Final product ready with below details..");
            Console.WriteLine($"Operating system : {productDetails.OS} \n Processor : {productDetails.Processor} \n Battery : {productDetails.Battery} " +
                              $"\nScreen Size : {productDetails.ScreenSize}");
        }
    }

    public class ProductDetails
    {
        public string OS { get; set; }
        public string Processor { get; set; }
        public int Battery { get; set; }
        public double ScreenSize { get; set; }
    }

    public abstract class Builder
    {
        public abstract void SetOS();
        public abstract void SetProcessor();
        public abstract void SetBattery();
        public abstract void SetScreenSize();
        public abstract ProductDetails GetDetails();
        public Product BuildProduct()
        {
            SetOS();
            SetProcessor();
            SetBattery();
            SetScreenSize();
            var pDetails = GetDetails();
            return new Product(pDetails);
        }
    }

    public class ConcreteBuilder : IConcreteBuilder
    {
        ProductDetails productDetails = new ProductDetails();

        public ProductDetails GetDetails()
        {
            SetOS();
            SetProcessor();
            SetBattery();
            SetScreenSize();
            return productDetails;
        }

        public void SetBattery()
        {
            Console.WriteLine("Enter battery capacity:");
            productDetails.Battery = int.Parse(Console.ReadLine());
        }

        public void SetOS()
        {
            Console.WriteLine("Enter Operating system name:");
            productDetails.OS = Console.ReadLine();
        }

        public void SetProcessor()
        {
            Console.WriteLine("Enter processor name:");
            productDetails.Processor = Console.ReadLine();
        }

        public void SetScreenSize()
        {
            Console.WriteLine("Enter Screen size:");
            productDetails.ScreenSize = double.Parse(Console.ReadLine());
        }

        Product IConcreteBuilder.BuildProduct()
        {
            
            return new Product(productDetails);
        }

        #region Implementation for abtsract class
        //public override ProductDetails GetDetails()
        //{
        //    return productDetails;
        //}

        //public override void SetOS()
        //{
        //    Console.WriteLine("Enter Operating system name:");
        //    productDetails.OS = Console.ReadLine();
        //}

        //public override void SetProcessor()
        //{
        //    Console.WriteLine("Enter processor name:");
        //    productDetails.Processor = Console.ReadLine();
        //}

        //public override void SetBattery()
        //{
        //    Console.WriteLine("Enter Operating system name:");
        //    productDetails.OS = Console.ReadLine();
        //}

        //public override void SetScreenSize()
        //{
        //    Console.WriteLine("Enter battery capacity:");
        //    productDetails.Battery = int.Parse(Console.ReadLine());
        //}
        #endregion


    }

    public class shop //Director
    {
        public static Product GetMobile()
        {
           //using concerete class implementation
           //Builder builder = new ConcreteBuilder();

           // using concerete interface implementation
           IConcreteBuilder builder = new ConcreteBuilder();
           builder.GetDetails();
           return builder.BuildProduct();
        }
    }


}
