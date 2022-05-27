using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TransportePublico> transporte = new List<TransportePublico>
            {
                new Colectivo(100),
                new Colectivo(30),
                new Colectivo(10),
                new Colectivo(50),
                new Colectivo(60),
                new Taxi(4),
                new Taxi(2),
                new Taxi(3),
                new Taxi(1),
                new Taxi(2)
            };



            bool salir = false;

            while (!salir)
            {

                try
                {
                    Console.Clear();
                    Console.WriteLine("Bienvenido! Se ha creado una lista con transportes públicos y su cantidad de pasajeros...");
                    Console.WriteLine("Ingresa 1 para ver el listado de transportes con la cantidad de pasajeros");
                    Console.WriteLine("Ingresa 2 para salir del programa");
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            ListarTransporte(transporte);
                            Console.WriteLine("Presione una tecla para volver al menú anterior...");
                            break;
                        case 2:
                            Console.WriteLine("Saliendo... Presione cualquier tecla continuar...");
                            salir = true;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ha ocurrido un error al ingresar la opcion");
                    Console.WriteLine("Detalle del error: " + ex.Message);
                    Console.WriteLine("Presiona cualquier tecla para continuar...");
                }
                Console.ReadKey();
            }
        }

        private static void ListarTransporte(List<TransportePublico> transporte)
        {
            foreach (TransportePublico item in transporte)
            {
                Console.WriteLine($"{item.GetType().Name} Nº {item.idTransporte}: {item.cantidadPasajeros} pasajeros");
            }
        }
    }
}



