using System;

namespace ArbolesGenerales
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolGeneral arbol = new ArbolGeneral("A");

            Nodo nodoB = arbol.InsertarNodo("B", arbol.Raiz);
            Nodo nodoC = arbol.InsertarNodo("C", arbol.Raiz);

            Nodo nodoD = arbol.InsertarNodo("D", nodoB);
            Nodo nodoE = arbol.InsertarNodo("E", nodoB);
            Nodo nodoF = arbol.InsertarNodo("F", nodoB);

            Nodo nodoI = arbol.InsertarNodo("I", nodoD);

            Nodo nodoJ = arbol.InsertarNodo("J", nodoF);
            Nodo nodoK = arbol.InsertarNodo("K", nodoF);

            Nodo nodoG = arbol.InsertarNodo("G", nodoC);
            Nodo nodoH = arbol.InsertarNodo("H", nodoC);

            Nodo nodoL = arbol.InsertarNodo("L", nodoH);

            Console.WriteLine(arbol.Raiz.Dato);
        }
    }
}
