
using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using Biblioteca;

namespace Biblioteca
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.AgregarLibro("Dracula", "Novela", "Bram Stoker");
            biblioteca.AgregarLibro("1984", "Novela", "George Orwell");
            biblioteca.AgregarLibro("Animal Farm", "Fábula", "George Orwell");
            biblioteca.AgregarLibro("Colmillo Blanco", "Aventura", "Jack London");
            biblioteca.AgregarLibro("El alquimista", "Novela", "Pablo Coelho");
            biblioteca.AgregarLibro("La Metamorfosis", "Ficción", "Franz Kafka");

            biblioteca.ListaLectores.Add(new Lector("Pepe López", 27123453));
            biblioteca.ListaLectores.Add(new Lector("María Gonzalez", 11123421));
            biblioteca.ListaLectores.Add(new Lector("Sandra Giménez", 22123159));
            biblioteca.ListaLectores.Add(new Lector("Juana Perez", 33123144));
            biblioteca.ListaLectores.Add(new Lector("Roberto López", 39176453));

            Console.WriteLine("Bienvenido al sistema de gestión de la Biblioteca. ");

            int rta = 1;
            do
            {
                try
                {
                    Console.WriteLine("Elija una de las siguientes opciones: ");
                    Console.WriteLine("Opción 1: Buscar un libro.");
                    Console.WriteLine("Opción 2: Agregar un libro.");
                    Console.WriteLine("Opción 3: Eliminar un Libro.");
                    Console.WriteLine("Opción 4: Dar de alta a un Lector.");
                    Console.WriteLine("Opción 5: Dar de baja a un Lector.");
                    Console.WriteLine("Opción 6: Prestar un libro a un Lector.");
                    Console.WriteLine("Opción 7: Mostrar todos los Lectores.");
                    Console.WriteLine("Opción 8: Mostrar todos los Libros.");
                    Console.WriteLine("Opción 9: Mostrar la cantidad de prestamos que tiene un lector.");
                    Console.WriteLine("Opción 10: Devolución de un Libro.");
                    Console.WriteLine("Opción 11: Salir del programa.");

                    rta = Convert.ToInt32(Console.ReadLine());

                    // 1. Buscar un Libro.
                    if (rta == 1)
                    {
                        Console.WriteLine("Ingrese el título del libro que desea buscar: ");
                        string libroBuscado = Console.ReadLine();

                        biblioteca.BuscarLibro(libroBuscado);
                        Console.WriteLine(" ");
                    }

                    // 2. Agregar un Libro a la Biblioteca.
                    else if (rta == 2)
                    {
                        Console.WriteLine("Ingresar el título del libro a agregar: ");
                        string titulo = Console.ReadLine();
                        Console.WriteLine("Ingresar el género del libro a agregar: ");
                        string genero = Console.ReadLine();
                        Console.WriteLine("Ingresar el autor del libro a agregar: ");
                        string autor = Console.ReadLine();

                        biblioteca.AgregarLibro(titulo, genero, autor);

                        Console.WriteLine("Libro agregado con éxito. ");
                        Console.WriteLine(" ");
                    }

                    // 3. Eliminar un Libro de la Biblioteca.
                    else if (rta == 3)
                    {
                        Console.WriteLine("Ingrese el nombre del libro que desea eliminar: ");
                        string libroBuscado = Console.ReadLine();

                        biblioteca.EliminarLibro(libroBuscado);

                        Console.WriteLine(" ");
                    }

                    // 4. Dar de alta un Lector.
                    else if (rta == 4)
                    {
                        try
                        {
                            Console.WriteLine("Ingrese el Nombre del lector: ");
                            string nombre = Console.ReadLine();

                            Console.WriteLine("DNI del nuevo lector: ");
                            int dni = Convert.ToInt32(Console.ReadLine());

                            biblioteca.AgregarLector(nombre, dni);

                            Console.WriteLine(" ");
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine("Ingrese un número válido");
                            Console.WriteLine(" ");
                            continue;
                        }
                    }

                    // 5. Dar de baja un Lector.
                    else if (rta == 5)
                    {
                        int dni;
                        Console.WriteLine("Ingrese el DNI del lector que desea dar de baja: ");
                        dni = Convert.ToInt32(Console.ReadLine());

                        biblioteca.EliminarLector(dni);
                        Console.WriteLine(" ");
                    }

                    // 6. Prestar un Libro a un Lector.
                    else if (rta == 6)
                    {
                        Console.WriteLine("Ingrese el Título del libro a prestar: ");
                        string titulo = Console.ReadLine();

                        Console.WriteLine("Ingrese el DNI del lector a prestar el libro: ");
                        int dni = Convert.ToInt32(Console.ReadLine());

                        biblioteca.PrestarLibro(titulo, dni);
                        Console.WriteLine(" ");
                    }

                    // 7. Muestra todos los lectores de la Biblioteca.
                    else if (rta == 7)
                    {
                        biblioteca.MostrarLectores();
                        Console.WriteLine(" ");
                    }

                    // 8. Muestra todos los libros de la Biblioteca.
                    else if (rta == 8)
                    {
                        biblioteca.MostrarLibros();
                        Console.WriteLine(" ");
                    }

                    // 9. Muestra cantidad de prestamos que tiene un lector.
                    else if (rta == 9)
                    {
                        int dni;
                        Console.WriteLine("Ingrese el DNI del lector: ");
                        dni = Convert.ToInt32(Console.ReadLine());

                        biblioteca.MostrarPrestamos(dni);
                        Console.WriteLine(" ");
                    }

                    // 10. Devolución de un libro.
                    else if (rta == 10)
                    {
                        int dni;
                        Console.WriteLine("Ingrese el título del libro: ");
                        string titulo = (Console.ReadLine());

                        Console.WriteLine("Ingrese el DNI del lector: ");
                        dni = Convert.ToInt32(Console.ReadLine());

                        biblioteca.DevuelveLibroPrestado(titulo, dni);
                        Console.WriteLine(" ");
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Ingrese un valor correcto.");
                    Console.WriteLine(" ");
                    continue;
                }

            //Si la respuesta es 11 se sale del programa.
            } while (rta != 11);
            Console.WriteLine("Gracias por usar el sistema de gestión de la Biblioteca.");
        }
    }
}
            
        
    

    


