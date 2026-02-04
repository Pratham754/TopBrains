namespace ExtensionMethod
{
    public static class MyExtensions
    {
        public static string[] MyDistinctBy(this string[] items)
        {
            List<string> names = [];
            HashSet<string> seenIds = [];

            foreach (string item in items)
            {
                string[] parts = item.Split(':');
                string id = parts[0];
                string name = parts[1];

                if (seenIds.Add(id))
                {
                    names.Add(name);
                }
            }
            return names.ToArray();
        }
    }
    public class Program
    {
        public static void Main()
        {
            string[] input = { "1:Alice", "2:Bob", "1:Charlie" };
            string[] result = input.MyDistinctBy();

            foreach (var name in result) Console.WriteLine(name);
        }
    }
}