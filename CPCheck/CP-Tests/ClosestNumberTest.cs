using CP;
using FluentAssertions;
using Xunit;

namespace CP_Tests
{
    public class ClosestNumberTest
    {
        [Theory]
        [InlineData(349, 1, 4 , 348)]
        [InlineData(395, 1, 7 , 392)]
        [InlineData(4, -2, 2, 0)]
        [InlineData(674, 2, 6, 454278)]
        [InlineData(184804527, 1, 38664371, 193321855)]
        [InlineData(782, -3, 135497282, 0)]
        [InlineData(927613903, 1, 892066602, 892066602)]
        [InlineData(86, 4, 760313751, 0)]
        public void ClosesNumberShouldPass(int a,  int b, int x, int expectedValue)
        {
            var closestNumber = new ClosestNumber();
            var output = closestNumber.closestNumber(a, b, x);
            output.Should().Be(expectedValue);
        }
    }
}