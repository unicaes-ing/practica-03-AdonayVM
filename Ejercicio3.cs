using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica3
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            int N1, N2, N3;
            Console.Write("Ingrese un numero: ");
            N1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese un numero: ");
            N2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese un numero: ");
            N3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (N1 < N2 && N1 < N3)
            {
                Console.WriteLine(N1);
            }
            else
            {
                if (N2 < N1 && N2 < N3)
                {
                    Console.WriteLine(N2);
                }
                else
                {
                    if (N3 < N1 && N3 < N2)
                    {
                        Console.WriteLine(N3);
                    }
                }
            }
            if (N1 > N2 && N1 < N3)
            {
                Console.WriteLine(N1);
            }
            else
            {
                if (N2 > N1 && N2 < N3)
                {
                    Console.WriteLine(N2);
                }
                else
                {
                    if (N3 > N1 && N3 < N2)
                    {
                        Console.WriteLine(N3);
                    }
                }
            }
            if (N1 > N2 && N1 > N3)
            {
                Console.WriteLine(N1);
            }
            else
            {
                if (N2 > N1 && N2 > N3)
                {
                    Console.WriteLine(N2);
                }
                else
                {
                    if (N3 > N1 && N3 > N2)
                    {
                        Console.WriteLine(N3);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
