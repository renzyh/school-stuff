using System;
namespace z
{
    internal class Program
    {


        static void Main()
        {
            Console.Write("Enter a number between 1 and 10: ");
            bool tryParse = int.TryParse(Console.ReadLine(), out int parsedEnteredNumber);
           // Console.WriteLine(tryParse);

            if (tryParse)

            {
            //    Console.WriteLine(parsedEnteredNumber);

                if (parsedEnteredNumber > 0 && parsedEnteredNumber < 11) { 
                

                Console.Write("Amount of loops: ");
                bool tryParseLoop = int.TryParse(Console.ReadLine(), out int loopAmount);

                if (tryParseLoop)
                {
                        for (int forInt = 1; forInt < loopAmount + 1; forInt++)
                        {
                            Console.WriteLine($"{forInt} * {parsedEnteredNumber} = {forInt * parsedEnteredNumber}, {forInt} / {parsedEnteredNumber} = {forInt / parsedEnteredNumber}, {forInt} % {parsedEnteredNumber} = {forInt % parsedEnteredNumber}"); //print numbers
                        }

                    }
                

                else 
                {
                    Console.WriteLine("Loop amount is not a number");
                }

            }
                else
                {
                    Console.WriteLine("Entered number is not a number between 1 and 10.");
                }
            }

            else
            {
                Console.WriteLine("Entered 'number' is not a number");
            }

        }

    }
}
