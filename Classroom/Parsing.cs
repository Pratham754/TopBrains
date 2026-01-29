namespace Parsing
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        string[] tokens = { "10", "20", "abc", "647", "214", "-5" };

        int sum = SumValidIntegers(tokens);

        Console.WriteLine(sum);
        }

        static int SumValidIntegers(string[] tokens)
        {
            if (tokens == null || tokens.Length == 0)
                return 0;

            int sum = 0;

            foreach (var token in tokens)
            {
                if (int.TryParse(token, out int value))
                {
                    sum += value;
                }
            }
            return sum;
        }
    }
}