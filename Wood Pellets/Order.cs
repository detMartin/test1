using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wood_Pellets
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public int Amount { get; set; }
        public Pellets Pellets { get; set; }
        public string DeliveryAddress { get; set; }
        public bool IsConfirmed { get; set; } = false;
        

        public Order(Customer customer, int amount, Pellets pellets, string address)
        {
            Customer = customer;
            Amount = amount; // In pallets
            Pellets = pellets;
            DeliveryAddress = address;
            Id++;

            //Customer.Orders.Add(this);
            OrderRegistry.List.Add(this);

            pellets.CheckStock();

            if (pellets.InStock == false)
            {
                IsConfirmed = false;
                Console.WriteLine("Order is pending, no stock available");
            } 
            else
            {
                pellets.RemoveStock(amount);
                IsConfirmed = true;
            }
        }

        public double Total()
        {
            int total = Pellets.Price * Amount;

            return total;
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Customer)}={Customer}, {nameof(Amount)}={Amount.ToString()}, {nameof(Pellets)}={Pellets}, {nameof(DeliveryAddress)}={DeliveryAddress}}}";
        }
    }
}
