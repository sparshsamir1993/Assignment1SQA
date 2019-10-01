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
            Triangle triChk = new Triangle();
            int[] try1 = { 12, 12, 12 };
            Assert.AreEqual("Equilateral", TriangleSolver.Analyse(try1));
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            Triangle triChk = new Triangle();
            int[] try1 = { 11, 12, 12 };
            Assert.AreEqual("isosceles", TriangleSolver.Analyse(try1));
            Assert.Pass();
        }

        [Test]
        public void Test3()
        {
            Triangle triChk = new Triangle();
            int[] try1 = { 12, 10, 12 };
            Assert.AreEqual("isosceles", TriangleSolver.Analyse(try1));
            Assert.Pass();
        }

        [Test]
        public void Test4()
        {
            Triangle triChk = new Triangle();
            int[] try1 = { 12, 9, 8 };
            Assert.AreEqual("Scalene", TriangleSolver.Analyse(try1));
            Assert.Pass();
        }

        [Test]
        public void Test5()
        {
            Triangle triChk = new Triangle();
            int[] try1 = { 1000, 1000, 1000 };
            Assert.AreEqual("Equilateral", TriangleSolver.Analyse(try1));
            Assert.Pass();
        }
        [Test]
        public void Test6()
        {
            Triangle triChk = new Triangle();
            int[] try1 = { 2147483647/2, 2147483647/2, 2147483647/2 };
            Assert.AreEqual("Equilateral", TriangleSolver.Analyse(try1));
            Assert.Pass();
        }
        [Test]
        public void Test7()
        {
            Triangle triChk = new Triangle();
            int[] try1 = { 2147483647, 2147483647, 2147483647 };
            Assert.AreEqual("invalid", TriangleSolver.Analyse(try1));
            Assert.Pass();
        }
        [Test]
        public void Test8()
        {
            Triangle triChk = new Triangle();
            int[] try1 = { 5, 5, 4 };
            Assert.AreEqual("isosceles", TriangleSolver.Analyse(try1));
            Assert.Pass();
        }







    }
}