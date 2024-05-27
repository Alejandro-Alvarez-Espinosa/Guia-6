using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_6
{
    public class Moto : Vehiculo
    {
        public override void RealizarMantenimiento()
        {
            Console.WriteLine("Realizando mantenimiento de la moto: Lubricacion de la cadena y revision de neumaticos.");
        }

        public override double ObtenerCostoMantenimiento()
        {
            return 100.0; // Costo del mantenimiento de la moto
        }

    }
}
