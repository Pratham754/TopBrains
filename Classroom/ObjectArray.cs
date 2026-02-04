using System;
using System.Linq;

namespace ObjectArray
{
    public class Program
    {
        public static void Main()
        {
            object[] values = [5, "Apple", 15, null, true, 10, 20, 134, 123.42];

            int sum = values.OfType<int>().Sum();
            Console.WriteLine($"Sum of integers: {sum}");
        }
    }
}