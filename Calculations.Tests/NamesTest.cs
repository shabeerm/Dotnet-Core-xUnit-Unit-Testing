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
            var result = names.MakeFullName("Shabeer", "Moothedath");
            Assert.Equal("Shabeer Moothedath", result, ignoreCase: true);
            Assert.Contains("Shabeer", result, StringComparison.InvariantCultureIgnoreCase);
            Assert.StartsWith("Shabeer", result, StringComparison.InvariantCultureIgnoreCase);
            Assert.EndsWith("Moothedath", result, StringComparison.InvariantCultureIgnoreCase);
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", result);
        }

        [Fact]
        public void NickName_MustBeNull()
        {
            var names = new Names();
            names.NickName = "Strong Man";
            Assert.NotNull(names.NickName);
        }

        [Fact]
        public void MakeFullName_AlwaysReturnValue()
        {
            var names = new Names();
            var result = names.MakeFullName("Aref", "Karimi");
            Assert.NotNull(result);
            Assert.False(string.IsNullOrEmpty(result));
        }
    }
}
