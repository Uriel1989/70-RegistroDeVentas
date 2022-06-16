using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegistroDeVentas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorLeft = 30;

            Console.ForegroundColor = ConsoleColor.Green;

            List<Vendedor> ListaVendedores = new List<Vendedor>();

            List<Venta> ListaVentas = new List<Venta>();

            Console.WriteLine("Ingrese la cantidad de vendedores a los que desea registrar:");

            int CantidadVendedores = Convert.ToInt32(Console.ReadLine());

            for (int i=0; i< CantidadVendedores; i++)
            {
                Vendedor Vendedor = new Vendedor();

                Console.WriteLine("Ingrese nombre del vendedor:");

                Vendedor.Nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el numero de cuenta del vendedor: ");
                Vendedor.NumeroCuenta = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese codigo del vendedor: ");
                Vendedor.Codigo = Convert.ToInt32(Console.ReadLine());



                Console.WriteLine("Ahora vamos a ingresar el nombre y el valor del producto vendida en cada mes: ");
                for (int j=0; j<12; j++)
                {
                    Venta IngresoVentas = new Venta();

                    Console.WriteLine("Ingrese el nombre del producto vendido el mes " + (j + 1));
                    IngresoVentas.NombreProducto = Console.ReadLine();

                    Console.WriteLine("Ingrese el valor del la venta realizada el mes " + (j + 1));
                    IngresoVentas.Precio = Convert.ToInt32(Console.ReadLine());

                    ListaVentas.Add(IngresoVentas);
                }
                ListaVendedores.Add(Vendedor);


            }

            for ( int i=0; i < ListaVendedores.Count; i++)
            {
                Vendedor j = ListaVendedores[i];
                Console.WriteLine(j.Mostrar());
            }

            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");

            Console.WriteLine("Los datos de las ventas son:");

            for (int i = 0; i < ListaVentas.Count; i++)
            {
                Venta j = ListaVentas[i];
                Console.WriteLine(j.Datos());
            }

            Console.ReadKey();
            
        }
    }
}
