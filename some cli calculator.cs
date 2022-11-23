using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nMethods:\n+ to plus\n- to minus\n* to multiplicate\n/ to divide\n% to modulus\n^ to power\n\n");
           
            while (true) { 
            Console.Write("Enter your first number: ");
            bool canParseFirst = int.TryParse(Console.ReadLine(), out int firstNumber);

            if (canParseFirst)
            {
                Console.Write("Enter your second number: ");
                bool canParseSecond = int.TryParse(Console.ReadLine(), out int secondNumber);
                if (canParseSecond)
                {
                    Console.Write("Enter a method: ");
                    string method = Console.ReadLine();

                    if (method == "+")
                    {
                        Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}\n");
                    }
                    else if (method == "-")
                    {
                        Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}\n");
                    }
                    else if (method == "*")
                    {
                        Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}\n");
                    }
                    else if (method == "/")
                    {
                        Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}\n");
                    }
                    else if (method == "%")
                    {
                        Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}\n");
                    }
                    else if (method == "^")
                    {
                        Console.WriteLine($"{firstNumber} ^ {secondNumber} = {Math.Pow(firstNumber, secondNumber)}\n");
                    }

                    else { Console.WriteLine("That method doesn't exist!\n"); }
                }
                else { Console.WriteLine("Entered text wasn't a number\n"); }
              }
                else { Console.WriteLine("Make sure to type a number\n"); }
            }
        }
    }
}
