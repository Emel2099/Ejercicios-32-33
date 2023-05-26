using System;

namespace Ejercicio_32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pedir N números por pantalla y guardarlos en vector. Mostrar el número máximo y el número mínimo.

            int n, maximo, minimo;

            Console.Write("´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´");
            Console.Write("Ingresa el tope de números a ingresar ");
            Console.WriteLine("´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´");
            

            n = int.Parse(Console.ReadLine());

            int[] numbs = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Ingresar el número {0}: ", i + 1);
                numbs [i] = int.Parse(Console.ReadLine());
            }

            maximo = numbs[0];
            minimo = numbs[0];

            for (int i = 1; i < n; i++)
            {
                if (numbs[i] > maximo)
                    maximo = numbs[i];

                if (numbs[i] < minimo)
                    minimo = numbs[i];
            }

            Console.WriteLine("El número máximo es: " + maximo);
            Console.WriteLine("El número mínimo es: " + minimo);        
        }
    }
}
