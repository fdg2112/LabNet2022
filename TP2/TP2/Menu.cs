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
        public static bool Opciones(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    PruebaExcepciones.PuntoUno();
                    return false;
                case 2:
                    Console.WriteLine("Ingrese dividendo");
                    string valor1 = Console.ReadLine();
                    Console.WriteLine("Ingrese divisor");
                    string valor2 = Console.ReadLine();
                    var res = PruebaExcepciones.PuntoDos(valor1, valor2);
                    Console.WriteLine(res);
                    return false;
                case 3:
                    Logic.PuntoTres();
                    return false;
                case 4:
                    Logic.PuntoCuatro();
                    return false;
                case 5:
                    Console.WriteLine("Saliendo... Presione cualquier tecla continuar...");
                    return true;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
