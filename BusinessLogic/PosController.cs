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
            _orderDao.Create(order);
        }

        public void FinishCustomerOrder(string customerName)
        {
            Order finishedOrder = _orderDao.GetById(customerName);
            if (finishedOrder != null)
            {
                finishedOrder.Status = "Finished";
                _orderDao.Update(finishedOrder);
            }
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