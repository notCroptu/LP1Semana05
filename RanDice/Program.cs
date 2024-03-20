using System;

namespace RanDice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(args[0]);
            int s = int.Parse(args[1]);

            int result = 0;

            Random random = new Random(s);

            for ( int i = 0; i < n; i++)
            {
                result += random.Next(1, 7);
            }
            Console.WriteLine(result);
        }
    }
}
