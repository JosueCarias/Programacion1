using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2
{
    public class csPerfecto
    {
        private int numero;

        public csPerfecto(int numero){
            this.numero=numero;
        }
        public int Numero{
            get { return numero;}
            set { numero=value;}
        }
        public bool calcularPerfecto(){
            if (numero <= 1)
            {
                return false;
            }

            int sumaDivisores = 0;
     
            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    sumaDivisores += i;
                }
            }

            return sumaDivisores == numero;
        }
    }
}