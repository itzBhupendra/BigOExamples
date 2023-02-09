using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsLibrary.AlgoExpert
{
    public static  class NonConstructibleChange
    {
        public static int fnNonConstructibleChange(int[] coins)
        {
            Array.Sort(coins);
            int total = 0;
            for (int i = 0; i < coins.Length; i++)
            {
                if (coins[i] > total + 1)
                    return total + 1;

                total += coins[i];
            }
            // Write your code here.
            return total+1;
        }
    }
}
