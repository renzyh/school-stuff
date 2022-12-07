using System;
namespace intPyramid
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Give a number between 1-82: ");
            bool canParse = int.TryParse(Console.ReadLine(), out int result);

            if (canParse) 
            {
                if (result > 0 & result < 83)
                {
                    for (int i = 1; i < result + 1; i++)
                    {
                        Console.WriteLine("");

                        for (int j = 1; j < i + 1; j++)
                        {
                            Console.Write("{0} ", j);
                        }
                    }
                    Console.WriteLine("");
                }
                else
                {
                  Console.WriteLine("Enter a number that's between 1 and 82.\n");
                    Main();
                }
            }
            else
            {
              Console.WriteLine("Enter a number.\n");
                Main();
            }
        }
    }

}

