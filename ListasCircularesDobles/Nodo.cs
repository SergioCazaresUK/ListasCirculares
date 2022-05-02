﻿using System;
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
            get { return Dato; }
            set { Dato = value; }
        }

        public Nodo siguiente
        {
            get { return Siguiente; }
            set { Siguiente = value; }
        }

        public Nodo anterior
        {
            get { return Anterior; }
            set { Anterior = value; }
        }
    }

}
