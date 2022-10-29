namespace BuilderDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var director = new Director(); // tworzymy nowa instancje Directora
            var builder = new HouseBuilder();  // tworzymy nowa instacje Buildera
            director.Builder = builder; // powiazanie zaleznosci directora i buildera ktoremu przekazywane sa zadania oraz przypisanie obiektu HouseBuilder 

            Console.WriteLine("Standard basic product:");
            director.BuildMinimalViableProduct(); // wywolanie metody / wskazanie Directorowi co maja zrobic builderzy dla tej metody
            Console.WriteLine(builder.GetProduct().ListParts()); // wypisanie w konsoli

            Console.WriteLine("Standard full featured product:"); //jw tylko inne zadania
            director.BuildFullFeaturedProduct(); 
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Custom product:"); // jw
            builder.BuildFloors();
            builder.BuildRoof();
            Console.Write(builder.GetProduct().ListParts());
        }
    }
}