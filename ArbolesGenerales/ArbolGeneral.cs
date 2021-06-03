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

        public Nodo InsertarNodo(string dato, Nodo nodoPadre) 
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
    }
}
