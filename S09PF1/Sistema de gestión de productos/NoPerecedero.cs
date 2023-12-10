using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_gestión_de_productos;

namespace Sistema_de_gestión_de_productos
{
    class NoPerecedero : Producto
    {
        string categoria;
        public NoPerecedero(string nombre, string tipo, float precio, string categoria) : base(nombre,tipo,precio)
        {
            this.Categoria = categoria;
        } 
        public string Categoria 
        { 
         get{ return categoria;}
         set{ categoria = value; }
        }
        public override string mostrarDatos() {
            return "Nombre: " + Nombre + ". Tipo: " + Tipo + ". Precio: " + Precio + ". Categoría: " + Categoria+".";
        }
    }
}
