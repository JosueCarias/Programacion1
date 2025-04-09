using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problema3
{
    public class csPermutacion : csTeorema
    {
        public csPermutacion(int n, int r):base(n,r){

        }
        public string Calcular(){
            return $"La permutacion es: {Factorial(N)/Factorial(N-R)}";
        }
    }
}