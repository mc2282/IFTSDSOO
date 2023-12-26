using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Biblioteca
{
    internal class Biblioteca
    {
        public List<Libro> listaLibros;
        public List<Lector> listaLectores;

        public Biblioteca()
        {
            listaLibros = new List<Libro>();
            listaLectores = new List<Lector>();
        }
        public List<Libro> ListaLibros { get => listaLibros; set => listaLibros = value; }
        public List<Lector> ListaLectores { get => listaLectores; set => listaLectores = value; }


        // 1. Buscar un libro. 
        public void BuscarLibro(string libroBuscado)
        {
            int tituloEncontrado = 0;
            for (int i = 0; i < ListaLibros.Count; i++)
            {
                if (ListaLibros[i].Titulo.Contains(libroBuscado, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Libro encontrado. ");
                    tituloEncontrado = 1;
                }
            }
            if (tituloEncontrado == 0)
            {
                Console.WriteLine("Libro no encontrado. ");
            }
        }

        // 2. Agregar un Libro.
        public void AgregarLibro(string titulo, string genero, string autor)
        {
            ListaLibros.Add(new Libro(titulo, genero, autor));
        }

        // 3. Eliminar un Libro.
        public void EliminarLibro(string libroBuscado)
        {
            int index;
            int libroEncontrado = 0;
            for (int i = 0; i < ListaLibros.Count; i++)
            {
                if (ListaLibros[i].Titulo.Contains(libroBuscado, StringComparison.OrdinalIgnoreCase))
                {
                    libroEncontrado = 1;
                    Console.WriteLine("Libro encontrado. ");
                    index = i;
                    Console.WriteLine("¿Desea eliminar éste libro? S/N");
                    string ans = Console.ReadLine();

                    if (ans == "S")
                    {
                        ListaLibros.RemoveAt(index);
                        Console.WriteLine("Libro eliminado con éxito.");
                    }
                }
                
            }if(libroEncontrado != 1)
                {
                    Console.WriteLine("Libro no encontrado. ");
                }
        }

        // 4. Agregar un Lector.
        public void AgregarLector(string nombre, int dni)
        {
            int lectorExistente = 0;

            //Si el lector existe, no se agrega a la lista.
            for (int i = 0; i < ListaLectores.Count; i++)
            {
                if (ListaLectores[i].Dni == dni)
                {
                    Console.WriteLine("Error. El lector YA EXISTE. ");
                    lectorExistente = 1;
                    break;
                }
            }
            //Si el lector no existe, entonces se agrega a la lista.
            if (lectorExistente == 0)
            {
                ListaLectores.Add(new Lector(nombre, dni));
                Console.WriteLine("Lector agregado con éxito.");
            }
        }

        // 5. Eliminar a un Lector.
        public void EliminarLector(int dni)
        {
            int lectorExistente = 0;
            int index;

            for (int i = 0; i < ListaLectores.Count; i++)
            {
                if (ListaLectores[i].Dni == dni)
                {
                    Console.WriteLine("Lector encontrado. ");
                    lectorExistente = 1;
                    index = i;
                    Console.WriteLine(" ");
                    Console.WriteLine("¿Desea eliminar al lector " + dni + " ? S/N");
                    string ans = Console.ReadLine();

                    if (ans.ToUpper() == "S")
                    {
                        ListaLectores.RemoveAt(index);
                        Console.WriteLine("Lector eliminado con éxito.");
                    }
                }
            }
            if (lectorExistente == 0)
            {
                Console.WriteLine("Lector no encontrado. ");
            }
        }

        //6. Prestar libro a un lector
        public void PrestarLibro(string titulo, int dni)
        {
            int indexLibro = 0;
            int indexLector = 0;
            int libroEncontrado = 0;
            int lectorEncontrado = 0;

            //Recorre la Lista de libros a ver si se encuentra registrado en la Biblioteca.
            for (int i = 0; i < ListaLibros.Count; i++)
            {
                if (ListaLibros[i].Titulo.Contains(titulo))
                {
                    //Si el libro existe, se guarda en indexLibro la ubicación del Libro dentro de "ListaLibros".
                    indexLibro = i;
                    libroEncontrado = 1;
                }
            }

            //Si el libro existe en Biblioteca, ahora valida que el lector también exista.
            if (libroEncontrado == 1)
            {
                for (int j = 0; j < ListaLectores.Count; j++)
                {
                    if (ListaLectores[j].Dni == dni)
                    {
                        //Si el DNI de los lectores coincide con el DNI brindado por parámetro:
                        //Se guarda en indexLector el indice del Lector dentro de "ListaLectores".
                        indexLector = j;
                        lectorEncontrado = 1;
                    }
                }
            }

            if (libroEncontrado == 1 && lectorEncontrado == 0)
            {
                Console.WriteLine("El Lector no existe en la Biblioteca. ");
            }

            if (libroEncontrado == 0 && lectorEncontrado == 0)
            {
                Console.WriteLine("El Libro y el Lector no existen en la Biblioteca. ");
            }

            if (libroEncontrado == 0 && lectorEncontrado == 1)
            {
                Console.WriteLine("El Libro no existe en la Biblioteca. ");
            }

            if (libroEncontrado == 1 && lectorEncontrado == 1 && ListaLibros[indexLibro].GetEstado() == "Prestado")
            {
                Console.WriteLine("El Libro ya fue Prestado. ");
            }

            if (libroEncontrado == 1 && lectorEncontrado == 1 && ListaLibros[indexLibro].GetEstado() != "Prestado" && ListaLectores[indexLector].GetPrestamos() == 3)
            {
                Console.WriteLine("El lector no puede realizar más de 3 préstamos.");
            }

            if (libroEncontrado == 1 && lectorEncontrado == 1 && ListaLibros[indexLibro].GetEstado() != "Prestado" && ListaLectores[indexLector].GetPrestamos() < 3)
                {
                Console.WriteLine("El Libro " + ListaLibros[indexLibro].Titulo + " fue prestado a el Lector " + ListaLectores[indexLector].GetNombre() + ".");
                ListaLibros[indexLibro].SetEstado("Prestado");
                ListaLectores[indexLector].SetPrestamos(ListaLectores[indexLector].GetPrestamos()+1);
                }
            }

        // 7. Ver todos los lectores registrados. 
        public void MostrarLectores()
        {
            Console.WriteLine("Hay " + ListaLectores.Count + " lector/es registrado/s.");
            foreach (Lector lector in ListaLectores)
            {
                Console.WriteLine(lector);
            }
        }

        // 8. Ver todos los libros registrados. 
        public void MostrarLibros()
        {
            Console.WriteLine("Hay " + ListaLibros.Count + " libro/s registrado/s.");
            foreach (Libro libro in ListaLibros)
            {
                Console.WriteLine(libro);
            }
        }

        // 9. Ver todos los prestamos de un lector. 
        public void MostrarPrestamos(int dni)
        {
            int lectorEncontrado = 0;
            for (int i = 0; i < ListaLectores.Count; i++)
            {
                if (ListaLectores[i].Dni == dni)
                {
                    lectorEncontrado = 1;
                    Console.WriteLine("Cantidad de préstamos que tiene el lector: ");
                    Console.WriteLine(ListaLectores[i].GetPrestamos());
                }
            }
            if (lectorEncontrado == 0)
            {
                Console.WriteLine("Lector no encontrado. ");
            }
        }

        // 10. Devolver un libro a la Biblioteca.
        public void DevuelveLibroPrestado(string titulo, int dni)
        {
            int indexLibro = 0;
            int indexLector = 0;
            int libroEncontrado = 0;
            int lectorEncontrado = 0;

            //Recorre la Lista de libros a ver si se encuentra registrado en la Biblioteca.
            for (int i = 0; i < ListaLibros.Count; i++)
            {
                if (ListaLibros[i].Titulo.Contains(titulo))
                {
                    //Si el libro existe, se guarda en indexLibro la ubicación del Libro dentro de "ListaLibros".
                    indexLibro = i;
                    libroEncontrado = 1;
                }
            }

            //Si el libro existe en Biblioteca, ahora valida que el lector también exista.
            if (libroEncontrado == 1)
            {
                for (int j = 0; j < ListaLectores.Count; j++)
                {
                    if (ListaLectores[j].Dni == dni)
                    {
                        //Si el DNI de los lectores coincide con el DNI brindado por parámetro:
                        //Se guarda en indexLector el indice del Lector dentro de "ListaLectores".
                        indexLector = j;
                        lectorEncontrado = 1;
                    }
                }
            }

            if (libroEncontrado == 1 && lectorEncontrado == 0)
            {
                Console.WriteLine("El Lector no existe en la Biblioteca. ");
            }

            if (libroEncontrado == 0 && lectorEncontrado == 0)
            {
                Console.WriteLine("El Libro o el Lector no existen en la Biblioteca. ");
            }

            if (libroEncontrado == 0 && lectorEncontrado == 1)
            {
                Console.WriteLine("El Libro no existe en la Biblioteca. ");
            }

            if (libroEncontrado == 1 && lectorEncontrado == 1 && ListaLibros[indexLibro].GetEstado() != "Prestado")
            {
                Console.WriteLine("El Libro no fue Prestado. ");
            }

            if (libroEncontrado == 1 && lectorEncontrado == 1 && ListaLibros[indexLibro].GetEstado() == "Prestado" && ListaLectores[indexLector].GetPrestamos() > 0 && ListaLectores[indexLector].GetPrestamos() <= 3)
            {
                Console.WriteLine("El Libro " + ListaLibros[indexLibro].Titulo + " prestado al lector " + ListaLectores[indexLector].GetNombre() + " fue devuelto a la Biblioteca.");
                ListaLibros[indexLibro].SetEstado("Disponible");
                ListaLectores[indexLector].SetPrestamos(ListaLectores[indexLector].GetPrestamos() - 1);
            }

            if (libroEncontrado == 1 && lectorEncontrado == 1 && ListaLibros[indexLibro].GetEstado() == "Prestado" && ListaLectores[indexLector].GetPrestamos() == 0)
            {
                Console.WriteLine("El Lector no realizó ningún préstamo. ");
            }
        }
    }
}


    


