using System;
using System.Collections.Generic;

namespace PollardsRhoExample
{
    class PollardsRhoSolver
    {
        public long GreatestCommonDivisorRec(long x1, long x2)
        {
            return x2 == 0 ? x1 : GreatestCommonDivisorRec(x2, x1%x2);
        }
        public bool IsPrime(long n)
        {
            for(int i = 2; i <= Math.Sqrt(n); i++){
                if(n % i == 0){
                    return false;
                }
            }

            return true;
        }

        public void GetFactors(List<long> acc, long n)
        {
            if(n == 1){
                return;
            }

            if(IsPrime(n))
            {
                acc.Add(n);
                return;
            }
            
            long divisor = Rho(n);
            GetFactors(acc, divisor);
            GetFactors(acc, n/divisor);
        }

        private long Rho(long num) 
        {
            long x1 = 2, x2 = 2, divisor;        

            if (num % 2 == 0) 
                return 2;
                
            do
            {
                x1 = Func(x1) % num;
                x2 = Func(Func(x2)) % num;
                divisor = GreatestCommonDivisorRec(Math.Abs(x1 - x2), num);
            } while (divisor == 1);
            return divisor;
        }

        private long Func(long X)    
        {
            //X^2 + C
            return X * X + 1;
        } 
    }
}