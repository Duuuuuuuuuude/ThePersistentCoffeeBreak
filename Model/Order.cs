using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public IList<Orderline> Orderlines { get; } = new List<Orderline>();

        public Order(int id, string customer)
        {
            Customer = customer;
            Id = id;
        }
    }
}
