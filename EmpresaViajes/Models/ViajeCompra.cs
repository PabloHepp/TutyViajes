using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaViajes.Models
{
    internal class ViajeCompra
    {
        public int ID { get;private set; }
        public Hotel hotel;
        public Transporte transporte;
        public string destino { get; private set;}
        public double costos { get; private set;}
        public int duracion {  get; private set;}


        public ViajeCompra(Transporte transporte, string destino,  double costos, int duracion)
        {
            this.transporte = transporte;
            this.destino = destino;
            this.costos = costos;
            this.duracion = duracion;

        }
    }
}
