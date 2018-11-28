using System;
using Xunit;

namespace Regate.Tests
{
    public class RegatePriceTests
    {
        [Fact]
        public void ConvertToString_Float()
        {
            float input = 123456;
            string output = RegatePriceHelpers.ConvertToString(input);
            var test = output == "123456";

            Assert.True(test);
        }
    }
}
