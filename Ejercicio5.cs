using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica3
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ingrese un número del 1 al 10:");
            num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("UNO");
                    break;
                case 2:
                    Console.WriteLine("DOS");
                    break;
                case 3:
                    Console.WriteLine("TRES");
                    break;
                case 4:
                    Console.WriteLine("CUATRO");
                    break;
                case 5:
                    Console.WriteLine("CINCO");
                    break;
                case 6:
                    Console.WriteLine("SEIS");
                    break;
                case 7:
                    Console.WriteLine("SIETE");
                    break;
                case 8:
                    Console.WriteLine("OCHO");
                    break;
                case 9:
                    Console.WriteLine("NUEVE");
                    break;
                case 10:
                    Console.WriteLine("DIEZ");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Ingrese un número entre 1 y 10");
                    break;
            }
        }
    }
}
