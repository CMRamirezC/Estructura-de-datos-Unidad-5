using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad_5
{
    class Metodos
    {
        // METODOS PARA EJERCICIO 1 (BUBBLE SORT)
        public void BubbleSort(int[] array)
        {
            int temp;
            for(int i = 0; i < array.Length; i++) // ciclo for anidado para:
            {
                for(int j = 1; j < array.Length; j++)
                {
                    if(array[j - 1] > array[j]) // si el elemento en la posicion anterior es mayor al elemento de la posicion actual 
                    {
                        temp = array[j]; // se guarda el elemento en la posicion actual en la variable temporal
                        array[j] = array[j - 1]; // el elemento de la posicion anterior se guarda en la posicion actual
                        array[j - 1] = temp; // se guarda el elemento temporal en la posicion anterior 
                    }
                }
            }
        }

        // METODOS PARA EJERCICIO 2 (RADIX SORT)
        public bool Comprobacion(int[] array, int indice, int num) // metodo para comprobar si el numero random ya se encuentra en el arreglo
        {
            for(int i = 0; i < indice; i++)//ciclo desde 0 hasta el indice
            {
                if(array[i] == num)// si el elemento en la posicion actual es igual al numero enviado como parametro
                {
                    return true; // retorna un true
                }
            }
            return false; // en caso de no cumplirse la condicion retorna un false
        }
        public void RadixSort(int[] array)
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

        // METODOS PARA EJERCICIO 3 (SHELL SORT)
        public void ShellSort(int[] array)
        {
            int tamaño = array.Length; // variable para guardar el tamaño del arreglo
            int gap = tamaño / 2; // variable para guardar la posicion media
            int temporal; // variable para guardado temporal de un dato 
            while (gap > 0)//mientras que la variable gap sea mayor a cero
            {
                for (int i = 0; i + gap < tamaño; i++)// ciclo for desde 0 hasta que i mas la variable gap sea mayor al tamaño del arreglo
                {
                    int j = i + gap; // variable para guardar la suma de i mas gap
                    temporal = array[j]; // se guarda el elemento en la posicion j como temporal
                    while (j - gap >= 0 && temporal < array[j - gap]) // mientras que j - gap sea mayor/igual a 0  y  el elemento temporal sea menor al elemento en la posicion j - gap
                    {
                        array[j] = array[j - gap];// se guardara el elemento de la posicion j - gap en la posicion j
                        j = j - gap;// j sera igual a j - gap
                    }
                    array[j] = temporal;// se guarda el elemento temporal en la posicion j del arreglo
                }
                gap = gap / 2;// se calcula gap como gap entre 2
            }
        }

        // METODOS PARA EJERCICIO 4 (QUICK SORT)
        public  void QuickSort(string[] nums, int izquierda, int derecha)//metodo para ordenar el arreglo con datos de tipo int 
        {
            int i = izquierda, j = derecha;
            int pivote = (izquierda + derecha) / 2;//se declara el pivote (posicion del valor que se encuentra a mitad del  arreglo
            while (i <= j)// hasta que i sea menor o igual j
            {
                while (Convert.ToInt32(nums[i].ToUpper().Substring(0)[0]) < Convert.ToInt32(nums[pivote].ToUpper().Substring(0)[0]))// mientras que el dato en la posicion i sea menor a el pivote, se extrajo el primer caracter del elemento tipo strin para convertirlo en su numero ascci y asi poder compararlos
                {
                    i++;// aumenta i
                }
                while (Convert.ToInt32(nums[j].ToUpper().Substring(0)[0]) > Convert.ToInt32(nums[pivote].ToUpper().Substring(0)[0]))// mientras que el dato en la posicion j sea mayor al pivote, se extrajo el primer caracter del elemento tipo strin para convertirlo en su numero ascci y asi poder compararlos
                {
                    j--;// disminuye j 
                }
                if (i <= j)// si i es menor o igual a j
                {
                    string temp = nums[i];// se guarda el dato en la posicion i como temporal
                    nums[i] = nums[j];// se guarda el dato en la posicion j como el dato de la posicion i
                    nums[j] = temp;// se guarda el dato que estaba como temporal en la posicion j 
                    i++;// aumenta i
                    j--;// disminuye j 
                }
            }
            if (izquierda < j)// si el valor de izquierda es menor a j
            {
                QuickSort(nums, izquierda, j);// llama al metodo mandando coo parametros el arreglo, el valor de izquierda y el valor de j
            }
            if (i < derecha)// si i es menor a derecha
            {
                QuickSort(nums, i, derecha);// llama al metodo mandando como parametros el arreglo, el valor de i y el valor de derecha 
            }
        }

        // METODOS DE IMPRESION
        public void ImprimirArreglo(int[] array)// metodo para imprimir un arreglo con datos int
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("[{0}]" + " ", array[i]);
            }
            Console.WriteLine();
        }
        public void ImprimirArregloString(string[] array)// metodo para imprimir un arreglo con datos string
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("[{0}]" + " ", array[i]);
            }
            Console.WriteLine();
        }
    }
}
