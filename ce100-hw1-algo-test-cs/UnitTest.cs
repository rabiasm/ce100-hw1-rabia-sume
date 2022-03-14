using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce100_hw1_algo_lib_cs;
using System.Collections;
    
namespace ce100_hw1_algo_test_cs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InsertionShort_TestMethod1()
        {
            int[] array = { 12, 5, 24, 65, 14, 46, 2 };
            int[] result = { 2, 5, 12, 14, 24, 46, 65 };

            CollectionAssert.AreEqual(Class1.InsertionShort(array), result);
        }

        [TestMethod]
        public void InsertionShort_TestMethod2()
        {
            int[] array = { 29, 42, 13, 75, 66, 81, 41 };
            int[] result = { 13, 29, 41, 42, 66, 75, 81 };

            CollectionAssert.AreEqual(Class1.InsertionShort(array), result);
        }

        [TestMethod]
        public void InsertionShort_TestMethod3()
        {
            int[] array = { 1, 11, 41, 91, 71, 81, 21 };
            int[] result = { 1, 11, 21, 41, 71, 81, 91 };

            CollectionAssert.AreEqual(Class1.InsertionShort(array), result);
        }


        [TestMethod]
        public void SelectionShort_TestMethod1()
        {
            int[] array = { 12, 5, 24, 65, 14, 46, 2 };
            int[] result = { 2, 5, 12, 14, 24, 46, 65 };

            CollectionAssert.AreEqual(Class1.SelectionSortArray(array), result);
        }

        [TestMethod]
        public void SelectionShort_TestMethod2()
        {
            int[] array = { 15, 95, 86, 65, 16, 52, 7 };
            int[] result = { 7, 15, 16, 52, 65, 86, 95 };

            CollectionAssert.AreEqual(Class1.SelectionSortArray(array), result);
        }

        [TestMethod]
        public void SelectionShort_TestMethod3()
        {
            int[] array = { 10, 22, 5, 90, 71, 8, 88 };
            int[] result = { 5, 8, 10, 22, 71, 88, 90 };

            CollectionAssert.AreEqual(Class1.SelectionSortArray(array), result);
        }

        [TestMethod]
        public void NaivePower_TestMethod1()
        {
            int a = 2;
            uint b = 3;
            int result = 8;
            long c = Class1.Naivepower(a, b);
            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void NaivePower_TestMethod2()
        {
            int a = 5;
            uint b = 3;
            int result = 125;
            long c = Class1.Naivepower(a, b);
            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void NaivePower_TestMethod3()
        {
            int a = 10;
            uint b = 2;
            int result = 100;
            long c = Class1.Naivepower(a, b);
            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void IterativebinarySearch_TestMethod1()
        {
            int[] array = { 5, 8, 10, 22, 71, 88, 90 };
            int index = 10;
            int result = 2;
            int c = Class1.IterativebinarySearch(array, index);
            Assert.AreEqual(c, result);
        }


        [TestMethod]
        public void IterativebinarySearch_TestMethod2()
        {
            int[] array = { 25, 35, 45, 55, 65, 75, 90 };
            int index = 45;
            int result = 2;
            int c = Class1.IterativebinarySearch(array, index);
            Assert.AreEqual(c, result);
        }


        [TestMethod]
        public void IterativebinarySearch_TestMethod3()
        {
            int[] array = { 4, 8, 12, 16, 20, 24, 28 };
            int index = 24;
            int result = 5;
            int c = Class1.IterativebinarySearch(array, index);
            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void RecursivebinarySearch_TestMethod1()
        {
            int[] array = { 10, 11, 12, 13, 14, 15, 16 };
            int index = 15;
            int result = 5;

            int c = Class1.BinarySearchRecursive(array, 0, 6, index);
            Assert.AreEqual(c, result);

        }



        [TestMethod]
        public void RecursivebinarySearch_TestMethod2()
        {
            int[] array = { 3, 6, 9, 12, 15, 18, 21 };
            int index = 18;
            int result = 5;

            int c = Class1.BinarySearchRecursive(array, 0, 6, index);
            Assert.AreEqual(c, result);

        }


        [TestMethod]
        public void RecursivebinarySearch_TestMethod3()
        {
            int[] array = { 2, 4, 6, 8, 10, 12, 14 };
            int index = 8;
            int result = 3;

            int c = Class1.BinarySearchRecursive(array, 0, 6, index);
            Assert.AreEqual(c, result);


        }
        [TestMethod]
        public void MergeSort_TestSimple_1()
        {

            int[] Arr1 = new int[6] { 6, 2, 10, 4, 8, 12 };

            int[] Exp = new int[6] { 2, 4, 6, 8, 10, 12 };
            CollectionAssert.AreEqual(Class1.mergeSort(Arr1), Exp);
        }

        [TestMethod]
        public void MergeSort_TestSimple_2()
        {

            int[] Arr1 = new int[6] { 10, 20, 5, 15, 25, 30, };

            int[] Exp = new int[6] { 5, 10, 15, 20, 25, 30, };
            CollectionAssert.AreEqual(Class1.mergeSort(Arr1), Exp);
        }

        [TestMethod]
        public void MergeSort_TestSimple_3()
        {
            int[] Arr1 = new int[6] { 77, 42, 83, 22, 95, 62 };

            int[] Exp = new int[6] { 22, 42, 62, 77, 83, 95 };
            CollectionAssert.AreEqual(Class1.mergeSort(Arr1), Exp);
        }

        [TestMethod]
        public void RecursivePower_test1()
        {
            
            double result = Class1.Recursive_Power(2,3);
            Assert.AreEqual(result, 8);
        }

        [TestMethod]

        public void RecursivePower_test2()
        {
            double result = Class1.Recursive_Power(-2, 4);
            Assert.AreEqual(result, 16);
        }

        [TestMethod]

        public void RecursivePower_test3()
        {
            double result = Class1.Recursive_Power(10, 0);
            Assert.AreEqual(result, 1);
        }


        [TestMethod]
        public void MasterMethod_TestMethod_1()
        {
            int a = 4;
            int b = 2;
            string c = "n^";
            string key = Class1.MasterMethod(a, b, c);
            string result = "T(n) = n^2";
            Assert.AreEqual(key, result);
        }

        [TestMethod]
        public void MasterMethod_TestMethod_2()
        {
            int a = 3;
            int b = 3;
            string c = "n^";
            string key = Class1.MasterMethod(a, b, c);
            string result = "T(n) = n^1logn";
            Assert.AreEqual(key, result);
        }

        [TestMethod]
        public void MasterMethod_TestMethod_3()
        {
            int a = 27;
            int b = 3;
            string c = "n^";
            string key = Class1.MasterMethod(a, b, c);
            string result = "T(n) = n^3";
            Assert.AreEqual(key, result);
        }
    }



   

    

    
}
