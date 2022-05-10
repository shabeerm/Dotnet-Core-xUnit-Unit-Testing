using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace Calculations.Tests
{
    public class CalculationsFixture : IDisposable
    {
        public Calculations calc = new Calculations();

        public void Dispose()
        {
            // Clean up resource code can add here
        }
    }
    public class CalculationsTest : IClassFixture<CalculationsFixture>, IDisposable
    {
        private readonly CalculationsFixture _calculationsFixture;
        private readonly MemoryStream _memoryStream;

        public CalculationsTest(CalculationsFixture calculationsFixture)
        {
            this._calculationsFixture = calculationsFixture;
            _memoryStream = new MemoryStream();
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotIncludeZero()
        {
            var calc = _calculationsFixture.calc;
            Assert.All(calc.FiboNumbers, n => Assert.NotEqual(0, n));
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboIncludes13()
        {
            var calc = _calculationsFixture.calc;
            Assert.Contains(13, calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotInclude4()
        {
            var calc = _calculationsFixture.calc;
            Assert.DoesNotContain(4, calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void CheckCollection()
        {
            var expectedCollection = new List<int> { 1, 1, 2, 3, 5, 8, 13 };
            var calc = _calculationsFixture.calc;
            Assert.Equal(expectedCollection, calc.FiboNumbers);
        }

        public void Dispose()
        {
            // Clean up resource code can add here
            _memoryStream.Close();
        }
    }
}
