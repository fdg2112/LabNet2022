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
                    Console.WriteLine("Ingresa 5 para ejecutar el ejercicio 5");
                    Console.WriteLine("Ingresa 5 para salir");
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (opcion)
                    {
                        case 1:
                            PruebaExcepciones.PuntoUno();
                            break;
                        case 2:
                            Console.WriteLine("Ingrese dividendo");
                            string valor1 = Console.ReadLine();
                            Console.WriteLine("Ingrese divisor");
                            string valor2 = Console.ReadLine();
                            var res = PruebaExcepciones.PuntoDos(valor1, valor2);
                            Console.WriteLine(res);
                            break;
                        case 3:
                            Logic.PuntoTres();
                            break;
                        case 4:
                            Logic.PuntoCuatro();
                            break;
                        case 6:
                            Console.WriteLine("Saliendo... Presione cualquier tecla continuar...");
                            salir = true;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
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
