using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2Logica
{
    public class Logic
    {
        public static void PuntoTres()
        {
            try
            {
                int? num1 = null;
                int num2 = 10;
                Console.WriteLine($"Dividendo: {num1}");
                Console.WriteLine($"Divisor: {num2}");
                Console.WriteLine(num1.Value / num2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine($"Mensaje de la excepción: {ex.Message}");
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine($"StackTrace de la excepción: {ex.StackTrace}");
            }
        }

        public static void PuntoCuatro()
        {
            try
            {
                int? num1 = null;
                int num2 = 10;
                Console.WriteLine($"Dividendo: {num1}");
                Console.WriteLine($"Divisor: {num2}");
                Console.WriteLine(num1.Value / num2);
            }
            catch
            {
                throw new ExcepcionPersonalizada("No se ha ingresado un valor en alguno de los operadores");
            }
        }
    }
}
