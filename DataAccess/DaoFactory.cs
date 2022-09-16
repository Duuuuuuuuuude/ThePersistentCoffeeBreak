using DataAccess.MemoryDaos;
using Model;

namespace DataAccess
{
    public static class DaoFactory
    {
        public static IDao<Order> CreateOrderDao()
        {
            return new OrderDao();
        }

        public static IDao<Product> CreateProductDao()
        {
            return new ProductDao();
        }
    }
}
