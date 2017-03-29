using System;
using System.Linq;

namespace Listing1_24_OrderedParallelQuery
{
    class Program
    {
        public static void Main()
        {
            var numbers = Enumerable.Range(0, 10);
            var parallelResult = numbers.AsParallel()
                .Where(i => i % 2 == 0)
                .ToArray();

            foreach (var item in parallelResult)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
