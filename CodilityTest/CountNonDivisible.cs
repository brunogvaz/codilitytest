using System;
using System.Collections.Generic;
using System.Text;

namespace CodilityTest
{
    public static class CountNonDivisible
    {

        public struct Couple:IComparable
        {
            public int originalIndex;
            public int value;

            public int CompareTo(Object obj)
            {

                Couple cp = (Couple)obj;
                return cp.value;
            }
        }
        public static int[] Solution(int[] A)
        {



            //var workingArray = new int[A.Length * 2];

            //for (int i = 0; i < A.Length; i++)
            //{
            //    var n = A[i];
            //    for (int j = n; j < workingArray.Length; j+=n)
            //    {
            //        workingArray[j] += 1;
            //    }
            //}
            ////Array.Sort(workingArray);
            var result = new int[A.Length];
            //for (int i = 0; i < A.Length; i++)
            //{
            //    result[i] = workingArray[A[i]];
            //}    


            for (int i = 0; i < A.Length; i++)

            {
                var count = 0;
                foreach (var item2 in A)
                {
                    if (A[i] % item2 != 0)
                    {
                        count++;
                    }
                }
                result[i] = count++;
            }

            return result;



        }
    }
}
