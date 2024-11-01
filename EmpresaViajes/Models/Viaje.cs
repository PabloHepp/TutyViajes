using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaViajes.Models
{
    public abstract class Viaje
    {
        
        public int id { get; private set; }

        public Transporte transporte;
        public string Destino { get; private set; }
        public double Costo { get; private set; }
        public int Duracion { get; private set; }

        public Hotel[] hoteles = new Hotel[3];

        public Viaje(Transporte transporte, string destino, double costos, int duracion)
        {
            this.transporte = transporte;
            this.Destino = destino;
            this.Costo = costos;
            this.Duracion = duracion;
        }

        public abstract void AgregarHotel(Hotel hot);

    }
}
