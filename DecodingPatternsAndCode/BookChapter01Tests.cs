using Xunit;
using static DecodingPatternsAndCode.Tests.Book.Chapter01.IsUniqueCharsBaseCase;

namespace DecodingPatternsAndCode.Tests
{
    public class BookChapter01Tests
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
                var actualResult = IsUniqueChars(inputString);
                Assert.Equal(expectedResult, actualResult);
            }
        }
    }

}