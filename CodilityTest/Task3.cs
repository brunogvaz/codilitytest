using System;
using System.Collections.Generic;
using System.Text;

namespace CodilityTest
{
    public static class Task3
    {
        public static string Solution(int AX, int AY, int BX, int BY)
        {

            double a = (AY - BY) / (AX - BX);

            var b = AY - AX * a;

            double a2 = -1 * (AX - BX)/ (AY - BY);
            double b2 = BY - BX * a2;


           
                var x = BX;
            while (true)
            {
                var y = a2 * x + b2;

                if (Math.Floor(y).Equals(y))
                {
                    return "{" + x + "," + y + "}";
                }


                if (a < 0 && ((AX - AY) < 0))
                {
                    x--;
                }

                else if (a > 0)
                {

                }
            }
        }
    }
}
