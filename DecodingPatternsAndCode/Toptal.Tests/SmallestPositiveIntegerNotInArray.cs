using System.Linq;
using Xunit;
namespace DecodingPatternsAndCode.Tests.Toptal.Tests
{
    public class MySolution // SmallestPositiveIntegerNotInArray
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            var positiveArr = A
                .Distinct()
                .Where(x => x > 0)
                .OrderBy(x => x)
                .ToArray();

            if (positiveArr.Length == 0)
            {
                return 1;
            }

            var i = 0;
            for (; i < positiveArr.Length; i++)
            {
                if (i + 1 != positiveArr[i])
                {
                    return i + 1;
                }
            }

            return i + 1;
        }


        public class TopTalSmallestPositiveIntegerNotInArray
        {

            [Fact]
            public void Solution()
            {
                var res2 = new MySolution().solution(new[] { 1, 3, 6, 4, 1, 2 });
                Assert.Equal(5, res2);

                var res = new MySolution().solution(new[] { -5, -15, 1, 3, 4, 5, 7 });
                Assert.Equal(2, res);

                var res3 = new MySolution().solution(new[] { -1, -3 });
                Assert.Equal(1, res3);

                var res4 = new MySolution().solution(new[] { 1, 2, 3 });
                Assert.Equal(4, res4);
            }
        }

    }

}
