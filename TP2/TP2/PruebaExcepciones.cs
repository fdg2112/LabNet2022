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

        public static string PuntoDos(string valor1, string valor2)
        {
            try
            {
                var num1 = Convert.ToDouble(valor1);
                var num2 = Convert.ToDouble(valor2);
                if (num2 == 0)
                {
                    throw new DivideByZeroException();
                }
                double resultado = num1 / num2;
                return $"El resultado es {resultado}";
            }
            catch (DivideByZeroException ex)
            {
                return "Sólo Goku puede dividir por cero!!!";
            }
            catch (FormatException ex)
            {
                return "¡Seguro Ingreso una letra o no ingreso nada!";
            }
            catch (Exception ex)
            {
                return $"Ocurrió el siguiente error: {ex.Message}";
            }
        }
    }
}
