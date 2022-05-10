using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculations.Tests
{
    public class CustomerTest
    {
        [Fact]
        public void CheckNameNotEmpty()
        {
            var customer = new Customer();
            Assert.NotNull(customer.Name);
            Assert.False(string.IsNullOrEmpty(customer.Name));
        }

        [Fact]
        public void CheckLegiForDiscount()
        {
            var customer = new Customer();
            Assert.InRange(customer.Age, 25, 40);
        }

        [Fact]
        public void GetOrdersByNameNotNull()
        {
            var customer = new Customer();
            var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GetOrdersByName(null));
            Assert.Equal("Please Provide Name", exceptionDetails.Message);
        }
    }
}
