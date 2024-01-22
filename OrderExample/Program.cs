using OrderExample.Entities;
using OrderExample.Entities.Enums;

Console.WriteLine("Enter client data: ");

Console.Write("Name: ");
string name = Console.ReadLine();

Console.Write("Email: ");
string email = Console.ReadLine();

Console.Write("Birth Date (MM/DD/YYYY): ");
DateTime birthdate = DateTime.Parse(Console.ReadLine());


Console.WriteLine("Enter order data: ");

Console.Write("Status: ");
OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());

Console.Write("How many items will be added to this order: ");
int nItems = int.Parse(Console.ReadLine());


Client client = new Client(name, email, birthdate);
Order order = new Order(DateTime.Now, orderStatus, client);

for (int i = 1; i <= nItems; i++)
{
    Console.WriteLine($"Enter the #{i} item data");

    Console.Write("Product name: ");
    string productName = Console.ReadLine();

    Console.Write("Product price: ");
    double productPrice = double.Parse(Console.ReadLine());

    Console.Write("Quatity: ");
    int qtdy = int.Parse(Console.ReadLine());

    Product product = new Product(productName, productPrice);
    OrderItem item = new OrderItem(qtdy, productPrice, product);

    order.AddItem(item);
}

Console.WriteLine();
Console.WriteLine("ORDER SUMMARY");
Console.WriteLine(order.ToString());