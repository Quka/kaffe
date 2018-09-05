using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kaffe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace kaffeTests
{
	[TestClass]
	public class FlatWhiteTests
	{
		[TestMethod()]
		public void TestFlatWhitePris()
		{
			Kaffe FlatWhite = new FlatWhite();

			Assert.AreEqual(45, FlatWhite.Pris());
		}

		[TestMethod()]
		public void TestFlatWhiteStyrke()
		{
			Kaffe FlatWhite = new FlatWhite();

			Assert.AreEqual("Mild", FlatWhite.Styrke());
		}

		[TestMethod()]
		public void TestFlatWhiteMlMælk()
		{
			FlatWhite FlatWhite = new FlatWhite();

			Assert.AreEqual(160, FlatWhite.MlMælk());
		}
	}
}
