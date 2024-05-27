using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_6
{
    public class Vehiculo
    {
        public virtual void RealizarMantenimiento()
        {
            Console.WriteLine("Realizando mantenimiento general del vehiculo");
        }

        public virtual double ObtenerCostoMantenimiento()
        {
            return 50.0; // Costo base de mantenimiento general 
        }

        public void Lavar()
        {
            Console.WriteLine("Lavando el vehiculo.");
        }
    }
}
