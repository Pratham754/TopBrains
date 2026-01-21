namespace MultiplicationTable
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

            int[] arr = new int[n];
            for(int i = 1; i <= n; i++)
            {
                arr[i-1] = m*i;
            }

            foreach(int num in arr)
            {
                Console.Write(num + " ");
            }
        }
    }

}