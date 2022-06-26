using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        // Constructor // 
        static void quicksort(int[] arreglo, int izquierda, int derecha)
        {
            // Izquierda es menor que derecha //
            if (izquierda < derecha)
            {
                int indiceParticion = particion(arreglo, izquierda, derecha);
                quicksort(arreglo, izquierda, indiceParticion);
                quicksort(arreglo, indiceParticion + 1, derecha);
            }
        }
        // Constructor // 
        static int particion(int[] arreglo, int izquierda, int derecha)
        {
            int pivote = arreglo[izquierda];
            while (true)
            {

                // Acercar los extremos hacia el centro mientras se encuentren elementos ordenados //

                while (arreglo[izquierda] < pivote)
                {
                    izquierda++;
                }

                while (arreglo[derecha] > pivote)
                {
                    derecha--;
                }
                // Si los extremos se cruzaron o superaron, entonces toda la porción del arreglo estaba ordenada //
                if (izquierda >= derecha)
                {
                    // Regresamos el índice para indicar hasta qué posición el arreglo está en orden //
                    return derecha;
                }
                else
                {
                    // Si no estuvieron ordenados, vamos a hacer el intercambio //
                    int temporal = arreglo[izquierda];
                    arreglo[izquierda] = arreglo[derecha];
                    arreglo[derecha] = temporal;
                    // Y acercamos en 1 los extremos //
                    derecha--; izquierda++;

                }
                // El while se repite hasta que izquierda >= derecha //
            }
        }
        static void Main(string[] args)
        {
            int[] arreglo = { 4, 3, 0, 1, 5, 7, 2, 9, 6 };
            Console.WriteLine("Antes de ordenar: ");
            foreach (int elemento in arreglo)
            {
                Console.Write(elemento);
                Console.Write(",");
            }
            // Ordenar. Recuerda que el arreglo original será modificado //
            Console.WriteLine("");
            quicksort(arreglo, 0, arreglo.Length - 1);
            Console.WriteLine("\nDespués de ordenar: ");
            foreach (int elemento in arreglo)
            {
                Console.Write(elemento);
                Console.Write(",");
            }

        }

    }
}