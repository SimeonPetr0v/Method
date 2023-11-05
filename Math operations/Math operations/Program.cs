namespace Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double b = int.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(a, command, b));
        }
        static double Calculate(double a, string command, double b)
        {
            double result = 0;
            switch (command)
            {
                case "*":
                    result+= a * b;
                    break;
                    case "+":
                    result+= a + b;
                    break;
                    case "-":
                    result+= a - b;
                    break;
                case "/":
                    result+= a / b;
                    break;
                    
            }
            return result;
        }
    }
}