using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaViajes.Models
{
    public class Cliente
    {
        public int DNI { get; private set; }
        public string Nombre { get; private set; }
        
        public string ViajeComprado
        {
            get
            {
                string viaje = $"";
                return viaje;
            }

            set
            {

            }
        }
        //Historial de viajes
        //static string[] Viajes { get; private set; }

        public Cliente(int dni, string nombre)
        {
            DNI = dni;
            this.Nombre = nombre;
        }
        //Registrar la info del viaje comprado
        public void RegistrarViaje(int id, string desntino)
        { }
        public override string ToString()
        {
            return $"{DNI}-{Nombre}";
        }


    }
}
