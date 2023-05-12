using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekSeven
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1, number2;
            Console.Write("number1 = ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("number2 = ");
            number2= Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\nOUTPUT: ");
            Console.WriteLine($"Sum of numbers = {Sum(number1, number2)}");
            Console.WriteLine($"Sub of numbers = {Sub(number1, number2)}");
            Console.WriteLine($"Mul of numbers = {Mul(number1, number2)}");
            Console.WriteLine($"Div of numbers = {Div(number1, number2)}");

            Console.ReadKey();
        }

        static double Sum(int a, int b)
        {
            int r = a + b;
            return r;

         }
        static double Sub(int a, int b)
        {
            int r = a - b;
            return r;

        }
        static double Div(int a, int b)
        {
            int r = a / b;
            return r;

        }
        static double Mul(int a, int b)
        {
            int r = a * b;
            return r;

        }

    }
}
