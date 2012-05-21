using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Problems
{
    class p003
    {

        /*************************** The Problem ****************************
            The prime factors of 13195 are 5, 7, 13 and 29.

            What is the largest prime factor of the number 600851475143 ?
        ***********************************************************************/

        static public void Solve()
        {
            long NumberToFactor = 600851475143;
            var Root = Math.Sqrt(NumberToFactor);
            long LargestFactor = 600851475143;
            bool Factored;
            
            do{
                Factored = false;
                if (LargestFactor % 2 == 0)
                {
                    Factored = true;
                    LargestFactor /= 2;
                    Root = Math.Sqrt(LargestFactor);
                }
                else if (LargestFactor % 3 == 0)
                {
                    Factored = true;
                    LargestFactor /= 3;
                    Root = Math.Sqrt(LargestFactor);
                }
                else
                {
                    for (long i = 6; i < Root; i += 6)
                    {
                        if (LargestFactor % (i - 1) == 0)
                        {
                            Factored = true;
                            LargestFactor /= (i - 1);
                            Root = Math.Sqrt(LargestFactor);
                            break;
                        }
                        else if (LargestFactor % (i + 1) == 0)
                        {
                            Factored = true;
                            LargestFactor /= (i + 1);
                            Root = Math.Sqrt(LargestFactor);
                            break;
                        }
                    }

                }
            }while(Factored);

            Console.WriteLine("Largest factor of "+ NumberToFactor +" is: " + LargestFactor);
        }
    }
}
