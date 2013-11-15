using System;
using System.Threading;

namespace ContinuousHelloWorld
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hello World!!! " + DateTime.UtcNow);
                Thread.Sleep(1000);
            }
        }
    }
}
