namespace Guia_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~~~~~~~ Bienvenidos amantes de los coches y las motos ~~~~~~~~~~~~");
            Console.WriteLine($"\n");

            Vehiculo miCoche = new Coche();
            miCoche.RealizarMantenimiento(); // Output: Realizando mantenimiento del coche: Cambio de aceite y revision de frenos
            Console.WriteLine("Costo de mantenimiento del coche: $" + miCoche.ObtenerCostoMantenimiento());

            miCoche.Lavar();                 // Output: Lavando el coche 
            Coche miCocheReal = new Coche();
            miCocheReal.Lavar();             // Output: Lavando el coche con cera y shampoo especial

            Servicio serAceite = new CambioAceite();
            serAceite.RealizarServicio();   // Output: Realizando cambio de aceite
            Console.WriteLine("Costo del cambio de aceite: $" + serAceite.CalcularCosto());

            Servicio serFrenos = new ReparacionFrenos();
            serFrenos.RealizarServicio();   // Output: Realizando reparacion de frenos
            Console.WriteLine("Costo de la reparacion de frenos: $" + serFrenos.CalcularCosto());
            Console.WriteLine($"\n");
           
            Vehiculo miMoto = new Moto();
            miMoto.RealizarMantenimiento(); // Output: Realizando mantenimiento de la moto: Lubricacion de la cadena y revision de neumaticos
            Console.WriteLine("Costo de mantenimiento de la moto: $" + miMoto.ObtenerCostoMantenimiento());
            Console.WriteLine($"\n");

            Console.WriteLine("---Servicios del Coche---");
            Servicio Tservicio = new CambioAceite();
            Tservicio.TiempoServicios();
            Console.Write("Estimado cliente el tiempo para el cambio de aceite es de: " + Tservicio.TiempoServicios()); Console.WriteLine("Horas");
            

            Servicio TServicio = new ReparacionFrenos();
            TServicio.TiempoServicios();
            Console.Write("Estimado cliente el tiempo para reparar los frenos es de: " + TServicio.TiempoServicios()); Console.WriteLine("Horas");
        }
    }
}
