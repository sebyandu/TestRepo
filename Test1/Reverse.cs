using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Core;
using NUnit.Framework;

namespace Test1
{
    static class Operations
    {
        public static string Reverse(string input)
        {
            input = input.Trim();
            var length = input.Length;
            var reverse = string.Empty;
            for (var i = length - 1; i >= 0; i--)
            {
                reverse += input[i];
            }
            return reverse;
        }

        public static bool Palind(string input)
        {
            return input.Trim() == Reverse(input);
        }

        public static List<int> FibonacciArrays(int lastNo)
        {
            var result = new List<int>();
            var i = 1;
            result.Add(0);
            result.Add(1);
            while (lastNo >= result[i])
            {
                result.Add(result[i-1]+result[i]);
                i++;
            }
            return result;

        }

        public static int[] SortedArray( int [] inputArray)
        {
            for (var i = 0; i < inputArray.Length; i++)
            {
                for (var j = 0; j < inputArray.Length-1; j++)
                {
                    if (inputArray[j] <= inputArray[j + 1]) continue;
                    var temp = inputArray[j];
                    inputArray[j] = inputArray[j + 1];
                    inputArray[j + 1] = temp;
                }
            }
            return inputArray;
        }
    }


    [TestFixture]
    public class OperationsTest
    {
        [Test]
        public void ReverseTest()
        {
            Assert.IsTrue(Operations.Reverse("Out") == "tuO");
        }

        [Test]
        public void PalindTest()
        {
            Assert.IsTrue(Operations.Palind("LUPUL"));
        }

        [Test]
        public void FiboTest()
        {
            Assert.IsTrue(Operations.FibonacciArrays(8).Capacity-1==7);
        }

        [Test]
        public void BubbleSortTest()
        {
            Assert.IsTrue(Operations.SortedArray(new[] {3,2,1}).SequenceEqual(new[] {1,2,3}));
        }
    }
}
