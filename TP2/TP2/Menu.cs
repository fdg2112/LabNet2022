using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2Logica;

namespace TP2
{
    public class Menu
    {
        public static void Opciones(int opcion)
        {
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
                case 5:
                    Environment.Exit(0);
                    break; 
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
