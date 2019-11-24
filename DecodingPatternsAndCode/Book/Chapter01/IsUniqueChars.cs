using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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

        public static bool IsUniqueCharsOptimized(string str)
        {
            var rgx = new Regex("[^a-z]", RegexOptions.Compiled);
            var filteredString = rgx.Replace(str, "");
            if (string.CompareOrdinal(str, filteredString) != 0)
            {
                throw new ArgumentException($"The input string {str} contains invalid arguments!");
            }

            var checker = 0;
            foreach (var c in str)
            {
                var val = c - 'a';
                if ((checker & (1 << val)) > 0)
                {
                    return false;
                }

                checker |= (1 << val);
            }
            return true;
        }


        public static bool IsUniqueCharsMemOptimized(string str)
        {
            var vis = string.Empty;
            var bitSet = 0;
            foreach (var c in str)
            {
                var v = new BitVisualizer(bitSet);
                vis = v.ToString();
                //var val_1 = 0 - 'a'; // a =97
                var val = c - 'a';
                if ((bitSet & (1 << val)) > 0)
                {
                    return false;
                }

                bitSet |= (1 << val);
            }

            return true;
        }

    }
}