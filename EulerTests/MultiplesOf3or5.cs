using System;
using System.Collections.Generic;
using System.Text;

namespace EulerTests
{
    public static class SumOfMultiples
    {
        public static int Solution(int [] A, int N)
        {
            var flags = new int[N];
            var result = 0;
            foreach (var item in A)
            {
                for (int i = item; i < flags.Length; i++)
                {
                    if (flags[i]!=1 && i%item==0)
                    {
                        flags[i] = 1;
                        result += i;

                    }
                }
            }
            return result;
        }
    }
}
