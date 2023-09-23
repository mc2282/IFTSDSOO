// See https://aka.ms/new-console-template for more information


/* El precio de los productos no tiene incluido el incremento del 15% que representa 
 * la ganancia del negocio, por lo tanto, el algoritmo debe calcular el precio final a 
 * abonar por un cliente. 
 * Se ingresa el precio del producto y como resultado muestra el precio de venta.*/

namespace Practica1_E1
{
    class Program
    {
        public static void Main(string[] args)
        {
            double precioInicial;
            double incremento = 0.15;
            double precioFinal;
            double gananciaNegocio;
            
            Console.WriteLine("Ingrese el precio del producto: ");
            precioInicial = Convert.ToInt32(Console.ReadLine());

            precioFinal = (precioInicial * incremento) + precioInicial;
            gananciaNegocio = (precioInicial * incremento);

;           Console.WriteLine("El precio de venta del producto, con un incremento del "+ (incremento*100) + "% es: "  + precioFinal);
            Console.WriteLine("La ganancia del negocio es de: " + gananciaNegocio + "$");
        }
    }
}
