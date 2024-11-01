using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaViajes.Models
{
    public class Asiento
    {
        public Cliente Pasajero { get; private set; }
        public int NroAsiento { get; private set; }
        public bool Ocupado { get; private set; }

        public Asiento(int numero) 
        {
            NroAsiento = numero;
            Ocupado = false;
        }
        public void AsignarAsiento(Cliente cliente)
        {
            Pasajero = cliente;
            Ocupado = true;
        }
        public void LiberarAsiento()
        {
            if(Ocupado) Ocupado = false;
        }
        public override string ToString()
        {
            return $@"Asiento: {NroAsiento} - {Pasajero.Nombre} - {Pasajero.DNI}";
        }
    }
}
