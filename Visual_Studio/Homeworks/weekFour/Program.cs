using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekFour
{
    class Program
    {
        static void Main(string[] args)
        {
            int passed, current;
            double percentage;

                Console.Write("Enter Passed cridets: ");
                passed = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter The Percentage: ");
                percentage = Convert.ToDouble(Console.ReadLine());
                current = passed / 20;

                if (current == 1 || current == 2 || current == 3 || current == 4)
                {
                    Console.WriteLine("\noutput:");
                    Console.WriteLine($"Your semester is {current}th.");

                    if (percentage <= 75 && percentage >= 55)
                    {

                        Console.WriteLine("intermediate percentage you can get higher score!");
                    }
                    else if (percentage <= 85 && percentage > 75)
                    {
                        Console.WriteLine("high percentage you have chance to make it better!");
                    }
                    else if (percentage <= 90 && percentage > 85)
                    {
                        Console.WriteLine("Your percentage is very high you have chance to make it even better!");
                    }
                    else if (percentage <= 100 && percentage > 90)
                    {
                        Console.WriteLine("great percentage Congratulations!");
                    }
                    else
                    {
                        Console.WriteLine("you are failed!");
                    }
                }
                else if (current == 5 || current == 6)
                {
                    Console.WriteLine("\noutput: ");
                    Console.WriteLine($"your semester is {current}th.");

                    if (percentage <= 75 && percentage >= 55)
                    {

                        Console.WriteLine($"intermediate percentage you can boost it to {passed + 5}!");
                    }
                    else if (percentage <= 85 && percentage > 75)
                    {
                        Console.WriteLine($"Your percentage is high, still you can boost it to {passed + 5}!");
                    }
                    else if (percentage <= 90 && percentage > 85)
                    {
                        Console.WriteLine($"Your percentage is well still you can boost it to {passed + 5}!");
                    }
                    else if (percentage <= 100 && percentage > 90)
                    {
                        Console.WriteLine($"Your percentage is great Congratulations!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input or may you failed!");
                    }

                }
                else if (current == 7 || current == 8)
                {
                    Console.WriteLine("\nOut put: ");
                    Console.WriteLine($"You are in term {current}.");

                    if (percentage <= 75 && percentage >= 55)
                    {

                        Console.WriteLine($"Your percentage is intermediate you have not chance to compensate sorry!");
                    }
                    else if (percentage <= 85 && percentage > 75)
                    {
                        Console.WriteLine($"Your percentage is high but you cannot boost it sorry!");
                    }
                    else if (percentage <= 90 && percentage > 85)
                    {
                        Console.WriteLine($"Your percentage is well but you cannot boost is sorry!");
                    }
                    else if (percentage <= 100 && percentage > 90)
                    {
                        Console.WriteLine($"Your percentage is great Congratulations!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input or may you failed!");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect input please try again!");
                }

            Console.ReadLine();
        }
    }
}
