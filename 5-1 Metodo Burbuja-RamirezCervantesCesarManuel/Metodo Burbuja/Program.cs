using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_Burbuja
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNum; 
            int cont, temp;
            Console.Write(" Cuantos numeros desea ingresar?: "); // se pregunta al usuario cuantos elementos va a ingresar
            cont = int.Parse(Console.ReadLine());
            arrayNum = new int[cont]; // se declara el arreglo del tamaño que el usuario ingreso 
            for(int i = 0; i < cont; i++) // ciclo for para: 
            {
                Console.Write(" Ingresa el numero de la posicion {0}: ", i + 1);// pregunta el valor desde la posicion 0 hasta el tamaño total del arreglo
                arrayNum[i] = int.Parse(Console.ReadLine()); // agrega el elemento ingresado por el usuario al arreglo 
            }
            for(int i = 0; i < arrayNum.Length; i++)
            {                                               // 2 ciclos for anidados para:
                for (int j = 1; j < arrayNum.Length; j++)
                {
                    if (arrayNum[j - 1] > arrayNum[j]) // si el valor actual menos 1 es mayor al valor actual
                    {
                        temp = arrayNum[j]; // se guarda el valor de la posicion actual en la variable temporal
                        arrayNum[j] = arrayNum[j - 1]; // se guarda el valor de la posicion actual menos 1 como el valor de la posicion actual 
                        arrayNum[j - 1] = temp; // se guarda el valor temporal como el valor de la posicion actual menos 1
                    }
                }
            }
            foreach(int num in arrayNum)// ciclo foreach para:
            {
                Console.Write(num + " "); // imprime el arreglo de numeros ordenados(menor a mayor)
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}