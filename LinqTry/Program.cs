using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTry
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = BalanceAggregate();
            Console.WriteLine(balance);

            int product = ProductAggregate();
            Console.WriteLine(product);


            CountAggregate();

            string[] names = { "John", "Suzy", "Dave" };
            IEnumerable<string> newNames = names.Select(x => x);
            foreach (var a in newNames)
            {
                Console.WriteLine(a);
            }

           
            Console.ReadKey();
        }

        private static void CountAggregate()
        {
            int[] numbers1 = { 10, 15, 20, 25, 30, 35, 10, 15, 30, 20 };
            var results = numbers1.GroupBy(x => x).Select(y => new { Num = y.Key, Times = y.Count() });
            foreach (var result in results)
            {
                Console.WriteLine("Number = {0} , count = {1}", result.Num, result.Times);
            }
        }

        private static int ProductAggregate()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var product = numbers.Aggregate((x, y) => x * y);
            return product;
        }

        private static double BalanceAggregate()
        {
            int[] attemptedWithdrawals = { 20, 10, 40, 50, 10, 70, 30 };
            double startBalance = 100.0;
            var balance = attemptedWithdrawals.Aggregate(startBalance, (x, y) => x - y);
            return balance;
        }
    }
}
