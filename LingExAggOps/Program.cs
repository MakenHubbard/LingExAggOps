using System;
using System.Collections.Generic;
using System.Linq;

namespace LingExAggOps
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Nums = new List<int>()
            {
                15, 8, 21, 24, 28, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var total = Nums.Count();

            Console.WriteLine(total);
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            List<double> Purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };

            double moneySpent = Purchases.Sum();

            Console.WriteLine($"As a Company We have spent ${moneySpent} in this month!");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            List<double> Prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };

            double mostPricey = Prices.Max();

            Console.WriteLine($" The most expensive product costs ${mostPricey}");
            Console.WriteLine("Press enter to end this application");
            Console.ReadLine();
        }
    }
}
