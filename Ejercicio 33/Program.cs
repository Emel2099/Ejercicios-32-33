using System;

namespace Ejercicio_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Realizar un algoritmo que declare 3 arrays de 5 elementos cada uno. 
            // Llenar el vector1 y vector2 y calcular vector3 = vector1 + vector2.

            int[] vector1 = new int[5];
            int[] vector2 = new int[5];
            int[] vector3 = new int[5];

            Console.WriteLine("Ingrese los números/elementos del Vector 1:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Número/Elemento {0}: ", i + 1);
                vector1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nIngrese los números/elementos del Vector 2:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Número/Elemento {0}: ", i + 1);
                vector2[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n--- Suma de los Vectores ---- ");

            for (int i = 0; i < 5; i++)
            {
                vector3[i] = vector1[i] + vector2[i];
            }

            Console.WriteLine("\nEl resultado de la suma del Vector 1 y Vector 2 es:");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(vector3[i]);
            }           
        }
    }
}
