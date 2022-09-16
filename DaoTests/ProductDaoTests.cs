using DataAccess;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoTests
{
    public class ProductDaoTests
    {
        [Fact]
        public void TestGetAllProductsSuccess()
        {
            // Arrange
            IDao<Product> dao = DaoFactory.CreateProductDao();

            // Act
            var test = dao.GetAll();

            // Assert
            Assert.NotNull(test);
            Assert.Equal(5, test.Count());
        }

        [Fact]
        public void TestDeleteProductThrowsNotImplementedException()
        {
            // Arrange
            IDao<Product> dao = DaoFactory.CreateProductDao();
            Product? product = dao.GetById(1);

            // Act
            // Assert
            Assert.NotNull(product);
            if (product != null)
            {
                Assert.Throws<NotImplementedException>(() => dao.Delete(product));
            }
        }

        [Fact]
        public void TestUpdateProductThrowsNotImplementedException()
        {
            // Arrange
            IDao<Product> dao = DaoFactory.CreateProductDao();
            Product? product = dao.GetById(1);

            // Act
            // Assert
            Assert.NotNull(product);
            if (product != null)
            {
                Assert.Throws<NotImplementedException>(() => dao.Update(product));
            }
        }

        [Fact]
        public void TestCreateProductThrowsNotImplementedException()
        {
            // Arrange
            IDao<Product> dao = DaoFactory.CreateProductDao();
            Product product = new(1, "test", 19.99m);

            // Act
            // Assert
            if (product != null)
            {
                Assert.Throws<NotImplementedException>(() => dao.Create(product));
            }
        }
    }
}
