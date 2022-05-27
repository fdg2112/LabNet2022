using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TP1
{
    public class Colectivo : TransportePublico
    {
        static int nextId;

        public Colectivo(int cantidadPasajeros) : base(cantidadPasajeros)
        {
            idTransporte = Interlocked.Increment(ref nextId);
        }

        public override string Avanzar()
        {
            return "El colectivo avanza";
        }

        public override string Detenerse()
        {
            return "El colectivo se detuvo";
        }
    }
}
