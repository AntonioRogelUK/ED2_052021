using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolesGenerales
{
    public class Nodo
    {
        private string dato;
        private Nodo hijo;
        private Nodo hermano;

        public string Dato { get => dato; set => dato = value; }
        public Nodo Hijo { get => hijo; set => hijo = value; }
        public Nodo Hermano { get => hermano; set => hermano = value; }
       
        public Nodo(string dato, Nodo hijo = null, Nodo hermano = null)
        {
            this.dato = dato;
            this.hijo = hijo;
            this.hermano = hermano;
        }
    }
}
