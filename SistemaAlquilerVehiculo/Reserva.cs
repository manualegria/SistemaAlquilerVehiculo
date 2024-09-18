

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlquilerVehiculo
{
    // Representa una reserva de un vehículo por un cliente.
    public class Reserva
    {
        public Vehiculo Vehiculo { get; private set; }
        public string Cliente { get; private set; }
        public DateTime FechaInicio { get; private set; }
        public DateTime FechaFin { get; private set; }

        public Reserva(Vehiculo vehiculo, string cliente, DateTime fechaInicio, DateTime fechaFin)
        {
            Vehiculo = vehiculo;
            Cliente = cliente;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }
    


    public void MostrarReserva()
        {
            Console.WriteLine($"Cliente: {Cliente}, Vehículo: {Vehiculo.Marca} {Vehiculo.Modelo}, Desde: {FechaInicio}, Hasta: {FechaFin}");
        }
    }

}

