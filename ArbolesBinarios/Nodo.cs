using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolesBinarios
{
    public class Nodo
    {
        private int dato;
        private Nodo subArbolIzquierdo;
        private Nodo subArbolDerecho;

        public int Dato { get => dato; set => dato = value; }
        public Nodo SubArbolIzquierdo { get => subArbolIzquierdo; set => subArbolIzquierdo = value; }
        public Nodo SubArbolDerecho { get => subArbolDerecho; set => subArbolDerecho = value; }

        public Nodo(int dato, Nodo subArbolIzquierdo = null, Nodo subArbolDerecho = null)
        {
            this.dato = dato;
            this.subArbolIzquierdo = subArbolIzquierdo;
            this.subArbolDerecho = subArbolDerecho;
        }
    }
}
