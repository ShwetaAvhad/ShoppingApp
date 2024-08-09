using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Model
{
    public class Customer
    {
        private int _customerId { get; set; }
        private string _customerName { get; set; }
        public static List<Order> orders = new List<Order>();

        public Customer(int cutomerId, string customerName)
        {
            _customerId = cutomerId;
            _customerName = customerName;
        }

        public int CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }
        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; }
        }
    }
}
