using Xunit;
using static DecodingPatternsAndCode.Tests.Book.Chapter01.PermutationsChecker;

namespace DecodingPatternsAndCode.Tests
{
    public class BookChapter01Permutations
    {
        public class ThePermutationsAlgorithmShould
        {
            [Theory]
            [InlineData("MyBlackFoxWithPens", "MyBlackPensFoxWith", true)]
            [InlineData("BlackFoxPit", "PitBlackFox", true)]
            [InlineData("BlackFox", "FoxBlack", true)]
            [InlineData("a", "b", false)]
            [InlineData(" ", " ", false)]
            [InlineData("AmazingChars", "CharsAmazing", true)]
            [InlineData("bb", "bb", false)]
            public void BeAbleToDetectStringPermutations(string inputString1, string inputString2, bool expectedResult)
            {
                var actualResult = Permutation(inputString1, inputString2);
                Assert.Equal(expectedResult, actualResult);
            }

            [Theory]
            [InlineData("MyBlackFoxWithPens", "MyBlackPensFoxWith", true)]
            [InlineData("BlackFoxPit", "PitBlackFox", true)]
            [InlineData("BlackFox", "FoxBlack", true)]
            [InlineData("a", "b", false)]
            [InlineData(" ", " ", false)]
            [InlineData("AmazingChars", "CharsAmazing", true)]
            [InlineData("bb", "bb", false)]
            public void BeAbleToDetectStringPermutationsInTheOptimizedVersion(string inputString1, string inputString2, bool expectedResult)
            {
                var actualResult2 = PermutationOptimized(inputString1, inputString2);
                Assert.Equal(expectedResult, actualResult2);
            }

        }
    }

}