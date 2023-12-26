using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Biblioteca
{
    internal class Lector
    {
        private string nombre;
        private int dni;
        private int prestamos;
        private string estado;


        public Lector(string nombre, int dni, int prestamos = 0)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.prestamos = prestamos;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string value) 
        {
            this.nombre = value;
        }

        public int Dni
        {
            get { return dni; }
            set { dni = value;}
        }

        public int GetPrestamos()
        {
            return prestamos;
        }

        public void SetPrestamos(int value)
        {

            if (prestamos < 3)
            {
            this.prestamos = value;
            }
        }

        public override string ToString()
        {
            return "Nombre: " + nombre + ". DNI: " + dni + ". Prestamos realizados: " + prestamos + ".";
        }

        
    }
}
