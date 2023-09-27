using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1Televisor
{
    internal class Persona
    {
        string nombre;
        Domicilio domicilio;
        Televisor televisor;

        public Persona(string nombre, Domicilio domicilio, Televisor televisor)
        {
            this.Nombre = nombre;
            this.Domicilio = domicilio;
            this.Televisor = televisor;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        internal Domicilio Domicilio { get => domicilio; set => domicilio = value; }
        internal Televisor Televisor { get => televisor; set => televisor = value; }
    }
}
