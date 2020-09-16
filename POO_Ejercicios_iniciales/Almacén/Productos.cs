using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacén
{
    class Productos
    {
        private string _nombre;
        private string _tipoProducto;
        private int _stock;
        private float _precio;
        private bool _disponible;

        public Productos(string nombre,string tipo)
        {
            this._nombre = nombre;
            this._tipoProducto = tipo;
        }
        public Productos(string nombre, string tipo, int stock, float precio):this(nombre,tipo)
        {
            if (stock < 0)
                throw new Exception();
            else
            { 
                this._stock = stock;
                this._precio = precio;
                this._disponible = true;
            }
        }
                
        public float Precio
        {
            get { return this._precio; }
            set { this._precio = value; }
        }
        public string TipoProducto
        {
            get { return this._tipoProducto; }
            set { this._tipoProducto = value; }
        }

        public void Comprar(int cantidad)
        {
            this._stock += cantidad;            
        }
        public void Comprar()
        {
            this._stock++;
        }
        public string vender(int cantidad)
        {
            if (this._stock < cantidad)
                return "No hay stock suficiente para la venta";
            else 
            {
                this._stock -= cantidad;
                return "Producto vendido";
            }
        }

        public string vender()
        {
            if (this._stock == 0)
                return "No hay stock suficiente para la venta";
            else
            {
                this._stock = this._stock - 1;
                return "Producto vendido";
            }
        }
        public void VerificarStock()
        {
            if (this._stock <= 0)
                this._disponible = false;
            else
                this._disponible = true;
        }        

        public override string ToString()
        {
            return string.Format("Producto: {0} -- Tipo: {1} -- Precio: {2} -- Stock: {3} -- Disponible: {4}",this._nombre,this.TipoProducto,this.Precio,this._stock, this._disponible);
        }

    }
}
