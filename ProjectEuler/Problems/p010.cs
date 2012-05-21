using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Problems
{
    class p010
    {
        /*************************** The Problem ****************************
            The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

            Find the sum of all the primes below two million.
        ***********************************************************************/

        static public void Solve(){
            long PrimesBelow = 2000000;
            List<int> Primes = Tools.PrimesBelowNumber(PrimesBelow);
            long Total = 0;
            
            foreach (var i in Primes)
                Total += i;

            Console.WriteLine("Sum of primes below "+ PrimesBelow + ": " + Total);
        }
    }
}
