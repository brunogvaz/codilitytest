using CodilityTest;
using Xunit;
using MyUtils;
using AlgoritimosDiversos;
using System.IO;
using System.Text;
using System.Linq;
using System;

namespace XUnitTestProject1
{
    public class UnitTest1
    {


        [Fact]
        public void TestNonDivisible()
        {

            var A = new int[] { 3, 1, 2, 3, 6 };
            Assert.Equal(new int[] { 2, 4, 3, 2, 0 }, CountNonDivisible.Solution(A));

            A = new int[] { 3 };
            Assert.Equal(new int[] { 0 }, CountNonDivisible.Solution(A));

            //A = new int[] { 1, 2, 3 };
            //Assert.Equal(4, Task1.Solution(A));

            //A = new int[] { 100 };
            //Assert.Equal(1, Task1.Solution(A));


        }
        [Fact]
        public void TestTask1()
        {


            Assert.Equal("INSERT e", Task1.Solution("nice", "niece"));
            Assert.Equal("EQUAL", Task1.Solution("nice", "nice"));
            Assert.Equal("IMPOSSIBLE", Task1.Solution("o", "odd"));
            Assert.Equal("INSERT d", Task1.Solution("o", "od"));

            Assert.Equal("REPLACE s n", Task1.Solution("test", "tent"));

            Assert.Equal("EQUAL", Task1.Solution("s", "s"));

            Assert.Equal("REPLACE s n", Task1.Solution("s", "n"));

            Assert.Equal("SWAP o r", Task1.Solution("form", "from"));





        }

        [Fact]
        public void TestTask2()
        {

            // A = new int[] { 4 };
            //Assert.Equal(0, Task2.Solution(A, A.Length));
            //A = new int[] { 4,4 };
            //Assert.Equal(1, Task2.Solution(A, A.Length));

            //A = new int[] { 4, 3, 4, 5 };
            //Assert.Equal(0, Task2.Solution(A, A.Length));

            //A = new int[] { 0,0};
            //Assert.Equal(1, Task2.Solution(A, A.Length));
        }



        [Fact]
        public void TestTask3()
        {


        }


        [Fact]
        public void TestAnagram()
        {

            Assert.False(Anagram.IsAnagram("abc", "cde"));
            Assert.True(Anagram.IsAnagram("abc", "cba"));
            Assert.True(Anagram.IsAnagram("abbb", "abbb"));



            Assert.Equal(4, Anagram.CountElementsToMakeAnagram("abc", "cde"));
            Assert.Equal(5, Anagram.CountElementsToMakeAnagram("ab", "cde"));
            Assert.Equal(2, Anagram.CountElementsToMakeAnagram("abbb", "ab"));
            Assert.Equal(4, Anagram.CountElementsToMakeAnagram("abbb", ""));
            Assert.Equal(2, Anagram.CountElementsToMakeAnagram("", "ab"));
            Assert.Equal(0, Anagram.CountElementsToMakeAnagram("", ""));




        }
        [Fact]
        public void TestAlternatingCharacters()
        {



            Assert.Equal(2, StringManipulation.AlternatingCaracters("AABAA"));
            Assert.Equal(0, StringManipulation.AlternatingCaracters("A"));
            Assert.Equal(1, StringManipulation.AlternatingCaracters("AA"));
            Assert.Equal(0, StringManipulation.AlternatingCaracters("ABABABAB"));
            Assert.Equal(0, StringManipulation.AlternatingCaracters("5"));

        }

        [Fact]
        public void TestSherlockAndValidString()
        {



            //Assert.True(StringManipulation.SherlockAndValidString("CABA"));
            //Assert.True(StringManipulation.SherlockAndValidString("A"));
            //Assert.True(StringManipulation.SherlockAndValidString("AB"));
            Assert.Equal("YES",StringManipulation.SherlockAndValidString("AABBCD"));
            Assert.Equal("YES", StringManipulation.SherlockAndValidString("AABBCCDD"));
            Assert.Equal("NO", StringManipulation.SherlockAndValidString("AAABBBCCCD"));
            Assert.Equal("YES", StringManipulation.SherlockAndValidString("AAABBCCDD"));
        }

        [Fact]
        public void TestSpecialPalindrome()
        {



           
            Assert.Equal(1, StringManipulation.SpecialPalindrome("a"));
            Assert.Equal(3, StringManipulation.SpecialPalindrome("aa"));
            Assert.Equal(4, StringManipulation.SpecialPalindrome("aba"));
            Assert.Equal(9, StringManipulation.SpecialPalindrome("aabaa"));
            Assert.Equal(7, StringManipulation.SpecialPalindrome("abaac"));
            Assert.Equal(7, StringManipulation.SpecialPalindrome("asasd"));
            Assert.Equal(10, StringManipulation.SpecialPalindrome("abcbaba"));
            Assert.Equal(10, StringManipulation.SpecialPalindrome("aaaa"));
            Assert.Equal(12, StringManipulation.SpecialPalindrome("mnonopoo"));


            var dir = Environment.CurrentDirectory;

            String text = File.ReadAllLines(@"..\..\..\testfiles\specialpalindrome1272919.txt").Skip(1).ToList().First();
            Assert.Equal(1272919, StringManipulation.SpecialPalindrome(text.ToString()));

             text = File.ReadAllLines(@"..\..\..\testfiles\specialpalindrome1583085.txt", Encoding.UTF8).Skip(1).ToList().First();
            Assert.Equal(1583085, StringManipulation.SpecialPalindrome(text.ToString()));


        }
    }

}
