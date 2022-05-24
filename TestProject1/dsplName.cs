using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics.Contracts;
using Xunit;


namespace TestProject1
{
    public class dsplNameXunit1
    {
        [Fact(DisplayName = "~dpNameChubatova1")]
        
        public void Test1chubatova()
        {
            Assert.Equal("a", "b");
        }

        [Theory(DisplayName = "dpNameChubatova2")]
        [InlineData("a123")]
        [InlineData("b")]
        [InlineData("c")]
        [InlineData("d")]
        public void Test2chubatova(string str)
        {
            Assert.Equal("a", "a");
        }
    }
    
    
    public class dsplNameXunit2
    {
        [Fact(DisplayName = "dpNameChubatova3")]
        public void Test1chubatova()
        {
        }

        [Theory(DisplayName = "dpNameChubatova4")]
        [InlineData("a")]
        [InlineData("b")]
        [InlineData("c")]
        [InlineData("d")]
        public void Test2chubatova(string str)
        {
            Assert.Equal(str, "a");
        }
    }
}
