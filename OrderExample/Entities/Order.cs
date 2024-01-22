using OrderExample.Entities.Enums;
using System.Text;

namespace OrderExample.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order items:");
            sb.AppendLine("Order moment: " + Moment);
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client.Name + " (" + Client.BirthDate + ") - " + Client.Email);
            foreach (OrderItem item in Items)
            {
                Console.WriteLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
