﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaViajes.Models
{
    public class ViajeCompra:Viaje
    {
      
        public ViajeCompra(Transporte transporte, string destino,  double costos, int duracion) 
            : base (transporte,destino, costos, duracion)
        {

        }
        public override void AgregarHotel(Hotel hotel)
        {
            base.hoteles[0] = hotel;
        }
        
    }
}
