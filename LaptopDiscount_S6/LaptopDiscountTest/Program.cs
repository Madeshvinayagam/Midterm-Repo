using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaptopDiscount;
using NUnit.Framework;

namespace LaptopDiscountTest
{
    internal class LaptopDiscountUnitTest
    {
        static void Main(string[] args)
        {
        }

        // Tests for Price with correct values
        [Test]
        public void DiscountedPrice_SetAndGetPrice_ReturnsCorrectPrice()
        {
            // Arrange
            var partTimeEmployee = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.PartTime,

                // Act
                Price = 100
            };
            var discountedPrice1 = partTimeEmployee.CalculateDiscountedPrice();
            // Expected: 100 (no discount)

        }
        // Tests for Price with Null values
        [Test]
        public void DiscountedPrice_SetAndGetPrice_ReturnsNullPrice()
        {
            // Arrange
            var partTimeEmployee = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.PartTime,

                // Act
                Price = 0
            };
            var discountedPrice2 = partTimeEmployee.CalculateDiscountedPrice();
            // Expected: 0 (no discount)

        }

        // Tests for Employee Type
        [Test]
        public void EmployeeType_SetAndGetEmployeeType_ReturnsCorrectEmployeeType()
        {
            // Arrange
            var partTimeEmployee = new EmployeeDiscount
            {
                // Act
                EmployeeType = EmployeeType.PartTime,

              
            };
            var employeeTypeResult = partTimeEmployee.Equals(EmployeeType.PartTime);
            // Expected: True

        }

        [Test]
        public void PartialLoadEmployee_SetAndGetPrice_ReturnsCorrectPrice() {
            // Arrange
            var partialLoadEmployee = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.PartialLoad,
                // Act
                Price = 200
            };
            var discountedPrice2 = partialLoadEmployee.CalculateDiscountedPrice();
            // Expected: 188 (200 - 6%)

        }
        [Test]
        public void FullTimeEmployee_SetAndGetPrice_ReturnsCorrectPrice() {
            // Arrange
            var fullTimeEmployee = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.FullTime,
                // Act
                Price = 300
            };
            var discountedPrice3 = fullTimeEmployee.CalculateDiscountedPrice();
            // Expected: 267 (300 - 11%)

        }


    }
}
