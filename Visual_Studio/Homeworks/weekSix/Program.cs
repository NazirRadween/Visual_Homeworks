using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekSix
{
    class Program
    {
     
        public static double count(int[,] matrix)
        {
            double result = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
            return result;
        }

        static void Main(string[] args)
        {
            int[,] matrix = { { -1, 3, 7 }, { 3, 0, -3 }, { 2, 1, 1 } };
            double Determinant = 0;

            var a = matrix[0, 0];
            var b = matrix[0, 1];
            var c = matrix[0, 2];

            int[,] sub_matrix_1 = { { matrix[1, 1], matrix[1, 2] }, { matrix[2, 1], matrix[2, 2] } };
            int[,] sub_matrix_2 = { { matrix[1, 0], matrix[1, 2] }, { matrix[2, 0], matrix[2, 2] } };
            int[,] sub_matrix_3 = { { matrix[1, 0], matrix[1, 1] }, { matrix[2, 0], matrix[2, 1] } };

            Determinant = (a * count(sub_matrix_1)) - (b * count(sub_matrix_2)) + (c * count(sub_matrix_3));
            Console.WriteLine("determinant of matrix = " + Determinant);


            Console.ReadKey();


        }
    }
    }
