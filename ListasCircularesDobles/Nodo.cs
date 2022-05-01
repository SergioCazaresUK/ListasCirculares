using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCircularesDobles
{
    public class Nodo
    {
        private int Dato;
        private Nodo Siguiente;
        private Nodo Anterior;

        public int dato
        {
            get { return dato; }
            set { dato = value; }
        }

        public Nodo siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public Nodo anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }
    }

}
