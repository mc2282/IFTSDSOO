using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_gestión_de_productos;

namespace Sistema_de_gestión_de_productos 
{
    abstract class Producto
    {
        public string nombre;
        public string tipo;
        public float precio;

        public Producto(string nombre, string tipo, float precio)
        {
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.Precio = precio;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public virtual float calcularPrecioTotal(int cantidad)
        { 
            float precioTotal = Precio * cantidad;
            return precioTotal;
        }
        public virtual string mostrarDatos()
        {
            return "Nombre: " + Nombre + ". Tipo: " + Tipo + ". Precio: " + Precio;
        }
    }
}
