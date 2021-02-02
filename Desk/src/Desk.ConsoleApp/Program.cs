using System;

namespace Desk.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseNum = 850000;
            var totalMonth = 6;
            var yieldMonth = 4 / 100D;
            Console.WriteLine(Math.Pow(1 + yieldMonth, totalMonth));
            Console.WriteLine(baseNum * Math.Pow(1 + yieldMonth, totalMonth));
        }
    }
}
