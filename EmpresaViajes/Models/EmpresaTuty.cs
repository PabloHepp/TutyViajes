using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaViajes.Models
{
    public class EmpresaTuty
    {
        // Lista de Viajes Disponibles
        public List<Viaje>[] ListaViajes = new List<Viaje>[20];
        public int cantViajes = 0;
        //public Viaje this[int idx]
        //{
        //    get
        //    {
                
        //        if (idx >= 0 && idx < ListaViajes.Count())
        //         return ListaViajes[idx]; 
        //        return null;
        //    }
        //}
       
        // Lista de Clientes
        public List<Cliente>[] ListaClientes = new List<Cliente>[50];
        private int cantClientes = 0;
        public EmpresaTuty()
        {
           

        }
        public void AgregarViaje(Transporte t, string nombre, int costo, int dias)
        {
            Viaje v = new ViajeCompra(t, nombre, costo, dias);
            ListaViajes[cantViajes++].Add(v);
        }
        public void AgregarCliente(int dni, string nombre)
        {
            Cliente nuevo = new Cliente(dni, nombre);
            ListaClientes[cantClientes++].Add(nuevo);
        }

    }
}