using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    abstract class Animales
    {
        string _especie;
        int _cantidadPatas;
        string _nombre;
        string _duenio;
        bool activo;

        public Animales(string especie, string nombre, string duenio)
        {
            this._especie = especie;
            this._nombre = nombre;
            this._duenio = duenio;
            this.activo = true;
        }
        public virtual string Listar()
        {
            return "Nombre: " + _nombre + "\tdueño: " + _duenio + "\tEspecie: " + _especie;
        }
        public string baja()
        {
            if (!this.activo)
                return "El anumal ya estaba dado de baja";
            else
            { 
                this.activo = false;
                return "Baja ok";
            }
        }
    }
}
