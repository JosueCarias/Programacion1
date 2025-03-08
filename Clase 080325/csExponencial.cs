using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Clase_080325
{
    public class csExponencial
    {
        private int x;
        private int n;

        public csExponencial(int x,int n){
            this.x=x;
            this.n=n;
        }
        public int X{
            get{return x;}
            set{x=value;}
        }
        public int N{
            get{return n;}
            set{N=value;}
        }
        public double resultado(){
            double sumatoria = 0;

            for (int i = 0; i <= n; i++)
            {
                sumatoria += Math.Pow(x, i) / Factorial(i);
            }

            return sumatoria;
        }
        private int Factorial(int num)
        {
            if (num == 0 || num == 1)
            {
                return 1; // El factorial de 0 y 1 es 1
            }

            int factorial = 1;
            for (int j = 2; j <= num; j++) // Comenzamos desde 2
            {
                factorial *= j;
            }

            return factorial;
        }
    }
}