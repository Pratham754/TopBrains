using System.Text.Json;

namespace StringFormat
{
    public class Student(string name, int score)
    {
        public string? Name { get; set; } = name;
        public int Score { get; set; } = score;
    }


    public class Program
    {
        public static string FindStudents(string[] items, int minScore)
        {
            var result = items.Select(item =>
            {
                string[] parts = item.Split(":");
                return new Student(parts[0],int.Parse(parts[1]));
            })
            .Where(s => s.Score >= minScore)
            .OrderByDescending(s => s.Score)
            .ThenBy(s => s.Name)
            .ToList();

            return JsonSerializer.Serialize(result);
        }
        public static void Main()
        {
            string[] studentList = ["Pratham:95", "Thiluck:82", "Mogra:85", "Gopi:70"];
            string json = FindStudents(studentList, 80);
            Console.WriteLine(json);
        }
    }
}