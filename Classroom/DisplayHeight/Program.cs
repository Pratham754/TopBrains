using System;
namespace DisplayHeight
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter height in cm: ");
            int heightCm = int.Parse(Console.ReadLine());

            string category = GetHeightCategory(heightCm);
            Console.WriteLine($"Height Category: {category}");
        }

        public static string GetHeightCategory(int heightCm)
        {
            if (heightCm > 300) return "Invalid height";
            else if (heightCm < 150) return "Short";
            else if (heightCm < 180) return "Average";
            else return "Tall";
        }
    }
}