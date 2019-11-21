using System;
using DecodingPatternsAndCode.Tests.Book.Chapter01;
using Xunit;

namespace DecodingPatternsAndCode.Tests.BookTests.Chapter01
{
    public class IsUniqueCharsTests
    {
        public class TheIsUniqueCharsAlgorithmShould
        {
            [Theory]
            [InlineData("MyBlackFoxWithDrugPens", true)]
            [InlineData("BlackFoxPen", true)]
            [InlineData("a", true)]
            [InlineData("", true)]
            [InlineData("AmazingChars", false)]
            [InlineData("bb", false)]
            public void BeAbleToDetectRepeatedChars(string inputString, bool expectedResult)
            {
                var actualResult = IsUniqueCharsBaseCase.IsUniqueChars(inputString);
                Assert.Equal(expectedResult, actualResult);
            }

            [Theory]
            [InlineData("myblackfoxwithdrugpens", true)]
            [InlineData("blackfoxpen", true)]
            [InlineData("amazingchars", false)]
            [InlineData("a", true)]
            [InlineData("", true)]
            [InlineData("bb", false)]
            public void BeAbleToDetectRepeatedCharsInTheOptimizedVersion(string inputString, bool expectedResult)
            {
                var actualResult = IsUniqueCharsBaseCase.IsUniqueCharsOptimized(inputString);
                Assert.Equal(expectedResult, actualResult);
            }

            [Theory]
            [InlineData("MyBlackFoxWithDrugPens")]
            [InlineData("BlackFoxPen")]
            [InlineData("AmazingChars")]
            public void BeAbleToDetectBadInputStringsInTheOptimizedVersion(string inputString)
            {
                Assert.Throws<ArgumentException>(() => { IsUniqueCharsBaseCase.IsUniqueCharsOptimized(inputString); });
            }

