using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica3
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            int minutos, segundos, zona;
            decimal TieLlamada, SeguAgre, Precio;

            Console.WriteLine("/COBRO POR LLAMADA/");
            Console.WriteLine("Duración de la llamada:");
            Console.Write("Minutos: ");
            minutos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundos: ");
            segundos = Convert.ToInt32(Console.ReadLine());

            SeguAgre = segundos * .1m;
            TieLlamada = minutos + SeguAgre;

            Console.WriteLine("Zona de realización de la llamada:");
            Console.WriteLine("[1] Zona Occidental");
            Console.WriteLine("[2] Zona central");
            Console.WriteLine("[3] Zona Oriental");
            zona = Convert.ToInt32(Console.ReadLine());


            switch (zona)
            {
                case 1:
                    Precio = TieLlamada * 0.32m;
                    Console.WriteLine("Costo de la llamada: ${0}", Math.Truncate(Precio * 100) / 100);
                    Console.ReadLine();
                    break;
                case 2:
                    Precio = TieLlamada * 0.25m;
                    Console.WriteLine("Costo de la llamada: ${0}", Math.Truncate(Precio * 100) / 100);
                    Console.ReadLine();
                    break;
                case 3:
                    Precio = TieLlamada * 0.36m;
                    Console.WriteLine("Costo de la llamada: ${0}", Math.Truncate(Precio * 100) / 100);
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Opción errónea");
                    break;
            }
        } 
    }
}
