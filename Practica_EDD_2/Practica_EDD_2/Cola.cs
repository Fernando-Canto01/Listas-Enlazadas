namespace Practica_EDD_2
{
    internal class NodoCola
    {
        public char Valor { get; set; }
        public NodoCola Siguiente { get; set; }

        public NodoCola(char valor)
        {
            Valor = valor;
            Siguiente = null;
        }
    }

    internal class Cola
    {
        private NodoCola Frente { get; set; }
        private NodoCola Final { get; set; }

        public Cola()
        {
            Frente = null;
            Final = null;
        }

        public void Encolar(char character)
        {
            NodoCola nuevoNodo = new NodoCola(character);

            if (EstaLlena())
            {
                Console.WriteLine($"No se pueden encolar el elemento {character}, la cola está llena.");
            }
            else
            {
                if (Frente == null)
                {
                    Frente = nuevoNodo;
                    Final = nuevoNodo;
                }
                else
                {
                    Final.Siguiente = nuevoNodo;
                    Final = nuevoNodo;
                }
            }
        }

        public char Desencolar()
        {
            if (EstaVacia())
            {
                Console.WriteLine("No se pueden desencolar elementos, la cola está vacía.");
                return '\0';
            }

            char valor = Frente.Valor;
            Frente = Frente.Siguiente;
            if (Frente == null)
            {
                Final = null;
            }
            return valor;
        }

        public bool EstaVacia()
        {
            return Frente == null;
        }

        public bool EstaLlena()
        {
            return false; // En una lista enlazada, la cola no se llena como en un arreglo estático.
        }

        public void ImprimirStatus()
        {
            if (EstaVacia())
            {
                Console.WriteLine("No es posible imprimir los elementos (cola vacía)");
            }
            else
            {
                Console.WriteLine("Imprimiendo todos los elementos de la cola");
                NodoCola actual = Frente;
                while (actual != null)
                {
                    Console.WriteLine(actual.Valor);
                    actual = actual.Siguiente;
                }
            }
        }
    }

}
