using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaViajes.Models
{
    internal class Transporte
    {
        public string Patente { get; private set; }
        public string Destino { get; private set; }
        public Asiento[] ListaAsientos { get; private set; }
        public DateTime Salida { get; private set; }
        public DateTime Llegada { get; private set; }
        public string conductor;

        public Transporte(string patente, string destino, int cantAsientos, DateTime salida, DateTime llegada, string conductor) {

            this.Patente = patente;
            this.Destino = destino;
            this.ListaAsientos = new Asiento[cantAsientos];
            this.Salida = salida;
            this.Llegada = llegada;
            this.conductor = conductor;

            for (int i = 1; i <= cantAsientos; i++)
            {
                // Numero de Asiento es indice + 1
                ListaAsientos[i - 1] = new Asiento(i);
            }
        }
        public bool ConsultarAsiento(int numero)
        {
            if (numero <= ListaAsientos.Length)
            {
                return ListaAsientos[numero - 1].Ocupado;
            }
            return false;
        }
        public bool ReservarAsiento(Cliente pasajero, int numero)
        {
            if (!ConsultarAsiento(numero))
            {
                ListaAsientos[numero].AsignarAsiento(pasajero);
                return true;
            }
            else { return false; }
        }
        public string[] VerListaPasajeros()
        {
            string[] listaResultado = new string [ListaAsientos.Length];

            for (int i = 0; i < ListaAsientos.Length; i++) 
            {
                listaResultado[i] = ListaAsientos[i].ToString();
            }
            return listaResultado;
        }
        public override string ToString()
        {
            return $@"Patente: {Patente}, Capacidad:{ListaAsientos.Length} Conductor: {conductor} - Destino: {Destino}";
        }
    }
}
