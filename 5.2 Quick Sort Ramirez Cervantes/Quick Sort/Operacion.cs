using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Sort
{
    class Operacion
    {
        public void ImprimirInt(int[] arrayNum)// metodo para imprimir la lista de tipo de datos int
        {
            for (int i = 0; i < arrayNum.Length; i++)// ciclo for para imprimir el arreglo de los numeros sin ser ordenados
            {
                Console.Write(arrayNum[i] + " ");
            }
            Console.WriteLine();
            OrdenarInt(arrayNum, 0, arrayNum.Length - 1);//llama al metodo para ordenar el arreglo de numeros enteros 
            for (int i = 0; i < arrayNum.Length; i++)// ciclo for para imprimir el arreglo de los numeros ordenados 
            {
                Console.Write(arrayNum[i] + " ");
            }
            Console.WriteLine();
        }
        public static void OrdenarInt(int[] nums, int izquierda, int derecha)//metodo para ordenar el arreglo con datos de tipo int 
        {
            int i = izquierda, j = derecha;
            int pivote = (izquierda + derecha) / 2;//se declara el pivote (posicion del valor que se encuentra a mitad del  arreglo
            while (i <= j)// hasta que i sea menor o igual j
            {
                while (nums[i] < nums[pivote])// mientras que el dato en la posicion i sea menor a el pivote
                {
                    i++;// aumenta i
                }
                while (nums[j] > nums[pivote])// mientras que el dato en la posicion j sea mayor al pivote
                {
                    j--;// disminuye j 
                }
                if (i <= j)// si i es menor o igual a j
                {
                    int temp = nums[i];// se guarda el dato en la posicion i como temporal
                    nums[i] = nums[j];// se guarda el dato en la posicion j como el dato de la posicion i
                    nums[j] = temp;// se guarda el dato que estaba como temporal en la posicion j 
                    i++;// aumenta i
                    j--;// disminuye j 
                }
            }
            if (izquierda < j)// si el valor de izquierda es menor a j
            {
                OrdenarInt(nums, izquierda, j);// llama al metodo mandando coo parametros el arreglo, el valor de izquierda y el valor de j
            }
            if (i < derecha)// si i es menor a derecha
            {
                OrdenarInt(nums, i, derecha);// llama al metodo mandando como parametros el arreglo, el valor de i y el valor de derecha 
            }
        }
        public void ImprimirDouble(double[] arrayNum)//metodo de imprimir, pero para los arreglos de datos de tipo double 
        {
            for (int i = 0; i < arrayNum.Length; i++)
            {
                Console.Write(arrayNum[i] + " ");
            }
            Console.WriteLine();
            OrdenarDouble(arrayNum, 0, arrayNum.Length - 1);
            for (int i = 0; i < arrayNum.Length; i++)
            {
                Console.Write(arrayNum[i] + " ");
            }
            Console.WriteLine();
        }
        public static void OrdenarDouble(double[] nums, int izquierda, int derecha)// metodo de ordenar, pero para los arreglos de datos de tipo double 
        {
            int i = izquierda, j = derecha;
            int pivote = (izquierda + derecha) / 2;
            while (i <= j)
            {
                while (nums[i] < nums[pivote])
                {
                    i++;
                }
                while (nums[j] > nums[pivote])
                {
                    j--;
                }
                if (i <= j)
                {
                    double temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                    i++;
                    j--;
                }
            }
            if (izquierda < j)
            {
                OrdenarDouble(nums, izquierda, j);
            }
            if (i < derecha)
            {
                OrdenarDouble(nums, i, derecha);
            }
        }
    }
}
