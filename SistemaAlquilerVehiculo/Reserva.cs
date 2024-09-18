
namespace SistemaAlquilerVehiculo
{

    // Representa una reserva de un vehículo por un cliente.
    public class Reserva
    {
        public string Cliente { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        // Constructor de la clase Reserva.
        public Reserva(string cliente, Vehiculo vehiculo, DateTime fechaInicio, DateTime fechaFin)
        {
            Cliente = cliente;
            Vehiculo = vehiculo;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }

        // Método para mostrar la información de la reserva.
        // El tipo de retorno es 'void' porque este método solo imprime en la consola y no devuelve un valor.
        public void MostrarReserva()
        {
            Console.WriteLine($"Cliente: {Cliente}, Vehículo: {Vehiculo.Marca} {Vehiculo.Modelo}, Desde: {FechaInicio.ToShortDateString()}, Hasta: {FechaFin.ToShortDateString()}");
        }
    }
}