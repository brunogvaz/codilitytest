using MyUtils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodilityTest
{
    class Employee:IComparable
    {
        public string Nome { get; set; }
        public decimal Salary { get; set; }

        public int CompareTo(object obj)
        {
            var other = (Employee)obj;
            return other.Nome.CompareTo(this.Nome);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            var a = new int[] { 1, 2, 3 };

            var i = "A";

           var h =  i.GetHashCode();

            var lst = new List<int>(a);


            Dictionary<String, String> dic = new Dictionary<string, string>()
            {
                 { "a", "A" },

                { "b", "B" }
            };

            Hashtable hs = new Hashtable
            {
                { "a", "A" },

                { "b", "B" }
            };














        }
    }
}
