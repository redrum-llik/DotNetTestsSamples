using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics.Contracts;
using Xunit;


namespace TestProject4
{
    public class dsplNameXunit11
    {
        //[Fact(DisplayName = "dpNameChubatova1")]
        public void Test1chubatova()
        {
            Assert.Equal("a", "b");
        }

        /* [Theory(DisplayName = "dpNameChubatova2")]
        [InlineData("a")]
        [InlineData("b")]
        [InlineData("c")]
        [InlineData("d")]
        public void Test2chubatova(string str)
        {
            Assert.Equal("a", "a");
        }*/
    }
    
    
    public class dsplNameXunit21
    {
        //[Fact(DisplayName = "dpNameChubatova3")]
        public void Test1chubatova()
        {
        }

        /* [Theory(DisplayName = "dpNameChubatova4")]
        [InlineData("a")]
        [InlineData("b")]
        [InlineData("c")]
        [InlineData("d")]
        public void Test2chubatova(string str)
        {
            Assert.Equal(str, "a");
        }*/
    }
}
