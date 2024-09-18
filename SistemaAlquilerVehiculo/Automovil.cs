using SistemaAlquilerVehiculo.enums;
using SistemaAlquilerVehiculo.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlquilerVehiculo
{
    public class Automovil : Vehiculo, IReserva, IDevuelve
    {
        // Constructor
        public Automovil(string marca, string modelo, int anio, decimal precioAlquiler)
            : base(marca, modelo, anio, precioAlquiler, TipoVehiculo.AUTOMOVIL) { }

        // Métodos de la interfaz IReserva
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

        // Métodos de la interfaz IDevuelve
        public void Devolver()
        {
            if (Estado == EstadoVehiculo.ALQUILADO)
            {
                CambiarEstado(EstadoVehiculo.DISPONIBLE);
                Console.WriteLine($"El automóvil {Marca}, {Modelo} ha sido devuelto.");
            }
            else
            {
                Console.WriteLine("Este automóvil no estaba alquilado.");
            }
        }
    }
