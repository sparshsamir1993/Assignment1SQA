using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1SQA
{
	[TestFixture]
	class Test1Checker
	{
		[TestCase]
		public void AddCheck() {
			Test1 t1 = new Test1();

			Assert.AreEqual(5, t1.Add(2, 3),0);
            Assert.Pass();
		}
		
	}
}
