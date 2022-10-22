namespace BuilderDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new HouseBuilder();
            director.Builder = builder;

            Console.WriteLine("Standard basic product:");
            director.BuildMinimalViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Standard full featured product:");
            director.BuildFullFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Custom product:");
            builder.BuildFloors();
            builder.BuildRoof();
            Console.Write(builder.GetProduct().ListParts());
        }
    }
}