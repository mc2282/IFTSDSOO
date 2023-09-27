// See https://aka.ms/new-console-template for more information


/*
 Objetivo:  Poner en práctica los conceptos de abstracción, encapsulamiento, toString, sobrecarga de métodos
Descripción:
En un pequeño departamento en la ciudad, Facundo y Camila son compañeros de piso y 
comparten un televisor. Ambos son amantes de las películas y programas de televisión,
y disfrutan relajarse juntos después de un largo día de trabajo. 
Para facilitar su entretenimiento, han decidido crear un programa simple en C# para administrar su televisor 
y controlar los canales que ven. Un televisor cuenta con varios atributos como ser:
 	
Marca (del tipo string)
 	
Modelo (del tipo string)
 	
Cantidad de pulgadas (del tipo entero)
 	
Estado (prendido o apagado) (del tipo booleano)

Número del canal que se está reproduciendo actualmente. (valor desde 1 a 150) (del tipo entero)

De la persona dueña del televisor se sabe:
nombre (del tipo string)
domicilio

Del domicilio conocemos:
calle
numero
barrio

Para hacer:
Con el objetivo de programar una experiencia de visualización óptima, se han definido una serie de operaciones que se pueden realizar en el televisor. Estas operaciones incluyen:

obtenerCanalActual(): int
Devuelve un valor entero con el número de canal que esta visualizándose en ese momento.

cambiarCanal(int): bool
Cambia el canal al número de canal que reciba por parámetro

cambiarCanal(): bool
Cambia el canal incrementando en uno al que se está reproduciendo actualmente. Si llega al tope de 150, debe comenzar por el primero.

verPrendido():bool
Informa con un verdadero si el televisor está encendido o falso en caso contrario.

cambiarEstado():void
Si el televisor se encontraba encendido entonces se debe apagar, y viceversa.

Se pide:
1. Modelá la solución en UML

2. Realizá la implementación de cada método en c#. 

3. También realizá los constructores de las siguientes clases:
Persona.
Televisor.
Domicilio.

El método Main de la clase Test que instancie lo siguiente y luego lo muestre:
Un televisor que le pertenece a Facundo y a Camila
Ambos viven juntos en Jonte 5299, Monte Castro
Que tanto Facundo como Camila, en distintos momentos, puedan realizar diferentes operaciones sobre mismo televisor (tener siempre en cuenta el estado del televisor por ejemplo, no se puede cambiar de canal si se encuentra apagado).
 * */

using System.Runtime.CompilerServices;

namespace TP1Televisor
{

    class Program
    {
        static void Main(string[] args)
        {
            Televisor televisor1 = new Televisor("LG", "65UQ70006LB", 65, true, 1);

            Domicilio domicilio1 = new Domicilio("Jonte", 5299, "Monte Castro");

            Persona camila = new Persona("Camila", domicilio1, televisor1);
            Persona facundo = new Persona("Facundo", domicilio1, televisor1);

            Console.WriteLine("Nombre: " + camila.Nombre);
            Console.Write("Televisor de " + camila.Nombre + ": Marca: " + camila.Televisor.Marca + ", ");
            Console.Write("Modelo: " + camila.Televisor.Modelo + ", ");
            Console.Write("Cantidad pulgadas: " + camila.Televisor.CantidadPulgadas + ", ");
            Console.Write("Estado: " + camila.Televisor.Estado + ", ");
            Console.Write("Canal: " + camila.Televisor.CanalActual);

            Console.WriteLine(" ");

            Console.Write("Domicilio de " + camila.Nombre + ": Calle: " + camila.Domicilio.Calle + ", ");
            Console.Write("Numero: " + camila.Domicilio.Numero + ", ");
            Console.Write("Barrio: " + camila.Domicilio.Barrio);

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("Nombre: " + facundo.Nombre);
            Console.Write("Televisor de " + facundo.Nombre + ": Marca: " + facundo.Televisor.Marca + ", ");
            Console.Write("Modelo: " + facundo.Televisor.Modelo + ", ");
            Console.Write("Cantidad pulgadas: " + facundo.Televisor.CantidadPulgadas + ", ");
            Console.Write("Estado: " + facundo.Televisor.Estado + ", ");
            Console.Write("Canal: " + facundo.Televisor.CanalActual);

            Console.WriteLine(" ");
            Console.Write("Domicilio de " + facundo.Nombre + ": Calle: " + facundo.Domicilio.Calle + ", ");
            Console.Write("Numero: " + facundo.Domicilio.Numero + ", ");
            Console.Write("Barrio: " + facundo.Domicilio.Barrio);
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            //Operaciones:
            while (true) {

            Console.WriteLine("¿Qué operación desea realizar?");
            Console.WriteLine("1. Encender/Apagar el televisor.");
            Console.WriteLine("2. Ver si está encendido el televisor. (True = encendido, False = apagado)");
            Console.WriteLine("3. Cambiar el canal.");
            Console.WriteLine("4. Ingresar el número del canal que se quiere ver.");
            Console.WriteLine("5. Conocer cuál es el canal actual.");
            Console.WriteLine("6. Salir del programa.");


                int userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == 1)
                {
                    televisor1.cambiarEstado();
                }
                else if (userInput == 2)
                {
                    Console.WriteLine("Estado del televisor: " + televisor1.verPrendido());
                }
                else if (userInput == 3)
                {
                    Console.WriteLine("El canal es: " + televisor1.CanalActual);
                    televisor1.cambiarCanal();
                    Console.WriteLine("Cambiaste el canal al: " + televisor1.CanalActual);
                }
                else if (userInput == 4)
                {
                    Console.WriteLine("Ingrese el canal que quiere ver: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(televisor1.cambiarCanal(num));
                    Console.WriteLine("Cambiaste el canal al: " + televisor1.CanalActual);
                }
                else if (userInput == 5)
                {
                    Console.WriteLine("El canal actual es: "+ televisor1.obtenerCanalActual());
                }
                else
                {
                    break;
                }
                Console.WriteLine(" ");
            }
         
        }
      }
    }

