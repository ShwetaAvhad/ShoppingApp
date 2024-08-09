using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Model
{
    public class LineItem
    {
        private int _lineItemId;
        private int _quantity;
        public Product _product;

        public LineItem(int lineItemId, int quantity, Product product)
        {
            _lineItemId = lineItemId;
            _quantity = quantity;
            _product = product;
        }

        public int LineItemId
        {
            get { return _lineItemId; }
            set { _lineItemId = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public static double CalculateLineItemCost(LineItem lineItem)
        {
            double lineItemCost = lineItem._product.calculateDiscountedPrice(lineItem._product.ProductPrice, lineItem._product.DiscountPercent) * lineItem.Quantity;
            return lineItemCost;
        }
    }
}
