using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wood_Pellets
{
    public class Pellets
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Brand { get; set; }
        public string Size { get; set; }
        public string Quality { get; set; }
        public string Energy { get; set; }
        public string Humidity { get; set; }
        public string? Info { get; set; }

        public bool InStock { get; set; } = false;
        
        // Lager/Warehouse
        public List<Pellets> Stock { get; set; }


        public Pellets(int price, string brand, string size, string quality, string energy, string humidity, string? info)
        {
            Price = price; // Price per pallet
            Brand = brand;
            Size = size;
            Quality = quality;
            Info = info;
            Energy = energy;
            Humidity = humidity;
            Id++;

            Stock = new List<Pellets>();
        }

        public void AddStock(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Stock.Add(this);
            }
        }

        public void RemoveStock(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Stock.Remove(this);
            }
        }

        public void CheckStock()
        {
            if (Stock.Count > 0)
            {
                InStock = true;
            } else
            {
                InStock = false;
            }
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Price)}={Price.ToString()}, {nameof(Brand)}={Brand}, {nameof(Size)}={Size}, {nameof(Quality)}={Quality}, {nameof(Energy)}={Energy}, {nameof(Humidity)}={Humidity}, {nameof(Info)}={Info}, {nameof(Stock)}={Stock}}}";
        }
    }
}
