using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problema5
{
    public class csSigma
    {
        private double n;
        private double i;
        public csSigma(double n, double i){
            this.n=n;
            this.i=i;
        }
        
        public double N{
            get{return n;}
            set{n=value;}
        }
        public double I{
            get{return i;}
            set{i=value;}
        }
        public double calcular(){
            double sum=0;
            for(int x=0; x<=n;x++){
                sum+=x;
            }
            return sum;
        }
    }
}