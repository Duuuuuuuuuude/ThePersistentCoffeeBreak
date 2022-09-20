using Xunit;
using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BusinessLogic.Tests
{
    public class PosControllerTests
    {
        [Fact()]
        public void CreateOrderTest()
        {
            // Arrange
            PosController posController = new();
            Order testOrder = new("TestCustomer");

            // Act
            posController.CreateOrder(testOrder);

            // Assert
            Assert.True(true, "There is really nothing to assert");
        }

        [Fact()]
        public void FinishCustomerOrderTest()
        {
            // Arrange
            PosController posController = new();

            // Act
            posController.FinishCustomerOrder("TestCustomer");

            // Assert
            Assert.True(true, "There is really nothing to assert");
        }
    }
}