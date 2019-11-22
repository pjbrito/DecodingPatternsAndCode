﻿using System;
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

            [Theory]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0000_0000_0000), unchecked((int)0b_1100_0000_0000_0000_0000_0000_0000_0000), 1)]
            [InlineData(unchecked((int)0b_1100_0000_0000_0000_0000_0000_0000_0000), unchecked((int)0b_1110_0000_0000_0000_0000_0000_0000_0000), 2)]
            [InlineData(unchecked((int)0b_1110_0000_0000_0000_0000_0000_0000_0000), unchecked((int)0b_1111_0000_0000_0000_0000_0000_0000_0000), 3)]
            [InlineData(unchecked((int)0b_1111_0000_0000_0000_0000_0000_0000_0000), unchecked((int)0b_1111_1000_0000_0000_0000_0000_0000_0000), 4)]
            [InlineData(unchecked((int)0b_1111_1000_0000_0000_0000_0000_0000_0000), unchecked((int)0b_1111_1100_0000_0000_0000_0000_0000_0000), 5)]
            [InlineData(unchecked((int)0b_1111_1100_0000_0000_0000_0000_0000_0000), unchecked((int)0b_1111_1110_0000_0000_0000_0000_0000_0000), 6)]
            [InlineData(unchecked((int)0b_1111_1110_0000_0000_0000_0000_0000_0000), unchecked((int)0b_1111_1111_0000_0000_0000_0000_0000_0000), 7)]
            [InlineData(unchecked((int)0b_1111_1111_0000_0000_0000_0000_0000_0000), unchecked((int)0b_1111_1111_1000_0000_0000_0000_0000_0000), 8)]
            [InlineData(unchecked((int)0b_1111_1111_1000_0000_0000_0000_0000_0000), unchecked((int)0b_1111_1111_1100_0000_0000_0000_0000_0000), 9)]
            [InlineData(unchecked((int)0b_1111_1111_1100_0000_0000_0000_0000_0000), unchecked((int)0b_1111_1111_1110_0000_0000_0000_0000_0000), 10)]
            [InlineData(unchecked((int)0b_1111_1111_1110_0000_0000_0000_0000_0000), unchecked((int)0b_1111_1111_1111_0000_0000_0000_0000_0000), 11)]
            [InlineData(unchecked((int)0b_1111_1111_1111_0000_0000_0000_0000_0000), unchecked((int)0b_1111_1111_1111_1000_0000_0000_0000_0000), 12)]
            [InlineData(unchecked((int)0b_1111_1111_1111_1000_0000_0000_0000_0000), unchecked((int)0b_1111_1111_1111_1100_0000_0000_0000_0000), 13)]
            [InlineData(unchecked((int)0b_1111_1111_1111_1100_0000_0000_0000_0000), unchecked((int)0b_1111_1111_1111_1110_0000_0000_0000_0000), 14)]
            [InlineData(unchecked((int)0b_1111_1111_1111_1110_0000_0000_0000_0000), unchecked((int)0b_1111_1111_1111_1111_0000_0000_0000_0000), 15)]
            [InlineData(unchecked((int)0b_1111_1111_1111_1111_0000_0000_0000_0000), unchecked((int)0b_1111_1111_1111_1111_1000_0000_0000_0000), 16)]
            [InlineData(unchecked((int)0b_1111_1111_1111_1111_1000_0000_0000_0000), unchecked((int)0b_1111_1111_1111_1111_1100_0000_0000_0000), 17)]
            [InlineData(unchecked((int)0b_1111_1111_1111_1111_1100_0000_0000_0000), unchecked((int)0b_1111_1111_1111_1111_1110_0000_0000_0000), 18)]
            [InlineData(unchecked((int)0b_1111_1111_1111_1111_1110_0000_0000_0000), unchecked((int)0b_1111_1111_1111_1111_1111_0000_0000_0000), 19)]
            [InlineData(unchecked((int)0b_1111_1111_1111_1111_1111_0000_0000_0000), unchecked((int)0b_1111_1111_1111_1111_1111_1000_0000_0000), 20)]
            [InlineData(unchecked((int)0b_1111_1111_1111_1111_1111_1000_0000_0000), unchecked((int)0b_1111_1111_1111_1111_1111_1100_0000_0000), 21)]
            [InlineData(unchecked((int)0b_1111_1111_1111_1111_1111_1100_0000_0000), unchecked((int)0b_1111_1111_1111_1111_1111_1110_0000_0000), 22)]
            [InlineData(unchecked((int)0b_1111_1111_1111_1111_1111_1110_0000_0000), unchecked((int)0b_1111_1111_1111_1111_1111_1111_0000_0000), 23)]
            [InlineData(unchecked((int)0b_1111_1111_1111_1111_1111_1111_0000_0000), unchecked((int)0b_1111_1111_1111_1111_1111_1111_1000_0000), 24)]
            [InlineData(unchecked((int)0b_1111_1111_1111_1111_1111_1111_1000_0000), unchecked((int)0b_1111_1111_1111_1111_1111_1111_1100_0000), 25)]
            [InlineData(unchecked((int)0b_1111_1111_1111_1111_1111_1111_1100_0000), unchecked((int)0b_1111_1111_1111_1111_1111_1111_1110_0000), 26)]
            [InlineData(unchecked((int)0b_1111_1111_1111_1111_1111_1111_1110_0000), unchecked((int)0b_1111_1111_1111_1111_1111_1111_1111_0000), 27)]
            [InlineData(unchecked((int)0b_1111_1111_1111_1111_1111_1111_1111_0000), unchecked((int)0b_1111_1111_1111_1111_1111_1111_1111_1000), 28)]
            [InlineData(unchecked((int)0b_1111_1111_1111_1111_1111_1111_1111_1000), unchecked((int)0b_1111_1111_1111_1111_1111_1111_1111_1100), 29)]
            [InlineData(unchecked((int)0b_1111_1111_1111_1111_1111_1111_1111_1100), unchecked((int)0b_1111_1111_1111_1111_1111_1111_1111_1110), 30)]
            [InlineData(unchecked((int)0b_1111_1111_1111_1111_1111_1111_1111_1110), unchecked((int)0b_1111_1111_1111_1111_1111_1111_1111_1111), 31)]
            [InlineData(unchecked((int)0b_1111_1111_1111_1111_1111_1111_1111_1111), unchecked((int)0b_1111_1111_1111_1111_1111_1111_1111_1111), 32)]
            public void RightShiftForNegativeNumbersDividesByTwo(int t, int shifted, int numOfDivisions)
            {
                var test = t >> 1;
                Assert.Equal(shifted, test);

                var e = int.MinValue;
                for (var i = 0; i < numOfDivisions; i++)
                {
                    e /= 2;
                }

                if (t != -1)
                {
                    Assert.Equal(e, test);
                }
                else
                {
                    Assert.Equal(-1, test);
                }
            }

            [Theory]
            [InlineData(unchecked((int)0b_0100_0000_0000_0000_0000_0000_0000_0000), unchecked((int)0b_0010_0000_0000_0000_0000_0000_0000_0000), 1)]
            [InlineData(unchecked((int)0b_0010_0000_0000_0000_0000_0000_0000_0000), unchecked((int)0b_0001_0000_0000_0000_0000_0000_0000_0000), 2)]
            [InlineData(unchecked((int)0b_0001_0000_0000_0000_0000_0000_0000_0000), unchecked((int)0b_0000_1000_0000_0000_0000_0000_0000_0000), 3)]
            [InlineData(unchecked((int)0b_0000_1000_0000_0000_0000_0000_0000_0000), unchecked((int)0b_0000_0100_0000_0000_0000_0000_0000_0000), 4)]
            [InlineData(unchecked((int)0b_0000_0100_0000_0000_0000_0000_0000_0000), unchecked((int)0b_0000_0010_0000_0000_0000_0000_0000_0000), 5)]
            [InlineData(unchecked((int)0b_0000_0010_0000_0000_0000_0000_0000_0000), unchecked((int)0b_0000_0001_0000_0000_0000_0000_0000_0000), 6)]
            [InlineData(unchecked((int)0b_0000_0001_0000_0000_0000_0000_0000_0000), unchecked((int)0b_0000_0000_1000_0000_0000_0000_0000_0000), 7)]
            [InlineData(unchecked((int)0b_0000_0000_1000_0000_0000_0000_0000_0000), unchecked((int)0b_0000_0000_0100_0000_0000_0000_0000_0000), 8)]
            [InlineData(unchecked((int)0b_0000_0000_0100_0000_0000_0000_0000_0000), unchecked((int)0b_0000_0000_0010_0000_0000_0000_0000_0000), 9)]
            [InlineData(unchecked((int)0b_0000_0000_0010_0000_0000_0000_0000_0000), unchecked((int)0b_0000_0000_0001_0000_0000_0000_0000_0000), 10)]
            [InlineData(unchecked((int)0b_0000_0000_0001_0000_0000_0000_0000_0000), unchecked((int)0b_0000_0000_0000_1000_0000_0000_0000_0000), 11)]
            [InlineData(unchecked((int)0b_0000_0000_0000_1000_0000_0000_0000_0000), unchecked((int)0b_0000_0000_0000_0100_0000_0000_0000_0000), 12)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0100_0000_0000_0000_0000), unchecked((int)0b_0000_0000_0000_0010_0000_0000_0000_0000), 13)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0010_0000_0000_0000_0000), unchecked((int)0b_0000_0000_0000_0001_0000_0000_0000_0000), 14)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0001_0000_0000_0000_0000), unchecked((int)0b_0000_0000_0000_0000_1000_0000_0000_0000), 15)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0000_1000_0000_0000_0000), unchecked((int)0b_0000_0000_0000_0000_0100_0000_0000_0000), 16)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0000_0100_0000_0000_0000), unchecked((int)0b_0000_0000_0000_0000_0010_0000_0000_0000), 17)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0000_0010_0000_0000_0000), unchecked((int)0b_0000_0000_0000_0000_0001_0000_0000_0000), 18)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0000_0001_0000_0000_0000), unchecked((int)0b_0000_0000_0000_0000_0000_1000_0000_0000), 19)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0000_0000_1000_0000_0000), unchecked((int)0b_0000_0000_0000_0000_0000_0100_0000_0000), 20)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0000_0000_0100_0000_0000), unchecked((int)0b_0000_0000_0000_0000_0000_0010_0000_0000), 21)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0000_0000_0010_0000_0000), unchecked((int)0b_0000_0000_0000_0000_0000_0001_0000_0000), 22)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0000_0000_0001_0000_0000), unchecked((int)0b_0000_0000_0000_0000_0000_0000_1000_0000), 23)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0000_0000_0000_1000_0000), unchecked((int)0b_0000_0000_0000_0000_0000_0000_0100_0000), 24)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0000_0000_0000_0100_0000), unchecked((int)0b_0000_0000_0000_0000_0000_0000_0010_0000), 25)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0000_0000_0000_0010_0000), unchecked((int)0b_0000_0000_0000_0000_0000_0000_0001_0000), 26)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0000_0000_0000_0001_0000), unchecked((int)0b_0000_0000_0000_0000_0000_0000_0000_1000), 27)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0000_0000_0000_0000_1000), unchecked((int)0b_0000_0000_0000_0000_0000_0000_0000_0100), 28)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0000_0000_0000_0000_0100), unchecked((int)0b_0000_0000_0000_0000_0000_0000_0000_0010), 29)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0000_0000_0000_0000_0010), unchecked((int)0b_0000_0000_0000_0000_0000_0000_0000_0001), 30)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0000_0000_0000_0000_0001), unchecked((int)0b_0000_0000_0000_0000_0000_0000_0000_0000), 31)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0000_0000_0000_0000_0000), unchecked((int)0b_0000_0000_0000_0000_0000_0000_0000_0000), 32)]
            public void RightShiftForPositiveNumbersDividesByTwo(int t, int shifted, int numOfDivisions)
            {
                var test = t >> 1;
                Assert.Equal(shifted, test);

                var e = int.MaxValue;
                for (var i = 0; i <= numOfDivisions; i++)
                {
                    e /= 2;
                }

                if (numOfDivisions < 31)
                {
                    e += 1;
                    Assert.Equal(e, test);
                }
                else
                {
                    Assert.Equal(0, test);
                }
            }

            [Theory]
            [InlineData(unchecked((int)0b_0000_0000_0000_0000_0000_0000_0000_0001), unchecked((int)0b_0000_0000_0000_0000_0000_0000_0000_0010), 1)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0000_0000_0000_0000_0010), unchecked((int)0b_0000_0000_0000_0000_0000_0000_0000_0100), 2)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0000_0000_0000_0000_0100), unchecked((int)0b_0000_0000_0000_0000_0000_0000_0000_1000), 3)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0000_0000_0000_0000_1000), unchecked((int)0b_0000_0000_0000_0000_0000_0000_0001_0000), 4)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0000_0000_0000_0001_0000), unchecked((int)0b_0000_0000_0000_0000_0000_0000_0010_0000), 5)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0000_0000_0000_0010_0000), unchecked((int)0b_0000_0000_0000_0000_0000_0000_0100_0000), 6)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0000_0000_0000_0100_0000), unchecked((int)0b_0000_0000_0000_0000_0000_0000_1000_0000), 7)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0000_0000_0000_1000_0000), unchecked((int)0b_0000_0000_0000_0000_0000_0001_0000_0000), 8)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0000_0000_0001_0000_0000), unchecked((int)0b_0000_0000_0000_0000_0000_0010_0000_0000), 9)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0000_0000_0010_0000_0000), unchecked((int)0b_0000_0000_0000_0000_0000_0100_0000_0000), 10)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0000_0000_0100_0000_0000), unchecked((int)0b_0000_0000_0000_0000_0000_1000_0000_0000), 11)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0000_0000_1000_0000_0000), unchecked((int)0b_0000_0000_0000_0000_0001_0000_0000_0000), 12)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0000_0001_0000_0000_0000), unchecked((int)0b_0000_0000_0000_0000_0010_0000_0000_0000), 13)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0000_0010_0000_0000_0000), unchecked((int)0b_0000_0000_0000_0000_0100_0000_0000_0000), 14)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0000_0100_0000_0000_0000), unchecked((int)0b_0000_0000_0000_0000_1000_0000_0000_0000), 15)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0000_1000_0000_0000_0000), unchecked((int)0b_0000_0000_0000_0001_0000_0000_0000_0000), 16)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0001_0000_0000_0000_0000), unchecked((int)0b_0000_0000_0000_0010_0000_0000_0000_0000), 17)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0010_0000_0000_0000_0000), unchecked((int)0b_0000_0000_0000_0100_0000_0000_0000_0000), 18)]
            [InlineData(unchecked((int)0b_0000_0000_0000_0100_0000_0000_0000_0000), unchecked((int)0b_0000_0000_0000_1000_0000_0000_0000_0000), 19)]
            [InlineData(unchecked((int)0b_0000_0000_0000_1000_0000_0000_0000_0000), unchecked((int)0b_0000_0000_0001_0000_0000_0000_0000_0000), 20)]
            [InlineData(unchecked((int)0b_0000_0000_0001_0000_0000_0000_0000_0000), unchecked((int)0b_0000_0000_0010_0000_0000_0000_0000_0000), 21)]
            [InlineData(unchecked((int)0b_0000_0000_0010_0000_0000_0000_0000_0000), unchecked((int)0b_0000_0000_0100_0000_0000_0000_0000_0000), 22)]
            [InlineData(unchecked((int)0b_0000_0000_0100_0000_0000_0000_0000_0000), unchecked((int)0b_0000_0000_1000_0000_0000_0000_0000_0000), 23)]
            [InlineData(unchecked((int)0b_0000_0000_1000_0000_0000_0000_0000_0000), unchecked((int)0b_0000_0001_0000_0000_0000_0000_0000_0000), 24)]
            [InlineData(unchecked((int)0b_0000_0001_0000_0000_0000_0000_0000_0000), unchecked((int)0b_0000_0010_0000_0000_0000_0000_0000_0000), 25)]
            [InlineData(unchecked((int)0b_0000_0010_0000_0000_0000_0000_0000_0000), unchecked((int)0b_0000_0100_0000_0000_0000_0000_0000_0000), 26)]
            [InlineData(unchecked((int)0b_0000_0100_0000_0000_0000_0000_0000_0000), unchecked((int)0b_0000_1000_0000_0000_0000_0000_0000_0000), 27)]
            [InlineData(unchecked((int)0b_0000_1000_0000_0000_0000_0000_0000_0000), unchecked((int)0b_0001_0000_0000_0000_0000_0000_0000_0000), 28)]
            [InlineData(unchecked((int)0b_0001_0000_0000_0000_0000_0000_0000_0000), unchecked((int)0b_0010_0000_0000_0000_0000_0000_0000_0000), 29)]
            [InlineData(unchecked((int)0b_0010_0000_0000_0000_0000_0000_0000_0000), unchecked((int)0b_0100_0000_0000_0000_0000_0000_0000_0000), 30)]
            [InlineData(unchecked((int)0b_0100_0000_0000_0000_0000_0000_0000_0000), unchecked((int)0b_1000_0000_0000_0000_0000_0000_0000_0000), 31)]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0000_0000_0000), unchecked((int)0b_0000_0000_0000_0000_0000_0000_0000_0000), 32)]
            public void LeftShiftForPositiveNumbersMultipliesByTwo(int t, int shifted, int numOfMultiplications)
            {
                var test = t << 1;
                Assert.Equal(shifted, test);

                var e = 1;
                for (var i = 0; i < numOfMultiplications; i++)
                {
                    e *= 2;
                }

                if (numOfMultiplications < 32)
                {
                    Assert.Equal(e, test);
                }
                else
                {
                    Assert.Equal(0, test);
                }
            }

            [Theory]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0000_0000_0001), unchecked((int)0b_0000_0000_0000_0000_0000_0000_0000_0010), 1)]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0000_0000_0010), unchecked((int)0b_0000_0000_0000_0000_0000_0000_0000_0100), 2)]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0000_0000_0100), unchecked((int)0b_0000_0000_0000_0000_0000_0000_0000_1000), 3)]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0000_0000_1000), unchecked((int)0b_0000_0000_0000_0000_0000_0000_0001_0000), 4)]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0000_0001_0000), unchecked((int)0b_0000_0000_0000_0000_0000_0000_0010_0000), 5)]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0000_0010_0000), unchecked((int)0b_0000_0000_0000_0000_0000_0000_0100_0000), 6)]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0000_0100_0000), unchecked((int)0b_0000_0000_0000_0000_0000_0000_1000_0000), 7)]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0000_1000_0000), unchecked((int)0b_0000_0000_0000_0000_0000_0001_0000_0000), 8)]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0001_0000_0000), unchecked((int)0b_0000_0000_0000_0000_0000_0010_0000_0000), 9)]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0010_0000_0000), unchecked((int)0b_0000_0000_0000_0000_0000_0100_0000_0000), 10)]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0100_0000_0000), unchecked((int)0b_0000_0000_0000_0000_0000_1000_0000_0000), 11)]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_1000_0000_0000), unchecked((int)0b_0000_0000_0000_0000_0001_0000_0000_0000), 12)]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0001_0000_0000_0000), unchecked((int)0b_0000_0000_0000_0000_0010_0000_0000_0000), 13)]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0010_0000_0000_0000), unchecked((int)0b_0000_0000_0000_0000_0100_0000_0000_0000), 14)]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0100_0000_0000_0000), unchecked((int)0b_0000_0000_0000_0000_1000_0000_0000_0000), 15)]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_1000_0000_0000_0000), unchecked((int)0b_0000_0000_0000_0001_0000_0000_0000_0000), 16)]
            [InlineData(unchecked((int)0b_1000_0000_0000_0001_0000_0000_0000_0000), unchecked((int)0b_0000_0000_0000_0010_0000_0000_0000_0000), 17)]
            [InlineData(unchecked((int)0b_1000_0000_0000_0010_0000_0000_0000_0000), unchecked((int)0b_0000_0000_0000_0100_0000_0000_0000_0000), 18)]
            [InlineData(unchecked((int)0b_1000_0000_0000_0100_0000_0000_0000_0000), unchecked((int)0b_0000_0000_0000_1000_0000_0000_0000_0000), 19)]
            [InlineData(unchecked((int)0b_1000_0000_0000_1000_0000_0000_0000_0000), unchecked((int)0b_0000_0000_0001_0000_0000_0000_0000_0000), 20)]
            [InlineData(unchecked((int)0b_1000_0000_0001_0000_0000_0000_0000_0000), unchecked((int)0b_0000_0000_0010_0000_0000_0000_0000_0000), 21)]
            [InlineData(unchecked((int)0b_1000_0000_0010_0000_0000_0000_0000_0000), unchecked((int)0b_0000_0000_0100_0000_0000_0000_0000_0000), 22)]
            [InlineData(unchecked((int)0b_1000_0000_0100_0000_0000_0000_0000_0000), unchecked((int)0b_0000_0000_1000_0000_0000_0000_0000_0000), 23)]
            [InlineData(unchecked((int)0b_1000_0000_1000_0000_0000_0000_0000_0000), unchecked((int)0b_0000_0001_0000_0000_0000_0000_0000_0000), 24)]
            [InlineData(unchecked((int)0b_1000_0001_0000_0000_0000_0000_0000_0000), unchecked((int)0b_0000_0010_0000_0000_0000_0000_0000_0000), 25)]
            [InlineData(unchecked((int)0b_1000_0010_0000_0000_0000_0000_0000_0000), unchecked((int)0b_0000_0100_0000_0000_0000_0000_0000_0000), 26)]
            [InlineData(unchecked((int)0b_1000_0100_0000_0000_0000_0000_0000_0000), unchecked((int)0b_0000_1000_0000_0000_0000_0000_0000_0000), 27)]
            [InlineData(unchecked((int)0b_1000_1000_0000_0000_0000_0000_0000_0000), unchecked((int)0b_0001_0000_0000_0000_0000_0000_0000_0000), 28)]
            [InlineData(unchecked((int)0b_1001_0000_0000_0000_0000_0000_0000_0000), unchecked((int)0b_0010_0000_0000_0000_0000_0000_0000_0000), 29)]
            [InlineData(unchecked((int)0b_1010_0000_0000_0000_0000_0000_0000_0000), unchecked((int)0b_0100_0000_0000_0000_0000_0000_0000_0000), 30)]
            [InlineData(unchecked((int)0b_1100_0000_0000_0000_0000_0000_0000_0000), unchecked((int)0b_1000_0000_0000_0000_0000_0000_0000_0000), 31)]
            [InlineData(unchecked((int)0b_1000_0000_0000_0000_0000_0000_0000_0000), unchecked((int)0b_0000_0000_0000_0000_0000_0000_0000_0000), 32)]
            public void LeftShiftForNegativeNumbersDoesNotMultiplyByTwo(int t, int shifted, int numOfMultiplications)
            {
                var test = t << 1;
                Assert.Equal(shifted, test);

                var e = 1;
                for (var i = 0; i < numOfMultiplications; i++)
                {
                    e *= 2;
                }

                if (numOfMultiplications < 32)
                {
                    Assert.Equal(e, test);
                }
                else
                {
                    Assert.Equal(0, test);
                }
            }

        }
    }
}