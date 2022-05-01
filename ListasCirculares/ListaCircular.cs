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
                primero.siguiete = primero;
                ultimo = primero;
            }
            else
            {
                ultimo.siguiete = nuevo;
                nuevo.siguiete = primero;
                ultimo = nuevo;
            }
        }
    }

}
