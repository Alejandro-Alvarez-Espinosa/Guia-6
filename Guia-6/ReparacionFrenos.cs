using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_6
{
    public class ReparacionFrenos : Servicio
    {
        public override void RealizarServicio()
        {
            Console.WriteLine("Realizando reparacion de frenos");
        }

        public override double CalcularCosto()
        {
            return 100.0; // Costo de reparacion de frenos
        }

        public override double TiempoServicios()
        {
            return 2.0; // Tiempo estimado a repara 2 horas
        }
    }
}
