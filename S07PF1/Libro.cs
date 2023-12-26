using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Biblioteca
{
    internal class Libro
    {
        string titulo;
        string genero;
        string autor;
        string estado;

        public Libro(string titulo, string genero, string autor, string estado = "Disponible")
        {
            this.Titulo = titulo;
            this.Genero = genero;
            this.Autor = autor;
            this.estado = estado;
        }
        public string GetEstado()
        {
            return estado;
        }

        public void SetEstado(string value)
        {
            this.estado = value;
        }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Autor { get => autor; set => autor = value; }

        public override string ToString()
        {
            return "Nombre: " + titulo + ". Género: " + genero + ". Autor: " + autor + ". Estado: " + estado;
        }
    }
}
