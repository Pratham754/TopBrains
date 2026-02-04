namespace MidPointRounding
{
    public class Program
    {
        public static void Main()
        {
            double input = double.Parse(Console.ReadLine());
            double area = Math.PI * input * input;
            double roundedArea = Math.Round(area,2,MidpointRounding.AwayFromZero);
            Console.WriteLine(roundedArea);
        }
    }
}