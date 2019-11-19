using DecodingPatternsAndCode.Tests.Book.Chapter01;
using Xunit;

namespace DecodingPatternsAndCode.Tests.BookTests
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
                var actualResult = PermutationsChecker.Permutation(inputString1, inputString2);
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
                var actualResult2 = PermutationsChecker.PermutationOptimized(inputString1, inputString2);
                Assert.Equal(expectedResult, actualResult2);
            }

        }
    }

}