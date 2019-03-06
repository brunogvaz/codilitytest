using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodilityTest
{
    public static class Task1
    {
        public static string Solution (string S, string T)
        {
            var s = new List<char>(S);

            var t=  new List<char>(T);


            if (S.Equals(T))
            {
                return "EQUAL";
            }
            else if (s.Count==t.Count)  //swaap replace 
            {
                Nullable<char> diff = null;
                Nullable<char> diffS = null;

                Nullable<char> diff2 = null;
                Nullable<char> diffS2 = null;

                int idx = -1;
                
                for (int i = 0; i < S.Length; i++)
                {
                    if (S[i]!=T[i])
                    {
                        if (diff == null)
                        {
                            diff = T[i];
                            diffS = S[i];
                            idx = i;

                        }
                        else if (diff2==null)
                        {
                            diff2 = T[i];
                            diffS2 = S[i];
                        }
                        else
                        {
                            return "IMPOSSIBLE";
                        }
                    }


                }
                if (diff!=null && diff2==null)
                {
                    return "REPLACE " + diffS + " " + diff;
                }
                else if (diff != null && diff2 != null)
                {
                    return "SWAP " +diffS + " " +diff;
                }
            }
            else if (t.Count-s.Count ==1) //insert
            {
                Nullable<char> diff=null;
                for (int i = 0; i < S.Length; i++)
                {
                    if (S[i]!=T[i])
                    {
                        if (diff==null)
                        {
                            diff = T[i];
                            i++;
                           
                        }
                        else
                        {
                            return "IMPOSSIBLE";
                        }
                    }

                }
                if (diff != null)
                {

                    return "INSERT " + diff;
                }
                else
                    
                {
                    return "INSERT " + T[T.Length-1];
                }
                
                

            }
            else if (t.Count - s.Count >1) //impossible
            {
                return "IMPOSSIBLE";
            }
            return "IMPOSSIBLE";

            
        }
    }
}
