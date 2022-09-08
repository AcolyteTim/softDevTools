using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryForArray;

namespace UnitTestProjectClassLibraryForIntArray
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ConstrucorWithLengthParamTest()
        {
            int expected = 12;
            IntArray testArr = new IntArray(expected);
            Assert.AreEqual(expected, testArr.Length);
        }

        [TestMethod]
        public void ConstrucorWithNegativeLengthParamTest()
        {
            int expected = -12;
            IntArray testArr = new IntArray(expected);
            Assert.AreNotEqual(expected, testArr.Length);
        }

        [TestMethod]
        public void ConstrucorWithSeveralParamTest()
        {
            int size = 12;
            IntArray testArr = new IntArray(0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);
            Assert.AreEqual(size, testArr.Length);
        }

        [TestMethod]
        public void ConstrucorWithSeveralParamRangeTest()
        {
            bool InRange = true;
            int size = 12;
            int downBorder = 5;
            int upBorder = 25; 
            IntArray arr = IntArray.RandomIntArray(size, downBorder, upBorder);

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > upBorder || arr[i] < downBorder) { InRange = false; }
            }

            Assert.AreEqual(InRange, true);
        }

        [TestMethod]
        public void ArrayFromNotExistingTextFileTest()
        {
            string nonExistingFile = "C:\\Users\\timag\\source\\repos\\ClassLibraryForArray\\ClassLibraryForArray\\testtest.txt";
            IntArray testArr = IntArray.ArrayFromTextFile(nonExistingFile);
            Assert.IsNull(testArr);
        }

        [TestMethod]
        public void ArrayToTextFileAndOutTest()
        {
            IntArray testArr = new IntArray(3, -12, 66, 111, 12323, 0, -289);
            string fileName = "C:\\Users\\timag\\source\\repos\\ClassLibraryForArray\\ClassLibraryForArray\\test.txt";
            IntArray.ArrayToTextFile(testArr, fileName);
            IntArray fromFileArr = IntArray.ArrayFromTextFile(fileName);
            Assert.IsNotNull(fromFileArr);
        }

        [TestMethod]
        public void SumArrayTest()
        {
            int expected = 11;
            IntArray test = new IntArray(1, 2, 3, 4, -5, 6);
            int realSum = IntArray.SumArray(test);
            Assert.AreEqual(expected, realSum);
        }

        [TestMethod]
        public void ArrEqualTest()
        {
            IntArray testArr1 = new IntArray(-3, 8, 55, 0, -2, 11, 0);
            IntArray testArr2= new IntArray(-3, 8, 55, 0, -2, 11, 0);
            bool expected = true;

            bool AreEqual = IntArray.AreEqual(testArr1, testArr2);
            Assert.AreEqual(expected,AreEqual);
        }

        [TestMethod]
        public void MySortTest()
        {
            IntArray testArr = new IntArray(-3, 8, 55, 0, -2, 11, 0);
            IntArray expected = new IntArray(8, 55, 11, -3, -2, 0, 0);
            testArr = IntArray.MySort(testArr);

            bool IsEqual = IntArray.AreEqual(testArr,expected);
            Assert.IsTrue(IsEqual);
        }

        [TestMethod]
        public void ArrayPrefixIncrementOperatorTest()
        {
            IntArray testArr = new IntArray(-3, 8, 55, 0, -2, 11, 0);
            IntArray result = testArr; 
            ++testArr;
            for (int i = 0; i < testArr.Length; ++i)
            {
                Assert.AreEqual(result[i],testArr[i]+1);
            }
        }

        [TestMethod]
        public void ArrayPostfixIncrementOperatorTest()
        {
            IntArray testArr = new IntArray(-3, 8, 55, 0, -2, 11, 0);
            IntArray result = testArr;
            testArr++;
            for (int i = 0; i < testArr.Length; ++i)
            {
                Assert.AreEqual(result[i],testArr[i]+1);
            }
        }

        [TestMethod]
        public void ArrayAndScalarAdditionTest()
        {
            IntArray expected = new IntArray(10, 13, 0, -9);
            IntArray testArr = new IntArray(20, 23, 10, 1);
            int x = -10;
            IntArray result = testArr + x;
            for (int i = 0; i < result.Length; ++i)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void ScalarAndArrayAdditionTest()
        {
            IntArray expected = new IntArray(10, 13, 0, -9);
            IntArray testArr = new IntArray(20, 23, 10, 1);
            int x = -10;
            IntArray result = x + testArr;
            for (int i = 0; i < result.Length; ++i)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void ArrayAndArrayAdditionTest()
        {
            IntArray a = new IntArray(88, 5, 7);
            IntArray b = new IntArray(12, 6, -5, 8, 99);
            IntArray sum = a + b;
            if (sum.Length == a.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    Assert.IsTrue(sum[i] == a[i] + b[i]);
                }
            }
        }

        [TestMethod]
        public void ArrayPrefixDecrementOperatorTest()
        {
            IntArray testArr = new IntArray(-3, 8, 55, 0, -2, 11, 0);
            IntArray result = testArr;
            --testArr; 
            for (int i = 0; i < testArr.Length; i++)
            {
                Assert.AreEqual(result[i],testArr[i]-1);
            }
        }

        [TestMethod]
        public void ArrayPostfixDecrementOperatorTest()
        {
            IntArray testArr = new IntArray(-3, 8, 55, 0, -2, 11, 0);
            IntArray result = testArr;
            testArr--;
            for (int i = 0; i < testArr.Length; i++)
            {
                Assert.AreEqual(result[i], testArr[i]-1);
            }
        }

        [TestMethod]
        public void ArrayAndScalarSubstractionTest()
        {
            IntArray expected = new IntArray(30, 33, 20, 11);
            IntArray testArr = new IntArray(20, 23, 10, 1);
            int x = -10;
            IntArray result = testArr - x;
            for (int i = 0; i < result.Length; ++i)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void ScalarAndArraySubstractionTest()
        {
            IntArray expected = new IntArray(-30, -33, -20, -11);
            IntArray testArr = new IntArray(20, 23, 10, 1);
            int x = -10;
            IntArray result = x - testArr;
            for (int i = 0; i < result.Length; ++i)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void ArrayAndArraySubstractionTest()
        {
            IntArray a = new IntArray(88, 5, 7);
            IntArray b = new IntArray(12, 6, -5, 8, 99);
            IntArray res = a - b;
            if (res.Length == a.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    Assert.IsTrue(res[i] == a[i] - b[i]);
                }
            }
        }
    }
}
