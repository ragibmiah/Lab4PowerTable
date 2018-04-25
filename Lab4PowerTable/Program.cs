using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4PowerTable
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Let's Get Squared and Cubed!");

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            int count;
            bool reply;

            while (true)
            {
                do
                {
                    Console.Write($"\n{name} please enter an integer from 1 to a value: ");
                    string input = Console.ReadLine();

                    reply = int.TryParse(input, out count);
                    if (!reply)
                    {
                        Console.WriteLine("\nThis is not a valid input.");
                    }
                }
                while (!reply);
                {
                    if (count <= 0)
                    {
                        Console.WriteLine("\nThis number is not within the scale.");
                    }
                    else
                    {
                        Console.WriteLine("Number \t\tsquared \tcubed");
                        for (int i = 1; i <= count; i++)
                        {
                            Console.WriteLine($"{i} \t\t{i * i} \t\t{i * i * i}");
                        }
                    }
                }
                Console.WriteLine("\nWould you like to continue? (Y or N) ");
                string doAgain = Console.ReadLine().ToLower();

                if (doAgain != "y")
                {
                    break;
                }
            }
        }
    }
}
