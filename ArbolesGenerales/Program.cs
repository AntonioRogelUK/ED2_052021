using System;

namespace ArbolesGenerales
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolGeneral arbol = new ArbolGeneral("A");
            

            Console.WriteLine(arbol.Raiz.Dato);
        }
    }
}
