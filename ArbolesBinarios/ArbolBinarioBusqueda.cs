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

        private void RecorrerArbol(Nodo nodo, ref string recorrido) 
        {
            if (nodo != null) 
            {
                //string raiz = (datos == string.Empty) ? "Raiz" : string.Empty;
                
                string raiz = string.Empty;
                if (recorrido == string.Empty)
                {
                    raiz = "Raiz";
                }

                recorrido += $"{raiz}{nodo.Dato, 5}\n";

                if (nodo.SubArbolIzquierdo != null) 
                {
                    recorrido += $"{nodo.Dato, -5}<- ";
                    RecorrerArbol(nodo.SubArbolIzquierdo, ref recorrido);
                }

                if (nodo.SubArbolDerecho != null) 
                {
                    recorrido += $"{nodo.Dato, -5}-> ";
                    RecorrerArbol(nodo.SubArbolDerecho, ref recorrido);
                }
            }
        }

        public string ObtenerArbol(Nodo nodo = null) 
        {
            if (nodo == null) 
            {
                nodo = this.raiz;
            }

            string recorrido = string.Empty;
            RecorrerArbol(nodo, ref recorrido);
            return recorrido;
        }
    }
}
