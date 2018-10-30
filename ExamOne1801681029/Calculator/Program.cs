using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's make some calculations");
            Console.WriteLine("Write your first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Write your second number");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Write a symbol for the calculation that you want to do");
            string symbolForEquation = Console.ReadLine();

            double result = 0;

            switch (symbolForEquation)
            {
                case "+":
                    result = (firstNumber + secondNumber) * (10 / 100);
                    Console.WriteLine($"The sum of your numbers is {result}");
                    break;
                    
                case  "*":
                    result = firstNumber * Math.Sqrt(secondNumber);
                    Console.WriteLine($"The sum of your numbers is {result}");
                    break;

                case "/":
                    if (secondNumber=0)
                    {
                        Console.WriteLine("You can't devide to 0");
                    }
                    else
                    {
                        result = firstNumber / secondNumber;
                        Console.WriteLine($"The sum of your numbers is {result}");
                    }
                    break;
            }

            
            
        }
    }
}
