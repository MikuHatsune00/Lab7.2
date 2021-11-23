using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба:");
            int a1 = Convert.ToInt32(Console.ReadLine());
            double S,V;
            SCube(a1, out S);
            VCube(a1, out V);
            Console.WriteLine("{0:0.00}", S);
            Console.WriteLine("{0:0.00}", V);
            Console.ReadKey();

        }

        static void SCube(int a, out double S)
        {   double A = Convert.ToDouble(a);
            S = 6 * Math.Pow(A, 2);
        }
        static void VCube(int a, out double V)
        {
            double A = Convert.ToDouble(a);
            V = Math.Pow(A, 3);
        }

    }
}
