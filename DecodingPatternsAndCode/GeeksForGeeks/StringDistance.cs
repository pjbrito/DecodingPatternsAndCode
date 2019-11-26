using System;
using Xunit;

namespace DecodingPatternsAndCode.Tests.GeeksForGeeks
{
    public class StringDistance
    {
        private static string Visualize(int[,] dp)
        {
            var xLen = dp.GetLength(0);
            var yLen = dp.GetLength(1);

            var visStr = string.Empty;
            for (var i = 0; i < xLen; i++)
            {
                for (var j = 0; j < yLen; j++)
                {
                    visStr += $"{dp[i, j]}";
                }
                visStr += "\n";
            }

            return visStr;
        }

        [Fact]
        public void CheckStringDistance()
        {
            var str1 = "geek";
            var str2 = "gks";
            var k = 3;

            var res = areKDistant(str1, str2, k);
            Assert.True(res);
        }

        private static int editDistDP(string str1, string str2, int m, int n)
        {
            // Create a table to store results of sub-problems
            int[,] dp = new int[m + 1, n + 1];

            // Fill d[][] in bottom up manner
            for (var i = 0; i <= m; i++)
            {
                for (var j = 0; j <= n; j++)
                {
                    // If first string is empty, only option is to insert all characters of second string
                    if (i == 0)
                    {
                        // Min. operations = j 
                        dp[i, j] = j;
                    }
                    // If second string is empty, only option is to remove all characters of second string
                    else if (j == 0)
                    {
                        // Min. operations = i
                        dp[i, j] = i;
                    }
                    // If last characters are same, ignore last char and recur for remaining string
                    else if (str1[i - 1] == str2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                    // If last character are different, consider all possibilities and find minimum
                    else
                    {
                        var insert = dp[i, j - 1];
                        var remove = dp[i - 1, j];
                        var replace = dp[i - 1, j - 1];
                        var val = 1 + min(insert, remove, replace);
                        dp[i, j] = val;
                    }
                    var v = Visualize(dp);
                }
            }
            return dp[m, n];
        }

        private static int min(int x, int y, int z)
        {
            return Math.Min(Math.Min(x, y), z);
        }

        // Returns true if str1 and str2 are 
        // k edit distance apart, else false. 
        public static bool areKDistant(string str1, string str2, int k)
        {
            var m = str1.Length;
            var n = str2.Length;

            if (Math.Abs(m - n) > k)
                return false;

            return (editDistDP(str1, str2, m, n) <= k);
        }

    }
}
