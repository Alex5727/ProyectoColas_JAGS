using System;

namespace ProyectoCola
{
    internal class Cola
    {
        private Nodo inicio;

        private int count = 0;

        private int Max;

        public Cola(int max)
        {
            Max = max;
            inicio = null;
        }

        private bool underflow()
        {
            if (inicio == null)
                return true;
            else
                return false;
        }

        private bool overflow()
        {
            if (count == Max)
                return true;
            else
                return false;
        }


        public void Print()
        {
            Nodo act = inicio;
            int c = count;
            int g = 0;
            string a = "";

            if (inicio == null)
            {
                Console.WriteLine("La pila esta vacia");
            }
            else
            {
                while(act != null)
                {
                    Console.WriteLine(act.Valor);

                    act = act.Sig;
                }
                
            }
        }


        public int Count()
        {
            return count;
        }

        public bool Insert(int n)
        {
            Nodo nuevo = new Nodo(n);
            Nodo act = inicio;

           if (overflow())
            {
                return false;
            }
            else if (inicio == null)
            {
                inicio = nuevo;
                count = 1;
                return true;
            }
            else
            {
                while (act.Sig != null)
                {
                    act = act.Sig;
                }
                act.Sig = nuevo;
                count = count + 1;
                return true;
            }
        }

        public int Extract()
        {
            int a;
            if(underflow())
            {
                return -1;
            }
            else if(count == 1)
            {
                a = inicio.Valor;
                inicio = inicio.Sig;
                count = count - 1;
                return a;
            }
            else
            {
                a = inicio.Valor;
                inicio = inicio.Sig;
                count = count - 1;
                return a;
            }
        }
    }
}