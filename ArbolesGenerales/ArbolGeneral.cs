using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolesGenerales
{
    public class ArbolGeneral
    {
        private readonly Nodo raiz;
        public Nodo Raiz { get { return raiz; } }

        public ArbolGeneral(string dato)
        {
            raiz = new Nodo(dato);
        }

        public Nodo Insertar(string dato, Nodo nodoPadre) 
        {
            if (string.IsNullOrWhiteSpace(dato)) 
            {
                throw new Exception("No se puede insertar un valor vacío en dato");
            }

            if (nodoPadre == null) 
            {
                throw new Exception("No se puede insertar un nodo, sin especificar el padre");
            }

            if (nodoPadre.Hijo == null)
            {
                nodoPadre.Hijo = new Nodo(dato);
                return nodoPadre.Hijo;
            }
            else 
            {
                Nodo hijoActual = nodoPadre.Hijo;

                while (hijoActual.Hermano != null) 
                {
                    hijoActual = hijoActual.Hermano;
                }

                hijoActual.Hermano = new Nodo(dato);
                return hijoActual.Hermano;
            }
        }

        private void Recorrer(Nodo nodo, ref int posicion, ref string datos) 
        {
            if (nodo != null) 
            {
                string dato = nodo.Dato;
                int cantidadGuiones = dato.Length + posicion;
                string datoConGuiones = dato.PadLeft(cantidadGuiones, '-');
                datos += $"{datoConGuiones}\n";

                if (nodo.Hijo != null) 
                {
                    posicion++;
                    Recorrer(nodo.Hijo, ref posicion, ref datos);
                    posicion--;
                }

                if (nodo.Hermano != null && posicion != 0) 
                {
                    Recorrer(nodo.Hermano, ref posicion, ref datos);
                }
            }
        }

        public string ObtenerArbol(Nodo nodo = null) 
        {
            if (nodo == null) 
            {
                nodo = raiz;
            }

            int posicion = 0;
            string datos = string.Empty;

            Recorrer(nodo, ref posicion, ref datos);
            return datos;
        }

        public Nodo Buscar(string dato, Nodo nodoBusqueda = null) 
        {
            if (nodoBusqueda == null) 
            {
                nodoBusqueda = raiz;
            }

            if (nodoBusqueda.Dato.ToUpper() == dato.ToUpper()) 
            {
                return nodoBusqueda;
            }

            if (nodoBusqueda.Hijo != null) 
            {
                Nodo nodoEncontrado = Buscar(dato, nodoBusqueda.Hijo);
                if (nodoEncontrado != null) 
                {
                    return nodoEncontrado;
                }
            }

            if (nodoBusqueda.Hermano != null) 
            {
                Nodo nodoEncontrado = Buscar(dato, nodoBusqueda.Hermano);
                if (nodoEncontrado != null) 
                {
                    return nodoEncontrado;
                }
            }

            return null;
        }
    }
}
