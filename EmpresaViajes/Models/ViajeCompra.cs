using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaViajes.Models
{
    internal class ViajeCompra:Viaje
    {
      
        public ViajeCompra(Transporte transporte, string destino,  double costos, int duracion) 
            : base (transporte,destino, costos, duracion)
        {

        }
        override void AgregarHotel(Hotel hotel)
        {
            base.hotel[0] = hotel;
        }
        
    }
}
