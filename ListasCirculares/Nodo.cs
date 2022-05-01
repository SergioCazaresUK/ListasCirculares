using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares
{
    public class Nodo
    {
        private int Dato;
        private Nodo siguiente;

        public int dato
        {
            get { return Dato; }
            set { Dato = value; }
        }

        public Nodo siguiete
        {
            get { return siguiente; }
            set { siguiente = value; } 
        }
    }
}
