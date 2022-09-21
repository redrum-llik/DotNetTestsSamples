using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading;
using System.Diagnostics.Contracts;
using Xunit;


namespace TestProject1
{
    public class xUnitLong1
    {
        [Fact]
        public void Test1()
        {
        }

        [Theory]
        [InlineData("a")]
        [InlineData("b")]
        [InlineData("c")]
         public void Test11(string str)
        {
                    Thread.Sleep(60);
        
        }
    }
}
