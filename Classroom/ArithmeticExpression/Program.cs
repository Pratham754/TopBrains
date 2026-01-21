namespace ArithmeticExpression
{
    public class Program
    {
        public static string Evaluate(string expression)
        {
            if (string.IsNullOrWhiteSpace(expression))
                return "Error:InvalidExpression";

            string[] parts = expression.Trim().Split(' ');

            if (parts.Length != 3)
                return "Error:InvalidExpression";

            string op = parts[1];

            bool isAValid = int.TryParse(parts[0], out int a);
            bool isBValid = int.TryParse(parts[2], out int b);

            if (!isAValid || !isBValid)
                return "Error:InvalidNumber";

            switch (op)
            {
                case "+":
                    return (a + b).ToString();
                case "-":
                    return (a - b).ToString();
                case "*":
                    return (a * b).ToString();
                case "/":
                    if (b == 0)
                        return "Error:DivideByZero";
                    return (a / b).ToString();
                default:
                    return "Error:UnknownOperator";
            }
        }

        public static void Main()
        {
            string? input = Console.ReadLine();
            Console.WriteLine(Evaluate(input));
            Console.WriteLine(Evaluate("10 + 5"));      // Output: 15
            Console.WriteLine(Evaluate("10 / 0"));      // Output: Error:DivideByZero
            Console.WriteLine(Evaluate("10 % 2"));      // Output: Error:UnknownOperator
            Console.WriteLine(Evaluate("abc + 5"));     // Output: Error:InvalidNumber
            Console.WriteLine(Evaluate("10 + 5 + 2"));  // Output: Error:InvalidExpression
        }
    }
}