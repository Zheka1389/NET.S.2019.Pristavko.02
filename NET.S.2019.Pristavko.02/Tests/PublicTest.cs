using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2019.Pristavko._02.Tests
{
    [TestFixture]
    class PublicTest
    {
        [TestCase(15, 15, 0, 0, ExpectedResult = 15)]
        [TestCase(8, 15, 0, 0, ExpectedResult = 9)]
        [TestCase(0, 158, 1, 3, ExpectedResult = 12)]
        [TestCase(546, 178, 0, 11, ExpectedResult = 690)]
        [TestCase(86, 18, 2, 9, ExpectedResult = 94)]
        [TestCase(8, 15, 3, 8, ExpectedResult = 120)]
        public static int InsertNumber(int numberSource, int numberIn, int i, int j)
            => InsertNumbers.InsertNumber(numberSource, numberIn, i, j);

        [TestCase(4, 5, 4, 3)]
        [TestCase(65, 13, -9, 3)]
        [TestCase(344, 715, 12, 11)]
        [TestCase(95, 13, -5, 3)]
        [TestCase(3, 55, 8, -3)]
        public static void InsertNumber_Exception(int numberSource, int numberIn, int i, int j) =>
            Assert.Throws<ArgumentException>(() => InsertNumbers.InsertNumber(numberSource, numberIn, i, j));

        
        [TestCase(12, ExpectedResult = 21)]
        [TestCase(513, ExpectedResult = 531)]
        [TestCase(2017, ExpectedResult = 2071)]
        [TestCase(414, ExpectedResult = 441)]
        [TestCase(144, ExpectedResult = 414)]
        [TestCase(1234321, ExpectedResult = 1241233)]
        [TestCase(1234126, ExpectedResult = 1234162)]
        [TestCase(3456432, ExpectedResult = 3462345)]
        [TestCase(10, ExpectedResult = null)]
        [TestCase(20, ExpectedResult = null)]
        public int? NextBiggerThanTests(int number) => NumberFinder.FindNextBiggerNumber(number);

        [TestCase(7, new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 }, ExpectedResult = new int[] { 7, 7, 70, 17 })]
        [TestCase(70, new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 }, ExpectedResult = new int[] { 70 })]
        [TestCase(3, new int[] { 8, 34, 5, 321, 7 }, ExpectedResult = new int[] { 34, 321 })]
        [TestCase(11, new int[] { 3, 5, 11, 311, 986, 713, 711 }, ExpectedResult = new int[] { 11, 311, 711 })]
        public int[] FilterDigit(int digit,int[] a) =>
            FilterDigits.FilterDigit(digit, a);


        [TestCase(1, 5, 0.0001, 1)]
        [TestCase(8, 3, 0.0001, 2)]
        [TestCase(0.001, 3, 0.0001, 0.1)]
        [TestCase(0.04100625, 4, 0.0001, 0.45)]
        [TestCase(8, 3, 0.0001, 2)]
        [TestCase(0.0279936, 7, 0.0001, 0.6)]
        [TestCase(0.0081, 4, 0.1, 0.3)]
        [TestCase(-0.008, 3, 0.1, -0.2)]
        [TestCase(0.004241979, 9, 0.00000001, 0.545)]
        public static void FindNthRoot(double number, int n, double accuracy, double expectedResult)
        {
            Assert.AreEqual(FindNthRoots.FindNthRoot(number, n, accuracy), expectedResult, accuracy);
        }

        [TestCase(8, 15, -7, -5)]
        [TestCase(8, 15, -0.6, -0.1)]
        public void FindNthRoot_Exception(double number, int n, double accuracy, double expectedResult) =>
            Assert.Throws<ArgumentOutOfRangeException>(() => FindNthRoots.FindNthRoot(number, n, accuracy));
    }
}
