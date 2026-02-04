using System;
using System.Collections.Generic;

namespace DictionaryQ
{

    public class Program
    {
        public static void Main()
        {
            List<int> ids = [1, 4, 5];
            Dictionary<int, long> salaries = new()
            {
            { 1, 20000 },
            { 4, 40000 },
            { 5, 15000 },
            { 2, 30000 }
            };

            long totalSalary = 0;

            foreach (int id in ids)
            {
                if (salaries.TryGetValue(id, out long salary))
                {
                    totalSalary += salary;
                }
            }
            Console.WriteLine($"Total Salary: {totalSalary}");
        }
    }
}