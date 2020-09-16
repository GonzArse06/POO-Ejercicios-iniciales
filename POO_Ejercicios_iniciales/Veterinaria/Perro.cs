using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    class Perro:Animales
    {
        string _raza;
        public Perro(string nombre, string duenio, string raza) : base("Perro", nombre, duenio)
        {
            this._raza = raza;
        }
        public override string Listar()
        {
            return base.Listar()+"\tRaza: "+_raza;
        }
    }
}
