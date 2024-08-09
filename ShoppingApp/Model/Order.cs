using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ShoppingApp.Model
{
    public class Order
    {
        private int _orderId;
        private DateTime _dateTime;

        private static List<LineItem> _items = new List<LineItem>();

        public Order(int orderId, DateTime dateTime)
        {
            _orderId = orderId;
            _dateTime = dateTime;
        }
        public int OrderId
        {
            get { return _orderId; }
            set { _orderId = value; }
        }
        public DateTime DateTime
        {
            get { return _dateTime; }
            set { _dateTime = value; }
        }
        public List<LineItem> Items
        {
            get { return _items; }
            set { _items = value; }
        }
        public void AddItem(LineItem lineItem)
        {
            _items.Add(lineItem);
        }
        public double CalculateOrderPrice()
        {
            double price = 0;
            foreach (var item in Items)
            {
                price += LineItem.CalculateLineItemCost(item);
            }

            return price;
        }
    }
}
