using Xunit;

namespace DecodingPatternsAndCode.Tests.BookTests.Chapter01
{
    public class ReplaceSpaces
    {
        public class TheReplaceSpacesAlgorithmShould
        {
            [Theory]
            [InlineData("Sentence to be escaped, end!", "Sentence%20to%20be%20escaped,%20end!")]
            [InlineData("ABC news cbs :)", "ABC%20news%20cbs%20:)")]
            public void BeAbleToCorrectlyInsertTheSpaceEscapeCodes(string inputString, string expectedResultString)
            {
                var charArr = inputString.ToCharArray();
                Book.Chapter01.ReplaceSpaces.ReplaceSpacesBase(ref charArr, charArr.Length);

                var resultString = new string(charArr);
                Assert.True(string.CompareOrdinal(expectedResultString, resultString) == 0);
            }

        }
    }
}