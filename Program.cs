using System;

namespace Práctica3
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas, minutos, segundos;
            Console.Write("Tiempo en horas: ");
            horas = Convert.ToInt32(Console.ReadLine());

            if (horas < 0)
            {
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("");
                minutos = horas * 60;
                Console.WriteLine("Minutos: " + minutos);
                Console.WriteLine("");
                segundos = minutos * 60;
                Console.WriteLine("Segundos: " + segundos);
                Console.ReadKey();
            }
        }
    }
}
