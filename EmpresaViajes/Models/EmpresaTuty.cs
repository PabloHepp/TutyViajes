using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaViajes.Models
{
    internal class EmpresaTuty
    {
        // Lista de Viajes Disponibles
        public List<ViajeCompra>[] ListaViajes = new List<ViajeCompra>[20];
        private int cantViajes = 0;
        // Lista de Clientes
        public List<Cliente>[] ListaClientes = new List<Cliente>[50];
        private int cantClientes = 0;
        public EmpresaTuty()
        {
            // Transporte Hardcodeado
            Transporte MicroUno = new Transporte("AAA111", "Cataratas del Iguazú", 50, DateTime.Today, DateTime.Today.AddDays(10), "Juan Perez");
            Transporte MicroDos = new Transporte("AAA000", "Jujuy", 50, DateTime.Today, DateTime.Today.AddDays(15), "Pedro Gimenez");

            // Viajes Harcodeado
            AgregarViaje(new ViajeCompra(MicroUno, "Cataratas del Iguazú", 150000, 10));
            AgregarViaje(new ViajeCompra(MicroDos, "Jujuy", 250000, 15));
            AgregarViaje(new ViajeCompra(MicroUno, "Cordoba", 90000, 7));

            // Clientes Harcodeados
            AgregarCliente(new Cliente(9999999, "Jose Gonzalez", 30));
            AgregarCliente(new Cliente(0000000, "Ana Fernandez", 36));
            AgregarCliente(new Cliente(1111111, "Lionel Messi ", 25));

        }
        public void AgregarViaje(ViajeCompra viaje)
        {
            ListaViajes[cantViajes++].Add(viaje);
        }
        public void AgregarCliente(Cliente clienteNuevo)
        {
            ListaClientes[cantClientes++].Add(clienteNuevo);
        }

    }
}