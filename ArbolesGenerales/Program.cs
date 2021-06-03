using System;

namespace ArbolesGenerales
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolGeneral arbol = new ArbolGeneral("A");

            Nodo nodoB = arbol.Insertar("B", arbol.Raiz);
            Nodo nodoC = arbol.Insertar("C", arbol.Raiz);

            Nodo nodoD = arbol.Insertar("D", nodoB);
            Nodo nodoE = arbol.Insertar("E", nodoB);
            Nodo nodoF = arbol.Insertar("F", nodoB);

            Nodo nodoI = arbol.Insertar("I", nodoD);

            Nodo nodoJ = arbol.Insertar("J", nodoF);
            Nodo nodoK = arbol.Insertar("K", nodoF);

            Nodo nodoG = arbol.Insertar("G", nodoC);
            Nodo nodoH = arbol.Insertar("H", nodoC);

            Nodo nodoL = arbol.Insertar("L", nodoH);

            string elArbol = arbol.ObtenerArbol(new Nodo("D"));
            Console.WriteLine(elArbol);

            Nodo nodoEncontrado = arbol.Buscar("F");
            Console.WriteLine(nodoEncontrado.Dato);
            Console.WriteLine(arbol.ObtenerArbol(nodoEncontrado));
        }
    }
}
