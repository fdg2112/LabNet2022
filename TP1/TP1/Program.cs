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
            TransportePublico[] transporte = new TransportePublico[10];

            Console.WriteLine("Bienvenido! Presiona cualquier tecla para cargar a continuación la cantidad de pasajeros de cada transporte...");
            Console.ReadKey();
            CargarListado(transporte);

            bool salir = false;

            while (!salir)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Ingresa 1 para ver el listado de transportes con la cantidad de pasajeros");
                    Console.WriteLine("Ingresa 2 para salir del programa");
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            MostrarListado(transporte);
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

        private static void MostrarListado(TransportePublico[] transporte)
        {
            Console.Clear();
            foreach (TransportePublico item in transporte)
            {
                Console.WriteLine($"{item.GetType().Name} Nº {item.idTransporte}: {item.cantidadPasajeros} pasajeros");
            }
            Console.WriteLine("Presione una tecla para volver al menú anterior...");
        }

        private static void CargarListado(TransportePublico[] transporte)
        {
            Console.Clear();
            int j = 1;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine($"Ingrese cantidad de pasajeros de 0 a 100 para el Colectivo Nº {j}");
                int cantidad;
                bool cantidadCorrecta = false;
                do
                {
                    try
                    {
                        cantidad = Convert.ToInt32(Console.ReadLine());
                        if (cantidad >= 0 && cantidad <= 100)
                        {
                            transporte[i] = new Colectivo(cantidad);
                            cantidadCorrecta = true;
                        }
                        else Console.WriteLine("Cantidad de pasajeros mal ingresada. Vuelva a hacerlo");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ha ocurrido un error al ingresar la cantidad de pasajeros");
                    Console.WriteLine("Detalle del error: " + ex.Message);
                    Console.WriteLine("Ingrese nuevamente la cantidad...");
                }
                } while (cantidadCorrecta == false);
                ++j;
            }
            j = 1;
            for (int i = 5; i < 10; i++)
            {
                Console.Clear();
                Console.WriteLine($"Ingrese cantidad de pasajeros de 0 a 4 para el Colectivo Nº {j}");
                int cantidad;
                bool cantidadCorrecta = false;
                do
                {
                    try
                    {
                        cantidad = Convert.ToInt32(Console.ReadLine());
                        if (cantidad >= 0 && cantidad <= 4)
                        {
                            transporte[i] = new Taxi(cantidad);
                            cantidadCorrecta = true;
                        }
                        else Console.WriteLine("Cantidad de pasajeros mal ingresada. Vuelva a hacerlo");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ha ocurrido un error al ingresar la cantidad de pasajeros");
                        Console.WriteLine("Detalle del error: " + ex.Message);
                        Console.WriteLine("Ingrese nuevamente la cantidad...");
                    }
                } while (cantidadCorrecta == false);
                ++j;
            }
            Console.WriteLine("Presione una tecla para volver al menú anterior...");
        }
    }
}





