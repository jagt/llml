using System;
using NUnit.Framework;
using llml;

namespace llmlBasics
{
	public class fsDataTests
	{
		[Test]
		public void llTableBasics()
		{
			var tab = new llTable();
			Assert.NotNull(tab.ArrayPart);
			Assert.NotNull(tab.DictPart);
			Assert.Throws<NotSupportedException>(() => { tab.DictPart.Add("foo", new llData()); });

			return;
		}

	}
}
