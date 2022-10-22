namespace AdapterDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RoundHole roundHole = new RoundHole(10);

            RoundBlock roundBlock = new RoundBlock(20);

            SquareBlock squareBlock1 = new SquareBlock(30);
            SquareBlock squareBlock2 = new SquareBlock(5);

            SquareBlockAdapter adapter1 = new SquareBlockAdapter(squareBlock1);
            SquareBlockAdapter adapter2 = new SquareBlockAdapter(squareBlock2);

            Console.WriteLine($"{roundHole.DoesFit(roundBlock)}");
            Console.WriteLine($"{roundHole.DoesFit(adapter1)}");
            Console.WriteLine($"{roundHole.DoesFit(adapter2)}");
        }
    }
}