using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_gestión_de_productos;

namespace Sistema_de_gestión_de_productos
{
    class Perecedero : Producto
    {
        public int diasCaducar;
        public Perecedero(string nombre, string tipo, float precio, int diasCaducar) : base(nombre, tipo, precio)
        {
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.Precio = precio;
            this.DiasCaducar = diasCaducar;
        }
        public int DiasCaducar
        {
            set { diasCaducar = value; }
            get { return diasCaducar; }
        }
        public override float calcularPrecioTotal(int cantidad)
        {
            precioDiasCaducar();
            return Precio * cantidad;
        }
        public void precioDiasCaducar()
        {
            if (diasCaducar == 1)
            {
                Precio = Precio - (Precio /4);
            }
            else if (diasCaducar == 2)
            {
                Precio = Precio - (Precio / 3);
            }
            else if (diasCaducar == 3)
            {
                Precio = (float)(Precio - (Precio /2));
            }
            else
            {
                Precio = Precio;
            }
        }
        public override string mostrarDatos()
        {
            return "Nombre: "+ Nombre + ". Tipo: " + Tipo + ". Precio: " + Precio + ". Días para caducar: " + DiasCaducar+ ".";
        }
    }
}
