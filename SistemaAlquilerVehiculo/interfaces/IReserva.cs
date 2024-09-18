using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlquilerVehiculo.interfaces
{
    public interface IReserva
    {

        void Reservar(Cliente cliente, DateTime fechaInicio, DateTime fechaFin);
        void Reservar();
    }
}
