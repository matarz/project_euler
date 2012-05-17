using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Tools
    {
        static List<int> PrimeGenerator(int PrimeCount){
            long Limit = (int)(PrimeCount/(Math.Log(PrimeCount)-1.08366));
            return PrimesBelowNumber(Limit);
        }

        static public List<int> PrimesBelowNumber(long Limit)
        {
            List<int> PrimeList = new List<int>();
            bool[] NumbersList = new bool[Limit + 1]; ;
            var LimitSqrt = Math.Sqrt(Limit);

            for (int i = 0; i <= Limit; ++i)
                NumbersList[i] = true;

            PrimeList.Add(2);
            for (int i = 3; i <= Limit; i += 2)
            {
                if (NumbersList[i])
                {
                    PrimeList.Add(i);
                    if (i < LimitSqrt)
                        for (int j = i * i; j <= Limit; j += i)
                            NumbersList[j] = false;
                }
            }
            return PrimeList;
        }

    }
}
