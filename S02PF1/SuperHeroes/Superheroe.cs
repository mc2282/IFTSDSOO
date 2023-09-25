namespace SuperHeroes
{
    internal class SuperHeroe
    {
        private string nombre;
        private int fuerza;
        private int resistencia;
        private int superpoderes;

        public SuperHeroe(string nombre, int fuerza, int resistencia, int superpoderes)
        {
            this.Nombre = nombre;
            this.Fuerza = fuerza;
            this.Resistencia = resistencia;
            this.Superpoderes = superpoderes;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Fuerza
        {
            get { return fuerza; }
            set
            {
                // Aplicar validación de límites
                if (value < 0)
                {
                    fuerza = 0;
                }
                else if (value > 100)
                {
                    fuerza = 100;
                }
                else
                {
                    fuerza = value;
                }
            }
        }
        public int Resistencia
        {
            get { return resistencia; }
            set
            {
                // Aplicar validación de límites
                if (value < 0)
                {
                    resistencia = 0;
                }
                else if (value > 100)
                {
                    resistencia = 100;
                }
                else
                {
                    resistencia = value;
                }
            }
        }
        public int Superpoderes
        {
            get { return superpoderes; }
            set
            {
                // Aplicar validación de límites
                if (value < 0)
                {
                    superpoderes = 0;
                }
                else if (value > 100)
                {
                    superpoderes = 100;
                }
                else
                {
                    superpoderes = value;
                }
            }
        }
        public void competir(SuperHeroe otroSuperHeroe)
        {
            int puntajeSuperHeroe1 = 0;
            int puntajeSuperHeroe2 = 0;

            if (Fuerza > otroSuperHeroe.Fuerza)
            {
                puntajeSuperHeroe1++;
            }
            else
            {
                puntajeSuperHeroe2++;
            }

            if (Resistencia > otroSuperHeroe.Resistencia)
            {
                puntajeSuperHeroe1++;
            }
            else
            {
                puntajeSuperHeroe2++;
            }

            if (Superpoderes > otroSuperHeroe.Superpoderes)
            {
                puntajeSuperHeroe1++;
            }
            else
            {
                puntajeSuperHeroe2++;
            }

            if (puntajeSuperHeroe1 > puntajeSuperHeroe2)
            {
                Console.WriteLine("TRIUNFO");
            }
            else if (puntajeSuperHeroe1 == puntajeSuperHeroe2)
            {
                Console.WriteLine("EMPATE");
            }
            else
            {
                Console.WriteLine("DERROTA");
            }
        }
    }
}
