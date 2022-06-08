using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4;
using TP4.Logic;

namespace TP2
{
    public static class Menu
    {
        public static void Opciones(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    Listar.MostrarProveedores();
                    break;
                case 2:
                    Listar.MostrarTransportistas();
                    break;
                case 3:
                    Altas.AgregarProveedor();
                    break;
                case 4:
                    Altas.AgregarTransportista();
                    break;
                case 5:
                    Bajas.BajaProveedor();
                    break;
                case 6:
                    Bajas.BajaTransportista();
                    break;
                case 7:
                    Modificaciones.ModificarProveedor();
                    break;
                case 8:
                    Modificaciones.ModificarTransportista();
                    break;
                case 9:
                    Environment.Exit(0);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}