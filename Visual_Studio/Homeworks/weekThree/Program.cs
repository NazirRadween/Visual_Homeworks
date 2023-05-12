using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age;
            string Name, Message;
            Name = Console.ReadLine();
            Age = Convert.ToInt32(Console.ReadLine());

            
            Message = "your name is " + Name + " and you are age " + Age + " years old";
            Console.Write("Print text by type 1 :");
            Console.WriteLine(Message);
            Console.Write("Print text by type 2 :");
            Console.WriteLine("your name is " + Name + " and you are age " + Age + " years old");
            Console.Write("Print text by type 3 :");
            Console.WriteLine("your name is {0} and you are age {1} years old", Name, Age);
            Console.Write("Print text by type 4 :");
            Console.WriteLine($"your name is {Name} and you are age {Age} years old");
            Console.ReadLine();
        }
    }
}
