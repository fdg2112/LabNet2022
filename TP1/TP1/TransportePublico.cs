using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public abstract class TransportePublico
    {
        public TransportePublico (int cantidadPasajeros)
        {
            this.cantidadPasajeros = cantidadPasajeros;
        }

        public int idTransporte { get; set; }
        public int cantidadPasajeros { get; set; }

        public abstract string Avanzar();

        public abstract string Detenerse();

    }
}
