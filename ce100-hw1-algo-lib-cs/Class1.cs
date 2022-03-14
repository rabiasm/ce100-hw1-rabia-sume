/**
 * Copyleft (L) 2022 CENG - All Rights Not Reserved
 * You may use, distribute and modify this code.
 **/

 /**
  * @file Class1.cs
  * @author Rabia SUME
  * @date 14 MARCH 2022
  *
  * @brief <b> HW-1 Functions </b>
  *
  * HW-1 Algo Lib Functions Header
  *
  * @see http://bilgisayar.mmf.erdogan.edu.tr/en/
  *
  */





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce100_hw1_algo_lib_cs
{
    public class Class1
    {

        /*
        *
        *      @name InsertionShort
        *       
        *      @brief InsertionShorting
        *
        *      // Function to sort array
               // using insertion sort
        *
        *      @param[in] mass[\b int] index of InsertionShort in the serie
        *
        *      @retval[\b int] calculated InsertionShort
        */

        // finds whether the i th element in the array is less than the previous element, if it is less and r is greater than 0, it assigns the previous number to the i th element
        public static int[] InsertionShort(int[] mass) // return method
        {
            for (int i = 1; i < mass.Length; i++) // Loops from 1 to the length of the mass array
            {
                int cur = mass[i]; // of the mass sequence i. assign element to cur variable
                int r = i;  // Synchronizing the variable i with the variable r
                while (r > 0 && cur < mass[r - 1]) // Looping from r 0 until the r-1 th value of the big and mass array is greater than the variable cur
                {
                    mass[r] = mass[r - 1]; // Assign the r-1 th element of the mass array to the r th element of the mass array
                    r--;  // reduce the variable r by 1
                }
                mass[r] = cur; // Assign the value in the variable cur to the rth element of the mass array
            }
            return mass; // return values ​​of mass array
        }


        /*
        *
        *      @name SelectionSortArray
        *
        *      @brief SelectionSortArraying Calculator
        *
        *      The selection sort algorithm sorts an array by repeatedly finding the minimum element (considering ascending order) from unsorted part and putting it at the beginning.
        *
        *      @param[in] NumArray[\b int] index of SelectionSortArray in the serie
        *
        *      @retval[\b int] calculated SelectionSortArray
        */


        public static int[] SelectionSortArray(int[] NumArray) // return value method
        {
            var arrayLength = NumArray.Length; //Assign the length of the NumArray.Length array to the arrayLength variable
            for (int i = 0; i < arrayLength - 1; i++) // loop advancing by 1 minus the length of the array variable
            {
                var smallestVal = i; // Assign i to smallestVa variable
                for (int j = i + 1; j < arrayLength; j++) // Loop starting from 1 more of i and going up to the length of the array variable

                {
                    if (NumArray[j] < NumArray[smallestVal]) // If the jth element of the NumArray array is less than the smallestVal of the NumArray array
                    {
                        smallestVal = j; // assign the value j to the smallestVal
                    }
                }
                var tempVar = NumArray[smallestVal]; //Assign the smallestVal element of the NumArray array to tempVar
                NumArray[smallestVal] = NumArray[i]; // smallestVal of the NumArray array. element of the NumArray array i. assign element
                NumArray[i] = tempVar; // Assign tempVar to the ith element of the NumArray array
            }
            return NumArray; // return NumArray variable
        }


        /*
        *
        *      @name Naivepower
        *
        *      @brief Naivepowering Calculator
        *
        *      The most basic way to calculate the nth power of a number is to multiply that number exactly n-times.
        *
        *      @param[in] x [\b int] index of Naivepower in the serie
        *      @param[in] n [\b uint] index of Naivepower in the serie
        *      @retval[\b int] calculated Naivepower
        */

        public static long Naivepower(int x, uint n) // return NumArray variable
        {
            
            int pow = 1; // variable pow equals 1


            for (int i = 0; i < n; i++) // loop that returns as many as n variables from the method
            {
                pow = pow * x; // Multiplying the pow variable with the x value that comes with the method to the pow variable
            }

            return pow; // return the value of the pow variable
        }


        /*
        *
        *      @name IterativebinarySearch
        *
        *      @brief Iterativebinary Searching 
        *
        *      Binary search begins by comparing the middle element of the arr to the x value.
        *
        *      @param[in] arr [\b int] index of iterativebinarySearch in the serie
        *      @param[in] x   [\b int] index of iterativebinarySearch in the serie
        *      @retval[\b int] calculated iterativebinarySearch
        */

        public static int IterativebinarySearch(int[] arr, int x) // assign array and x variables
        {
            int l = 0, r = arr.Length - 1;
            while (l <= r) // when l is less than and equal to r
            {
                int m = l + (r - l) / 2;

                
                if (arr[m] == x) // if m equals x return m
                    return m;

                
                if (arr[m] < x) // if m less than x, l equals m plus 1
                    l = m + 1;

               
                else
                    r = m - 1; // else r equals m minus 1
            }

            
            
            return -1;
        }

        /*
        *
        *      @name BinarySearchRecursive
        *
        *      @brief BinarySearch Recursiving
        *
        *      // Recursive implementation of the binary search algorithm to return
        *      // the position of key in subarray inputarray[min…max]
        *
        *      @param[in] inputarray [\b int[]] index of BinarySearchRecursive in the serie
        *      @param[in] min[\b int[]] index of BinarySearchRecursive in the serie
        *      @param[in] max[\b int[]] index of BinarySearchRecursive in the serie
        *      @param[in] key[\b int[]] index of BinarySearchRecursive in the serie
        *      @retval[\b int] calculated BinarySearchRecursive
        */

        public static int BinarySearchRecursive(int[] inputarray, int min, int max,int key) // assign inputarray, min, max, key variable
        {
            int mid = min + (max - min) / 2;

            
            if (key == inputarray[mid]) // if key equals mid return mid
            {
                return mid;
            }

           
            else if (key < inputarray[mid]) // else key less than mid return inputarray, min, mid minus 1, key
            {
                return BinarySearchRecursive(inputarray, min, mid - 1, key);
            }

           
            else
            {
                return BinarySearchRecursive(inputarray, mid + 1, max, key); // else key less than mid retun inputarray, mid plus 1, max, key
            }
        }


        /*
        *
        *      @name mergeSort
        *
        *      @brief mergeSorting
        *
        *      // Merges two subarrays of array[].
        *       // First subarray is arr[begin..mid]
        *       // Second subarray is arr[mid+1..end]
        *
        *      @param[in] array[\b int] index of mergeSort in the serie
        *
        *      @retval[\b int] calculated mergeSort
        */


        public static int[] mergeSort(int[] array) // retun NumArray variable
        {
            int[] left; // assign variable left
            int[] right; // assign variable right 
            int[] result = new int[array.Length]; // result equals new lenght variable
            

            if (array.Length <= 1) // return to array if length is less than 1 and equal
                return array;
              
            int midPoint = array.Length / 2; // length divided by 2

            left = new int[midPoint]; // left equals midpoint

            

            if (array.Length % 2 == 0) // if 2% of lenght equals 0 then right midPoint equals
                right = new int[midPoint];
            
            else
                right = new int[midPoint + 1]; // else right equals midPoint plus 1 
            
            for (int i = 0; i < midPoint; i++) // write i to the left, starting from 0 and increasing by 1
                left[i] = array[i]; 
               
            int x = 0; 
           

            for (int i = midPoint; i < array.Length; i++) // if i equals midPoint then increase length by 1
            {
                right[x] = array[i]; 
                x++;
            }
            
            left = mergeSort(left); 
            
            right = mergeSort(right);
            
            result = merge(left, right);
            return result;
        }

        //This method will be responsible for combining our two sorted arrays into one giant array
        public static int[] merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];

            int indexLeft = 0, indexRight = 0, indexResult = 0;
            //while either array still has an element
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                //if both arrays have elements  
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    //If item on left array is less than item on right array, add that item to the result array 
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    // else the item in the right array wll be added to the results array
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                //if only the left array still has elements, add all its items to the results array
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                //if only the right array still has elements, add all its items to the results array
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }


        /*
        *
        *      @name Recursive_Power
        *
        *      @brief Recursive_Powering
        *
        *      // Function to calculate x raised to the power y
        *
        *      @param[in] x[\b int] index of Recursive_Power in the serie
        *      @param[in] y[\b int] index of Recursive_Power in the serie
        *
        *      @retval[\b int] calculated Recursive_Power
        */

        public static int Recursive_Power(int x, int y) // return NumArray variable
        {
            if (y == 0) // if y equals 0 return 1
                return 1;
            else
                return x * Recursive_Power(x, y - 1); // if not equal multiply x by (x, y-1)
        }


        /*
        *
        *      @name MasterMethod
        *
        *      @brief MasterMethoding
        *
        *      // Master theorem for iterations of divide and conquer in the analysis of algorithms.
        *
        *      @param[in] r[\b int] index of MasterMethod in the serie
        *      @param[in] s[\b int] index of MasterMethod in the serie
        *      @param[in] fn[\b string] index of MasterMethod in the serie
        *      @retval[\b string] calculated MasterMethod
        */

        public static string MasterMethod(int r, int s, string fn)
        {
            double i = Math.Log(Convert.ToDouble(r), Convert.ToDouble(s));
            double d;
            try
            {
                d = Convert.ToDouble(fn.Replace("n^", ""));

            }
            catch (Exception)
            {
                d = 1;
            }

            if (r >= 1) // if r equals and more than 1 
            {
                if (i > d) // if i more than d then return case 1
                {
                    return "T(n) = n^" + i;
                }
                else if (i == d) //else i equals d return case 2 
                {
                    return "T(n) = n^" + i + "logn";
                }
                else if (i < d) // if i less than d return case 3
                {
                    return "T(n) = n^" + d;
                }
            }
            return "Incalculable!";
        }









    }
}

