using System;
using System.Collections.Generic;
using System.Text;

namespace EulerTests
{
    public static class Fibonacci
    {
        public static IEnumerable<int> GenerateSequence(int item1, int item2, int n)
        {
            var sequence = new int[n];
            sequence[0] = item1;
            sequence[1] = item2;

            for (int i = 2; i < sequence.Length; i+=2)
            {
                sequence[i] = sequence[i - 1] + sequence[2];
                yield return sequence[i]; 
            }

        }
    }
}
