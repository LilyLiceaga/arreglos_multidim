using System;


namespace arreglos_multidim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,,] nombredelarreglo = { { { 'a', 'b' }, { 'c', 'd' }},{{ 'e', 'f' }, { 'g', 'h' }}};
            Console.WriteLine(nombredelarreglo[1,1,0]);// imprime la g, aqui lo debemos de ver como si fuera un cubo la primera matriz seria
            /*
             la primera parte como la capa 0 seria:
             a b
             c d
            la segunda capa seria:
            e f
            g h
            entonces
            para llamar a alguna parte del arreglo el primer numero es la capa, el segudo es fila y el tercero es la columna
             */
            Console.ReadLine();


            char[,,] nombredelarreglo2 = { { { 'a', 'b' }, { 'c', 'd' } }, { { 'e', 'f' }, { 'g', 'h' } } };
            Console.WriteLine(nombredelarreglo2[1, 1, 0]); //imprime la letra g
            Console.ReadLine();
        }
    }
}
