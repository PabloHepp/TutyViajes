using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaViajes.Models
{
    internal class Cliente
    {
        public int Dni { get; private set; }
        public string nombre { get; private set; }
        public int edad { get; private set; }

        public Cliente(int dni, string nombre, int edad)
        {
            Dni = dni;
            this.nombre = nombre;
            this.edad = edad;
        }

    }
}
