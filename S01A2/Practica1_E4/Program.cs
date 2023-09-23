// See https://aka.ms/new-console-template for more information


/* Se trata de implementar un programa que sume los dígitos de un número entero no negativo de 4 dígitos. 
 * Por ejemplo, la suma de los dígitos del 3433 es 13.  Para darle un poco más de emoción, 
 * el programa no se limitará a escribir el resultado de la suma, 
 * sino que también escribirá todos los sumandos utilizados: 3 + 4 + 3 + 3 = 13.*/

namespace Practica1_E4
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                double[] digitos = new double[4];

                Console.WriteLine("Por favor, ingrese un número no negativo de 4 dígitos: ");
                double num = Convert.ToInt32(Console.ReadLine());

                digitos[0] = Math.Truncate(num / 1000);

                digitos[1] = Math.Floor((num % 1000) / 100);

                digitos[2] = Math.Floor((num % 100) / 10);

                digitos[3] = num % 10;

                double sumaDigitos = digitos[0] + digitos[1] + digitos[2] + digitos[3];
                
                Console.WriteLine("La suma de los números " + digitos[0] + " + " + digitos[1] + " + " + digitos[2] + " + " + digitos[3] + " es: " + sumaDigitos);
               
                Console.WriteLine(" ");

                Console.WriteLine("Desea volver a realizar la operación?: S/N ");
                string respuesta = Console.ReadLine();

                if (respuesta != "S")
                {
                    break;
                }
            }
        }
    }
}

