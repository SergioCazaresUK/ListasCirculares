using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares
{
    public class Lista
    {
        private Nodo primero = new Nodo();
        private Nodo ultimo = new Nodo();

        public Lista()
        {
            primero = null;
            ultimo = null;
        }

        public void InsertarNodo()
        {
            Nodo nuevo = new Nodo();
            Console.WriteLine("Insertar un nuevo dato");
            nuevo.dato = int.Parse(Console.ReadLine());
            if(primero == null)
            {
                primero = nuevo;
                primero.siguiente = primero;
                ultimo = primero;
            }
            else
            {
                ultimo.siguiente = nuevo;
                nuevo.siguiente = primero;
                ultimo = nuevo;
            }
        }

        public void DesplegarLista()
        {
            Nodo actual = new Nodo();
            actual = primero;
            if(actual != null)
            {
                do
                {
                    Console.WriteLine(" " + actual.dato);
                    actual = actual.siguiente;
                } while (actual != primero);
            }
            else
            {
                Console.WriteLine("Esta Lista Esta Vacia");
            }
            return;
        }
    }

}
