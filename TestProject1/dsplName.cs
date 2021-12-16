using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics.Contracts;
using Xunit;


namespace TestProject1
{
    public class dsplNameXunit
    {
        [Fact(DisplayName = "dpname GET /api/books returns http status code 200")]
        public void Test1()
        {
        }

        [Theory]
        [InlineData("a")]
        [InlineData("b")]
        [InlineData("c")]
        [InlineData("d")]
        public void Test2(string str)
        {
            Assert.Equal(str, "a");
        }
    }
}
