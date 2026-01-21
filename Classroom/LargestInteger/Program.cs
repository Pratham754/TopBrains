namespace LargestInteger
{
    public class Program
    {
        public static void Main()
        {
            string? input = Console.ReadLine();
            string[] inputs = input.Split(" ");
            
            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);
            int c = int.Parse(inputs[2]);

            var largestInteger = (a > b) ? (a > c ?  a : c) : ( b > c ? b : c );
            Console.WriteLine("Largest Integer is "+ largestInteger);
        }
    }
}