// See https://aka.ms/new-console-template for more information


/* 6. Tres personas aportan diferente capital a una sociedad y desean saber el valor total aportado 
 * y qué porcentaje aportó cada una (indicando nombre y porcentaje). Para ello, solicitar la carga 
 * por teclado del nombre de cada socio, su capital aportado y a partir de esto calcular e informar lo
requerido previamente */

namespace Practica1_E6
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Persona 1
            Console.WriteLine("Ingrese el nombre de la persona: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el capital aportado por la persona: ");
            int capital = Convert.ToInt32(Console.ReadLine());

            Persona persona1 = new Persona(nombre, capital);

            Console.WriteLine(" ");

            //Persona 2
            Console.WriteLine("Ingrese el nombre de la persona: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el capital aportado por la persona: ");
            capital = Convert.ToInt32(Console.ReadLine());

            Persona persona2 = new Persona(nombre, capital);

            Console.WriteLine(" ");

            //Persona 3
            Console.WriteLine("Ingrese el nombre de la persona: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el capital aportado por la persona: ");
            capital = Convert.ToInt32(Console.ReadLine());

            Persona persona3 = new Persona(nombre, capital);

            Console.WriteLine(" ");

            //Calculo del capital total y el porcentaje aportado
            int capitalTotal = persona1.CapitalAportado + persona2.CapitalAportado + persona3.CapitalAportado;
            persona1.PorcentajeAportado = (persona1.CapitalAportado * 100)/ (capitalTotal);
            persona2.PorcentajeAportado = (persona2.CapitalAportado * 100) / (capitalTotal);
            persona3.PorcentajeAportado = (persona3.CapitalAportado * 100) / (capitalTotal);

            //Imprime el capital total aportado y el porcentaje individual 
            Console.WriteLine("El valor total aportado a la sociedad es: $"+capitalTotal+".");

            Console.WriteLine("El porcentaje aportado por " + persona1.Nombre + " es: " + persona1.PorcentajeAportado + "%");

            Console.WriteLine("El porcentaje aportado por " + persona2.Nombre + " es: " + persona2.PorcentajeAportado + "%");

            Console.WriteLine("El porcentaje aportado por " + persona3.Nombre + " es: " + persona3.PorcentajeAportado + "%");
        }
    }
}