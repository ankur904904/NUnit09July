using NUnit.Framework;
using System.Threading;

namespace NUnit09July
{
 
    public class NUnit09July
    {
        [Test]
        //[Parallelizable(ParallelScope.Self)]
        public void Test1()
        {
            Thread.Sleep(4000); // Simulate some work
            Assert.Pass("Test3 completed");
        }

        [Test]
      //  [Parallelizable(ParallelScope.Self)]
        public void Test2()
        {
            Thread.Sleep(4000); // Simulate some work
            Assert.Equals(1, 1);
        }

        [Test]
        //[Parallelizable(ParallelScope.Self)]
        public void Test3()
        {
            Thread.Sleep(4000); // Simulate some work
            Assert.Pass("Test3 completed");
        }

    }
}