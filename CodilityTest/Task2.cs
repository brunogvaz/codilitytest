using System;
using System.Collections.Generic;
using System.Text;

namespace CodilityTest
{
    public static class Task2
    {
        public static bool[] Solution (int N)
        {

            bool[] flags = new bool[N + 1];

            initFlags(flags);

            var prime = 2;

            var sqrt = Math.Sqrt(flags.Length);

            while (prime <=sqrt)
            {
                crossOff(flags, prime);
                prime = nextPrime(flags,prime);
            }
            return flags;
        }

        private static int nextPrime(bool[] flags,int prime)
        {
            prime++;
            for (int i = prime; i < flags.Length; i++)
            {
                if (flags[i])
                {
                    prime = i;
                    break;
                }
            }
            return prime;
        }

        private static void crossOff(bool[] flags, int prime)
        {
            for (int i = prime * prime; i < flags.Length; i += prime)
            {
                flags[i]=false;
            }
        }

        private static void initFlags(bool[] flags)
        {
            for (int i = 0; i < flags.Length; i++)
            {
                flags[i] = true;
            }
        }
    }
}
