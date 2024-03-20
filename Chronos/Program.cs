using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            crono1.Start();
            Thread.Sleep(600);
            crono2.Start();
            Thread.Sleep(200);
            crono1.Stop();
            crono2.Stop();

            TimeSpan TimeCrono1 = crono1.Elapsed;
            TimeSpan TimeCrono2 = crono2.Elapsed;            

            Console.WriteLine($"{TimeCrono1.Milliseconds/1000f:f3}");
            Console.WriteLine($"{TimeCrono2.Milliseconds/1000f:f3}");
        }
    }
}
