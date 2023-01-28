using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsLibrary.LeetCode
{
    public class TwoSumProblem
    {

        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dicSumOfIntegers = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int CurrentSum = target - nums[i];
                if (dicSumOfIntegers.ContainsKey(CurrentSum))                
                {
                    return new int[] { dicSumOfIntegers[CurrentSum], i };
                }
                if(!dicSumOfIntegers.ContainsKey(nums[i]))
                    dicSumOfIntegers.Add(nums[i], i);
            }
            
            return null;
        }

    }
}
