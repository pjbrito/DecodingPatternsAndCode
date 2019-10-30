using Xunit;
using static DecodingPatternsAndCode.Tests.Book.Chapter01.ReplaceSpaces;

namespace DecodingPatternsAndCode.Tests
{
    public class BookChapter01ReplaceSpaces
    {
        public class TheReplaceSpacesAlgorithmShould
        {
            [Theory]
            [InlineData("Sentence to be escaped, end!", "Sentence%20to%20be%20escaped,%20end!")]
            [InlineData("ABC news cbs :)", "ABC%20news%20cbs%20:)")]
            public void BeAbleToCorrectlyInsertTheSpaceEscapeCodes(string inputString, string expectedResultString)
            {
                var charArr = inputString.ToCharArray();
                ReplaceSpacesBase(ref charArr, charArr.Length);

                var resultString = new string(charArr);
                Assert.True(string.CompareOrdinal(expectedResultString, resultString) == 0);
            }

        }
    }
}