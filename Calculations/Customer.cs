using System;
using System.Collections.Generic;
using System.Text;

namespace Calculations
{
    public class Customer
    {
        public string Name = "Shabeer";
        public int Age = 30;
        public int GetOrdersByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Please Provide Name");
            }
            return 100;
        }
    }
}
