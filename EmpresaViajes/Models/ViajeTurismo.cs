using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaViajes.Models
{
    internal class ViajeTurismo:Viaje
    {
        public bool ExcursionesNocturna { get; private set; }

        public int cantPaseos { get; private set; }

        public ViajeTurismo(Transporte transporte, string destino, double costos, int duracion, int paseos) : base (transporte, destino, costos, duracion)
        {
            this.cantPaseos = paseos;
        }

        public override void AgregarHotel(Hotel hotel)
        {
            base.hoteles[0] = hotel;
        }

        //public string ElegirExcursion(int excursion)
        //{
        //    if (excursion)
        //        return cantExcursiones;
        //}
    }
}
