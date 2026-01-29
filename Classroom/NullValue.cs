namespace NullValue
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double?[] values = { 1.234, null, 2.345, 3.456 };

            double? average = ComputeAverage(values);

            if (average.HasValue)
                Console.WriteLine(average.Value);
            else
                Console.WriteLine("null");
        }

        static double? ComputeAverage(double?[] values)
        {
            if (values == null || values.Length == 0)
                return null;

            double sum = 0.0;
            int count = 0;

            foreach (var value in values)
            {
                if (value.HasValue)
                {
                    sum += value.Value;
                    count++;
                }
            }
            if (count == 0)
                return null;

            double avg = sum / count;
            return Math.Round(avg, 2, MidpointRounding.AwayFromZero);
        }
    }
}