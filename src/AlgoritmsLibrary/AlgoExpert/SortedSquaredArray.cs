using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsLibrary.AlgoExpert
{

    public  class SortedSquaredArrayClass
    {
        /// <summary>
        /// Write a function that takes in a non-empty array of integers that are sorted in ascending order
        /// and returns a new array of the same length with the squares of original integers, also 
        /// sorted in ascending order
        /// Tricky part is  that array will contain Negative values as well, their squares will be positive integers
        /// and the result array needs to be re-ordered
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] SortedSquaredArray(int[] array)
        {
            int left = 0;
            int right = array.Length - 1;
            int[] result= new int[array.Length];
            int count = right;
            while (count>=0)
            {
                if (Math.Abs(array[left]) > Math.Abs(array[right]))
                {
                    result[count] = array[left] * array[left];
                    left++;
                }
                else
                {
                    result[count] = array[right] *  array[right];
                    right--;
                }
                count--;
            }
            return result;
        }
    }
}
