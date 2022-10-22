namespace SingletonDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Singleton nauczyciel = Singleton.GetInstance;
            nauczyciel.WypiszSzczególy("Jestem nauczycielem");

            Singleton student = Singleton.GetInstance;
            student.WypiszSzczególy("Jestem studentem");
        }
    }
}