namespace Programming
{
    public class Program
    {
        public static void Main()
        {
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) return;

            string[] parts = input.Split(' ');
            int m = int.Parse(parts[0]);
            int n = int.Parse(parts[1]);
            int luckyCount = 0;

            for (int i = m; i <= n; i++)
            {
                if (IsLucky(i))
                {
                    luckyCount++;
                }
            }
            Console.WriteLine(luckyCount);
        }

        public static bool IsLucky(int num)
        {
            if (IsPrime(num)) return false;
            int sumOfNumber = SumOfNumber(num);
            int sumOfNumSquared = SumOfNumber(num * num);
            return sumOfNumSquared == (sumOfNumber*sumOfNumber);
        }

        public static int SumOfNumber(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
        public static bool IsPrime(int num)
        {
            if (num < 2) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            for (int i = 3; i <= (int)Math.Sqrt(num); i += 2)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}