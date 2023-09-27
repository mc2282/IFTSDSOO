using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1Televisor
{
    internal class Televisor
    {
        string marca;
        string modelo;
        int cantidadPulgadas;
        bool estado;
        int canalActual;

        public Televisor(string marca, string modelo, int cantidadPulgadas, bool estado, int canalActual)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.CantidadPulgadas = cantidadPulgadas;
            this.Estado = estado;
            this.CanalActual = canalActual;
        }

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int CantidadPulgadas { get => cantidadPulgadas; set => cantidadPulgadas = value; }
        public bool Estado { get => estado; set => estado = value; }
        public int CanalActual { get => canalActual; set => canalActual = value; }

        public int obtenerCanalActual()
        {
            return this.CanalActual;
           
        }
        public bool cambiarCanal()
        {
            if (Estado=true & CanalActual == 150)
            {
                this.CanalActual = 1;
                return true;
            }
            else if (Estado = true & (CanalActual > 0 | CanalActual < 150))
            {
                this.CanalActual = CanalActual+ 1;
                return true;
            }
            else 
            {
                return false;
            }

        }

        public bool cambiarCanal(int num)
        {
            if (num > 150 | num < 0 )
            {
                return false;
            }
            else
            {
                this.CanalActual = num;
                return true;
                
            }
        }

        public bool verPrendido()
        {
            if (this.Estado == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void cambiarEstado()
        {
            if (this.Estado == true)
            {
                this.Estado = false;
                Console.WriteLine("Apagado");
            }
            else
            {
                this.Estado = true;
                Console.WriteLine("Encendido");
            }
        }

    }
}
