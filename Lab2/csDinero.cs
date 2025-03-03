using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2
{
    public class csDinero
    {
        private int dinero;

        public csDinero(int dinero){
            this.dinero=dinero;
        }
        public int Dinero{
            get { return dinero;}
            set { dinero=value;}
        }
        public int[] calcularBilletes(){
            int[] billetes =new int [6];
            int cantidad=dinero;

            billetes[0]=cantidad/100;
            cantidad%=100;

            billetes[1]=cantidad/50;
            cantidad%=50;

            billetes[2]=cantidad/20;
            cantidad%=20;

            billetes[3]=cantidad/10;
            cantidad%=10;

            billetes[4]=cantidad/5;
            cantidad%=5;

            billetes[5]=cantidad;
        
            return billetes;
        }
    }
}