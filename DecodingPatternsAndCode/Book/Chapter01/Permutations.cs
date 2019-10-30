using System;

namespace DecodingPatternsAndCode.Tests.Book.Chapter01
{
    public static class PermutationsChecker
    {

        public static bool Permutation(string s, string t)
        {
            if (s.Length != t.Length || string.CompareOrdinal(s, t) == 0)
            {
                return false;
            }

            return Sort(s).Equals(Sort(t));
        }

        public static bool PermutationOptimized(string s, string t)
        {
            if (s.Length != t.Length || string.CompareOrdinal(s, t) == 0)
            {
                return false;
            }

            var letters = new int[128]; // Assumption

            var sArray = s.ToCharArray();
            for (var i = 0; i < sArray.Length; i++)
            {
                letters[sArray[i]]++; // count number of each char in s
            }

            for (var i = 0; i < t.Length; i++)
            {
                var c = (int)t[i];
                letters[c]--;
                if (letters[c] < 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static string Sort(string s)
        {
            var cArr = s.ToCharArray();
            Array.Sort(cArr);

            return new string(cArr);
        }

    }
}