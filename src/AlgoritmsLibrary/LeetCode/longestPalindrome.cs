using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsLibrary.LeetCode
{
    public class findLongestPalindrome
    {

        // acccivicmaddam
        public string LongestPalindrome(string s)
        {
            if (s.Length == 1)
                return s;
            if (s.Length == 2)
            {
                if (s[0] == s[1])
                    return s;
                else
                    return s[0].ToString();

            }
            System.Collections.Generic.Dictionary<int, char> dicValues = new Dictionary<int, char>();
        
            for (int i = 0; i < s.Length; i++)
            {
                dicValues.Add(i, s[i]);

            }
            string finalSubstring = "";
            var UniqueValue = dicValues.GroupBy(x => x.Value);
            var data = UniqueValue.Where(x => x.Count() > 1);
            if (UniqueValue.Count() == 1)
                return s;
            int count=0,max=0,left=0, right=0;
            
            foreach (var item in data)
            {
                count = 0;
                left = 0;

                
                foreach (var item2 in item)              
                {
                    count = left;
                    left = item2.Key;
                    var dd = item.Where(a => a.Key > left);
                        foreach (var item3 in dd)
                        {
                            if (left>= count && item3.Key != left)
                            {
                                right = item3.Key;
                                if (right > left)
                                {
                                    string Cut = s.Substring(left, right -left+1);
                                    if (isPalindrome(Cut))
                                    {
                                     
                                        if (finalSubstring == String.Empty)
                                            finalSubstring = Cut;
                                        else
                                            finalSubstring = Cut.Length > max ? Cut : finalSubstring;

                                    max = Math.Max(max, Cut.Length);

                                }
                                }
                            }
                        }
                    
                     
                }
            }
            if (finalSubstring.Length == 0)
                return s[0].ToString();
            return finalSubstring;
        }

        bool isPalindrome(string Value)
        {
            char[] charArray = Value.ToCharArray();
            Array.Reverse(charArray);

            return (new string(charArray) == Value);
        }
    }
}
