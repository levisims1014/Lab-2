using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool room = true;
            do
            {
                //declare your variables for the equations
                double l, w, a, p, v, h;

                Console.WriteLine("Welcome to Grand Circus Detail Generator!");
                Console.WriteLine(" ");
                Console.WriteLine("Enter Length: ");
                //get user input
                l = Double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Width: ");
                w = Double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Height: ");
                h = Double.Parse(Console.ReadLine());

                Console.WriteLine($"Area: {a = l * w}");
                Console.WriteLine($"Perimeter: {p = 2 * l + 2 * w}");
                Console.WriteLine($"Volume: {v = l * w }");
                {
                    //get input to continue with code
                Repeat:
                        Console.WriteLine("Do you want to continue? (y/n)");
                        string again = Console.ReadLine().ToLower();
                    if (again == "y")
                    {
                        room = true;
                    }
                    else if (again == "n")
                    {
                        Console.WriteLine("Okay, Goodbye!");
                        room = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Please try again!");
                        //added to go back to repeat if user doesnt enter right input
                        goto Repeat;
                    }   
                }
            } while (room == true);
        }
    }
}