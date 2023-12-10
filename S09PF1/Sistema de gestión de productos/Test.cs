using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_gestión_de_productos;

namespace Sistema_de_gestión_de_productos
{
    class Test
    {
        public static void Main(string[] args)
        {
            //se crea un array para almacenar los atributos de los 5 productos en cada clase
            Producto[] productos = new Producto[5];

            for (int i = 0; i < productos.Length; i++)
            {
                string resp;
                do
                {
                    Console.WriteLine("Producto: " + (i + 1) + ". Perecedero o No Perecedero? ");
                    resp = Console.ReadLine().ToLower();
                } while (resp != "perecedero" && resp != "no perecedero");

                Console.WriteLine(" ");

                //si la respuesta fue perecedero guarda los valores en la clase Perecedero
                if (resp.ToLower() == "perecedero")
                {
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Precio: ");
                    float precio = float.Parse(Console.ReadLine());

                    Console.Write("Días para caducar: ");
                    int diasCaducar = int.Parse(Console.ReadLine());

                    productos[i] = new Perecedero(nombre, "Perecedero", precio, diasCaducar);

                    Console.WriteLine(" ");
                }
                //si la respuesta fue no perecedero guarda los valores en la clase NoPerecedero
                else if (resp.ToLower() == "no perecedero")
                {
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Precio: ");
                    float precio = float.Parse(Console.ReadLine());

                    Console.Write("Categoria: ");
                    string categoria = Console.ReadLine();

                    productos[i] = new NoPerecedero(nombre, "No Perecedero", precio, categoria);
                    Console.WriteLine(" ");
                }
            }
            //se muestran los datos por pantalla de cada producto
            for (int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine("Producto " + (i + 1) + ":");
                Console.WriteLine(productos[i].mostrarDatos());
                Console.WriteLine(" ");
            }
            float suma = 0;
            for (int i = 0; i < productos.Length; i++)
            {
                Console.Write("Precio del producto " + (i+1) + " sin descuento: $");
                Console.WriteLine(productos[i].Precio);

            //suma acumula las sumas de los precios de los productos y al resultado lo multiplica por 5
            //se modifica el precio del producto aplicandole el descuento
                suma = suma + productos[i].calcularPrecioTotal(5);
            }
            Console.WriteLine(" ");

            for (int i = 0; i < productos.Length; i++)
            {
                Console.Write("Precio del producto " + (i + 1) + " con descuento: $");

            //imprime el precio del producto con el descuento aplicado
                Console.WriteLine(productos[i].Precio);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Precio total de vender 5 productos de cada tipo: $" + suma);
            Console.WriteLine(" ");
        }
    }
}



