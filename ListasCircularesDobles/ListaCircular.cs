using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCircularesDobles
{
    public class Lista
    {
        Nodo primero = new Nodo();
        Nodo ultimo = new Nodo();

        public Lista()
        {
            primero = null;
            ultimo = null;
        }

        public void insertarNodo()
        {
            Nodo nuevo = new Nodo();
            Console.WriteLine("Insertar un nuevo dato:");
            nuevo.dato = int.Parse(Console.ReadLine());
            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
                primero.siguiente = primero;
                primero.anterior = ultimo;
            }
            else
            {
                ultimo.siguiente = nuevo;
                nuevo.anterior = ultimo;
                nuevo.siguiente = primero;
                ultimo = nuevo;
                primero.anterior = ultimo;
            }
        }

        public void DesplegarNodoP()
        {
            Nodo actual = new Nodo();
            actual = primero;
            if (actual != null)
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

        public void DesplegarNodoU()
        {
            Nodo actual = new Nodo();
            actual = ultimo;
            if (actual != null)
            {
                do
                {
                    Console.WriteLine(" " + actual.dato);
                    actual = actual.anterior;
                } while (actual != ultimo);
            }
            else
            {
                Console.WriteLine("Esta Lista se Encuentra Vacia");
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
                do
                {

                    if (actual.dato == nodoBusqueda)
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

        public void ModificarNodo()
        {
            Nodo actual = new Nodo();
            actual = primero;
            bool buscar = false;
            Console.WriteLine("Que Nodo Modificar?");
            int nodoBusqueda = int.Parse(Console.ReadLine());
            if (actual != null)
            {
                do
                {

                    if (actual.dato == nodoBusqueda)
                    {
                        Console.WriteLine("Nodo Encontrado " + actual.dato);
                        Console.WriteLine("Nuevo Nodo: ");
                        actual.dato = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nodo Modificado");
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
