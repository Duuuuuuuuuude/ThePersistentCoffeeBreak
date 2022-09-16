using DataAccess;
using DataAccess.MemoryDaos;
using Model;

namespace DaoTests
{
    public class OrderDaoTests
    {
        [Fact]
        public void TestGetOrderSuccess()
        {
            // Arrange
            IDao<Order> orderDao = DaoFactory.CreateOrderDao();

            // Act
            Order? test = orderDao.GetById(2);

            // Assert
            Assert.NotNull(test);
        }

        [Fact]
        public void TestGetAllOrdersSuccess()
        {
            // Arrange
            IDao<Order> orderDao = DaoFactory.CreateOrderDao();

            // Act
            var test = orderDao.GetAll();

            // Assert
            Assert.NotNull(test);
            Assert.Equal(3, test.Count());
        }

        [Fact]
        public void TestDeleteOrderSuccess()
        {
            // Arrange
            IDao<Order> orderDao = DaoFactory.CreateOrderDao();
            Order? test = orderDao.GetById(1);

            // Act
            if (test != null)
            {
                orderDao.Delete(test);
            }

            // Assert
            Assert.Null(orderDao.GetById(1));
        }

        [Fact]
        public void TestUpdateOrderSuccess()
        {
            // Arrange
            IDao<Order> orderDao = DaoFactory.CreateOrderDao();
            Order? test = orderDao.GetById(1);

            // Act
            if (test != null)
            {
                test.Orderlines.Clear();
                orderDao.Update(test);
            }

            // Assert
            Assert.Equal(0, orderDao.GetById(1)?.Orderlines.Count);
        }

        [Fact] 
        public void TestCreateOrderSuccess()
        {
            // Arrange
            IDao<Order> orderDao = DaoFactory.CreateOrderDao();
            string customerName = "TestCustomer";
            var orderCount = orderDao.GetAll().Count();
            Order order = new Order(0, customerName);

            // Act
            orderDao.Create(order);
            var testCount = orderDao.GetAll().Count();
            var testOrder = orderDao.GetById(4);

            // Assert
            Assert.True(testCount == orderCount + 1);
            Assert.NotNull(testOrder);
            Assert.Equal(customerName, testOrder?.Customer);
        }
    }
}