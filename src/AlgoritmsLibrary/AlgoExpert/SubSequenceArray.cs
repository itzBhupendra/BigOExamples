using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsLibrary.AlgoExpert
{
    public class SubSequenceArray
    {
        /// <summary>
        /// Main Array -->       [5, 1, 22, 25, 6, -1, 8, 10]
        /// SubSequence Array--> [1, 6, -1, 10]
        /// 
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="sequence"></param>
        /// <returns></returns>
        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {

            int arrayCount  = 0;
            int totalFound = 0;

            while (totalFound != sequence.Count && arrayCount!= array.Count)
            { 
                if(array[arrayCount]== sequence[totalFound])
                    totalFound++;
                arrayCount++;
            }
            return totalFound== sequence.Count;
        }
    }
}
