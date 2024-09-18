using SistemaAlquilerVehiculo.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlquilerVehiculo
{
    public abstract class Camion : Vehiculo
    {

        public override TipoVehiculo Tipo => TipoVehiculo.CAMIOn;
    }
}
