using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculations.Tests
{
    [Collection("Customer")]
    public class CustomerDetailsTest
    {
        private readonly CustomerFixture _customerFixture;

        public CustomerDetailsTest(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }

        [Fact]
        public void GetFullName_GivenFirstAndLastName_ReturnsFullName()
        {
            var customer = _customerFixture.cust;
            var result = customer.GetFullName("Shabeer", "Moothedath");
            Assert.Equal("Shabeer Moothedath", result, ignoreCase: true);
        }
    }
}
