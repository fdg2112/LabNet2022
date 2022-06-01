using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class ExcepcionPersonalizada : Exception
    {

        public ExcepcionPersonalizada(string mensaje) : base("No se ha ingresado nada en el dividendo o en el divisor")
        {
            Console.WriteLine(mensaje);
        }

    }
}
