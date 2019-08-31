using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica3
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            Random i = new Random(DateTime.Now.Millisecond);
            int iAleatorio = i.Next(100);
            Console.WriteLine("Número generado: " + iAleatorio);
            Console.WriteLine("");

            if (iAleatorio % 2 == 0)
            {

                Console.Write("Número par");
            }
            else
            {
                Console.Write("Número impar");
            }

            Console.ReadKey();
        }
    }
}
