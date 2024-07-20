namespace DesignPatterns.Builder
{
    public interface IConcreteBuilder
    {
        ProductDetails GetDetails();
        Product BuildProduct();
        void SetBattery();
        void SetOS();
        void SetProcessor();
        void SetScreenSize();
    }
}