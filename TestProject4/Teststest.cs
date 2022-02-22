using NUnit.Framework;
using System.Threading;

namespace TestProject4
{
    public class UnitTest1
    {


        [Test]
 
        public void Test1NunitSimplever1()
        {
            Thread.Sleep(30000);
            Assert.Fail();
        }
        
        
        
    }
}
