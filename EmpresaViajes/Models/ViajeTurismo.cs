using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaViajes.Models
{
    internal class ViajeTurismo:ViajeCompra
    {
        public Enum Excursiones { get; private set; }
        public int cantExcursiones { get; private set; }

        public ViajeTurismo(Transporte transporte, string destino, double costos, int duracion, int excursiones) : base (transporte, destino, costos, duracion)
        {
            this.cantExcursiones = excursiones;
        }

        public string ElegirExcursion(int excursion)
        { 
            if (excursion )
        }
    }
}
