using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DecodingPatternsAndCode.Tests.BookTests.Chapter05
{
    public class IntComplementTest
    {
        public class IfDotNetUsesComplementIntVarsShould
        {
            [Fact]
            public void AllowDetectionOfShiftOfZero()
            {
                var t = (int)0b_0100_0000_0000_0000_0000_0000_0000_0000;

                var test1 = t >> 1;

                var expected = (int)0b_0010_0000_0000_0000_0000_0000_0000_0000;
                Assert.Equal(expected, test1);
            }

            [Theory]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0000_0000_0000), unchecked((int)0b_1100_0000_0000_0000_0000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1100_0000_0000_0000_0000_0000_0000_0000), unchecked((int)0b_1110_0000_0000_0000_0000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1010_0000_0000_0000_0000_0000_0000_0000), unchecked((int)0b_1101_0000_0000_0000_0000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1001_0000_0000_0000_0000_0000_0000_0000), unchecked((int)0b_1100_1000_0000_0000_0000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_1000_0000_0000_0000_0000_0000_0000), unchecked((int)0b_1100_0100_0000_0000_0000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0100_0000_0000_0000_0000_0000_0000), unchecked((int)0b_1100_0010_0000_0000_0000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0010_0000_0000_0000_0000_0000_0000), unchecked((int)0b_1100_0001_0000_0000_0000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0001_0000_0000_0000_0000_0000_0000), unchecked((int)0b_1100_0000_1000_0000_0000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_1000_0000_0000_0000_0000_0000), unchecked((int)0b_1100_0000_0100_0000_0000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0100_0000_0000_0000_0000_0000), unchecked((int)0b_1100_0000_0010_0000_0000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0010_0000_0000_0000_0000_0000), unchecked((int)0b_1100_0000_0001_0000_0000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0001_0000_0000_0000_0000_0000), unchecked((int)0b_1100_0000_0000_1000_0000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_1000_0000_0000_0000_0000), unchecked((int)0b_1100_0000_0000_0100_0000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0100_0000_0000_0000_0000), unchecked((int)0b_1100_0000_0000_0010_0000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0010_0000_0000_0000_0000), unchecked((int)0b_1100_0000_0000_0001_0000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0001_0000_0000_0000_0000), unchecked((int)0b_1100_0000_0000_0000_1000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_1000_0000_0000_0000), unchecked((int)0b_1100_0000_0000_0000_0100_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0100_0000_0000_0000), unchecked((int)0b_1100_0000_0000_0000_0010_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0010_0000_0000_0000), unchecked((int)0b_1100_0000_0000_0000_0001_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0001_0000_0000_0000), unchecked((int)0b_1100_0000_0000_0000_0000_1000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_1000_0000_0000), unchecked((int)0b_1100_0000_0000_0000_0000_0100_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0100_0000_0000), unchecked((int)0b_1100_0000_0000_0000_0000_0010_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0010_0000_0000), unchecked((int)0b_1100_0000_0000_0000_0000_0001_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0001_0000_0000), unchecked((int)0b_1100_0000_0000_0000_0000_0000_1000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0000_1000_0000), unchecked((int)0b_1100_0000_0000_0000_0000_0000_0100_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0000_0100_0000), unchecked((int)0b_1100_0000_0000_0000_0000_0000_0010_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0000_0010_0000), unchecked((int)0b_1100_0000_0000_0000_0000_0000_0001_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0000_0001_0000), unchecked((int)0b_1100_0000_0000_0000_0000_0000_0000_1000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0000_0000_1000), unchecked((int)0b_1100_0000_0000_0000_0000_0000_0000_0100))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0000_0000_0100), unchecked((int)0b_1100_0000_0000_0000_0000_0000_0000_0010))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0000_0000_0010), unchecked((int)0b_1100_0000_0000_0000_0000_0000_0000_0001))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0000_0000_0001), unchecked((int)0b_1100_0000_0000_0000_0000_0000_0000_0000))]
            public void BehaveWithRightShiftCoherency(int t, int shifted)
            {
                // var view1 = Convert.ToString(t, toBase: 2);
                // var view2 = Convert.ToString(shifted, toBase: 2);

                var test = t >> 1;
                // var v = Convert.ToString(test, toBase: 2);

                Assert.Equal(shifted, test);
            }

            [Theory]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0000_0000_0000), unchecked((int)0b_0000_0000_0000_0000_0000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1100_0000_0000_0000_0000_0000_0000_0000), unchecked((int)0b_1000_0000_0000_0000_0000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1010_0000_0000_0000_0000_0000_0000_0000), unchecked((int)0b_0100_0000_0000_0000_0000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1001_0000_0000_0000_0000_0000_0000_0000), unchecked((int)0b_0010_0000_0000_0000_0000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_1000_0000_0000_0000_0000_0000_0000), unchecked((int)0b_0001_0000_0000_0000_0000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0100_0000_0000_0000_0000_0000_0000), unchecked((int)0b_0000_1000_0000_0000_0000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0010_0000_0000_0000_0000_0000_0000), unchecked((int)0b_0000_0100_0000_0000_0000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0001_0000_0000_0000_0000_0000_0000), unchecked((int)0b_0000_0010_0000_0000_0000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_1000_0000_0000_0000_0000_0000), unchecked((int)0b_0000_0001_0000_0000_0000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0100_0000_0000_0000_0000_0000), unchecked((int)0b_0000_0000_1000_0000_0000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0010_0000_0000_0000_0000_0000), unchecked((int)0b_0000_0000_0100_0000_0000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0001_0000_0000_0000_0000_0000), unchecked((int)0b_0000_0000_0010_0000_0000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_1000_0000_0000_0000_0000), unchecked((int)0b_0000_0000_0001_0000_0000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0100_0000_0000_0000_0000), unchecked((int)0b_0000_0000_0000_1000_0000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0010_0000_0000_0000_0000), unchecked((int)0b_0000_0000_0000_0100_0000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0001_0000_0000_0000_0000), unchecked((int)0b_0000_0000_0000_0010_0000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_1000_0000_0000_0000), unchecked((int)0b_0000_0000_0000_0001_0000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0100_0000_0000_0000), unchecked((int)0b_0000_0000_0000_0000_1000_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0010_0000_0000_0000), unchecked((int)0b_0000_0000_0000_0000_0100_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0001_0000_0000_0000), unchecked((int)0b_0000_0000_0000_0000_0010_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_1000_0000_0000), unchecked((int)0b_0000_0000_0000_0000_0001_0000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0100_0000_0000), unchecked((int)0b_0000_0000_0000_0000_0000_1000_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0010_0000_0000), unchecked((int)0b_0000_0000_0000_0000_0000_0100_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0001_0000_0000), unchecked((int)0b_0000_0000_0000_0000_0000_0010_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0000_1000_0000), unchecked((int)0b_0000_0000_0000_0000_0000_0001_0000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0000_0100_0000), unchecked((int)0b_0000_0000_0000_0000_0000_0000_1000_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0000_0010_0000), unchecked((int)0b_0000_0000_0000_0000_0000_0000_0100_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0000_0001_0000), unchecked((int)0b_0000_0000_0000_0000_0000_0000_0010_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0000_0000_1000), unchecked((int)0b_0000_0000_0000_0000_0000_0000_0001_0000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0000_0000_0100), unchecked((int)0b_0000_0000_0000_0000_0000_0000_0000_1000))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0000_0000_0010), unchecked((int)0b_0000_0000_0000_0000_0000_0000_0000_0100))]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0000_0000_0001), unchecked((int)0b_0000_0000_0000_0000_0000_0000_0000_0010))]
            public void BehaveWithLeftShiftCoherency(int t, int shifted)
            {
                // var view1 = Convert.ToString(t, toBase: 2);
                // var view2 = Convert.ToString(shifted, toBase: 2);

                var test = t << 1;
                // var v = Convert.ToString(test, toBase: 2);

                Assert.Equal(shifted, test);
            }
        }
    }
}