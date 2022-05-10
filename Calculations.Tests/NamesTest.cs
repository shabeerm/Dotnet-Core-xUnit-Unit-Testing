using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculations.Tests
{
    public class NamesTest
    {
        [Fact]
        public void MakeFullNameTest()
        {
            var names = new Names();
            var result = names.MakeFullName("shabeer", "Moothedath");
            Assert.Equal("Shabeer Moothedath", result, ignoreCase: true);
            Assert.Contains("Shabeer", result, StringComparison.InvariantCultureIgnoreCase);
            Assert.StartsWith("Shabeer", result, StringComparison.InvariantCultureIgnoreCase);
            Assert.EndsWith("Moothedath", result, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
