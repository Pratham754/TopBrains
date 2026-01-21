namespace Swapping
{
    public class Program
    {
        public static void Main()
        {
            int x = 10, y = 20;

            Console.WriteLine($"Before Ref Swap: x={x}, y={y}");
            SwapWithRef(ref x, ref y);
            Console.WriteLine($"After Ref Swap: x={x}, y={y}");

            Console.WriteLine("---");

            Console.WriteLine($"Before Out Swap: x={x}, y={y}");
            SwapWithOut(x, y, out x, out y);
            Console.WriteLine($"After Out Swap: x={x}, y={y}");
        }

        public static void SwapWithRef(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void SwapWithOut(int valA, int valB, out int a, out int b)
        {
            a = valB;
            b = valA;
        }
    }
}