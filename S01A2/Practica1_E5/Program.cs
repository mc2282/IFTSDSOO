// See https://aka.ms/new-console-template for more information



/* 4. Se trata de implementar un programa que sume los dígitos de un número entero no negativo de 4 dígitos. 
 * Por ejemplo, la suma de los dígitos del 3433 es 13.  Para darle un poco más de emoción, 
 * el programa no se limitará a escribir el resultado de la suma, 
 * sino que también escribirá todos los sumandos utilizados: 3 + 4 + 3 + 3 = 13.*/

/* 5. Resolver la consiga del punto 4 con la particularidad que el número puede tener cualquier cantidad de dígitos, 
 * es decir, puede ser un número de dos dígitos como un número de 6 dígitos. 
 * Tomá la codificación anterior e introducí los cambios que sean necesarios.*/

namespace Practica1_E4
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                int i,j;
                double aux;
                //Acumulador
                double sumaDigitos = 0;

                Console.WriteLine("Por favor, ingrese un número entero no negativo: ");
                double num = Convert.ToInt32(Console.ReadLine());
                int dimension = num.ToString().Length;

                //Se define el tamaño del array
                double[] digitos = new double[num.ToString().Length];

                Console.WriteLine("cantidad de digitos: "+  dimension);
                
                Console.WriteLine(" ");

                //Calcula y aloja los digitos en las posiciones del array
                for (i= dimension-1; i >= 0 ; i--)
                {
                    digitos[(dimension-1)-i] = Math.Truncate((num % Math.Pow(10,(i+1)))/Math.Pow(10,i));   
                }

                //Suma de los digitos 
                for (i = 0; i < dimension; i++)
                {
                    sumaDigitos = sumaDigitos + digitos[i];
                }
               
                //Imprime el resultado
                Console.WriteLine("La suma de los números es: " );

                for (i=0;i<=dimension-1;i++)  
                {
                    Console.Write(digitos[i]);

                    if (i <= (dimension -1)-1)
                    {
                        Console.Write(" + ");
                    }
                    else
                    {
                        Console.Write(" = ");
                    }  
                }

                Console.WriteLine( sumaDigitos);
                
                Console.WriteLine(" ");

                //Pregunta si desea continuar
                Console.WriteLine("Desea volver a realizar la operación?: S/N ");
                string respuesta = Console.ReadLine();

                if (respuesta.ToUpper() != "S")
                {
                    break;
                }
                Console.WriteLine(" ");
            }
        }
    }
}

