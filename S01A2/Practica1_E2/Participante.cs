using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1_E2
{
    class Participante
    {
        private string nombre;
        private int[] puntaje;

        public Participante(string nombre)
        {
            Nombre = nombre;
            Puntaje = new int[3];
        }

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int[] Puntaje { get { return puntaje; } set { puntaje = value; } }

        public int calcularPuntaje()
        {
            int puntajeTotal;
            puntajeTotal = puntaje[0] + puntaje[1] + puntaje[2];
            return puntajeTotal;
        }

        public void resultadoPuntaje()
        {
            if (calcularPuntaje()>80){
            Console.WriteLine("Pasa a finales");
            }
            else
            {
            Console.WriteLine("No pasa a finales");
            }
        }
    }
}

