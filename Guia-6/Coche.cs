using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_6
{
    public class Coche : Vehiculo
    {
        public override void RealizarMantenimiento()
        {
            Console.WriteLine("Realizando mantenimiento del coche: Cambio de aceite y revision de frenos.");
        }

        public override double ObtenerCostoMantenimiento()
        {
            return 150.0; // Costo del mantenimiento del coche
        }

        public new void Lavar()
        {
            Console.WriteLine("Lavando el coche con cera y shampoo especial.");
        }
    }
}
