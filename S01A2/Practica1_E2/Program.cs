// See https://aka.ms/new-console-template for more information

/* En el campeonato estudiantil llegan a la última etapa los participantes que superen los 80 puntos. 
 * El algoritmo pide el nombre de cada participante y la puntuación de los 3 jurados. 
 * Debe mostrar el nombre y el puntaje total de cada participante.        
 * Nota: cuando se ingrese "FIN" en el nombre del participante finaliza nuestro programa.*/

using System.ComponentModel;
using System.Collections.Generic;
using Practica1_E2;

namespace Practica1_E2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            while(true)
            {        
                Console.WriteLine("Ingrese el nombre del participante: ");
                string nombre = Console.ReadLine();

                if (nombre.ToUpper() != "fin")
                {
                    break;
                }

                Participante participante = new Participante(nombre);

                for (i=0; i <3;i++)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Ingrese el puntaje del Jurado " + (i+1));
                    int num = Convert.ToInt32(Console.ReadLine());
                    participante.Puntaje[i] = num;
                }

                    Console.WriteLine("Participante: " + participante.Nombre + " Puntaje 1: " + participante.Puntaje[0] + " Puntaje 2: " + participante.Puntaje[1] + " Puntaje 3: " + participante.Puntaje[2]);
                    Console.WriteLine("El puntaje total obtenido fue de: " + participante.calcularPuntaje());
                    participante.resultadoPuntaje();
                Console.WriteLine(" ");
            }    
        }
    }
}

    
