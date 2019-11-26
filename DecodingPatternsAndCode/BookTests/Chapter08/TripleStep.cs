﻿using System;
using Xunit;

namespace DecodingPatternsAndCode.Tests.BookTests.Chapter08
{
    public class TripleStep
    {
        private static int _recur = 0;

        [Fact]
        public void TestTripleStep()
        {
            var res = TripleStep.CountWays(100);

            var max1 = int.MaxValue;    // 2 147 483 647                //
            //                             1 836 311 903                // 45 in fib series
            //                             2 082 876 103                // 36 in fb3 series
            var max2 = Int64.MaxValue;  // 9 223 372 036 854 775 807    //
            //                             7 540 113 804 746 346 429    // 91 in fib series
            //                             7 015 254 043 203 144 209    // 72 in fb3 series

            var test = _recur;
        }

        public static Int64 CountWays(Int64 n)
        {
            var memo = new Int64[n + 1];
            Array.Fill(memo, -1);
            var res = CountWays(n, memo);

            return res;
        }

        private static Int64 CountWays(Int64 n, Int64[] memo)
        {
            _recur++;

            if (n < 0)
            {
                return 0;
            }
            else if (n == 0)
            {
                return 1;
            }
            else if (memo[n] > -1)
            {
                return memo[n];
            }
            else
            {
                memo[n] =
                    CountWays(n - 1, memo) +
                    CountWays(n - 2, memo) +
                    CountWays(n - 3, memo);

                return memo[n];
            }
        }

    }
}
