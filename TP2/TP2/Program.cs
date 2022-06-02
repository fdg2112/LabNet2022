using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2Logica;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Bienvenido!!!");
                    Console.WriteLine("Ingresa 1 para ejecutar el ejercicio 1");
                    Console.WriteLine("Ingresa 2 para ejecutar el ejercicio 2");
                    Console.WriteLine("Ingresa 3 para ejecutar el ejercicio 3");
                    Console.WriteLine("Ingresa 4 para ejecutar el ejercicio 4");
                    Console.WriteLine("Ingresa 5 para salir");
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    salir = Menu.Opciones(opcion);
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Presione una tecla para volver al menú anterior...");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Detalle del error: " + ex.Message);
                    Console.WriteLine("Presiona cualquier tecla para continuar...");
                }
                Console.ReadKey();
            }
        }
    }
}
