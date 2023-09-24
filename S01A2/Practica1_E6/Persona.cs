using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1_E6
{
    class Persona
    {
        string nombre;
        int capitalAportado;
        double porcentajeAportado;

        public Persona(string nombre, int capitalAportado)
        {
            Nombre = nombre;
            CapitalAportado = capitalAportado;
            PorcentajeAportado = porcentajeAportado;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int CapitalAportado
        {
            get { return capitalAportado; }
            set { capitalAportado = value; }
        }
        public double PorcentajeAportado
        {
            get { return porcentajeAportado; }
            set { porcentajeAportado = value; }
        }


    }
}
