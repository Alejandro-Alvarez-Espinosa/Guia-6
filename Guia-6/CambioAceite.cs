using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_6
{
    public class CambioAceite : Servicio
    {
        public override void RealizarServicio()
        {
            Console.WriteLine("Realizando cambio de aceite.");
        }

        public override double CalcularCosto()
        {
            return 50.0; // Costo por cambio de aceite
        }

        public override double TiempoServicios()
        {
            return 3; // Tiempo estimado 3 horas
        }

    }
}
