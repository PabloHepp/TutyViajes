using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaViajes.Models
{
    internal class Cliente
    {
        public int DNI { get; private set; }
        public string Nombre { get; private set; }
        public int Edad { get; private set; }

        public Cliente(int dni, string nombre, int edad)
        {
            DNI = dni;
            this.Nombre = nombre;
            this.Edad = edad;
        }

        public override string ToString()
        {
            return $"{DNI}-{Nombre}-{Edad}";
        }


    }
}
