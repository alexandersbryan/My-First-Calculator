using System;

namespace My_First_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int num1 = 0;
                int num2 = 0;
                int result = 0;

                Console.WriteLine("Calculator");

                Console.WriteLine("Enter the first number");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the second number");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter an option: ");
                Console.WriteLine(" +: Addition");
                Console.WriteLine(" -: Subtract");
                Console.WriteLine(" *: Multiply");
                Console.WriteLine(" /: Divide");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"your result: {num1} + {num2} =" + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"your result: {num1} - {num2} =" + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"your result: {num1} * {num2} =" + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"your result: {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("Pick a real number or else.");
                        break;
                }
                Console.WriteLine("Would you like to perform another Calculation? (y = yes, n = no): ");
            } while(Console.ReadLine().ToLower() == "y");

            Console.WriteLine("See Ya!");
            




        }
    }
}
