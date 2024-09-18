using SistemaAlquilerVehiculo.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlquilerVehiculo
{

    // Clase abstracta que representa un vehículo genérico.
    public abstract class Vehiculo
    {
        // Propiedades básicas del vehículo
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public EstadoVehiculo Estado { get; set; }
        public decimal PrecioAlquiler { get; private set; }

        // Propiedad abstracta Tipo (solo lectura)
        public abstract TipoVehiculo Tipo { get; }

        // Constructor
        public Vehiculo(string marca, string modelo, int anio, decimal precioAlquiler)
        {
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            PrecioAlquiler = precioAlquiler;
            Estado = EstadoVehiculo.DISPONIBLE;
        }

        // Método para cambiar el estado del vehículo
        public void CambiarEstado(EstadoVehiculo nuevoEstado)
        {
            Estado = nuevoEstado;
        }

        // Mostrar la información del vehículo
        public void MostrarInformacion()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Año: {Anio}, Precio Alquiler: {PrecioAlquiler}, Estado: {Estado}");
        }
    }
}