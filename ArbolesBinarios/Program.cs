using System;

namespace ArbolesBinarios
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolBinarioBusqueda abb = new ArbolBinarioBusqueda(120);

            int[] numeros = { 87,140,43,99,130,22,65,56,93,135,10,150,1,150,2000 };

            foreach (int numero in numeros)
            {
                abb.Insertar(numero);
            }

            Console.WriteLine(abb.ObtenerArbol());


            Console.WriteLine("");
            Console.WriteLine(abb.Recorrido());
        }
    }
}
