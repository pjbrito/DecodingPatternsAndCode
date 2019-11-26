using System;
using Xunit;

namespace DecodingPatternsAndCode.Tests.BookTests.Chapter08
{
    public class TripleStep
    {
        private static int _recur = 0;

        [Fact]
        public void TestTripleStep()
        {

            var max1 = int.MaxValue;        //                          2 147 483 647   //
            //                                                          2 082 876 103   //  36 in fb3 series
            //                                                          1 836 311 903   //  45 in fib series
            var max2 = Int64.MaxValue;      //              9 223 372 036 854 775 807   //
            //                                              7 015 254 043 203 144 209   //  72 in fb3 series
            //                                              7 540 113 804 746 346 429   //  91 in fib series
            var max3 = decimal.MaxValue;    // 79 228 162 514 264 337 593 543 950 335   //
            //                                 43 458 307 810 949 238 672 214 594 009   // 109 in fb3 series
            //                                 50 095 301 248 058 391 139 327 916 261   // 138 in fib series

            var res = TripleStep.CountWays(10);
            Assert.Equal(274, res);
        }

        public static decimal CountWays(int n)
        {
            var memo = new decimal[n + 1];
            Array.Fill(memo, -1);
            var res = CountWays(n, memo);

            return res;
        }

        private static decimal CountWays(int n, decimal[] memo)
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
