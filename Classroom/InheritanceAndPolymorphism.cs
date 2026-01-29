using System;
using System.Globalization;

namespace InheritanceAndPolymorphism
{
    abstract class Employee
    {
        public abstract decimal Pay();
    }

    class HourlyEmployee : Employee
    {
        decimal rate, hours;
        public HourlyEmployee(decimal r, decimal h) { rate = r; hours = h; }
        public override decimal Pay() => rate * hours;
    }

    class SalariedEmployee : Employee
    {
        decimal salary;
        public SalariedEmployee(decimal s) { salary = s; }
        public override decimal Pay() => salary;
    }

    class CommissionEmployee : Employee
    {
        decimal commission, baseSalary;
        public CommissionEmployee(decimal c, decimal b) { commission = c; baseSalary = b; }
        public override decimal Pay() => baseSalary + commission;
    }

    class Program
    {
        public static void Main()
        {
            string[] employees =
            {
            "H 20 160",
            "S 3000",
            "C 500 2500"
        };

            decimal total = 0;

            foreach (var e in employees)
            {
                var parts = e.Split(' ');
                Employee emp = null;

                if (parts[0] == "H")
                    emp = new HourlyEmployee(decimal.Parse(parts[1]), decimal.Parse(parts[2]));
                else if (parts[0] == "S")
                    emp = new SalariedEmployee(decimal.Parse(parts[1]));
                else if (parts[0] == "C")
                    emp = new CommissionEmployee(decimal.Parse(parts[1]), decimal.Parse(parts[2]));

                total += emp.Pay();
            }

            Console.WriteLine(Math.Round(total, 2));
        }
    }
}