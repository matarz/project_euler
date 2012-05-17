using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Problems
{
    class p010
    {
        static public void Show()
        {

            string Problem = "The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.\n" + 
                             "Find the sum of all the primes below two million.\n\n";

            Console.Write("Problem: \n"+Problem);
        }
        
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
