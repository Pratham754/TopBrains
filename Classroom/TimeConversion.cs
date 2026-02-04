namespace TimeConversion
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(ConvertSecondsToTime(125));
            Console.WriteLine(ConvertSecondsToTime(60));
            Console.WriteLine(ConvertSecondsToTime(9));

        }
        public static string ConvertSecondsToTime(int totalSeconds)
        {
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;
            return $"{minutes}:{seconds:D2}";
        }
    }
}