using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = " Examen Unidad 5, Ramirez Cervantes Cesar Manuel ";
            Metodos metodo = new Metodos();
            int[] array;
            int tamaño;
            bool condicion = true;
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine(" 1.- Bubble Sort, 2.- Radix, 3.- Shell Sort, 4.- Quick Sort ");
                    Console.WriteLine();
                    Console.Write(" Que ejercicio desea revisar?: ");
                    int opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1: // EJERCICIO 1 BUBBLE SORT
                            Console.Write(" De cuantos numeros desea agregar su arreglo?: ");//pregunta al usuario de que tamaño sera el arreglo
                            tamaño = int.Parse(Console.ReadLine());// se guarda el tamaño ingresado por el usuario
                            array = new int[tamaño];// se crea el arreglo con el tamaño que ingreso el usuario
                            X:
                            for (int i = 0; i < tamaño; i++)// ciclo for para hacer llenado del arreglo
                            {
                                Console.Write(" Ingrese el numero para la posicion [{0}]: ", i + 1);
                                int num = int.Parse(Console.ReadLine());
                                if (num >= 0 && num <= 2)//si el numero ingresado por el usuario es mayor/igual a 0 y menor/igual a 2
                                {
                                    array[i] = num;//guardara el numero en la posicion acutal (i) del arreglo
                                }
                                else // si no se cumple la condicion
                                {
                                    Console.WriteLine(" numero ingresado no valido pruebe agregando cualquiera de los siquientes numeros: (0,1,2)! ");// manda mensaje de numero invalido
                                    goto X;//se regresa al inicio del ejercicio para que el usuario vuelva a intentar ingresar los numeros 
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine(" Arreglo no ordenado: ");
                            metodo.ImprimirArreglo(array);//se manda a llamar el metodo para imprimir el arreglo sin ser ordenado mandando como parametro el arreglo
                            metodo.BubbleSort(array);//se manda a llamar el metodo de ordenamiendo de burbuja mandando como parametro el arreglo
                            Console.WriteLine();
                            Console.WriteLine(" Arreglo ordenado: ");
                            metodo.ImprimirArreglo(array);// se vuelve a llamar el metodo para imprimir el arreglo despues de ser ordenado mandando como parametro el arreglo
                            break;
                        case 2: // EJERCICIO 2 RADIX SORT
                            array = new int[80];// se crea un arreglo con un tamaño de 80 elementos
                            Random random = new Random();
                            int numRandom;
                            for (int i = 0; i < array.Length; i++)// ciclo for para llenado del arreglo con los numeros random
                            {
                                do//hacer
                                {
                                    numRandom = random.Next(1000);//genera un nuevo numero random desde 0 hasta 1000
                                }
                                while (metodo.Comprobacion(array, i, numRandom));// lo hara hasta que el metodo para comprobar si el arreglo ya contiene el numero random actual generado regrese un false
                                array[i] = numRandom;// guarda el numero random en el arreglo en la posicion actual
                            }
                            Console.WriteLine();
                            Console.WriteLine(" Arreglo no ordenado: ");
                            metodo.ImprimirArreglo(array);//se manda a llamar el metodo para imprimir el arreglo sin ser ordenado mandando como parametro el arreglo
                            metodo.RadixSort(array);//se manda a llamar el metodo de ordenamiento de radix mandando como parametro el arreglo
                            Console.WriteLine();
                            Console.WriteLine(" Arreglo ordenado: ");
                            metodo.ImprimirArreglo(array);// se vuelve a llamar el metodo para imprimir el arreglo despues de ser ordenado mandando como parametro el arreglo
                            break;
                        case 3: // EJERCICIO 3 SHELL SORT
                            Console.Write(" De cuantos numeros desea agregar su arreglo?: ");//pregunta al usuario el tamaño del arreglo
                            tamaño = int.Parse(Console.ReadLine());// se guarda el tamaño del arerglo ingresado
                            array = new int[tamaño];// se crea el arreglo con el tamaño ingresado por el usuario
                            for (int i = 0; i < tamaño; i++)// ciclo for para el llenado del arerglo
                            {
                                Console.Write(" Ingrese el numero para la posicion [{0}]: ", i + 1);// pregunta al usuario el elemento que agregara en la posicion actual del arerglo
                                array[i] = int.Parse(Console.ReadLine());// se agrega el elemento ingresado al arreglo en la posicion actual
                            }
                            Console.WriteLine();
                            Console.WriteLine(" Arreglo no ordenado: ");
                            metodo.ImprimirArreglo(array);//se manda a llamar el metodo para imprimir el arreglo sin ser ordenado mandando como parametro el arreglo
                            metodo.ShellSort(array);// se llama a llamar el metodo de ordenamiento shellsort mandando como parametro el arreglo
                            Console.WriteLine();
                            Console.WriteLine(" Arreglo ordenado: ");
                            metodo.ImprimirArreglo(array);// se vuelve a llamar el metodo para imprimir el arreglo despues de ser ordenado mandando como parametro el arreglo
                            break;
                        case 4: // EJERCICIO 4 QUICK SORT
                            string[] arrayString = new string[] { "Lorem", "ipsum", "dolor", "sit", "amet",      
                                                          "consectetur", "adipiscing", "elit",                   
                                                          "Fusce", "varius",                                     // Se crea un arreglo de tipo string 
                                                          "augue", "vitae", "tincidunt", "virrera",              // con la frase separada por palabras
                                                          "sem", "felis", "bibendum", "nisl",
                                                          "id", "cursus", "diam", "leo", "sit", "amet", "urna",
                                                          "Duis", "ac", "massa", "est"};
                            Console.WriteLine(" Arreglo (frase) no ordenado: ");
                            metodo.ImprimirArregloString(arrayString);//se manda a llamar el metodo para imprimir el arreglo sin ser ordenado mandando como parametro el arreglo
                            metodo.QuickSort(arrayString, 0, arrayString.Length - 1);// se manda a llamar el metodo de ordenamiento Quick sort mandando como parametro el arreglo, el indice del primer elemento del arreglo y el indice del ultimo elmento del arreglo 
                            Console.WriteLine();
                            Console.WriteLine(" Arreglo (frase) ordenado: ");
                            metodo.ImprimirArregloString(arrayString);// se vuelve a llamar el metodo para imprimir el arreglo despues de ser ordenado mandando como parametro el arreglo
                            break;
                    }
                    Console.Write(" Desea volver al menu o salir del programa? (menu/salir): ");
                    string respuesta = Console.ReadLine();
                    if (respuesta.ToUpper() == "SALIR")
                    {
                        condicion = false;
                    }
                    else if (respuesta.ToUpper() == "MENU")
                    {
                        condicion = true;
                    }
                    else
                        Console.WriteLine(" Opcion incorrecta!, reiniciando programa... ");
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (condicion == true);   
        }
    }
}
