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

        public void BuscarNodo()
        {
            Nodo actual = new Nodo();
            actual = primero;
            bool buscar = false;
            Console.WriteLine("Que Nodo Buscar?");
            int nodoBusqueda = int.Parse(Console.ReadLine());
            if (actual != null)
            {
                do {
                
                    if(actual.dato == nodoBusqueda)
                    {
                        Console.WriteLine("Nodo Encontrado " + actual.dato);
                        buscar = true;
                    }
                    actual = actual.siguiente;
                } while (actual != primero && buscar != true);
                if (!buscar)
                {
                    Console.WriteLine("No encontrado");
                }
            }
            else
            {
                Console.WriteLine("Esta Lista Esta Vacia");
            }
            return;
        }
    }

}
