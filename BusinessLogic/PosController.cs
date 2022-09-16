using DataAccess;
using Model;

namespace BusinessLogic
{
    public class PosController
    {
        private IDao<Order> _orderDao = DaoFactory.CreateOrderDao();
        private IDao<Product> _productDao = DaoFactory.CreateProductDao();

        public void CreateOrder(Order order)
        { 
            throw new NotImplementedException();
        }

        public void FinishCustomerOrder(string customerName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            return _productDao.GetAll();
        }

        public IEnumerable<Order> GetActiveOrders()
        {
            return _orderDao.GetAll();
        }
    }
}