using ShoppingApp.Model;

public class Program
{
    public static void PrintOrder(Order order)
    {
        Console.WriteLine("Order Id : "+order.OrderId);
        Console.WriteLine("Order Date and Time : "+order.DateTime); 
    }
    public static void PrintCustomer(Customer customer)
    {
        Console.WriteLine("Customer Id : "+customer.CustomerId);
        Console.WriteLine("Customer Name : "+customer.CustomerName);        
        Console.WriteLine();
    }
    public static void PrintDetails(Order order)
    {
        Console.WriteLine(new string('-', 120));
        Console.WriteLine($"Line Item | Product Item | Product Name | Quantity | Unit Price | Discount | Price After Discount | Total LineItem Cost");
        Console.WriteLine(new string('-', 120));

        foreach (var item in order.Items)
        {                    
            Console.WriteLine($"{item.LineItemId,-10}| {item._product.ProductId,-13}| {item._product.ProductName,-13}| {item.Quantity,-9}| {item._product.ProductPrice,-11}|" +
                              $"{item._product.DiscountPercent,-10}| {item._product.calculateDiscountedPrice(item._product.ProductPrice, item._product.DiscountPercent),-21}|" +
                              $"{LineItem.CalculateLineItemCost(item),-10}");
        }

        Console.WriteLine(new string('-', 120));
        Console.WriteLine($"Total Bill : {order.CalculateOrderPrice(),90}");
        Console.WriteLine(new string('-', 120));
    }
    
    static void Main(string[] args)
    {
        Customer customer1 = new Customer(1, "shweta");        

        Product product1 = new Product(1,"Shirt",500,10);
        Product product2 = new Product(2,"Jeans", 1000, 20);
        Product product3 = new Product(3,"Top", 300, 50);
        Product product4 = new Product(4, "T-Shirt", 200, 10);

        LineItem lineItem1=new LineItem(1,2,product1);
        LineItem lineItem2 = new LineItem(2, 1, product2);
        LineItem lineItem3=new LineItem(3, 2, product3);
        LineItem lineItem4=new LineItem(4, 1, product4);
        
        Order order1=new Order(1,DateTime.Now);        
        order1.AddItem(lineItem1);
        order1.AddItem(lineItem2);  
        order1.AddItem(lineItem3);
        order1.AddItem(lineItem4);

        PrintCustomer(customer1);
        PrintOrder(order1);
        PrintDetails(order1);


    }
}