namespace Conversion
{
    public class Program
    {
        public static void Main()
        {
            int feet = 5;

            double centimeters = FeetToCentimeters(feet);
            Console.WriteLine(centimeters);
        }

        static double FeetToCentimeters(int feet)
        {
            double cm = feet * 30.48;
            return Math.Round(cm, 2, MidpointRounding.AwayFromZero);
        }
    }
}