using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace EulerTests
{
    class Program
    {
        static void Main(string[] args)
        {

            string s1 = "nice";
            string s2 = "niece";


            var e = s2.Except(s1).ToList();


            var lst = new List<int>() { 1,2,3,4,66,66,8};


            var query = lst.OrderBy(p => p);
           
                var foundMatch = Regex.Match("dogcatabddefghi", "dog(cat(...){3})");
           

            while (true)
            {

                
                Console.WriteLine($"{foundMatch.Index}  {foundMatch.Length}  {foundMatch.Value}");

                foreach (Group group in foundMatch.Groups)
                {

                    Console.WriteLine("group {0} {1}",group.Index,group.Value);
                    foreach (Capture capture in group.Captures)
                    {
                        Console.WriteLine("\t capture index {0} {1}",capture.Index,
                        capture.Value);
                    }
                }
                //Console.WriteLine(SumOfMultiples.Solution(new int[] { 3, 5 }, 1000));
                foundMatch = foundMatch.NextMatch();
            }

         
        }
    }
}
