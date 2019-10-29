using System;
using System.Collections.Generic;
using System.Text;

namespace DecodingPatternsAndCode.Tests.Book.Chapter01
{
    public class IsUniqueCharsBaseCase
    {
        public static bool IsUniqueChars(string str)
        {
            if (str.Length > 128) return false;
            var char_set = new bool[128];
            for (var i = 0; i < str.Length; i++)
            {
                int val = str[i];
                if (char_set[val]) // Already found this char in string
                {
                    return false;
                }
                char_set[val] = true;
            }
            return true;
        }
    }
}
