using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculations.Tests
{
    [Collection("Customer")]
    public class CustomerTest
    {
        private readonly CustomerFixture _customerFixture;

        public CustomerTest(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }

        [Fact]
        public void CheckNameNotEmpty()
        {
            var customer = _customerFixture.cust;
            Assert.NotNull(customer.Name);
            Assert.False(string.IsNullOrEmpty(customer.Name));
        }

        [Fact]
        public void CheckLegiForDiscount()
        {
            var customer = _customerFixture.cust;
            Assert.InRange(customer.Age, 25, 40);
        }

        [Fact]
        public void GetOrdersByNameNotNull()
        {
            var customer = _customerFixture.cust;
            var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GetOrdersByName(null));
            Assert.Equal("Please Provide Name", exceptionDetails.Message);
        }

        [Fact]
        public void LoyalCustomerForOrderG100()
        {
            var customer = CustomerFactory.CreateCustomerInstance(102);
            var loyalCustomer = Assert.IsType<LoyalCustomer>(customer);
            Assert.Equal(10, loyalCustomer.Discount);
        }
    }
}
