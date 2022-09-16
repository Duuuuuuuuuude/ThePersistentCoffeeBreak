using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        public string CustomerName { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Status { get; set; } = "New";
        public int Discount { get; set; } = 0;
        public IList<Orderline> Orderlines { get; } = new List<Orderline>();

        public Order(string customer)
        {
            CustomerName = customer;
        }
    }
}
