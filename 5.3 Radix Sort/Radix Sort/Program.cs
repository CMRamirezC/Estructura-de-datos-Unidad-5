using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radix_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNums;
            Radix Op = new Radix();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" --> Ejercicio 1 <-- ");
            arrayNums = new int[] { 3, 6, 9, 5, 1, 4, 7, 2, 1, 3 };
            Op.Imprimir(arrayNums);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" --> Ejercicio 2 <-- ");
            arrayNums = new int[] { 8, 3, 9, 3, 11, 7, 1, 27, 12 };
            Op.Imprimir(arrayNums);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" --> Ejercicio 3 <-- ");
            arrayNums = new int[] { 10, 40, 36, 5, 24, 2, 5, 8 };
            Op.Imprimir(arrayNums);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" --> Ejercicio 4 <-- ");
            arrayNums = new int[] { 55, 42, 0, -3, 0, -1, 2, 4, 7 };
            Op.Imprimir(arrayNums);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" --> Ejercicio 5 <-- ");
            arrayNums = new int[] { 25, 108, 1024, 12, 351, 251, 39 };
            Op.Imprimir(arrayNums);
            Console.WriteLine();
        }
    }
}
