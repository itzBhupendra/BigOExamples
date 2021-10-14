using System;
using System.Linq;

namespace AlgoritmsLibrary
{
    public class Palindrome
    {


        public bool CheckPalindromeManual(string strValue)
        {
            int length = string.IsNullOrEmpty(strValue) == false ? strValue.Length : 0;
            if (length < 2)
                return false;

            for (int i = 0; i < length; i++)
            {
                if (strValue[i] != strValue[length - (i+1)])
                    return false;

                if (i == length - (i + 1))
                    break;
            }

            return true;
        }

        public bool CheckPalindromeAuto(string strValue)
        {
            char[] charArray = strValue.ToCharArray();
            Array.Reverse(charArray);
            
            return (new string(charArray) == strValue);            
        }


    }
}