            [Theory]
            [InlineData(-2, "01000000000000000000000000000000")]
            [InlineData(-1, "10000000000000000000000000000000")]
            #region [InlineData(0, "00000000000000000000000000000001")] to [InlineData(128, "00000000000000000000000000000001")]
            [InlineData(0, "00000000000000000000000000000001")]
            [InlineData(1, "00000000000000000000000000000010")]
            [InlineData(2, "00000000000000000000000000000100")]
            [InlineData(3, "00000000000000000000000000001000")]
            [InlineData(4, "00000000000000000000000000010000")]
            [InlineData(5, "00000000000000000000000000100000")]
            [InlineData(6, "00000000000000000000000001000000")]
            [InlineData(7, "00000000000000000000000010000000")]
            [InlineData(8, "00000000000000000000000100000000")]
            [InlineData(9, "00000000000000000000001000000000")]
            [InlineData(10, "00000000000000000000010000000000")]
            [InlineData(11, "00000000000000000000100000000000")]
            [InlineData(12, "00000000000000000001000000000000")]
            [InlineData(13, "00000000000000000010000000000000")]
            [InlineData(14, "00000000000000000100000000000000")]
            [InlineData(15, "00000000000000001000000000000000")]
            [InlineData(16, "00000000000000010000000000000000")]
            [InlineData(17, "00000000000000100000000000000000")]
            [InlineData(18, "00000000000001000000000000000000")]
            [InlineData(19, "00000000000010000000000000000000")]
            [InlineData(20, "00000000000100000000000000000000")]
            [InlineData(21, "00000000001000000000000000000000")]
            [InlineData(22, "00000000010000000000000000000000")]
            [InlineData(23, "00000000100000000000000000000000")]
            [InlineData(24, "00000001000000000000000000000000")]
            [InlineData(25, "00000010000000000000000000000000")]
            [InlineData(26, "00000100000000000000000000000000")]
            [InlineData(27, "00001000000000000000000000000000")]
            [InlineData(28, "00010000000000000000000000000000")]
            [InlineData(29, "00100000000000000000000000000000")]
            [InlineData(30, "01000000000000000000000000000000")]
            [InlineData(31, "10000000000000000000000000000000")]
            [InlineData(32, "00000000000000000000000000000001")]
            [InlineData(33, "00000000000000000000000000000010")]
            [InlineData(34, "00000000000000000000000000000100")]
            [InlineData(35, "00000000000000000000000000001000")]
            [InlineData(36, "00000000000000000000000000010000")]
            [InlineData(37, "00000000000000000000000000100000")]
            [InlineData(38, "00000000000000000000000001000000")]
            [InlineData(39, "00000000000000000000000010000000")]
            [InlineData(40, "00000000000000000000000100000000")]
            [InlineData(41, "00000000000000000000001000000000")]
            [InlineData(42, "00000000000000000000010000000000")]
            [InlineData(43, "00000000000000000000100000000000")]
            [InlineData(44, "00000000000000000001000000000000")]
            [InlineData(45, "00000000000000000010000000000000")]
            [InlineData(46, "00000000000000000100000000000000")]
            [InlineData(47, "00000000000000001000000000000000")]
            [InlineData(48, "00000000000000010000000000000000")]
            [InlineData(49, "00000000000000100000000000000000")]
            [InlineData(50, "00000000000001000000000000000000")]
            [InlineData(51, "00000000000010000000000000000000")]
            [InlineData(52, "00000000000100000000000000000000")]
            [InlineData(53, "00000000001000000000000000000000")]
            [InlineData(54, "00000000010000000000000000000000")]
            [InlineData(55, "00000000100000000000000000000000")]
            [InlineData(56, "00000001000000000000000000000000")]
            [InlineData(57, "00000010000000000000000000000000")]
            [InlineData(58, "00000100000000000000000000000000")]
            [InlineData(59, "00001000000000000000000000000000")]
            [InlineData(60, "00010000000000000000000000000000")]
            [InlineData(61, "00100000000000000000000000000000")]
            [InlineData(62, "01000000000000000000000000000000")]
            [InlineData(63, "10000000000000000000000000000000")]
            [InlineData(64, "00000000000000000000000000000001")]
            [InlineData(65, "00000000000000000000000000000010")]
            [InlineData(66, "00000000000000000000000000000100")]
            [InlineData(67, "00000000000000000000000000001000")]
            [InlineData(68, "00000000000000000000000000010000")]
            [InlineData(69, "00000000000000000000000000100000")]
            [InlineData(70, "00000000000000000000000001000000")]
            [InlineData(71, "00000000000000000000000010000000")]
            [InlineData(72, "00000000000000000000000100000000")]
            [InlineData(73, "00000000000000000000001000000000")]
            [InlineData(74, "00000000000000000000010000000000")]
            [InlineData(75, "00000000000000000000100000000000")]
            [InlineData(76, "00000000000000000001000000000000")]
            [InlineData(77, "00000000000000000010000000000000")]
            [InlineData(78, "00000000000000000100000000000000")]
            [InlineData(79, "00000000000000001000000000000000")]
            [InlineData(80, "00000000000000010000000000000000")]
            [InlineData(81, "00000000000000100000000000000000")]
            [InlineData(82, "00000000000001000000000000000000")]
            [InlineData(83, "00000000000010000000000000000000")]
            [InlineData(84, "00000000000100000000000000000000")]
            [InlineData(85, "00000000001000000000000000000000")]
            [InlineData(86, "00000000010000000000000000000000")]
            [InlineData(87, "00000000100000000000000000000000")]
            [InlineData(88, "00000001000000000000000000000000")]
            [InlineData(89, "00000010000000000000000000000000")]
            [InlineData(90, "00000100000000000000000000000000")]
            [InlineData(91, "00001000000000000000000000000000")]
            [InlineData(92, "00010000000000000000000000000000")]
            [InlineData(93, "00100000000000000000000000000000")]
            [InlineData(94, "01000000000000000000000000000000")]
            [InlineData(95, "10000000000000000000000000000000")]
            [InlineData(96, "00000000000000000000000000000001")]
            [InlineData(97, "00000000000000000000000000000010")]
            [InlineData(98, "00000000000000000000000000000100")]
            [InlineData(99, "00000000000000000000000000001000")]
            [InlineData(100, "00000000000000000000000000010000")]
            [InlineData(101, "00000000000000000000000000100000")]
            [InlineData(102, "00000000000000000000000001000000")]
            [InlineData(103, "00000000000000000000000010000000")]
            [InlineData(104, "00000000000000000000000100000000")]
            [InlineData(105, "00000000000000000000001000000000")]
            [InlineData(106, "00000000000000000000010000000000")]
            [InlineData(107, "00000000000000000000100000000000")]
            [InlineData(108, "00000000000000000001000000000000")]
            [InlineData(109, "00000000000000000010000000000000")]
            [InlineData(110, "00000000000000000100000000000000")]
            [InlineData(111, "00000000000000001000000000000000")]
            [InlineData(112, "00000000000000010000000000000000")]
            [InlineData(113, "00000000000000100000000000000000")]
            [InlineData(114, "00000000000001000000000000000000")]
            [InlineData(115, "00000000000010000000000000000000")]
            [InlineData(116, "00000000000100000000000000000000")]
            [InlineData(117, "00000000001000000000000000000000")]
            [InlineData(118, "00000000010000000000000000000000")]
            [InlineData(119, "00000000100000000000000000000000")]
            [InlineData(120, "00000001000000000000000000000000")]
            [InlineData(121, "00000010000000000000000000000000")]
            [InlineData(122, "00000100000000000000000000000000")]
            [InlineData(123, "00001000000000000000000000000000")]
            [InlineData(124, "00010000000000000000000000000000")]
            [InlineData(125, "00100000000000000000000000000000")]
            [InlineData(126, "01000000000000000000000000000000")]
            [InlineData(127, "10000000000000000000000000000000")]
            [InlineData(128, "00000000000000000000000000000001")]
            #endregion
            public void UseTheShiftOperationCorrectly(int inputValue, string resultBitRepresentation)
            {
                var inputResult = 1 << inputValue; // shift operation
                var resultString = (new BitVisualizer(inputResult)).GetBitString();

                Assert.True(string.CompareOrdinal(resultBitRepresentation, resultString) == 0);
            }

        }

    }

}