using DecodingPatternsAndCode.Tests.Book.Chapter17;
using Xunit;

namespace DecodingPatternsAndCode.Tests.BookTests.Chapter17
{
    public class AddWithoutPlusTests
    {
        [Fact]
        public void ShouldAddZerosCorrectly()
        {
            var uut = new AddWithoutPlus();
            var result = uut.IntAddImpl(0, 0);

            Assert.Equal(0, result);
        }

        [Fact]
        public void ShouldAddOnesCorrectly()
        {
            var uut = new AddWithoutPlus();
            var result = uut.IntAddImpl(1, 1);

            Assert.Equal(2, result);
        }

        [Fact]
        public void ShouldAddThreeDigitsCorrectly()
        {
            var uut = new AddWithoutPlus();
            var result = uut.IntAddImpl(741, 123);

            Assert.Equal(864, result);
        }

    }
}