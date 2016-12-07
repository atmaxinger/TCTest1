using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit;
using NUnit.Framework;

namespace tctest.tests
{
	[TestFixture]
	class SomethingTest
	{
		[Test]
		public void SomeWorkingTest()
		{
			Assert.That(true);
		}

		[Test]
		public void SomeFailingTest()
		{
			Assert.That(false);
		}
	}
}
