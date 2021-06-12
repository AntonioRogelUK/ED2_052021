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

        private void AgregarDato(Nodo nodo, ref string recorrido) 
        {
            string coma = (recorrido == string.Empty) ? string.Empty : ",";
            recorrido += $"{coma}{nodo.Dato}";
        }

        private void RecorridoPreorden(Nodo nodo, ref string recorrido) 
        {
            if (nodo != null) 
            {
                AgregarDato(nodo, ref recorrido);

                if (nodo.SubArbolIzquierdo != null) 
                {
                    RecorridoPreorden(nodo.SubArbolIzquierdo, ref recorrido);
                }

                if (nodo.SubArbolDerecho != null) 
                {
                    RecorridoPreorden(nodo.SubArbolDerecho, ref recorrido);
                }
            }
        }

        public string Recorrido(Nodo nodo = null, 
            TipoRecorrido tipoRecorrido = TipoRecorrido.Preorden) 
        {
            if (nodo == null) 
            {
                nodo = this.raiz;
            }

            string recorrido = string.Empty;

            switch (tipoRecorrido) 
            {
                case TipoRecorrido.Preorden:
                    RecorridoPreorden(nodo, ref recorrido);
                    break;

                default: throw new Exception("Recorrido incorrecto");
            }

            return $"Tipo recorrido: {tipoRecorrido}: {recorrido}";
        }
    }
}
