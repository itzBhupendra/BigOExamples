using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AlgoritmsLibrary
{
    internal class LongestSubString
    {
        public int lengthOfLongestSubstring(string s)
        {
            HashSet<char> seen = new HashSet<char> ();

            int left = 0, right = 0 , max = 0;
            while (right<s.Length)
            {
                char c = s[right];
                if (seen.Contains(c))
                {
                    max = Math.Max(max, right - left + 1);
                    seen.Add(c);
                    right++;
                }
                else
                {
                    while (s[left]!= c)
                    {
                        seen.Remove(s[left]);
                        left++;
                    }
                    s.Remove(c);
                    left++;
                }
            }

            return max;
        }
    }
}
