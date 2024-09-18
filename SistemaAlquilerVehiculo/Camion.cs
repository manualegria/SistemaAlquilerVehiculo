using SistemaAlquilerVehiculo.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlquilerVehiculo
{
    // Clase 'Camion' que hereda de 'Vehiculo'.
    // Implementa el tipo específico de vehículo 'CAMION'.
    public class Camion : Vehiculo
    {
        // Constructor que pasa los parámetros requeridos al constructor de la clase base 'Vehiculo'.
        public Camion(string marca, string modelo, int anio, decimal precioAlquiler)
            : base(marca, modelo, anio, precioAlquiler, TipoVehiculo.CAMION)
        {
        }

        // Sobrescribe la propiedad Tipo para especificar que es un CAMION.
        public override TipoVehiculo Tipo => TipoVehiculo.CAMION;
    }
}
