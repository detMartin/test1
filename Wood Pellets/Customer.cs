using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wood_Pellets
{
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public int Id { get; set; }

        //public List<Order> Orders { get; set; }

        public Customer(string name, string address, string phone, string mail)
        {
            Name = name;
            Address = address;
            Phone = phone;
            Mail = mail;
            Id++;

            //Orders = new List<Order>();

            CustomerRegistry.List.Add(this);
        }

        //public void AddOrder(Order order)
        //{
            //Orders.Add(order);
            //OrderRegistry.List.Add(order);
        //}

        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(Address)}={Address}, {nameof(Phone)}={Phone}, {nameof(Mail)}={Mail}, {nameof(Id)}={Id.ToString()}}}";
        }
    }
}
