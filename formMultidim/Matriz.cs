using System;

// aqui estamos creando un clase para darle las propiedades como tal de lo que sera una matriz

namespace formMultidim
{
    internal class Matriz
    {
        private int m;
        private int n;



        #region encapsulmiento
        /*
         como hacerlo?
         selecicionas las variables que quieres encapsular
        clik derecho
        click en el foquito
        y darle en encapsular pero seguir usando
         */
        public int M
        {
            get => m; 
            set
            {
                if ( value<0)//aqui value hace reeferencia al valor que esta guardado en la variable m
                {
                    m = 2; 
                }
                else
                {
                    m= value;
                }
            }
            
        }
        public int N { get => n; 
            
                set
            {
                if (value < 0)//aqui value hace reeferencia al valor que esta guardado en la variable n
                {
                    n = 2;
                }
                else
                {
                    n = value;
                }
            }
        }
        #endregion
    }
}
