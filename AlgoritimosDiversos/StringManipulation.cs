using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace AlgoritimosDiversos
{
    public static class StringManipulation
    {


        public static int SpecialPalindrome(String s)
        {

            /*
             * Special PalindromeXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
                        Again
                        A string is said to be a special palindromic string if either of two conditions is met:
                        All of the characters are the same, e.g. aaa .
                        All characters except the middle one are the same, e.g. aadaa.
                        A special palindromic substring is any substring of a string which meets one of those criteria. Given a
                        string, determine how many special palindromic substrings can be formed from it.
                        For example, given the string , we have the following special palindromic substrings:
                        .
                        Function Description
                        Complete the substrCount function in the editor below. It should return an integer representing the
                        number of special palindromic substrings that can be formed from the given string.
                        substrCount has the following parameter(s):
                        n: an integer, the length of string s
                        s: a string
                        Input Format
                        The first line contains an integer, , the length of .
                        The second line contains the string .
                        Constraints
                        Each character of the string is a lowercase alphabet, .
                        Output Format
                        Print a single line containing the count of total special palindromic substrings.
             * 
             * */

            int result = 0;
                char? previous = null;
                var lst = new List<Tuple<char?, int>>();
               
            var counter = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == previous)
                    {
                    counter++;
                    }
                    else
                    {
                    if (previous !=null)
                    {
                        lst.Add(new Tuple<char?, int>(previous, counter));

                    }
                    counter = 1;
                    }
                    previous = s[i];
                }

            lst.Add(new Tuple<char?, int>(previous, counter)); //TODO test for NULL

            for (int i = 0; i < lst.Count; i++)
            {
                result += (lst[i].Item2 +1 )* lst[i].Item2/2;

                if (lst.Count>=3 && i >0 && i < lst.Count-1)
                {

                    if ((lst[i-1].Item1 == lst[i+1].Item1)  && lst[i].Item2 ==1)
                    {
                        result += Math.Min(lst[i - 1].Item2, lst[i + 1].Item2);
                    }
                }
               
            }
           
            return result;
        }
        public static String SherlockAndValidString(String s)
        {
            //Sherlock considers a string to be valid if all characters of the string
            //appear the same number of times. It is also valid if he can remove just  character 
            //at  index in the string, and the remaining characters will occur the same number of times. 
            //Given a string , 
            //determine if it is valid. If so, return YES, otherwise return NO.
            var dic = s.GroupBy(c=>c).GroupBy(g=>g.Count()).ToList();

            const String YES = "YES";
            const String NO = "NO";

            if (dic.Count()==1)
            {
                return YES;
            }
            else if (dic.Count() == 2)
            {
                if (dic.Where(p => p.Key == dic.Max(x => x.Key)).SelectMany(i => i).Count() == 1)
                {

                    if ((dic.Max(p => p.Key) - dic.Min(p => p.Key) == 1))
                    {
                        return YES;
                    }
                    else return NO;
                }

                else if (dic.Where(p => p.Key == dic.Min(x => x.Key)).SelectMany(i => i).Count() == 1)
                {
                    if ((dic.Min(p => p.Key) == 1))
                    {
                        return YES;
                    }
                    else return NO;
                }
                else return NO;
                
            }
            else
                 return NO;
        }
        public static int AlternatingCaracters(String s1)
        {


            //VERSAO USANDO LINQ

            //string b = new string(s1.Select((s, i) => new { s, i })
            //    .Where(x => x.i == s1.Length - 1 || s1[x.i + 1] != x.s)
            //    .Select(x => x.s)
            //    .ToArray());

            //return Math.Abs(s1.Length - b.Length);



            //versao tradicional

            var allowedChars = new char[] { 'A', 'B' };

            if (s1.Where(c => !allowedChars.Contains(c)).ToList().Count() == 0)
            {
                char? previous = null;
                var lst = new List<Tuple<int,int>>();
                int counter = 0;
                int head = 0;
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[i] == previous)
                    {
                        counter++;
                    }
                    else
                    {
                       if( i - head-1>0)
                        lst.Add(new Tuple<int, int>(head, i - head-1));
                        head = i;

                    }
                    previous = s1[i];
                }
                if (s1.Length - head - 1 > 0)
                    lst.Add(new Tuple<int, int>(head, s1.Length - head - 1));


                var nString = new StringBuilder(s1);
                foreach (var item in lst)
                {
                    nString.Remove(item.Item1, item.Item2);
                }


                return counter;
            }
            return 0;
        }

    }
}
