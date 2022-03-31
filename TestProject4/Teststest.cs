using NUnit.Framework;
using System.Threading;
using System;

namespace TestProject4
{
    public class UnitTest1
    {


        [Test]
 
        public void Test1NunitSimplever1()
        {
            //Thread.Sleep(60);
            Console.WriteLine("##teamcity[buildNumber 'hi']");
            Assert.Fail();
        }
        
        
        
    }
}
