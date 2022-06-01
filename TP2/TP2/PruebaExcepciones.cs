using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class PruebaExcepciones
    {
        public static void PuntoUno()
        {
            int num1 = 10;
            int num2 = 0;
            try
            {
                int resultado = num1 / num2;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Operacion terminada");
            }
        }

        public static void PuntoDos()
        {
            try
            {
                Console.WriteLine("Ingrese dividendo");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese divisor");
                double num2 = Convert.ToDouble(Console.ReadLine());
                if (num2 == 0)
                {
                    throw new DivideByZeroException();
                }
                double resultado = num1 / num2;
                Console.WriteLine($"El resultado es {resultado}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Sólo Goku puede dividir por cero!!!");
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("¡Seguro Ingreso una letra o no ingreso nada!");
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message}");
            }
        }
    }
}
