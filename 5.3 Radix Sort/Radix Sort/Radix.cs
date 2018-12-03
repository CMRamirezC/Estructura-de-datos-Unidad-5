using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radix_Sort
{
    class Radix
    {
        private void RadixSort(int[] array)
        {
            int[] aux = new int[array.Length];//arreglo auxiliar 
            int r = 2;
            int b = 32; // variable que representa el numero de bits de un entero
            int[] count = new int[1 << r];
            int[] pref = new int[1 << r];

            int groups = (int)Math.Ceiling((double)b / (double)r);
            int mask = (1 << r) - 1;
            for (int i = 0, shift = 0; i < groups; i++, shift += r)
            {
                for (int j = 0; j < count.Length; j++)
                    count[j] = 0;

                for (int k = 0; k < array.Length; k++)
                    count[(array[k] >> shift) & mask]++;

                pref[0] = 0;
                for (int l = 1; l < count.Length; l++)
                    pref[l] = pref[l - 1] + count[l - 1];

                for (int m = 0; m < array.Length; m++)
                    aux[pref[(array[m] >> shift) & mask]++] = array[m];

                aux.CopyTo(array, 0);
            }
        }
        public void Imprimir(int[] array)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Arreglo de numeros: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i] + ",");
            }
            RadixSort(array);
            Console.WriteLine();
            Console.WriteLine("\n Arreglo de numeros ordenados por Radix: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i] + ",");
            }
            Console.WriteLine();
        }
    }
}
