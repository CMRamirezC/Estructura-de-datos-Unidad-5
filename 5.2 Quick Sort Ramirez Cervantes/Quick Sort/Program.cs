using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Operacion Op = new Operacion();
            int[] arrayNum1 = new int[] { 11, 2, 3, 14, 18, 4, 5, -3, -1, 6, 9 };
            double[] arrayNum2 = new double[] { 1, 3, 5, 7, 8, 3, 9, 0.7071, 16.5664, 12, 0, 10 };
            double[] arrayNum3 = new double[] { 3, 7, 15, 4 / 3, 155, 100, 15, Math.Sqrt(3), 5, 2, 3, 2 };
            int[] arrayNum4 = new int[] { 8, 19, 7, 3, 15, 23, 34, 27, 89, 101 };

            Console.WriteLine(" Lista No.1: ");
            Op.ImprimirInt(arrayNum1);
            Console.WriteLine();

            Console.WriteLine(" Lista No.2: ");
            Op.ImprimirDouble(arrayNum2);
            Console.WriteLine();

            Console.WriteLine(" Lista No.3: ");
            Op.ImprimirDouble(arrayNum3);
            Console.WriteLine();

            Console.WriteLine(" Lista No.4: ");
            Op.ImprimirInt(arrayNum4);
            Console.WriteLine();
        }
    }
}
