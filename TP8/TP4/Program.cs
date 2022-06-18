using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Bienvenido!!!");
                    Console.WriteLine("Ingresa 1 para listar los proveeodres");
                    Console.WriteLine("Ingresa 2 para listar las transportistas");
                    Console.WriteLine("Ingresa 3 para agregar un proveedor");
                    Console.WriteLine("Ingresa 4 para agregar un transportista");
                    Console.WriteLine("Ingresa 5 para eliminar un proveedor");
                    Console.WriteLine("Ingresa 6 para eliminar un transportista");
                    Console.WriteLine("Ingresa 7 para modificar un proveedor");
                    Console.WriteLine("Ingresa 8 para modificar un transportista");
                    Console.WriteLine("Ingresa 9 para salir");
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Menu.Opciones(opcion);
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Presione una tecla para volver al menú anterior o Escape para salir...");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Detalle del error: " + ex.Message);
                    Console.WriteLine("Presiona cualquier tecla para continuar o Escape para salir......");
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}