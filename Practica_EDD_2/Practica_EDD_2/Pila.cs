namespace Practica_EDD_2
{

    internal class Nodo
    {
        public char Valor { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(char valor)
        {
            Valor = valor;
            Siguiente = null;
        }
    }

    internal class Pila
    {
        private Nodo Tope { get; set; }

        public Pila()
        {
            Tope = null;
        }

        public void Push(char caracter)
        {
            Nodo nuevoNodo = new Nodo(caracter);
            nuevoNodo.Siguiente = Tope;
            Tope = nuevoNodo;
        }

        public char Pop()
        {
            if (EstaVacia())
            {
                Console.WriteLine("No se pueden sacar elementos de la pila, la pila está vacía.");
                return '\0';
            }

            char valor = Tope.Valor;
            Tope = Tope.Siguiente;
            return valor;
        }

        public bool EstaVacia()
        {
            return Tope == null;
        }

        public void ImprimirPila()
        {
            if (EstaVacia())
            {
                Console.WriteLine("La pila está vacía.");
            }
            else
            {
                Console.WriteLine("Elementos de la pila:");
                Nodo actual = Tope;
                while (actual != null)
                {
                    Console.WriteLine(actual.Valor);
                    actual = actual.Siguiente;
                }
            }
        }

        public void VaciarPila()
        {
            Tope = null;
        }
    }

}
