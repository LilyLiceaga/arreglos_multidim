using System;
using System.Runtime.Remoting.Messaging;

//clase multimensional es para hacer todas las operaciones de las matrices en la clase matriz

namespace formMultidim
{
    internal class Multidimensional:Matriz
    //internal class Multidimensional:Matriz HERENCIA despues del nombre la clase Multidemsional ponemos 2 puntos y la matriz de la va a heredar rasgos
    {
        float[,] A;
        //constructor
        public Multidimensional(int M,int N)
        {
            //aqui estamos ocupando el this para decir que viene de la clase matriz (this.N y this.M)la N y M que esta igualado son los valores que le mete en el constructor
            this.N = N;
            this.M = M;
            // aqui en esta A estamos definiendo la matriz A y los caracteres que va a tener
            A=new float[this.M,this.N];
        }
        // creamos un metodo estatico para que no se le alteren los valores de dentro es decir que siempre sera la misma matriz, no se editara desde fuera
        public static Multidimensional Leer (string A)
        {
            // este sera el constructor que separa nuestro texto
            //1,2;3,4 Matriz ingresada Ejemplo

            // el string [] hace que yo vaya a a hacer un arreglo llamado renglones de espacio indeterminado
            string[] renglones = A.Split(';'); //el metodo split sirve para separar una cada de acuerdo a un caracter especifico, elimina el caracter separador y separa el string

            //lo que haria el split es:
            // renglones [0]= 1,2
            //renglones [1]= 3,4

            //ahora haremos el split para separar cada renglon

            string[] columnas = renglones[0].Split(',');

            // aqui estamos creando ya el objeto m1 a partir de la clase multidimensional

            Multidimensional m1=new Multidimensional(renglones.Length,columnas.Length);

            for (int i=0; i<m1.M; i++)
            {
                columnas = renglones[i].Split(',');
                for (int j=0; j<m1.N; j++)
                {
                    m1.A[i, j] = float.Parse(columnas[j]);
                }
            }

            return m1; //regresa la matriz dada, recordando que esta como herencia la clase matriz
        } 
        public static Multidimensional operator+(Multidimensional m1, Multidimensional m2)
        {
            Multidimensional m3= new Multidimensional(m1.M,m1.N);
            for (int i=0; i<m1.M; i++)
            {
                for (int j = 0; j < m1.N; j++)
                {
                    m3.A[i,j]= m1.A[i, j] + m2.A[i,j];
                }
            }
            return m3;
        }

        public static Multidimensional operator *(Multidimensional m1, Multidimensional m2)
        {
            Multidimensional m3 = new Multidimensional(m1.M, m1.N);
            for (int i = 0; i < m1.M; i++)
            {
                for (int j = 0; j < m1.N; j++)
                {
                    m3.A[i, j] = m1.A[i, j] + m2.A[i, j];
                }
            }
            return m3;
        }


        public override string ToString()
        {
            //1 2
            //3 4
            string A = "";
            for (int i=0; i<M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A = A + "  " + this.A[i,j].ToString();

                }
                A += "\n";
            }
            return A;
        }
    }
}
