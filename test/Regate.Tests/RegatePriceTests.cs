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

            Assert.Equal("123456", output);
        }

        [Fact]
        public void ConvertToString_Float2()
        {
            float input = 12345678;
            string output = RegatePriceHelpers.ConvertToString(input);

            Assert.Equal("12345678", output);
        }


        [Fact]
        public void ConvertToString_Decimal1()
        {
            decimal input = 123456;
            string output = RegatePriceHelpers.ConvertToString(input);

            Assert.Equal("123456", output);
        }


        [Fact]
        public void ConvertToString_Decimal2()
        {
            decimal input = 1234567890;
            string output = RegatePriceHelpers.ConvertToString(input);

            Assert.Equal("1234567890", output);
        }
    }
}
