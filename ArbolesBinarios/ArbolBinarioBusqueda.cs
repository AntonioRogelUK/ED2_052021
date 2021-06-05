using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolesBinarios
{
    public class ArbolBinarioBusqueda
    {
        private readonly Nodo raiz;
        public Nodo Raiz { get { return raiz; } }
        public ArbolBinarioBusqueda(int dato)
        {
            this.raiz = new Nodo(dato);
        }
        
        public enum TipoRecorrido 
        {
            Preorden,
            Inorden,
            Posorden
        }

        public void Insertar(int dato, Nodo nodo = null)
        {
            if (nodo == null) 
            {
                nodo = this.raiz;
            }

            if (dato > nodo.Dato) 
            {
                if (nodo.SubArbolDerecho == null) 
                {
                    nodo.SubArbolDerecho = new Nodo(dato);
                }

                Insertar(dato, nodo.SubArbolDerecho);
            }
            else if (dato < nodo.Dato) 
            {
                if (nodo.SubArbolIzquierdo == null) 
                {
                    nodo.SubArbolIzquierdo = new Nodo(dato);
                }

                Insertar(dato, nodo.SubArbolIzquierdo);
            }
        }
    }
}
