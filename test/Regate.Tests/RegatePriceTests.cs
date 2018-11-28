using System;
using Xunit;

namespace Regate.Tests
{
    public class RegatePriceTests
    {
        [Fact]
        public void ConvertToString_Float1()
        {
            float input = 123456;
            string output = RegatePriceHelpers.ConvertToString(input);
            var test = output == "123456";

            Assert.True(test);
        }

        [Fact]
        public void ConvertToString_Float2()
        {
            float input = 12345678;
            string output = RegatePriceHelpers.ConvertToString(input);

            Assert.Equal("12345678", output);
        }
    }
}
