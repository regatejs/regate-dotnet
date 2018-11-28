using System;
using Xunit;

namespace Regate.Tests
{
    public class RegatePriceTests
    {
        [Fact]
        public void ValidInput()
        {
            var input = 124;
            var output = input.ToString();
            var test = output == "124";

            Assert.True(test);
        }
    }
}
