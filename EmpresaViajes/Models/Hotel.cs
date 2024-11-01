using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaViajes.Models
{
    public class Hotel
    {
        public string Nombre { get; set; }
        public int Categoria { get; private set; }
        public int Habdisponibles { get; private set; }
        public int Habocupadas{ get; private set; }

        public Hotel(string nombre, int categoria, int comidas, int habdisponibles)
        {
            this.Nombre = Nombre;
            this.Categoria = categoria;
            this.Habdisponibles = habdisponibles;
            this.Habocupadas = 0;
        }       

        public bool ConsultarHabitacion()
        {

            if (Habocupadas < Habdisponibles)
                return true;
            else
                return false;
        }

        public int ReservarHabitacion()

        {
            int habitacion = -1; //si devuelve -1 no se pudo hacer la reserva
            if (ConsultarHabitacion()) //consulto si hay disponibles
            {
                habitacion = Habocupadas; 
                Habocupadas++; //sumo uno a la pila de habitaciones
            }

            return habitacion; //retorno numero de habitacion
        }
        
        public bool LiberarHabitacion()
        {
            int habitacion = Habocupadas;
            if (habitacion > 0)
            {
                Habocupadas--;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Hotel {Nombre}-{Categoria}";
        }

    }
}
