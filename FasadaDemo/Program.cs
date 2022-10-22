namespace FasadaDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BrideFasade brideFasade = new BrideFasade();
            Console.WriteLine(brideFasade.MakeWedding());
        }


    }
}