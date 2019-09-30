using NUnit.Framework;
using Assignment1SQA;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Test1 t1 = new Test1();

            Assert.AreEqual(5, t1.Add(2, 3), 0);
            Assert.Pass();
        }
    }
}