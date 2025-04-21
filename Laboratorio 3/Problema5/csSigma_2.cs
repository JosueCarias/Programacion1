using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problema5
{
    public class csSigma_2:csSigma
    {
        public csSigma_2(double n,double i)
        :base(n,i){

        }
        public double calcular(){
            double sum=0;
            for(int x=0;x<=I;x++){
                sum+=(N*(N+1)*(2*N+1))/6;
            }
            return sum;
        }
        
    }
}