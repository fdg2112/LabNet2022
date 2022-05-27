using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TP1
{
    public class Taxi : TransportePublico
    {
        static int nextId;

        public Taxi(int cantidadPasajeros) : base(cantidadPasajeros)
        {
            idTransporte = Interlocked.Increment(ref nextId);
        }

        public override string Avanzar()
        {
            return "El taxi avanza";
        }

        public override string Detenerse()
        {
            return "El taxi se detuvo";
        }
    }
}
