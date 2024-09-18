using SistemaAlquilerVehiculo.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlquilerVehiculo
{
    public abstract class Motocicleta : Vehiculo
    {
        protected Motocicleta(string marca, string modelo, int anio, decimal precioAlquiler, TipoVehiculo aUTOMOVIL) : base(marca, modelo, anio, precioAlquiler, aUTOMOVIL)
        {
        }

        public override TipoVehiculo Tipo => TipoVehiculo.MOTOCICLETA;
    }
}
