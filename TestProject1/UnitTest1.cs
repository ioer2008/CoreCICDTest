using System;

using Xunit;

namespace TestProject1
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			var str = "00";

			Assert.Equal("00", str);
		}
	}
}
