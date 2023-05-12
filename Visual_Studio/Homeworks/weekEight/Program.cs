using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekEight
{
    class Program
    {
        static int mohitt(int zul)
        {
            int mohit = 0;
            mohit = 12 * zul;
            return mohit;
        }
        static void Main(string[] args)
        {
            Console.Write("zul: ");
           int zul = Convert.ToInt32(Console.ReadLine());
           int mohit = mohitt(zul);

            Console.WriteLine("Mohit =" + mohit);
            Console.ReadKey();

        }



    }
}
