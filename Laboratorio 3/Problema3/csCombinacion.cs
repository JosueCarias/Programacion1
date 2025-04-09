using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problema3
{
    public class csCombinacion:csTeorema
    {
        public csCombinacion(int n, int r):base(n,r){

        }
        public string Calcular(){
            return $"La combinacion es: {Factorial(N)/(Factorial(N-R)*Factorial(R))}";
        }
    }
}