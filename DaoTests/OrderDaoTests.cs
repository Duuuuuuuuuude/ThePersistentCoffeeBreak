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
            Order? test = orderDao.GetById("Kurt");

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
            string customerName = "Hans";
            IDao<Order> orderDao = DaoFactory.CreateOrderDao();
            Order? test = orderDao.GetById(customerName);

            // Act
            if (test != null)
            {
                orderDao.Delete(test);
            }

            // Assert
            Assert.Null(orderDao.GetById(customerName));
        }

        [Fact]
        public void TestUpdateOrderSuccess()
        {
            // Arrange
            string customerName = "Hans";
            IDao<Order> orderDao = DaoFactory.CreateOrderDao();
            Order? test = orderDao.GetById(customerName);

            // Act
            if (test != null)
            {
                test.Orderlines.Clear();
                orderDao.Update(test);
            }

            // Assert
            Assert.Equal(0, orderDao.GetById(customerName)?.Orderlines.Count);
        }

        [Fact] 
        public void TestCreateOrderSuccess()
        {
            // Arrange
            string customerName = "TestCustomer";
            IDao<Order> orderDao = DaoFactory.CreateOrderDao();
            var orderCount = orderDao.GetAll().Count();
            Order order = new Order(customerName);

            // Act
            orderDao.Create(order);
            var testCount = orderDao.GetAll().Count();
            var testOrder = orderDao.GetById(customerName);

            // Assert
            Assert.True(testCount == orderCount + 1);
            Assert.NotNull(testOrder);
            Assert.Equal(customerName, testOrder?.CustomerName);
        }
    }
}