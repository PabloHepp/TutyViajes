using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaViajes.Models
{
    internal class Hotel
    {
        public int categoria { get; private set; }
        public int comidas {  get; private set; }
        public int habdisponibles { get; private set; }
        public int habocupadas{ get; private set; }

        public Hotel(int categoria, int comidas, int habdisponibles)
        {
            this.categoria = categoria;
            this.comidas = comidas;
            this.habdisponibles = habdisponibles;
            this.habocupadas = 0;
        }


        public bool ConsultarHabitacion()
        {

            if (habocupadas < habdisponibles)
                return true;
            else
                return false;
        }

        public int ReservarHabitacion()

        {
            int habitacion = -1; //si devuelve -1 no se pudo hacer la reserva
            if (ConsultarHabitacion()) //consulto si hay disponibles
            {
                habitacion = habocupadas; 
                habocupadas++; //sumo uno a la pila de habitaciones
            }

            return habitacion; //retorno numero de habitacion
        }
        
        public bool LiberarHabitacion()
        {
            int habitacion = habocupadas;
            if (habitacion > 0)
            {
                habocupadas--;
                return true;
            }
            return false;
        }


            
    }
}
