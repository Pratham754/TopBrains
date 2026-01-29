namespace CountCharFromString
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string input = "hello world!";
            CountCharacters(input);
        }
        static void CountCharacters(string text)
        {
            if (string.IsNullOrEmpty(text))
                return;

            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (char c in text)
            {
                if (counts.ContainsKey(c))
                    counts[c]++;
                else
                    counts[c] = 1;
            }

            foreach (var pair in counts)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }
        }
    }
}