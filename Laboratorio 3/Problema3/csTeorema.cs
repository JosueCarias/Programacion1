using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problema3
{
    public class csTeorema
    {
        private int n;
        private int r;

        public csTeorema(int n,int r){
            this.n=n;
            this.r=r;
        }
        public int N{
            get{return n;}
            set{n=value;}
        }
        public int R{
            get{return r;}
            set{r=value;}
        }
        public int Factorial(int number){
            int resultado = 1;
            for (int i = 2; i <= number; i++)
            {
                resultado *= i;
            }
            return resultado;
        }
    }
}