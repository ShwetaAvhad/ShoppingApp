using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Model
{
    public class Product
    {
        private int _productId;
        private string _productName;
        private double _productPrice;
        private int _discountPercent;

        public Product(int productId, string productName, double productPrice, int discountPercent)
        {
            _productId = productId;
            _productName = productName;
            _productPrice = productPrice;
            _discountPercent = discountPercent;
        }

        public int ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }
        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }
        public double ProductPrice
        {
            get { return _productPrice; }
            set { _productPrice = value; }
        }
        public int DiscountPercent
        {
            get { return _discountPercent; }
            set { _discountPercent = value; }
        }

        public double calculateDiscountedPrice(double price, double discount)
        {
            double discountedPrice = price - price * discount / 100;
            return discountedPrice;
        }
    }
}
