using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica3
{
    class Ejercicio6
    {
        static void Main(string[] args)
        {
            string producto;
            decimal precio, precioF, descuento;
            int cantidad;

            Console.WriteLine("/DESCUENTO/");
            Console.Write("Producto: ");
            producto = Console.ReadLine();
            Console.Write("Precio del producto: \n$");
            precio = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Cantidad: ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            precioF = precio * cantidad;

            if (precioF > 0 && precioF <= 100)
            {
                Console.WriteLine("\nNo aplica el descuento");
                Console.WriteLine("Producto:{0}", producto);
                Console.WriteLine("Total a pagar: ${0}", precioF);
            }

            if (precioF > 100.01m && precioF <= 200)
            {
                Console.WriteLine("\nAplica al 12% de descuento");
                descuento = precioF * 0.12m;
                Console.WriteLine("Producto:{0}", producto);
                Console.WriteLine("Total a pagar: ${0}", precioF - descuento);
            }

            if (precioF > 200.01m && precioF <= 500)
            {
                Console.WriteLine("\nAplica al 15% de descuento");
                descuento = precioF * 0.15m;
                Console.WriteLine("Producto:{0}", producto);
                Console.WriteLine("Total a pagar: ${0}", precioF - descuento);
            }

            if (precioF > 500.01m)
            {
                Console.WriteLine("\nAplica al 20% de descuento");
                descuento = precioF * 0.20m;
                Console.WriteLine("Producto:{0}", producto);
                Console.WriteLine("Total a pagar: ${0}", precioF - descuento);
            }
            Console.ReadKey();
        }
    }
}
