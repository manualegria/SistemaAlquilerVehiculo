using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlquilerVehiculo
{
    internal class Automovil
    {
    }
    public class Automovil : Vehiculo 
    {

        public Automovil(string marca, string modelo, int anio, decimal precioAlquiler)
             : base(marca, modelo, anio, precioAlquiler) { }


        public void Devolver()
        {

            if (Estado == EstadoVehiculo.ALQUILADO)
            {
                Console.WriteLine($"El automóvil {Marca}, {Modelo} ha sido devuelto.");
            }

        }
        public void Reservar()
        {
            if (Estado == EstadoVehiculo.DISPONIBLE)
            {
                CambiarEstado(EstadoVehiculo.ALQUILADO);
                Console.WriteLine($"El automóvil {Marca}, {Modelo} ha sido reservado.");
            }
            else
            {
                Console.WriteLine("Este automóvil no está disponible.");
            }
        }

    }
}
