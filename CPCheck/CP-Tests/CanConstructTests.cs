using CP;
using FluentAssertions;
using Xunit;

namespace CP_Tests
{
    public class CanConstructTests
    {
        [Theory]
        [InlineData(new [] { 1, 4 } , "No")]
        [InlineData(new [] { 1, 5 } , "Yes")]
        [InlineData(new [] { 40, 50, 90 } , "Yes")]
        public void CanConstructShouldPass(int [] input, string expectedValue)
        {
            var canConstruct = new CanConstructNumber();
            var output = canConstruct.CanConstruct(input);
            output.Should().Be(expectedValue);
        }
    }
}