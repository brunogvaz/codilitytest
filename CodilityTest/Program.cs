using MyUtils;
using System;
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



            













        }
    }
}
